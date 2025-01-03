using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiziix
{
    public class GenerateVerificationCode
    {

        public static string generateVerificationCode()
        {
            var chars = "abcdefghijkmnoprstqwvyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
            var stringChars = new char[5];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new String(stringChars);
        }


    }
}
