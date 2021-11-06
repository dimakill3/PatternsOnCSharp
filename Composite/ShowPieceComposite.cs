using System;
using System.Collections.Generic;
using System.Linq;

namespace PatternsOnCSharp
{
    class ShowPieceComposite
    {
        private List<IShowPiece> showPieces;

        public ShowPieceComposite()
        {
            showPieces = new List<IShowPiece>();
        }

        public void Add(IShowPiece showPiece)
        {
            showPieces.Add(showPiece);
            Console.WriteLine("Элемент добавлен");
        }

        public void Remove(int idx)
        {
            if (idx < showPieces.Count())
            {
                showPieces.RemoveAt(idx);
                Console.WriteLine($"Элемент на позиции {idx} удалён");
            }
                
        }

        public void Show()
        {
            Console.WriteLine("Композиция экспонатов: ");
            foreach (IShowPiece sp in showPieces)
            {
                sp.Show();
            }
        }
    }
}
