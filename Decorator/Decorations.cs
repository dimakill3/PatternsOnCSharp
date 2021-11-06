using System;

namespace PatternsOnCSharp
{
    class ArtistLink : ShowPieceDecorator
    {
        public ArtistLink(IShowPiece showPiece) : base(showPiece)
        { }

        override public void Show()
        {
            Console.Write("выведена ссылка на художника, ");
            wrappe.Show();
        }
    }

    class ShowPieceLink : ShowPieceDecorator
    {
        public ShowPieceLink(IShowPiece showPiece) : base(showPiece)
        { }

        override public void Show()
        {
            Console.Write("выведена ссылка на экспонат, ");
            wrappe.Show();
        }
    }

    class ShowPieceMark : ShowPieceDecorator
    {
        public ShowPieceMark(IShowPiece showPiece) : base(showPiece)
        { }

        override public void Show()
        {
            Console.Write("выведена подпись, ");
            wrappe.Show();
        }
    }
}
