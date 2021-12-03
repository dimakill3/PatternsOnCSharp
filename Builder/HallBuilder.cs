using System.Collections.Generic;

namespace PatternsOnCSharp
{
    class HallBuilder : Builder<Hall>
    {
        private Hall hall;

        public HallBuilder()
        {
            this.builder();
        }

        public void builder()
        {
            this.hall = new Hall();
        }

        public HallBuilder ShowPieceLimit(int spLimit)
        {
            hall.ShowPieceLimit = spLimit;
            return this;
        }

        public HallBuilder ShowPieces(List<ShowPiece> showPieces)
        {
            foreach (ShowPiece sp in showPieces)
                hall.AddShowPiece(sp);
            return this;
        }

        public HallBuilder Theme(string theme)
        {
            hall.Theme = theme;
            return this;
        }

        public HallBuilder ID(int id)
        {
            hall.Id = id;
            return this;
        }

        public Hall Build()
        {
            Hall res = hall;

            return res;
        }
    }
}
