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
}