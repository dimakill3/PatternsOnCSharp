using System;

namespace PatternsOnCSharp
{
    class ClosedState : State
    {
        public override void AddShowPiece(ShowPiece sp)
        {
            if (hall.ShowPieces.Count < hall.ShowPieceLimit)
                hall.ShowPieces.Add(sp);

            Console.WriteLine("Картина была добавлена!");
        }

        public override void Close()
        {
            Console.WriteLine("Зал уже закрыт!");
        }

        public override void Open()
        {
            hall.ChangeState(new OpenedState()); 
            Console.WriteLine("Зал был открыт!");
        }
    }
}
