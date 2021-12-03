using System;

namespace PatternsOnCSharp
{
    class Customer : HallListeners
    {
        public string Name
        {
            get;
            set;
        }

        public void UpdateState(int id, State hallState)
        {
            Console.WriteLine($"\tПосетитель уведомлён об изменении состояния зала № {id} : {hallState.GetType().Name}");
        }

        public void UpdateShowPiece(int id)
        {
            Console.WriteLine($"\tПосетитель уведомлён о добавлении нового экспоната в зале № {id}!");
        }
    }
}
