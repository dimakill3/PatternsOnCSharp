using System.Collections.Generic;
using System;


namespace PatternsOnCSharp
{
    class Program
    {
        static public void DemoAdapter()
        {
            Console.WriteLine("Демонстрация Адаптера");
            VideoAdapter adapter = new VideoAdapter(new Video());
            adapter.BeginTell();

            Guide g = new Guide();

            g.SetTellType(adapter);
            g.TellDescription();
        }

        static public void DemoIterator()
        {
            Console.WriteLine("Демонстрация Итератора");
            var hall1 = new Hall(1);
            var hall2 = new Hall(2);
            var hall3 = new Hall(3);

            var museum = new Museum(new List<Hall>() { hall1, hall2, hall3 });

            Iterator hallIter = museum.GetEnumerator();

            hallIter.MoveNext();
            Hall hall = (Hall)hallIter.Current();

            Console.WriteLine($"Идентификатор зала: {hall.GetId()}");
        }

        static public void DemoComposite()
        {
            Console.WriteLine("\nДемонстрация Композита + Декоратора");
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

        static public void DemoDecorator()
        {
            Console.WriteLine("\nДемонстрация Декоратора");
            ShowPiece sp1 = new ShowPiece();
            sp1.Show();

            ArtistLink sp2 = new ArtistLink(sp1);
            sp2.Show();

            ShowPieceLink sp3 = new ShowPieceLink(sp2);
            sp3.Show();
        }

        static void Main()
        {
            DemoAdapter();
            DemoDecorator();
            DemoComposite();
            DemoIterator();
        }
    }
}
