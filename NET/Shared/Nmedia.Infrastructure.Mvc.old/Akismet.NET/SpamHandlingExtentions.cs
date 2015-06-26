using Akismet.NET;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nmedia.MVC.Infrastructure.Utils
{
    public static class SpamHandlingExtentions
    {


        public static string AkisMetkey = "2e849dc20b2d";

          //   <add key="AKISMET_KEY" value="2e849dc20b2d"/>
   // <add key="AKISMET_DOMAIN" value="http://XXX"/>


        /// <summary>
        /// This class add some extenssion methods for the <see cref="Akismet.NET.Comment"/>.
        /// </summary>

        /// <summary>
        /// Check if the input akismet comment is spam or not.
        /// </summary>
        /// <param name="comment">The input comment.</param>
        /// <returns>True for a spam comment, false otherwise.</returns>
        public static Boolean IsSpam(Comment comment)
        {
            Validator validator = new Validator(ConfigurationManager.AppSettings["AKISMET_KEY"]);
            return validator.IsSpam(comment);
        }


        /// <summary>
        /// Check if the input akismet comment is spam or not.
        /// </summary>
        /// <param name="comment">The input comment.</param>
        /// <returns>True for a spam comment, false otherwise.</returns>
        public static Boolean MessageContainsBannedChars(string value)
        {

            string stringToCheck = value;
            string[] stringArray = { "yahoo", "gmail", "@", ".com", ".net", "hotmail", "msn" };
            string[] revArray = Array.ConvertAll<string, string>(stringArray, delegate(string s) { return s.ToUpper(); });

            string[] combined = stringArray.Concat(revArray).ToArray();

            if (combined.Any(stringToCheck.Contains))
                // Process... 
                return true;


            return false;
        }
    }
}
