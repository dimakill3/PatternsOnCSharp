using System.Collections.Generic;
using System;


namespace PatternsOnCSharp
{
    class Program
    {
        static public void DemoAdapter()
        {
            Console.WriteLine("\nDemo adapter:\n");
            VideoAdapter adapter = new VideoAdapter(new Video());
            adapter.BeginTell();

            Guide g = new Guide();

            g.SetTellType(adapter);
            g.TellDescription();
        }

        static public void DemoIterator()
        {
            Console.WriteLine("\nDemo iterator:\n");
            var hall1 = new Hall();
            var hall2 = new Hall();
            var hall3 = new Hall();

            var museum = new Museum(new List<Hall>() { hall1, hall2, hall3 });

            Iterator hallIter = museum.GetEnumerator();

            hallIter.MoveNext();
            Hall hall = (Hall)hallIter.Current();

            Console.WriteLine($"Идентификатор зала: {hall.Id}");
        }

        static public void DemoComposite()
        {
            Console.WriteLine("\nDemo composite + decorator:\n");
            ShowPieceComposite compose = new ShowPieceComposite();
            IShowPiece sp = new ShowPiece();
            IShowPiece sp1 = new ArtistLink(sp);

            compose.Add(sp);
            compose.Add(sp1);
            compose.Add(new ShowPieceLink(sp));
            compose.Add(new ShowPieceMark(sp));
            compose.Add(new ShowPieceLink(sp1));
            compose.Remove(2);
            compose.Show();
        }

        static public void DemoBuilder()
        {
            Console.WriteLine("\nDemo builder:\n");
            Director d = new Director();

            Hall defaultHall = d.MakeDefaultHall();
            Hall reqHall = d.MakeRequiredHall();

            var b = new HallBuilder();

            ShowPiece sp = new ShowPiece(100);

            Hall customHall = b
                              .ID(1)
                              .ShowPieceLimit(1)
                              .ShowPieces(new List<ShowPiece> { sp })
                              .Theme("Classic")
                              .Build();

            Console.WriteLine($"Default hall:\n {defaultHall}\n");
            Console.WriteLine($"Required hall:\n {reqHall}\n");
            Console.WriteLine($"Custom hall:\n {customHall}\n");
        }

        static void Main()
        {
            DemoAdapter();
            DemoComposite();
            DemoIterator();
            DemoBuilder();
        }
    }
}
