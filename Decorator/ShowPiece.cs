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

        public ShowPiece() { }

        public ShowPiece(int id) { Id = id; }

        public void Show()
        {
            Console.Write("отображён экспонат!\n");
        }
    }
}
