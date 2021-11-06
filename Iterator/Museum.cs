using System.Collections.Generic;
using System.Collections;

namespace PatternsOnCSharp
{
    class Museum : IterableCollection
    {
        List<Hall> halls;

        public Museum(List<Hall> halls)
        {
            this.halls = new List<Hall>(halls);
        }

        public Iterator GetEnumerator()
        {
            return new IteratorHall(halls);
        }
    }
}
