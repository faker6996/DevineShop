using System;
using System.Globalization;
using System.Text;

namespace Draftt
{
    internal class Program
    {
        public static string ConvertToSlug(string input)
        {
            string normalized = input.Normalize(NormalizationForm.FormD);
            StringBuilder slugBuilder = new StringBuilder();

            foreach (char c in normalized)
            {
                UnicodeCategory category = CharUnicodeInfo.GetUnicodeCategory(c);
                if (category != UnicodeCategory.NonSpacingMark)
                {
                    if (c == ' ')
                    {
                        slugBuilder.Append('-');
                    }
                    else if (category != UnicodeCategory.OtherNotAssigned)
                    {
                        slugBuilder.Append(c);
                    }
                }
            }

            string slug = slugBuilder.ToString().ToLower();
            return slug;
        }
        static void Main(string[] args)
        {
            string title = @"Custom Terminal bằng Oh-my-posh";
            string slug = ConvertToSlug(title);
            Console.WriteLine(slug);
        }
    }
}
