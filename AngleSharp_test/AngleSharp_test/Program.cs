using System;
using AngleSharp;
using AngleSharp.Parser.Html;

namespace AngleSharp_test
{
    class Program
    {
        static void Main(string[] args)
        {
            //We require a custom configuration
            var config = Configuration.Default.WithJavaScript();
            //Let's create a new parser using this configuration
            var parser = new HtmlParser(config);

            //This is our sample source, we will set the title and write on the document
            var source = @"<!doctype html><html><head></head><body><style>a.fr-green{color: green;}a.fr-strong{font-weight: 700;}a{color: inherit !important;}</style><p><span style='color: rgb(209, 213, 216);'><a href='http://cnn.com'>CNN</a></span></p><script>(function(){var doc = document;elementList=doc.querySelectorAll('span a');for(var i=0, max=elementList.length; i < max; i++) {doc.title = elementList[i].parentNode.style;elementList[i].setAttribute('style', elementList[i].parentNode.style);}})();</script></body></html>";
            var document = parser.Parse(source);

            //Modified HTML will be output
            Console.WriteLine(document.DocumentElement.OuterHtml);
        }
    }
}
