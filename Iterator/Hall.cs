using System;
using System.Collections.Generic;

namespace PatternsOnCSharp
{
    class Hall
    {
        private HallManager manager = new HallManager();

        public int Id
        {
            get;
            set;
        }

        public int ShowPieceLimit
        {
            get;
            set;
        }

        public List<ShowPiece> ShowPieces
        {
            get;
        }

        public string Theme
        {
            get;
            set;
        }

        public State State
        {
            get;
            set;
        }

        public Hall()
        { 
            ShowPieces = new List<ShowPiece>();
            ChangeState(new ClosedState());
        }

        public void ChangeState(State state)
        {
            this.State = state;
            this.State.SetContext(this);
            Console.WriteLine($"Hall: State changed: {State.GetType().Name}");
            manager.StateNotify(Id, this.State);
        }

        public void AddShowPiece(ShowPiece sp)
        {
            State.AddShowPiece(sp);
            manager.NewShowPieceNotify(Id);
        }

        public void Subscribe(HallListeners listener)
        {
            manager.Subscribe(Id, listener);
        }

        public void Unsubscribe(HallListeners listener)
        {
            manager.Unsubscribe(Id, listener);
        }

        public override string ToString()
        {
            string retStrng = new string($"Id: {Id},\nShowPieceLimit: {ShowPieceLimit}," +
                $"\nTheme: {Theme},\nShowPieces Id: ");
            foreach (ShowPiece sp in ShowPieces)
                retStrng += sp.Id + ",";

            return retStrng;
        }

        public void SetHallManager(HallManager manager)
        {
            this.manager = manager;
        }
    }
}
