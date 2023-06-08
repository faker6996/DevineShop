using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace MARShop.Core.Common
{
    public static class ConvertToSlug
    {
        public static string ToSlug(this string input)
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
            return $"{slug}-{Guid.NewGuid().ToString()}";
        }
    }
}
