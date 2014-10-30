using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Nmedia.Infrastructure.Helpers
{
    public static class StringHelpers
    {
        public static string RandomReadableString(int length)
        {
            return "23456789ABCDEFGHJKMNPQRSTUVWXYZabcdefghijkmnpqrstuvwxyz".RandomString(length);
        }

        public static string RandomString(this string characterSet, int length)
        {
            var rng = new RNGCryptoServiceProvider();
            var random = new byte[length];
            rng.GetNonZeroBytes(random);

            var buffer = new char[length];
            var usableChars = characterSet.ToCharArray();
            var usableLength = usableChars.Length;

            for (int index = 0; index < length; index++)
            {
                buffer[index] = usableChars[random[index] % usableLength];
            }

            return new string(buffer);
        }


    }
}
