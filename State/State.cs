namespace PatternsOnCSharp
{
    abstract class State
    {
        protected Hall hall;

        public void SetContext(Hall hall)
        {
            this.hall = hall;
        }

        public abstract void Close();
        public abstract void Open();
        public abstract void AddShowPiece(ShowPiece sp);
    }
}
