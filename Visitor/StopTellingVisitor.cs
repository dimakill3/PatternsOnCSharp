using System;

namespace PatternsOnCSharp
{
    class StopTellingVisitor : Visitor
    {
        public void VisitAudioTell(AudioTell a)
        {
            Console.WriteLine("Аудиогид выключен!");
        }

        public void VisitTextTell(TextTell t)
        {
            Console.WriteLine("Текстовый гид выключен!");
        }

        public void VisitVideoTell(Video v)
        {
            v.StopVideo();
        }

        public void VisitWithoutTell(WithoutTell w)
        {
            Console.WriteLine("У вас нет гида!");
        }
    }
}
