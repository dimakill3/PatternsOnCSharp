using System;

namespace PatternsOnCSharp
{
    class ShowPiece : IShowPiece
    {
        public void Show()
        {
            Console.Write("отображён экспонат!\n");
        }
    }
}
