using System.Collections.Generic;

namespace PatternsOnCSharp
{
    class Director
    {
        static Director instance;

        public static Director Instance
        {
            get
            {
                if (instance == null)
                    instance = new Director();
                return instance;
            }
        }

        public Hall MakeRequiredHall()
        {
            Hall hall = new HallBuilder()
                .ID(100)
                .ShowPieceLimit(3)
                .Theme("Required theme")
                .ShowPieces(new List<ShowPiece> { new ShowPiece(1), new ShowPiece(2), new ShowPiece(3) })
                .Build();

            return hall;
        }

        public Hall MakeDefaultHall()
        {
            Hall hall = new HallBuilder()
                .ID(0)
                .ShowPieceLimit(0)
                .Theme("Nothing")
                .ShowPieces(new List<ShowPiece> {})
                .Build();

            return hall;
        }
    }
}
