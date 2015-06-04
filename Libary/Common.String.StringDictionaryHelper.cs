using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Common.String
{
    public static class StringDictionaryHelper
    {
        public static bool ToBool(this Dictionary<string, string> dict, string key, bool defaultval = false)
        {
            bool ret = defaultval;
            if (dict != null)
            {
                if (dict.Keys.Contains(key))
                {
                    string ischecktest = (dict[key] ?? "");
                    ret = ischecktest == "1";
                }
            }
            return ret;
        }
        public static float ToFloat(this Dictionary<string, string> dict, string key, float defaultval = 0)
        {
            float ret = defaultval;
            if (dict != null)
            {
                if (dict.Keys.Contains(key))
                {
                    string val = dict[key] ?? "";
                    try
                    {
                        ret = float.Parse(val);
                    }
                    catch
                    {
                        //poorly formatted data will return defaultval
                    }
                }
            }
            return ret;
        }
        public static int ToInt(this Dictionary<string, string> dict, string key, int defaultval = 0)
        {
            int ret = defaultval;
            if (dict != null)
            {
                if (dict.Keys.Contains(key))
                {
                    string val = dict[key] ?? "";
                    try
                    {
                        ret = int.Parse(val);
                    }
                    catch
                    {
                        //poorly formatted data will return defaultval
                    }
                }
            }
            return ret;
        }
        public static decimal ToDecimal(this Dictionary<string, string> dict, string key, decimal defaultval = 0)
        {
            decimal ret = defaultval;
            if (dict != null)
            {
                if (dict.Keys.Contains(key))
                {
                    string val = dict[key] ?? "";
                    try
                    {
                        ret = int.Parse(val);
                    }
                    catch
                    {
                        //poorly formatted data will return defaultval
                    }
                }
            }
            return ret;
        }
        public static string ToString(this Dictionary<string, string> dict, string key, string defaultval = "")
        {
            string ret = defaultval;
            if (dict != null)
            {
                if (dict.Keys.Contains(key))
                {
                    ret = dict[key];
                }
            }
            return ret;
        }
        public static DateTime ToDateTime(this Dictionary<string, string> dict, string key, DateTime? defaultval = null)
        {
            DateTime ret = defaultval ?? DateTime.Now;
            if (dict != null)
            {
                if (dict.Keys.Contains(key))
                {
                    try
                    {
                        ret = DateTime.Parse(dict[key]);
                    }
                    catch
                    {
                        //leave as default.
                    }
                }
            }
            return ret;
        }
    }
}
