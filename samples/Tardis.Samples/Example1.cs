using System;

namespace Tardis.Samples
{
    public class Example1
    {
        public Example1()
            : this(string.Empty)
        {
        }

        public Example1(string title)
        {
#if DEBUG
            this.DateTime = DateTimeProvider.Default;
            this.Initialize(title);
        }

        internal IDateTimeProvider DateTime { get; set; }

        internal Example1(string title, IDateTimeProvider provider)
        {
            this.DateTime = provider;
#endif
            this.Initialize(title);
        }

        private void Initialize(string title)
        {
            this.Title = title;
            this.CreatedAt = DateTime.UtcNow;
        }

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

        public DateTime CreatedAt { get; private set; }

        public DateTime UpdatedAt { get; private set; }
    }
}
