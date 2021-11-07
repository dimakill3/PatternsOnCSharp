using System.Collections.Generic;
using System;

namespace PatternsOnCSharp
{
    class Museum : IterableCollection
    {
        public List<Lazy<Hall>> halls
        {
            get;
            set;
        }

        static Museum instance;

        private Museum(List<Lazy<Hall>> halls)
        {
            this.halls = new List<Lazy<Hall>>(halls);
        }

        public Iterator GetEnumerator()
        {
            List<Hall> lh = new List<Hall>();
            foreach (var h in this.halls)
                lh.Add(h.Value);

            return new IteratorHall(lh);
        }

        public void AddHall(Lazy<Hall> hall)
        {
            halls.Add(hall);
        }

        public static Museum Instance
        {
            get
            {
                if (instance == null)
                    instance = new Museum(new List<Lazy<Hall>>());

                return instance;
            }
        }
    }
}
