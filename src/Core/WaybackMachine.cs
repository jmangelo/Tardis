using System;

namespace Tardis
{
    public static class WaybackMachine
    {
        private static IDateTimeProvider dateTimeProvider = Tardis.DateTimeProvider.Default;

        public static IDateTimeProvider DateTimeProvider
        {
            get { return dateTimeProvider; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                dateTimeProvider = value;
            }
        }
    }
}
