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
            var hall1 = new Lazy<Hall>();
            var hall2 = new Lazy<Hall>();
            var hall3 = new Lazy<Hall>();
            hall1.Value.Id = 1;
            hall2.Value.Id = 2;
            hall3.Value.Id = 3;

            var museum = Museum.Instance;
            museum.halls = new List<Lazy<Hall>>() { hall1, hall2, hall3 };

            Iterator hallIter = museum.GetEnumerator();

            hallIter.MoveNext();
            Hall hall = (Hall)hallIter.Current();

            Console.WriteLine($"Hall id: {hall.Id}");
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

        static public void DemoSingletone()
        {
            Console.WriteLine("\nDemo singletone:\n");

            Museum m1 = Museum.Instance;
            Museum m2 = Museum.Instance;

            if (m1 == m2)
                Console.WriteLine("Both variables contain the same instance");


        }

        static public void DemoPrototype()
        {
            Console.WriteLine("\nDemo prototype:\n");

            ShowPiece sh = new ShowPiece(10, new Timetable("tt"));
            ShowPiece sh1 = sh.ShallowCopy();

            sh1.timetable.Name = "tt1";


            Console.WriteLine($"ShallowCopy:\nsh: \t id: {sh.Id} \t timetable {sh.timetable.Name}, sh1: \t id: {sh1.Id} \t timetable {sh1.timetable.Name}\n");

            ShowPiece sh2 = sh.DeepCopy();


            sh2.timetable.Name = "tt2";

            Console.WriteLine($"DeepCopy:\nsh: \t id: {sh.Id} \t timetable {sh.timetable.Name}, sh1: \t id: {sh2.Id} \t timetable {sh2.timetable.Name}\n");
        }

        static public void DemoLazyInitializing()
        {
            Console.WriteLine("\nDemo lazy initializing:\n");

            var b = new HallBuilder();
            Museum m = Museum.Instance;
            m.AddHall(new Lazy<Hall>(() => b.ID(1)
                                            .ShowPieceLimit(1)
                                            .ShowPieces(new List<ShowPiece> { new ShowPiece(100) })
                                            .Theme("Classic")
                                            .Build()));

            Console.WriteLine($"Hall (not initialized):\n {m.halls[0]}\n");
            Console.WriteLine($"Hall (initialized):\n {m.halls[0].Value}\n");
        }

        static void Main()
        {
            DemoAdapter();
            DemoComposite();
            DemoIterator();
            DemoBuilder();
            DemoSingletone();
            DemoPrototype();
            DemoLazyInitializing();
        }
    }
}
