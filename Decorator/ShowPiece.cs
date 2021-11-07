using System;

namespace PatternsOnCSharp
{
    class ShowPiece : IShowPiece
    {
       public int Id
        {
            get;
            set;
        }

        public Timetable timetable
        {
            get;
            set;
        }

        public ShowPiece() { }

        public ShowPiece(int id) { Id = id; }

        public ShowPiece(int id, Timetable tt) { Id = id; timetable = tt; }

        public void Show()
        {
            Console.Write("отображён экспонат!\n");
        }

        public ShowPiece ShallowCopy()
        {
            return (ShowPiece) this.MemberwiseClone();
        }

        public ShowPiece DeepCopy()
        {
            ShowPiece sh = (ShowPiece)this.MemberwiseClone();
            sh.timetable = new Timetable(this.timetable.Name);

            return sh;
        }
    }
}
