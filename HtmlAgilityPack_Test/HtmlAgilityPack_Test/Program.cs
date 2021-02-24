using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace HtmlAgilityPack_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var tooltipText = File.ReadAllText("D:\\html1.txt");
            var bodyContent = tooltipText;
            if (!string.IsNullOrEmpty(tooltipText))
            {
                var doc = new HtmlDocument();
                doc.LoadHtml(tooltipText);
                bodyContent = doc.DocumentNode?.SelectSingleNode("//body")?.InnerHtml ?? bodyContent;
                bodyContent = bodyContent.Replace("\"", "'");
            }

            Console.WriteLine(bodyContent);
        }
    }
}
