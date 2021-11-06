using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsOnCSharp
{
    class Director
    {

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
