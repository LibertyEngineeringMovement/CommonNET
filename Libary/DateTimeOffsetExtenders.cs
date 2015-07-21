using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class DateTimeOffsetExtenders
    {
        public static DateTimeOffset Now(this TimeZoneInfo value){
            //For some reason, if I just get UtcNow, I get something that starts off as a datetime, but it has an inherent bind to the UTC timezone.
            //So if I run the convert on it, then it bombs. And if I just change the timezone, everthing looks good until I hit EF, then it switches to the server's timezone.
            //So this creates a UTC date, but one that isn't bound to the UTC.
            //Finally, this recalculates the time to the proper time for the timezone passed in.
            DateTime utcdate = TimeZoneInfo.ConvertTimeFromUtc(new DateTime(DateTime.UtcNow.Ticks), value);
            //Once we have the correct timezone time, we use that with the new constructor to generate the final DateTimeOffset.
            //In no way is this elegent. I am still convinced that there is a simpler and better way, but I just have not found it.
            DateTimeOffset Ret = new DateTimeOffset(utcdate, value.GetUtcOffset(utcdate));
            return Ret;
        }

        public static DateTimeOffset NowFromTimeZoneName(this string value) { 
            TimeZoneInfo tzi = tzi = TimeZoneInfo.FindSystemTimeZoneById(value);
            return tzi.Now();
        }
    }
}
