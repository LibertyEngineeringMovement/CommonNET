using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Common
{
    public static class SystemStringUtilities
    {

        /// <summary>
        /// Removes both double quotes and single quotes from the string.
        /// </summary>
        /// <param name="value">String to be unquoted. </param>
        /// <returns>The original string minus the quotes, if the string </returns>
        /// <remarks>
        /// String must be surrounded by double quotes or single quotes. 
        /// If the string begins with one, but doesn't end with the same one, 
        /// then the string is untouched.
        /// </remarks>
        public static string DequoteString(this string value)
        {
            value = value.Trim();

            if ((value.StartsWith("\"") && value.EndsWith("\""))
                || (value.StartsWith("'") && value.EndsWith("'")))
            {
                value = value.Substring(1, value.Length - 2);
            }

            return value;
        }

        /// <summary>
        /// Dequotes the string.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="trim">if set to <c>true</c> [trim].</param>
        /// <returns></returns>
        public static string DequoteString(this string value, bool trim)
        {
            if (trim)
                value = value.Trim();

            return value.DequoteString();
        }

        /// <summary>
        /// DeNulls the string.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static string DeNullString(this string value)
        {
            //Cheezy way to avoid null checks, but if you don't need it, just force a blank.
            return string.Format("{0}", value);
        }

        public static Guid ToGuid(this string value)
        {
            Guid ret;
            if (Guid.TryParse(value, out ret))
                return ret;
            else
                throw new ParsingException(string.Format("Cannot convert \"{0}\" to Guid", value));
        }

        private const string STRING_SAMPLE = "qwertyupasdfghjkzxcvbnmQWERTYUPASDFGHJKLZXCVBNM";
        private const string NUMBER_SAMPLE = "701623284349056575819";
        private const string SYMBOL_SAMPLE = "~!@#$%^&*()_+`-=[]{}|,./<?>:";
        public static string GenerateRandomPassword(this string ignoredvalue, int minlength = 6, int maxlength = 24) {
            minlength = minlength < 6 ? 6 : minlength;
            maxlength = maxlength < minlength ? minlength : maxlength;
            DateTime core = DateTime.Now;
            var seed = core.Year + core.Month + core.Day + core.Hour + core.Minute + core.Second + core.Millisecond + (core.IsDaylightSavingTime() ? 1 : 0);
            Random rnd = new Random(seed);
            int length = rnd.Next(maxlength - minlength);
            int digits = Convert.ToInt32(length * 0.16);
            int symbols = Convert.ToInt32(length * 0.33);
            int characters = length;
            digits = digits < 1 ? 1 : digits;
            symbols = symbols < 1 ? 1 : symbols;
            characters -= digits;
            characters -= symbols;

            StringBuilder sb = new StringBuilder();
            var branch = (new int[] { 0, 1, 2 }).ToList();

            for (var i = 0; i < length; i++)
            {
                var go = branch[rnd.Next(branch.Count -1)];
                switch (go) { 
                    case 0: //digit
                        digits--;
                        sb.Append(NUMBER_SAMPLE[rnd.Next(20)]);
                        if (digits == 0) {
                            branch.Remove(0);
                        }
                        break;
                    case 1: //symbol
                        symbols--;
                        sb.Append(SYMBOL_SAMPLE[rnd.Next(27)]);
                        if (symbols == 0)
                        {
                            branch.Remove(1);
                        }
                        break;
                    case 2: //character
                        characters--;
                        sb.Append(STRING_SAMPLE[rnd.Next(47)]);
                        if (characters == 0)
                        {
                            branch.Remove(2);
                        }
                       break;
                }
            }

            return sb.ToString();
        }

        public static T FromJSON<T>(this string value) {
            try { 
                return JsonConvert.DeserializeObject<T>(value);
            }
            catch(Exception ex)
            {  
                throw new ParsingException("Failed to deserialize jSon string.", ex);
            }
        }
    }

    public class ParsingException : Exception
    {
        public ParsingException(string msg)
            : base(msg)
        { }

        public ParsingException(string msg, Exception innerException)
            : base(msg, innerException)
        { }
    }
}
