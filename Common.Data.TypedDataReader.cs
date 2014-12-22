using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Data
{
    /// <summary>
    /// Extensions for the SQL data reader for casting and nulls
    /// </summary>
    public static class SQLDataReaderHelper
    {
        #region Get Guid
        public static Guid? GetGuidOrNull(this DbDataReader sdr, int index){
            return sdr.IsDBNull(index) ? (Guid?)null : sdr.GetGuid(index);
        }

        public static Guid? GetGuidOrNull(this DbDataReader sdr, string index)
        {
            return sdr.GetGuidOrNull(sdr.GetOrdinal(index));
        }

        public static Guid GetGuid(this DbDataReader sdr, string index)
        {
            return sdr.GetGuid(sdr.GetOrdinal(index));
        }
        #endregion

        #region Get DateTime
        public static DateTime? GetDateTimeOrNull(this DbDataReader sdr, int index)
        {
            return sdr.IsDBNull(index) ? (DateTime?)null : sdr.GetDateTime(index);
        }

        public static DateTime? GetDateTimeOrNull(this DbDataReader sdr, string index)
        {
            return sdr.GetDateTimeOrNull(sdr.GetOrdinal(index));
        }

        public static DateTime GetDateTime(this DbDataReader sdr, string index)
        {
            return sdr.GetDateTime(sdr.GetOrdinal(index));
        }

        #endregion

        #region Get DateTimeOffset
        public static DateTimeOffset? GetDateTimeOffsetOrNull(this DbDataReader sdr, int index)
        {
            return sdr.IsDBNull(index) ? (DateTimeOffset?)null : sdr.GetFieldValue<DateTimeOffset>(index);
        }

        public static DateTimeOffset? GetDateTimeOffsetOrNull(this DbDataReader sdr, string index)
        {
            return sdr.GetDateTimeOffsetOrNull(sdr.GetOrdinal(index));
        }

        public static DateTimeOffset GetDateTimeOffset(this DbDataReader sdr, string index)
        {
            return sdr.GetFieldValue<DateTimeOffset>(sdr.GetOrdinal(index));
        }
        public static DateTimeOffset GetDateTimeOffset(this DbDataReader sdr, int index)
        {
            return sdr.GetFieldValue<DateTimeOffset>(index);
        }

        #endregion

        #region Get String
        public static String GetStringOrNull(this DbDataReader sdr, int index)
        {
            return sdr.IsDBNull(index) ? (string)null : sdr.GetString(index);
        }

        public static String GetStringOrNull(this DbDataReader sdr, int index, string defaultValue)
        {
            return sdr.IsDBNull(index) ? defaultValue : sdr.GetString(index);
        }

        public static String GetStringOrNull(this DbDataReader sdr, string index)
        {
            return sdr.GetStringOrNull(sdr.GetOrdinal(index));
        }

        public static String GetStringOrNull(this DbDataReader sdr, string index, string defaultValue)
        {
            return sdr.GetStringOrNull(sdr.GetOrdinal(index), defaultValue);
        }

        public static String GetString(this DbDataReader sdr, string index)
        {
            try { 
                return sdr.GetString(sdr.GetOrdinal(index));
            }
            catch (Exception e) { 
                throw new Exception(string.Format("Field {0} is having a problem", index), e);
            }
        }

        #endregion

        #region Get Int32
        public static Int32? GetInt32OrNull(this DbDataReader sdr, int index)
        {
            return sdr.IsDBNull(index) ? (Int32?)null : sdr.GetInt32(index);
        }

        public static Int32? GetInt32OrNull(this DbDataReader sdr, string index)
        {
            return sdr.GetInt32OrNull(sdr.GetOrdinal(index));
        }

        public static Int32 GetInt32(this DbDataReader sdr, string index)
        {
            return sdr.GetInt32(sdr.GetOrdinal(index));
        }

        #endregion

        #region Get Bool
        public static bool? GetBoolOrNull(this DbDataReader sdr, int index)
        {
            return sdr.IsDBNull(index) ? (bool?)null : sdr.GetBoolean(index);
        }

        public static bool? GetBoolOrNull(this DbDataReader sdr, string index)
        {
            return sdr.GetBoolOrNull(sdr.GetOrdinal(index));
        }

        public static bool GetBool(this DbDataReader sdr, string index)
        {
            return sdr.GetBoolean(sdr.GetOrdinal(index));
        }

        #endregion

    }
}
