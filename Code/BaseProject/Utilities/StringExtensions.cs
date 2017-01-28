using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace BaseProject.Web.Utilities
{
    public static class StringExtensions
    {
        public static string GenerateSlug(this string str)
        {
            var trimLength = 100;
            str = str.ToLower();
            // invalid chars           
            str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
            // convert multiple spaces into one space   
            str = Regex.Replace(str, @"\s+", " ").Trim();
            // cut and trim 
            str = str.Substring(0, str.Length <= trimLength ? str.Length : trimLength).Trim();
            str = Regex.Replace(str, @"\s", "-"); // hyphens   
            return str;
        }

        public static string RemoveWhitespace(this string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }
    }
}