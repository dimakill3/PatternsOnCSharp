namespace PatternsOnCSharp
{
    class ShowPieceDecorator : IShowPiece
    {
        protected IShowPiece wrappe;

        public ShowPieceDecorator(IShowPiece showPiece)
        {
            wrappe = showPiece;
        }

        virtual public void Show()
        {
        }
    }
}
