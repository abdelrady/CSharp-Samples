using System;

namespace CSSInliner
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = "<style type=\"text/css\">a.fr-green{color: green;}a.fr-strong{font-weight: 700;}</style><p><a class=\"fr-green fr-strong\" href=\"http://www.sql.ru/\">SQL Web Site</a></p>";
            Console.WriteLine(PreMailer.Net.PreMailer.MoveCssInline(result).Html);
        }
    }
}
