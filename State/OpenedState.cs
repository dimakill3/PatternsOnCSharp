using System;

namespace PatternsOnCSharp
{
    class OpenedState : State
    {
        public override void AddShowPiece(ShowPiece sp)
        {
            Console.WriteLine("Зал открыт, нельзя добавить картину!");
        }

        public override void Close()
        {
            hall.ChangeState(new ClosedState());
            Console.WriteLine("Зал был закрыт!");
        }

        public override void Open()
        {
            Console.WriteLine("Зал уже открыт!");
        }
    }
}
