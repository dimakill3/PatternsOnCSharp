using System.Collections.Generic;

namespace PatternsOnCSharp
{
    class Hall
    {
        public int Id
        {
            get;
            set;
        }

        public int ShowPieceLimit
        {
            get;
            set;
        }

        public List<ShowPiece> ShowPieces
        {
            get;
        }

        public string Theme
        {
            get;
            set;
        }

        public Hall(){ ShowPieces = new List<ShowPiece>(); }

        public void AddShowPiece(ShowPiece sp)
        {
            if (ShowPieces.Count < ShowPieceLimit)
                ShowPieces.Add(sp);
        }

        public override string ToString()
        {
            string retStrng = new string($"Id: {Id},\nShowPieceLimit: {ShowPieceLimit}," +
                $"\nTheme: {Theme},\nShowPieces Id: ");
            foreach (ShowPiece sp in ShowPieces)
                retStrng += sp.Id + ",";

            return retStrng;
        }
    }
}
