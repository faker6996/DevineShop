using System;
using System.Text;

namespace MARShop.Core.Common
{
    public class GeneratePass
    {
        private static readonly Random random = new Random();

        public static string GenerateRandomPassword(int length)
        {
            const string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

            StringBuilder password = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                int randomIndex = random.Next(0, allowedChars.Length);
                password.Append(allowedChars[randomIndex]);
            }

            return password.ToString();
        }
    }
}
