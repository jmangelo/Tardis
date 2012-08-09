using System;
using System.Globalization;

namespace Tardis
{
    public interface IDateTimeProvider
    {
        DateTime MinValue { get; }
        DateTime MaxValue { get; }
        DateTime Now { get; }
        DateTime UtcNow { get; }
        DateTime Today { get; }
        int Compare(DateTime t1, DateTime t2);
        int DaysInMonth(int year, int month);
        bool Equals(DateTime t1, DateTime t2);
        DateTime FromBinary(long dateData);
        DateTime FromFileTime(long fileTime);
        DateTime FromFileTimeUtc(long fileTime);
        DateTime FromOADate(double d);
        bool IsLeapYear(int year);
        DateTime Parse(string s);
        DateTime Parse(string s, IFormatProvider provider);
        DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles);
        DateTime ParseExact(string s, string format, IFormatProvider provider);
        DateTime ParseExact(
            string s, 
            string format, 
            IFormatProvider provider, 
            DateTimeStyles style);
        DateTime ParseExact(
            string s, 
            string[] formats, 
            IFormatProvider provider, 
            DateTimeStyles style);
        DateTime SpecifyKind(DateTime value, DateTimeKind kind);
        bool TryParse(string s, out DateTime result);
        bool TryParse(
            string s, 
            IFormatProvider provider, 
            DateTimeStyles styles, 
            out DateTime result);
        bool TryParseExact(
            string s, 
            string format, 
            IFormatProvider provider,
            DateTimeStyles style, 
            out DateTime result);
        bool TryParseExact(
            string s, 
            string[] formats, 
            IFormatProvider provider, 
            DateTimeStyles style, 
            out DateTime result);
    }

    public class DateTimeProvider : IDateTimeProvider
    {
        public static readonly DateTimeProvider Default = new DateTimeProvider();

        public virtual DateTime Now { get { return DateTime.Now; } }
        public virtual DateTime UtcNow { get { return DateTime.UtcNow; } }
        public virtual DateTime Today { get { return DateTime.Today; } }
        public virtual DateTime MinValue { get { return DateTime.MinValue; } }
        public virtual DateTime MaxValue { get { return DateTime.MaxValue; } }

        public virtual int Compare(DateTime t1, DateTime t2)
        {
            return DateTime.Compare(t1, t2);
        }
        public virtual int DaysInMonth(int year, int month)
        {
            return DateTime.DaysInMonth(year, month);
        }
        public virtual bool Equals(DateTime t1, DateTime t2)
        {
            return DateTime.Equals(t1, t2);
        }
        public virtual DateTime FromBinary(long dateData)
        {
            return DateTime.FromBinary(dateData);
        }
        public virtual DateTime FromFileTime(long fileTime)
        {
            return DateTime.FromFileTime(fileTime);
        }
        public virtual DateTime FromFileTimeUtc(long fileTime)
        {
            return DateTime.FromFileTimeUtc(fileTime);
        }
        public virtual DateTime FromOADate(double d)
        {
            return DateTime.FromOADate(d);
        }
        public virtual bool IsLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }
        public virtual DateTime Parse(string s)
        {
            return DateTime.Parse(s);
        }
        public virtual DateTime Parse(string s, IFormatProvider provider)
        {
            return DateTime.Parse(s, provider);
        }
        public virtual DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles)
        {
            return DateTime.Parse(s, provider, styles);
        }
        public virtual DateTime ParseExact(string s, string format, IFormatProvider provider)
        {
            return DateTime.ParseExact(s, format, provider);
        }
        public virtual DateTime ParseExact(
            string s, 
            string format, 
            IFormatProvider provider, 
            DateTimeStyles style)
        {
            return DateTime.ParseExact(s, format, provider, style);
        }
        public virtual DateTime ParseExact(
            string s, 
            string[] formats, 
            IFormatProvider provider, 
            DateTimeStyles style)
        {
            return DateTime.ParseExact(s, formats, provider, style);
        }
        public virtual DateTime SpecifyKind(DateTime value, DateTimeKind kind)
        {
            return DateTime.SpecifyKind(value, kind);
        }
        public virtual bool TryParse(string s, out DateTime result)
        {
            return DateTime.TryParse(s, out result);
        }
        public virtual bool TryParse(
            string s, 
            IFormatProvider provider, 
            DateTimeStyles styles, 
            out DateTime result)
        {
            return DateTime.TryParse(s, provider, styles, out result);
        }
        public virtual bool TryParseExact(
            string s, 
            string format, 
            IFormatProvider provider, 
            DateTimeStyles style, 
            out DateTime result)
        {
            return DateTime.TryParseExact(s, format, provider, style, out result);
        }
        public virtual bool TryParseExact(
            string s, 
            string[] formats, 
            IFormatProvider provider, 
            DateTimeStyles style, 
            out DateTime result)
        {
            return DateTime.TryParseExact(s, formats, provider, style, out result);
        }
    }
}
