using System;
using System.Text;

namespace UrlParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nPaste Url to parse: ");
            string url = Console.ReadLine();

            string newUrl = ReplaceHexCharactersWithASCIICharacters(url);

            newUrl = FormatOutput(newUrl);

            Console.WriteLine();
            Console.WriteLine(newUrl);

            Console.WriteLine("\nHit <ENTER> to continue");
            Console.ReadLine();
        }

        private static string ReplaceHexCharactersWithASCIICharacters(string url)
        {
            for (int i = 0; i < url.Length; i++)
            {
                if (url[i] == '%')
                {
                    string stringToConvert = url.Substring(i + 1, 2);
                    uint hexStringUint = uint.Parse(stringToConvert, style: System.Globalization.NumberStyles.HexNumber);
                    string hexString = ((char)hexStringUint).ToString();


                    url = url.Remove(i, 3);
                    url = url.Insert(i, hexString);
                    i -= 1;
                }
            }

            return url;
        }

        private static string FormatOutput(string url)
        {
            string newUrl = "";

            for (int i = 0; i < url.Length; i++)
            {
                if (url[i] != '?' && url[i] != '&')
                {
                    newUrl += url[i];
                }
                else
                {
                    newUrl += $"\n{url[i]}\n";
                }
            }

            return newUrl;
        }
    }
}
