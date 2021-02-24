using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midi
{
    class Program
    {
        static void Main()
        {
            var dt1 = DateTime.Now;
            go1(@"D:\Temp\g_thing", 10, 5);
            var dt2 = (DateTime.Now - dt1).TotalSeconds;
            Console.WriteLine(dt2);
        }

        static void go1(string inputFolder, int NuNotes, int DiNotes)
        {

            List<string> rhythm_files = new List<string>();
            List<string> notes_files = new List<string>();
            List<string> shape_files = new List<string>();

            string[] files = Directory.GetFiles(inputFolder);

            for (int f = 0; f < files.Length; f++)
            {
                if (files[f] != "")
                {
                    if (Path.GetFileName(files[f]).StartsWith("r"))
                    {
                        rhythm_files.Add(files[f]);
                    }
                    else if (Path.GetFileName(files[f]).StartsWith("s"))
                    {
                        shape_files.Add(files[f]);
                    }
                    else if (Path.GetFileName(files[f]).StartsWith("n"))
                    {
                        notes_files.Add(files[f]);
                    }
                }
            }

            int counter = 0;
            Console.WriteLine("Total: " + (shape_files.Count * notes_files.Count * rhythm_files.Count));
            for (int s = 0; s < shape_files.Count; s++)
            {
                for (int c = 0; c < notes_files.Count; c++)
                {
                    for (int j = 0; j < rhythm_files.Count; j++)
                    {
                        counter++;
                        Console.WriteLine(counter);
                        create_permsText(shape_files[s], notes_files[c], rhythm_files[j], NuNotes, DiNotes,
                            @"d:\temp\g_thing_output\" + "10ser" + ".txt");
                    }
                }
            }
        }

        public static void snr(List<List<byte>> shape_perms, List<List<byte>> note_perms, List<List<byte>> rhythm_perms,
            int NuNotes, int DiNotes, string outputPath, string outputFolder)
        {

            for (int f = 0; f < shape_perms.Count; f++)
            {

                //patterns
                List<List<byte>> patterns = new List<List<byte>>();
                for (int c = 0; c < note_perms.Count; c++)
                {

                    for (int v = 0; v < rhythm_perms.Count; v++)
                    {

                        List<byte> inter = new List<byte>();

                        for (int j = 0; j < NuNotes; j++)
                        {
                            inter.Add(note_perms[c][(shape_perms[f][j] - 1)]);
                        }

                        patterns.Add(inter);
                        patterns.Add(rhythm_perms[v]);
                    }

                }

                string x = Utility.perm_2_string(shape_perms[f]);
                string outfolder = Path.Combine(Path.Combine(outputFolder, outputPath), x);
                Directory.CreateDirectory(outfolder);
                Utility.phrases_2_midi(patterns, outfolder);
            }
        }

        public static void nsr(List<List<byte>> shape_perms, List<List<byte>> note_perms, List<List<byte>> rhythm_perms,
            int NuNotes, int DiNotes, string outputPath, string outputFolder)
        {

            for (int c = 0; c < note_perms.Count; c++)
            {
                //patterns
                List<List<byte>> patterns = new List<List<byte>>();
                for (int v = 0; v < rhythm_perms.Count; v++)
                {

                    for (int f = 0; f < shape_perms.Count; f++)
                    {


                        List<byte> inter = new List<byte>();

                        for (int j = 0; j < NuNotes; j++)
                        {
                            inter.Add(note_perms[c][(shape_perms[f][j] - 1)]);
                        }

                        patterns.Add(inter);
                        patterns.Add(rhythm_perms[v]);
                    }

                }
                //midi files for each folder
                string x = Utility.perm_2_string(note_perms[c]);
                string outfolder = Path.Combine(Path.Combine(outputFolder, outputPath), x);
                Directory.CreateDirectory(outfolder);
                Utility.phrases_2_midi(patterns, outfolder);
            }
        }

        public static void rns(List<List<byte>> shape_perms, List<List<byte>> note_perms, List<List<byte>> rhythm_perms,
            int NuNotes, int DiNotes, string outputPath, string outputFolder)
        {


            for (int v = 0; v < rhythm_perms.Count; v++)
            {
                //patterns
                List<List<byte>> patterns = new List<List<byte>>();

                for (int c = 0; c < note_perms.Count; c++)
                {
                    for (int f = 0; f < shape_perms.Count; f++)
                    {


                        List<byte> inter = new List<byte>();

                        for (int j = 0; j < NuNotes; j++)
                        {
                            inter.Add(note_perms[c][(shape_perms[f][j] - 1)]);
                        }

                        patterns.Add(inter);
                        patterns.Add(rhythm_perms[v]);
                    }

                }
                //midi files for each folder
                string x = Utility.perm_2_string(rhythm_perms[v]);
                string outfolder = Path.Combine(Path.Combine(outputFolder, outputPath), x);
                Directory.CreateDirectory(outfolder);
                Utility.phrases_2_midi(patterns, outfolder);
            }
        }

        public static void files_all(string shape_file, string notes_file, string rhythm_file, int NuNotes, int DiNotes,
            string outputFolder)
        {
            byte[] notes = File.ReadAllBytes(notes_file);
            byte[] shapes = File.ReadAllBytes(shape_file);
            byte[] rhythm_bytes = File.ReadAllBytes(rhythm_file);

            List<List<byte>> note_perms = Utility.array_2_perms(notes, DiNotes);
            List<List<byte>> shape_perms = Utility.array_2_perms(shapes, NuNotes);
            List<List<byte>> rhythm_perms = Utility.array_2_perms(rhythm_bytes, NuNotes);

            List<List<byte>> phrases = new List<List<byte>>();

            for (int f = 0; f < shape_perms.Count; f++)
            {
                for (int c = 0; c < note_perms.Count; c++)
                {
                    for (int r = 0; r < rhythm_perms.Count; r++)
                    {
                        List<byte> pattern = new List<byte>();

                        for (int j = 0; j < NuNotes; j++)
                        {
                            pattern.Add(note_perms[c][(shape_perms[f][j] - 1)]);
                        }
                        phrases.Add(pattern);
                        phrases.Add(rhythm_perms[r]);

                        //create midi file

                        #region create

                        List<string> the_notes = new List<string>();
                        int repetition = 4;

                        List<string> notes_list = new List<string>();
                        int running_rhythm = 0;

                        string shapeString = Utility.perm_2_string(shape_perms[f]);
                        string noteString = Utility.perm_2_string(note_perms[c]);
                        string rhythmString = Utility.perm_2_string(rhythm_perms[r]);

                        for (int k = 0; k < repetition; k++)
                        {
                            for (int j = 0; j < NuNotes; j++)
                            {
                                string note = Convert.ToInt32(pattern[j]).ToString();
                                string rhythm = (Convert.ToInt32(rhythm_perms[r][j]) * 24).ToString();
                                int rhythm_end = running_rhythm + Convert.ToInt32(rhythm);

                                notes_list.Add("On_" + note + "_126_" + running_rhythm + "_" + rhythm_end.ToString() +
                                               "_red");

                                running_rhythm += Convert.ToInt32(rhythm);
                            }
                        }

                        string note_filename = Path.GetFileNameWithoutExtension(notes_file);
                        string rhythm_filename = Path.GetFileNameWithoutExtension(rhythm_file);
                        string shape_filename = Path.GetFileNameWithoutExtension(shape_file);


                        byte[] midi = Utility.notes_list_2_midi(notes_list, "midi_file");
                        string x = getFilename(shape_filename, note_filename, rhythm_filename, shapeString, noteString,
                            rhythmString);
                        File.WriteAllBytes(Path.Combine(outputFolder, x + ".mid"), midi);

                        #endregion create

                    }
                }
            }
        }

        public static void create_permsText(string shape_file, string notes_file, string rhythm_file, int NuNotes,
            int DiNotes, string outputFile)
        {
            byte[] notes = File.ReadAllBytes(notes_file);
            byte[] shapes = File.ReadAllBytes(shape_file);
            byte[] rhythm_bytes = File.ReadAllBytes(rhythm_file);
            var sw = new StreamWriter(outputFile, true);

            List<List<byte>> note_perms = Utility.array_2_perms(notes, DiNotes);
            List<List<byte>> shape_perms = Utility.array_2_perms(shapes, NuNotes);
            List<List<byte>> rhythm_perms = Utility.array_2_perms(rhythm_bytes, NuNotes);

            string note_filename = Path.GetFileNameWithoutExtension(notes_file);
            string rhythm_filename = Path.GetFileNameWithoutExtension(rhythm_file);
            string shape_filename = Path.GetFileNameWithoutExtension(shape_file);

            for (int f = 0; f < shape_perms.Count; f++)
            {
                for (int c = 0; c < note_perms.Count; c++)
                {
                    for (int r = 0; r < rhythm_perms.Count; r++)
                    {
                        string shapeString = Utility.perm_2_string(shape_perms[f]);
                        string noteString = Utility.perm_2_string(note_perms[c]);
                        string rhythmString = Utility.perm_2_string(rhythm_perms[r]);
                        string x = getFilename(shape_filename, note_filename, rhythm_filename, shapeString, noteString,
                            rhythmString);
                        sw.WriteLine(x);
                    }
                }
            }
        }

        public static string getFilename(string shape_filename, string note_filename, string rhythm_filename,
            string shapeString, string noteString, string rhythmString)
        {
            return "(" + shape_filename + ")" + "(" + shapeString + ")" + "_" + "(" + note_filename + ")" + "(" +
                       noteString + ")" + "_" + "(" + rhythm_filename + ")" + "(" + rhythmString + ")";
        }




    }


    class Utility
    {

        public static string perm_2_string(List<byte> perm)
        {
            string mine = "";
            for (int f = 0; f < perm.Count; f++)
            {
                mine += perm[f].ToString();
                if (f != perm.Count - 1)
                {
                    mine += "-";

                }
            }
            return mine;

        }

        public static List<List<byte>> array_2_perms(byte[] array, int NuNotes)
        {
            List<List<byte>> perms = new List<List<byte>>();

            int NuPerms = array.Length / NuNotes;

            for (int f = 0; f < NuPerms; f++)
            {
                List<byte> perm = new List<byte>();

                for (int c = 0; c < NuNotes; c++)
                {
                    perm.Add(array[(f * NuNotes) + c]);
                }
                perms.Add(perm);
            }

            return perms;


        }

        public static List<string> phrase_2_notes_list(List<List<int>> phrase)
        {
            int repetition = 1;
            int NuNotes = phrase[0].Count;

            List<string> notes_list = new List<string>();
            int running_rhythm = 0;

            for (int c = 0; c < repetition; c++)
            {

                for (int j = 0; j < NuNotes; j++)
                {
                    string note = Convert.ToInt32(phrase[0][j]).ToString();
                    string rhythm = (Convert.ToInt32(phrase[1][j]) * 24).ToString();
                    int rhythm_end = running_rhythm + Convert.ToInt32(rhythm);

                    notes_list.Add("On_" + note + "_126_" + running_rhythm + "_" + rhythm_end.ToString() + "_red");

                    running_rhythm += Convert.ToInt32(rhythm);
                }
            }

            //byte[] midi = notes_list_to_midi(notes_list, "midi_file");
            //File.WriteAllBytes(Path.Combine(outputFolder, "phrase_" + f.ToString() + ".mid"), midi);

            return notes_list;


        }

        public static byte[] notes_list_2_midi(List<string> notes_list, string midi_label)
        {
            List<string> events = notes_list_2_events(notes_list);
            List<byte> midi = events_2_content(events);
            return content_2_midi(midi.ToArray(), midi_label);
        }

        public static void phrases_2_midi(List<List<byte>> phrases, string outputFolder)
        {
            int NuNotes = phrases[0].Count;
            List<string> the_notes = new List<string>();
            int repetition = 4;

            for (int f = 0; f < phrases.Count; f = f + 2)
            {
                //take first 2 rows
                List<string> notes_list = new List<string>();
                int running_rhythm = 0;

                for (int c = 0; c < repetition; c++)
                {

                    for (int j = 0; j < NuNotes; j++)
                    {
                        string note = Convert.ToInt32(phrases[f][j]).ToString();
                        string rhythm = (Convert.ToInt32(phrases[f + 1][j]) * 24).ToString();
                        int rhythm_end = running_rhythm + Convert.ToInt32(rhythm);

                        notes_list.Add("On_" + note + "_126_" + running_rhythm + "_" + rhythm_end.ToString() + "_red");

                        running_rhythm += Convert.ToInt32(rhythm);
                    }
                }

                byte[] midi = notes_list_2_midi(notes_list, "midi_file");
                File.WriteAllBytes(Path.Combine(outputFolder, "phrase_" + f.ToString() + ".mid"), midi);

            }
        }

        public static byte[] Times24_To_Midi(int times_24)
        {
            List<byte> midi_rhythms = new List<byte>();


            //if > 16383 (cutoff

            if (times_24 > 16384)
            {
                int how_many = (times_24 / 16384);
                midi_rhythms.Add(Convert.ToByte(128 + how_many));
                midi_rhythms.Add(Convert.ToByte(Convert.ToByte(((times_24 - (how_many * 16384)) / 128) + 128)));
                midi_rhythms.Add(Convert.ToByte(0));//always be zero pretty much (i've checked up to 300)
            }
            else if (times_24 > 127 && times_24 <= 16384)
            {
                midi_rhythms.Add(Convert.ToByte(((times_24) / 128) + 128));
                midi_rhythms.Add(Convert.ToByte((times_24) - (((times_24) / 128) * 128)));
            }
            else if (times_24 < 128)
            {
                midi_rhythms.Add(Convert.ToByte(times_24));
            }




            byte[] midi_rhythms_byte = midi_rhythms.ToArray();
            return midi_rhythms_byte;

        }

        public static List<string> clone_liststring(List<string> a)
        {
            List<string> a_clone = new List<string>();
            for (int u = 0; u < a.Count; u++)
            {
                a_clone.Add(a[u]);
            }

            return a_clone;

        }

        public static int GetNthIndex(string s, char t, int n)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == t)
                {
                    count++;
                    if (count == n)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public static List<string> notes_list_2_events(List<string> notes_list_2)
        {
            List<string> new_events = new List<string>();

            List<string> notes_list = clone_liststring(notes_list_2);

            List<byte> content = new List<byte>();
            List<string> events = new List<string>();

            int first1 = GetNthIndex(notes_list[0], '_', 1);
            int second1 = GetNthIndex(notes_list[0], '_', 2);
            int third1 = GetNthIndex(notes_list[0], '_', 3);
            int fourth1 = GetNthIndex(notes_list[0], '_', 4);

            string on_or_off1 = notes_list[0].Substring(0, first1);
            string note1 = notes_list[0].Substring(first1 + 1, second1 - (first1 + 1));
            string velocity1 = notes_list[0].Substring(second1 + 1, third1 - (second1 + 1));
            string starts_at1 = notes_list[0].Substring(third1 + 1, fourth1 - (third1 + 1));
            string ends_at1 = notes_list[0].Substring(fourth1 + 1, notes_list[0].Length - (fourth1 + 1));

            int first_rhythm = int.Parse(starts_at1) - 0;//extracts the starts_at from the first line to get the first rhythm


            //get distinct rhythms==================================================================
            List<string> all_rhythms = new List<string>();
            List<string> all_starts = new List<string>();
            List<string> all_ends = new List<string>();

            for (int u = 0; u < notes_list.Count; u++)
            {

                string[] splitter = notes_list[u].Split('_');

                string on_or_off = splitter[0];
                string note = splitter[1];
                string velocity = splitter[2];
                string starts_at = splitter[3];
                string ends_at = splitter[4];

                all_rhythms.Add(starts_at);
                all_rhythms.Add(ends_at);

                all_starts.Add(starts_at);
                all_ends.Add(ends_at);

            }

            List<int> all_rhythms_int = new List<int>();
            List<int> all_starts_int = new List<int>();
            List<int> all_ends_int = new List<int>();

            for (int f = 0; f < all_rhythms.Count; f++)
            {
                all_rhythms_int.Add(int.Parse(all_rhythms[f]));
            }

            for (int f = 0; f < all_starts.Count; f++)
            {
                all_starts_int.Add(int.Parse(all_starts[f]));
            }

            for (int f = 0; f < all_ends.Count; f++)
            {
                all_ends_int.Add(int.Parse(all_ends[f]));
            }

            all_rhythms_int.Sort();
            all_starts_int.Sort();
            all_ends_int.Sort();

            List<string> distinct_rhythms = new List<string>();

            List<int> distinct_rhythms_int = new List<int>();

            distinct_rhythms_int.AddRange(all_rhythms_int.Distinct());

            for (int f = 0; f < distinct_rhythms_int.Count; f++)
            {
                distinct_rhythms.Add(distinct_rhythms_int[f].ToString());

            }

            string holder = "";
            List<string> running_starts = new List<string>();
            running_starts.Add(all_starts[all_starts.Count - 1]);
            holder = all_starts[all_starts.Count - 1];
            for (int f = all_starts.Count - 2; f > -1; f--)
            {
                if (/*running_starts[running_starts.Count - 1] ==*/ holder == all_starts[f])
                {
                    running_starts.Add("0");
                }
                else
                {
                    running_starts.Add(all_starts[f]);
                    holder = all_starts[f];
                }
            }


            //go through the rhythm instead of notes_list

            int the_running_rhythm = 0;
            for (int f = 0; f < distinct_rhythms.Count; f++)
            {

                for (int u = 0; u < notes_list.Count; u++)
                {


                    string[] splitter = notes_list[u].Split('_');

                    string on_or_off = splitter[0];
                    string note = splitter[1];
                    string velocity = splitter[2];
                    string starts_at = splitter[3];
                    string ends_at = splitter[4];



                    if (int.Parse(starts_at) == int.Parse(distinct_rhythms[f]))
                    {


                        if (new_events.Count > 0)
                        {
                            int new_rhythm = int.Parse(starts_at) - the_running_rhythm;
                            new_events[new_events.Count - 1] += new_rhythm.ToString();
                        }

                        new_events.Add(string.Format("On _{0}_126_", note));





                        the_running_rhythm = int.Parse(distinct_rhythms[f]);

                    }
                    if (int.Parse(ends_at) == int.Parse(distinct_rhythms[f]))
                    {


                        int new_rhythm = int.Parse(ends_at) - the_running_rhythm;
                        new_events[new_events.Count - 1] += new_rhythm.ToString();

                        new_events.Add(string.Format("Off_{0}_126_", note));





                        the_running_rhythm = int.Parse(distinct_rhythms[f]);
                    }
                }
            }//end f total rhythm

            new_events[new_events.Count - 1] += "0";
            new_events.Insert(0, first_rhythm.ToString());
            return new_events;

        }

        public static byte[] content_2_midi(byte[] content, string name)//send content, clipname?, filename
        {
            List<byte> out_file = new List<byte>();

            string clipname = System.IO.Path.GetFileNameWithoutExtension(name);

            int length = content.Length + 4 + clipname.Length;

            byte[] footer = new byte[4];
            footer[0] = 0x00;
            footer[1] = 0xff;
            footer[2] = 0x2f;
            footer[3] = 0x00;

            byte[] cliphead = new byte[4];
            cliphead[0] = 0x00;
            cliphead[1] = 0xFF;
            cliphead[2] = 0x03;
            cliphead[3] = Convert.ToByte(clipname.Length);

            //byte[] signature = new byte[16];
            //signature[0] = 0x00;
            //signature[1] = 0xFF;
            //signature[2] = 0x58;
            //signature[3] = 0x04;
            //signature[4] = 0x04;
            //signature[5] = 0x02;
            //signature[6] = 0x24;
            //signature[7] = 0x08;
            //signature[8] = 0x00;
            //signature[9] = 0xff;
            //signature[10] = 0x58;
            //signature[11] = 0x04;
            //signature[12] = 0x04;
            //signature[13] = 0x02;
            //signature[14] = 0x24;
            //signature[15] = 0x08;

            byte[] header = new byte[22];

            header[0] = 0x4d;
            header[1] = 0x54;
            header[2] = 0x68;
            header[3] = 0x64;
            header[4] = 0x00;
            header[5] = 0x00;
            header[6] = 0x00;
            header[7] = 0x06;
            header[8] = 0x00;
            header[9] = 0x00;
            header[10] = 0x00;
            header[11] = 0x01;
            header[12] = 0x00;
            header[13] = 0x60;
            header[14] = 0x4d;//MTRK
            header[15] = 0x54;
            header[16] = 0x72;
            header[17] = 0x6b;
            header[18] = Convert.ToByte(length / 16777217);
            header[19] = Convert.ToByte((length - ((length / 16777217) * 16777217)) / 65536);
            header[20] = Convert.ToByte((length - ((length / 65536) * 65536)) / 256);
            header[21] = Convert.ToByte((length - ((length / 256) * 256)));


            //header
            for (int u = 0; u < header.Length; u++)
            {
                out_file.Add(header[u]);
            }

            //clipname beginning
            for (int u = 0; u < cliphead.Length; u++)
            {
                out_file.Add(cliphead[u]);
            }
            //clipname

            for (int u = 0; u < clipname.Length; u++)
            {
                out_file.Add(Convert.ToByte(clipname[u]));
            }

            ////signature
            //for (int u = 0; u < signature.Length; u++)
            //{
            //    out_file.Add(Convert.ToByte(signature[u]));
            //}

            //content
            for (int u = 0; u < content.Length; u++)
            {
                out_file.Add(content[u]);
            }

            //footer
            for (int u = 0; u < footer.Length; u++)
            {
                out_file.Add(footer[u]);
            }

            byte[] mymidi = out_file.ToArray();

            return mymidi;


        }

        public static List<string> events_2_notes_list(List<string> events2)
        {
            int running_rhythm = 0;
            //int running_rhythm_before = 0;
            // int running_rhythm_after = 0;
            List<string> note_list = new List<string>();


            List<string> events = liststring(events2);
            string first_rhythm = events[0];
            events.Remove(events[0]);
            events[events.Count - 1] += "0";
            running_rhythm = int.Parse(first_rhythm);

            List<int> placements = new List<int>();
            for (int u = 0; u < events.Count; u++)
            {
                int first = GetNthIndex(events[u], '_', 1);
                int second = GetNthIndex(events[u], '_', 2);
                int third = GetNthIndex(events[u], '_', 3);

                string on_or_off = events[u].Substring(0, first);
                string note = events[u].Substring(first + 1, second - (first + 1));
                string velocity = events[u].Substring(second + 1, third - (second + 1));
                string rhythm = events[u].Substring(third + 1, events[u].Length - (third + 1));



                if (on_or_off == "On ")
                {
                    note_list.Add(string.Format("On _{0}_{1}_{2}_", note, velocity, running_rhythm));
                }



                //now look for next off

                if (on_or_off == "On ")
                {
                    int running_rhythm2 = running_rhythm;

                    for (int f = u; f < events.Count; f++)
                    {


                        int first2 = GetNthIndex(events[f], '_', 1);
                        int second2 = GetNthIndex(events[f], '_', 2);
                        int third2 = GetNthIndex(events[f], '_', 3);

                        string on_or_off2 = events[f].Substring(0, first2);
                        string note2 = events[f].Substring(first2 + 1, second2 - (first2 + 1));
                        string velocity2 = events[f].Substring(second2 + 1, third2 - (second2 + 1));
                        string rhythm2 = events[f].Substring(third2 + 1, events[f].Length - (third2 + 1));



                        if (on_or_off2 == "Off" && note2 == note)
                        {
                            note_list[note_list.Count - 1] += running_rhythm2.ToString();
                            break;
                        }
                        running_rhythm2 = running_rhythm2 + int.Parse(rhythm2);
                    }
                }

                running_rhythm = running_rhythm + int.Parse(rhythm);



            }

            //note_list.Insert(0, first_rhythm);





            //add _red to the end?
            for (int i = 0; i < note_list.Count; i++)
            {
                note_list[i] += "_red";
            }



            return note_list;


        }

        public static int midi_int(byte[] midi_rhythms)
        {
            //List<int> times_24 = new List<int>();
            int times_24 = 0;


            List<int> copied = new List<int>();
            for (int u = 0; u < midi_rhythms.Length; u++)
            {
                copied.Add(midi_rhythms[u]);
            }


            //===========================================================//


            if (copied.Count == 3)
            {
                int how_many = copied[0] - 128;

                times_24 = (copied[0] - 128) * 16384;
                int y = ((copied[1] - (128 * how_many)) * 128);
                times_24 += y;


            }

            else if (copied.Count == 2)/*(copied[0] > 127)*/
            {
                times_24 = ((copied[0] - 128) * 128) + (copied[0 + 1]);

            }
            else if (copied.Count == 1)
            {
                times_24 = copied[0];
            }

            return times_24;

        }

        public static List<byte> listbyte(List<byte> a)
        {
            List<byte> a_clone = new List<byte>();
            for (int u = 0; u < a.Count; u++)
            {
                a_clone.Add(a[u]);
            }

            return a_clone;

        }

        public static List<string> liststring(List<string> a)
        {
            List<string> a_clone = new List<string>();
            for (int u = 0; u < a.Count; u++)
            {
                a_clone.Add(a[u]);
            }

            return a_clone;

        }

        public static List<byte> events_2_content(List<string> events2)
        {
            List<string> events = clone_liststring(events2);
            //events.RemoveAt(0);

            List<byte> content = new List<byte>();
            //content.Add(0x00);

            int y = Convert.ToInt32(events[0]);
            byte[] x = Times24_To_Midi(y);
            content.AddRange(x);

            for (int u = 1; u < events.Count; u++)//u=1 because 0 is first_rhythm
            {
                int number_of_dash = events[u].Split('_').Length - 1;


                if (number_of_dash == 3)
                {

                    int first = GetNthIndex(events[u], '_', 1);
                    int second = GetNthIndex(events[u], '_', 2);
                    int third = GetNthIndex(events[u], '_', 3);

                    string on_or_off = events[u].Substring(0, first);
                    string note = events[u].Substring(first + 1, second - (first + 1));
                    string velocity = events[u].Substring(second + 1, third - (second + 1));
                    string rhythm = events[u].Substring(third + 1, events[u].Length - (third + 1));

                    if (on_or_off == "On ")
                    {
                        content.Add(0x90);
                        content.Add(byte.Parse(note));
                        content.Add(byte.Parse(velocity));
                    }
                    else if (on_or_off == "Off")
                    {
                        content.Add(0x80);
                        content.Add(byte.Parse(note));
                        content.Add(byte.Parse(velocity));
                    }

                    else if (on_or_off == "Dpw")
                    {
                        content.Add(0xE0);
                        content.Add(byte.Parse(note));
                        content.Add(byte.Parse(velocity));
                    }

                    else if (on_or_off == "Dpa")
                    {
                        content.Add(0xA0);
                        content.Add(byte.Parse(note));
                        content.Add(byte.Parse(velocity));
                    }

                    else if (on_or_off == "Dcc")
                    {
                        content.Add(0xB0);
                        content.Add(byte.Parse(note));
                        content.Add(byte.Parse(velocity));
                    }

                    int the_rhythm = int.Parse(rhythm);
                    byte[] rhythm_byte = Times24_To_Midi(the_rhythm);
                    content.AddRange(rhythm_byte);

                }
                else if (number_of_dash == 2)
                {

                    int first = GetNthIndex(events[u], '_', 1);
                    int second = GetNthIndex(events[u], '_', 2);


                    string on_or_off = events[u].Substring(0, first);
                    string note = events[u].Substring(first + 1, second - (first + 1));
                    string rhythm = events[u].Substring(second + 1, events[u].Length - (second + 1));



                    if (on_or_off == "Dpc")
                    {
                        content.Add(0xC0);
                        content.Add(byte.Parse(note));

                    }

                    else if (on_or_off == "Dca")
                    {
                        content.Add(0xD0);
                        content.Add(byte.Parse(note));

                    }

                    int the_rhythm = int.Parse(rhythm);
                    byte[] rhythm_byte = Times24_To_Midi(the_rhythm);
                    content.AddRange(rhythm_byte);


                }


            }

            return content;
        }

        public static List<string> content_2_events(List<byte> content_not_cloned)
        {
            /*
            byte[] a = Content_from_array_with_first_rhythm.content(whole_file);
            List<byte> cleaned = clean_content.clean(a);
                     for (int u = 0; u < cleaned.Count; u++)
            {
                content.Add(cleaned[u]);
            }
            */

            List<string> events = new List<string>();


            List<byte> content = listbyte(content_not_cloned);

            List<byte> rhythms = new List<byte>();
            List<byte> note_ons = new List<byte>();
            List<byte> note_offs = new List<byte>();

            int flag = 0;

            int chunk_counter = 0;
            int odd_or_even = 0;

            int rhythm_counter = 0;

            herewego:
            chunk_counter++;//whether chunk_counter is even or odd (could have something to do with it?)
            odd_or_even = chunk_counter % 2;


            if (odd_or_even == 1 && content[0] > 127 && content[1] > 127)//rhythm is greater than 42.5 measures (cutoff for two byte rhythm)
            {
                rhythm_counter++;

                rhythms.Add(content[0]);
                rhythms.Add(content[1]);
                rhythms.Add(content[2]);


                byte[] junk = new byte[3];
                junk[0] = content[0];
                junk[1] = content[1];
                junk[2] = content[2];

                if (rhythm_counter == 1)//cant add when nothing's there
                {
                    events.Add(midi_int(junk).ToString());
                }
                else
                {
                    events[events.Count - 1] += midi_int(junk).ToString();
                }

                for (int u = 0; u < 3; u++)
                {
                    content.Remove(content[0]);
                }
            }

            else if (odd_or_even == 1 && content[0] > 127 && content[1] < 0x80)
            {
                rhythm_counter++;

                rhythms.Add(content[0]);
                rhythms.Add(content[1]);

                byte[] junk = new byte[2];
                junk[0] = content[0];
                junk[1] = content[1];

                if (rhythm_counter == 1)//cant add when nothing's there
                {
                    events.Add(midi_int(junk).ToString());
                }
                else
                {
                    events[events.Count - 1] += midi_int(junk).ToString();
                }



                for (int u = 0; u < 2; u++)
                {
                    content.Remove(content[0]);
                }

            }

            else if (odd_or_even == 1 && content[0] < 0x80)
            {

                rhythm_counter++;
                rhythms.Add(content[0]);

                if (rhythm_counter == 1)
                {
                    int inter = content[0];
                    events.Add(inter.ToString());
                }
                else
                {
                    int inter = content[0];
                    events[events.Count - 1] += inter.ToString();
                }


                content.Remove(content[0]);

            }

            else if (odd_or_even == 0 && content[0] >= 0x90 && content[0] <= 0x9F)
            //else if (odd_or_even == 0 && content[0] == 0x90 /* && content[0]>= 0x90 && content[0] <= 0x9F*/)
            {
                events.Add("On _");

                if (content[1] < 10)
                {
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += content[1].ToString();
                    events[events.Count - 1] += "_";
                }
                else if (content[1] > 9 && content[1] < 100)
                {
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += content[1].ToString();
                    events[events.Count - 1] += "_";
                }
                else if (content[1] > 99)
                {
                    events[events.Count - 1] += content[1].ToString();
                    events[events.Count - 1] += "_";
                }



                if (content[2] < 10)
                {
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += content[2].ToString();
                    events[events.Count - 1] += "_";
                }
                else if (content[2] > 9 && content[2] < 100)
                {
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += content[2].ToString();
                    events[events.Count - 1] += "_";
                }
                else if (content[2] > 99)
                {
                    events[events.Count - 1] += content[2].ToString();
                    events[events.Count - 1] += "_";
                }

                flag = 0;
                note_ons.Add(content[0]);
                note_ons.Add(content[1]);
                note_ons.Add(content[2]);

                for (int u = 0; u < 3; u++)
                {
                    content.Remove(content[0]);
                }

            }

            else if (odd_or_even == 0 && content[0] >= 0x80 && content[0] <= 0x8F)
            //else if (odd_or_even == 0 && content[0] == 0x80)
            {
                events.Add("Off_");
                if (content[1] < 10)
                {
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += content[1].ToString();
                    events[events.Count - 1] += "_";
                }
                else if (content[1] > 9 && content[1] < 100)
                {
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += content[1].ToString();
                    events[events.Count - 1] += "_";
                }
                else if (content[1] > 99)
                {
                    events[events.Count - 1] += content[1].ToString();
                    events[events.Count - 1] += "_";
                }



                if (content[2] < 10)
                {
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += content[2].ToString();
                    events[events.Count - 1] += "_";
                }
                else if (content[2] > 9 && content[2] < 100)
                {
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += content[2].ToString();
                    events[events.Count - 1] += "_";
                }
                else if (content[2] > 99)
                {
                    events[events.Count - 1] += content[2].ToString();
                    events[events.Count - 1] += "_";
                }

                flag = 1;
                note_offs.Add(content[0]);
                note_offs.Add(content[1]);
                note_offs.Add(content[2]);


                for (int u = 0; u < 3; u++)
                {
                    content.Remove(content[0]);
                }

            }


            else if (odd_or_even == 0 && content[0] >= 0xC0 && content[0] <= 0xCF)
            //else if (odd_or_even == 0 && content[0] == 0xC0)
            {
                events.Add("Dpc_");

                if (content[1] < 10)
                {
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += content[1].ToString();
                    events[events.Count - 1] += "_";
                }
                else if (content[1] > 9 && content[1] < 100)
                {
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += content[1].ToString();
                    events[events.Count - 1] += "_";
                }
                else if (content[1] > 99)
                {
                    events[events.Count - 1] += content[1].ToString();
                    events[events.Count - 1] += "_";
                }


                events[events.Count - 1] += "  0_";//just to keep everything uniform

                flag = 1;


                for (int u = 0; u < 2; u++)
                {
                    content.Remove(content[0]);
                }

            }

            else if (odd_or_even == 0 && content[0] >= 0xD0 && content[0] <= 0xDF)
            //else if (odd_or_even == 0 && content[0] == 0xD0)
            {
                events.Add("Dca_");

                if (content[1] < 10)
                {
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += content[1].ToString();
                    events[events.Count - 1] += "_";
                }
                else if (content[1] > 9 && content[1] < 100)
                {
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += content[1].ToString();
                    events[events.Count - 1] += "_";
                }
                else if (content[1] > 99)
                {
                    events[events.Count - 1] += content[1].ToString();
                    events[events.Count - 1] += "_";
                }


                events[events.Count - 1] += "  0_";

                flag = 1;


                for (int u = 0; u < 2; u++)
                {
                    content.Remove(content[0]);
                }

            }

            else if (odd_or_even == 0 && content[0] >= 0xB0 && content[0] <= 0xBF)
            //else if (odd_or_even == 0 && content[0] == 0xB0)
            {
                events.Add("Dcc_");
                if (content[1] < 10)
                {
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += content[1].ToString();
                    events[events.Count - 1] += "_";
                }
                else if (content[1] > 9 && content[1] < 100)
                {
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += content[1].ToString();
                    events[events.Count - 1] += "_";
                }
                else if (content[1] > 99)
                {
                    events[events.Count - 1] += content[1].ToString();
                    events[events.Count - 1] += "_";
                }



                if (content[2] < 10)
                {
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += content[2].ToString();
                    events[events.Count - 1] += "_";
                }
                else if (content[2] > 9 && content[2] < 100)
                {
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += content[2].ToString();
                    events[events.Count - 1] += "_";
                }
                else if (content[2] > 99)
                {
                    events[events.Count - 1] += content[2].ToString();
                    events[events.Count - 1] += "_";
                }

                flag = 1;


                for (int u = 0; u < 3; u++)
                {
                    content.Remove(content[0]);
                }

            }

            else if (odd_or_even == 0 && content[0] >= 0xA0 && content[0] <= 0xAF)
            //else if (odd_or_even == 0 && content[0] == 0xA0)
            {
                events.Add("Dpa_");
                if (content[1] < 10)
                {
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += content[1].ToString();
                    events[events.Count - 1] += "_";
                }
                else if (content[1] > 9 && content[1] < 100)
                {
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += content[1].ToString();
                    events[events.Count - 1] += "_";
                }
                else if (content[1] > 99)
                {
                    events[events.Count - 1] += content[1].ToString();
                    events[events.Count - 1] += "_";
                }



                if (content[2] < 10)
                {
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += content[2].ToString();
                    events[events.Count - 1] += "_";
                }
                else if (content[2] > 9 && content[2] < 100)
                {
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += content[2].ToString();
                    events[events.Count - 1] += "_";
                }
                else if (content[2] > 99)
                {
                    events[events.Count - 1] += content[2].ToString();
                    events[events.Count - 1] += "_";
                }

                flag = 1;


                for (int u = 0; u < 3; u++)
                {
                    content.Remove(content[0]);
                }

            }

            else if (odd_or_even == 0 && content[0] >= 0xE0 && content[0] <= 0xEF)
            //else if (odd_or_even == 0 && content[0] == 0xE0)
            {
                events.Add("Dpw_");
                if (content[1] < 10)
                {
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += content[1].ToString();
                    events[events.Count - 1] += "_";
                }
                else if (content[1] > 9 && content[1] < 100)
                {
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += content[1].ToString();
                    events[events.Count - 1] += "_";
                }
                else if (content[1] > 99)
                {
                    events[events.Count - 1] += content[1].ToString();
                    events[events.Count - 1] += "_";
                }



                if (content[2] < 10)
                {
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += content[2].ToString();
                    events[events.Count - 1] += "_";
                }
                else if (content[2] > 9 && content[2] < 100)
                {
                    events[events.Count - 1] += " ";
                    events[events.Count - 1] += content[2].ToString();
                    events[events.Count - 1] += "_";
                }
                else if (content[2] > 99)
                {
                    events[events.Count - 1] += content[2].ToString();
                    events[events.Count - 1] += "_";
                }


                flag = 1;


                for (int u = 0; u < 3; u++)
                {
                    content.Remove(content[0]);
                }

            }

            if (content.Count != 0)
            {
                goto herewego;
            }

            byte[] noteons_array = note_ons.ToArray();

            return events;


        }

        public static byte[] content_to_midi(byte[] content, string name)//send content, clipname?, filename
        {
            List<byte> out_file = new List<byte>();

            string clipname = System.IO.Path.GetFileNameWithoutExtension(name);

            int length = content.Length + 4 + clipname.Length;

            byte[] footer = new byte[4];
            footer[0] = 0x00;
            footer[1] = 0xff;
            footer[2] = 0x2f;
            footer[3] = 0x00;

            byte[] cliphead = new byte[4];
            cliphead[0] = 0x00;
            cliphead[1] = 0xFF;
            cliphead[2] = 0x03;
            cliphead[3] = Convert.ToByte(clipname.Length);
            
            byte[] header = new byte[22];

            header[0] = 0x4d;
            header[1] = 0x54;
            header[2] = 0x68;
            header[3] = 0x64;
            header[4] = 0x00;
            header[5] = 0x00;
            header[6] = 0x00;
            header[7] = 0x06;
            header[8] = 0x00;
            header[9] = 0x00;
            header[10] = 0x00;
            header[11] = 0x01;
            header[12] = 0x00;
            header[13] = 0x60;
            header[14] = 0x4d;//MTRK
            header[15] = 0x54;
            header[16] = 0x72;
            header[17] = 0x6b;
            header[18] = Convert.ToByte(length / 16777217);
            header[19] = Convert.ToByte((length - ((length / 16777217) * 16777217)) / 65536);
            header[20] = Convert.ToByte((length - ((length / 65536) * 65536)) / 256);
            header[21] = Convert.ToByte((length - ((length / 256) * 256)));


            //header
            for (int u = 0; u < header.Length; u++)
            {
                out_file.Add(header[u]);
            }

            //clipname beginning
            for (int u = 0; u < cliphead.Length; u++)
            {
                out_file.Add(cliphead[u]);
            }
            //clipname

            for (int u = 0; u < clipname.Length; u++)
            {
                out_file.Add(Convert.ToByte(clipname[u]));
            }

            //content
            for (int u = 0; u < content.Length; u++)
            {
                out_file.Add(content[u]);
            }

            //footer
            for (int u = 0; u < footer.Length; u++)
            {
                out_file.Add(footer[u]);
            }

            byte[] mymidi = out_file.ToArray();

            return mymidi;

        }
    }
}
