using System;

namespace PatternsOnCSharp
{
    class BeginTellingVisitor : Visitor
    {
        public void VisitAudioTell(AudioTell a)
        {
            Console.WriteLine("Аудиогид включён!");
        }

        public void VisitTextTell(TextTell t)
        {
            Console.WriteLine("Текстовый гид включён!");
        }

        public void VisitVideoTell(Video v)
        {
            v.PlayVideo();
        }

        public void VisitWithoutTell(WithoutTell w)
        {
            Console.WriteLine("У вас нет гида!");
        }
    }
}
