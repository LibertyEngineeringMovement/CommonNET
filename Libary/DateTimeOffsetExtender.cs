using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonNet
{
    public static class DateTimeOffsetExtender
    {

        public static DateTimeOffset ToNewTimeZone(this DateTimeOffset value, TimeZoneInfo tzObject)
        {
            value = value.UtcDateTime;
            DateTimeOffset ret = value.ToOffset(tzObject.GetUtcOffset(value));
            return ret;
        }
        public static DateTimeOffset ToNewTimeZone(this DateTimeOffset value, string timeZone)
        {
            value = value.UtcDateTime;
            TimeZoneInfo tzObject = TimeZoneInfo.FindSystemTimeZoneById(timeZone);
            DateTimeOffset ret = value.ToOffset(tzObject.GetUtcOffset(value));
            return ret;
        }

        public static DateTimeOffset ToTimeZone(this DateTime value, TimeZoneInfo tzObject)
        {
            DateTimeOffset ret = new DateTimeOffset(value, tzObject.GetUtcOffset(value));
            return ret;
        }
        public static DateTimeOffset ToTimeZone(this DateTime value, string timeZone)
        {
            TimeZoneInfo tzObject = TimeZoneInfo.FindSystemTimeZoneById(timeZone);
            DateTimeOffset ret = new DateTimeOffset(value, tzObject.GetUtcOffset(value));
            return ret;
        }

    }
}
