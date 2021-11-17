using System;

namespace PatternsOnCSharp
{
    class AudioTell : Tell
    {
        public void Accept(Visitor v)
        {
            v.VisitAudioTell(this);
        }
    }

    class TextTell : Tell
    {
        public void Accept(Visitor v)
        {
            v.VisitTextTell(this);
        }
    }

    class WithoutTell : Tell
    {
        public void Accept(Visitor v)
        {
            v.VisitWithoutTell(this);
        }
    }
}
