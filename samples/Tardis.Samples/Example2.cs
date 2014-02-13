using System;

namespace Tardis.Samples
{
    public class Example2
    {
#if DEBUG
        internal IDateTimeProvider DateTime { get; set; }

        internal Example2(IDateTimeProvider provider)
        {
            this.DateTime = provider;
        }
#endif

        private string title;

        public string Title
        {
            get { return this.title; }
            set
            {
                this.title = value;
                this.UpdatedAt = DateTime.UtcNow;
            }
        }

        public DateTime UpdatedAt { get; private set; }
    }
}