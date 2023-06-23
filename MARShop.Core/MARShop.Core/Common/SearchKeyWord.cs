using System;
using System.Globalization;
using System.Text;

namespace MARShop.Core.Common
{
    public static class SearchKeyWord
    {
        private static int[] ComputeLPSArray(string pattern)
        {
            int[] lps = new int[pattern.Length];
            int len = 0;
            int i = 1;

            while (i < pattern.Length)
            {
                if (pattern[i] == pattern[len])
                {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else
                {
                    if (len != 0)
                    {
                        len = lps[len - 1];
                    }
                    else
                    {
                        lps[i] = 0;
                        i++;
                    }
                }
            }

            return lps;
        }

        private static string PreprocessText(string input)
        {
            if (input == null) return "";

            // Thay thế các ký tự "d", "đ", "Đ", "D" thành "d"
            input = input.Replace("đ", "d").Replace("Đ", "d").Replace("D", "d");

            // Loại bỏ dấu câu và chuyển về chữ thường
            input = RemoveDiacritics(input).ToLower();

            return input;
        }

        private static string RemoveDiacritics(string input)
        {
            string normalizedString = input.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char c in normalizedString)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    stringBuilder.Append(c);
            }

            return stringBuilder.ToString();
        }

        public static bool Search(this string text, string keyword)
        {
            if (keyword.Trim() == String.Empty) return true;
            keyword = PreprocessText(keyword); // Tiền xử lý từ khóa
            string processedText = PreprocessText(text); // Tiền xử lý văn bản

            return IsKeywordPresent(keyword, processedText);
        }

        private static bool IsKeywordPresent(string keyword, string text)
        {
            int[] lps = ComputeLPSArray(keyword);
            int i = 0;
            int j = 0;

            while (i < text.Length)
            {
                if (keyword[j] == text[i])
                {
                    j++;
                    i++;
                }

                if (j == keyword.Length)
                {
                    return true;
                }
                else if (i < text.Length && keyword[j] != text[i])
                {
                    if (j != 0)
                    {
                        j = lps[j - 1];
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            return false;
        }
    }
}
