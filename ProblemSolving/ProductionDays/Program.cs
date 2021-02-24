using System;
using System.IO;

namespace ProductionDays
{

    class Solution
    {

        // Complete the minTime function below.
        static long minTime(long[] machines, long goal)
        {
            Array.Sort(machines);
            var lowRate = machines[0];
            var lowerBound = (long)(Math.Ceiling((decimal)goal / machines.Length) * lowRate);
            lowerBound = (int) (goal / ((double) machines.Length / lowRate));
            //(goal // (len(machines) / low_rate))
            var highRate = machines[machines.Length - 1];
            var upperBound = (long)(Math.Ceiling((decimal)goal / machines.Length) * highRate) + 1;
            //(goal // (len(machines) / high_rate)) + 1
            upperBound = (int)(goal / ((double)machines.Length / highRate));

            long days = 0;
            while (upperBound > lowerBound)
            {
                var achieved = 0;
                days = (upperBound + lowerBound) / 2;
                for (int i = 0; i < machines.Length; i++)
                {
                    achieved += (int)(days / machines[i]);
                }

                if (achieved < goal) lowerBound = days + 1;
                else upperBound = days;
            }

            return days;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nGoal = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nGoal[0]);

            long goal = Convert.ToInt64(nGoal[1]);

            long[] machines = Array.ConvertAll(Console.ReadLine().Split(' '), machinesTemp => Convert.ToInt64(machinesTemp))
                ;
            long ans = minTime(machines, goal);

            textWriter.WriteLine(ans);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
