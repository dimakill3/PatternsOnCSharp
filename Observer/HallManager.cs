using System;
using System.Collections.Generic;


namespace PatternsOnCSharp
{
    class HallManager
    {
        private List<HallListeners> listeners = new List<HallListeners>();

        public void Subscribe(int id, HallListeners listener)
        {
            listeners.Add(listener);
            Console.WriteLine($"Hall № {id}: Подписка {listener.GetType().Name}.");
        }

        public void Unsubscribe(int id, HallListeners listener)
        {
            listeners.Remove(listener);
            Console.WriteLine($"Hall № {id}: Отписка {listener.GetType().Name}.");
        }

        public void StateNotify(int id, State hallState)
        {
            Console.WriteLine($"Hall № {id}: Уведомляем подписчиков об изменении состояния...");

            foreach (var listener in listeners)
            {
                listener.UpdateState(id, hallState);
            }
        }

        public void NewShowPieceNotify(int id)
        {
            Console.WriteLine($"Hall № {id}: Уведомляем подписчиков о добавлении нового произведения искусства...");

            foreach (var listener in listeners)
            {
                listener.UpdateShowPiece(id);
            }
        }
    }
}
