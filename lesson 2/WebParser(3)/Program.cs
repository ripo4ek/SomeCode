using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;

namespace WebParser_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            WebParser parser = new WebParser("https://www.google.ru/");
            var content = parser.FindContentInTag("div");
            foreach (var match in content)
            {
                Console.WriteLine(match);
            }
        }
    }
    class WebParser : WebClient
    {
        private string _url;

        public WebParser(string url)
        {
            _url = url;
        }

        public IEnumerable FindContentInTag(string tag)
        {
            string page = DownloadString(_url);
            string pattern = $"<{tag}.*?>(.*?)<\\/{tag}>";
            MatchCollection matches = Regex.Matches(page, pattern);
            if (matches.Count > 0)
            {
                foreach (Match m in matches)
                {
                    yield return m.Groups[1];
                }
            }                   
        }
    }
}
