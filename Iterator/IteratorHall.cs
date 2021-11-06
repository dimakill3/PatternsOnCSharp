using System.Collections.Generic;


namespace PatternsOnCSharp
{
    class IteratorHall : Iterator
    {
        private List<Hall> collection;

        private int pos;

        public IteratorHall(List<Hall> collection)
        {
            this.collection = collection;
        }

        public object Current()
        {
            return collection[pos];
        }

        public bool MoveNext()
        {
            if (pos + 1 < collection.Count)
            {
                pos++;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            pos = 0;
        }
    }
}
