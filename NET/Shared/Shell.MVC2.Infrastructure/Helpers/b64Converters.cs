using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shell.MVC2.Infrastructure.Helpers
{
    public static class b64Converters
    {

        public static byte[] b64stringtoByteArray(string b64string)
        {

           byte [] bytearray;
            try
            {
                bytearray =
                        System.Convert.FromBase64String(b64string);
                return bytearray;
                 
            }
            catch (System.ArgumentNullException)
            {
                System.Console.WriteLine("string data array is null.");
                return null;
            }

        }

        public static string ByteArraytob64string(byte[] binaryData)
        {

            string base64String;
            try
            {
                base64String =
                  System.Convert.ToBase64String(binaryData,
                                         0,
                                         binaryData.Length);

                return base64String;
            }
            catch (System.ArgumentNullException)
            {
                System.Console.WriteLine("Binary data array is null.");
                return "Error";
            }

        }
    }
}