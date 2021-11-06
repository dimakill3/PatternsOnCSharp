namespace PatternsOnCSharp
{
    interface Iterator
    {

        public bool MoveNext();
        public object Current();
        public void Reset();
    }
}
