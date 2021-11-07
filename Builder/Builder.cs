namespace PatternsOnCSharp
{
    interface Builder<T>
    {
        public void builder();
        public T Build();
    }
}
