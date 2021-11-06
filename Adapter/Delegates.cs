using System;

namespace PatternsOnCSharp
{
        class AudioTell : Tell
        {
            public void BeginTell()
            {
                Console.WriteLine("Аудиогид включён!");
            }
        }

        class TextTell : Tell
        {
            public void BeginTell()
            {
                Console.WriteLine("Текстовый гид включён!");
            }
        }

        class WithoutTell : Tell
        {
            public void BeginTell()
            {
                Console.WriteLine("У вас нет гида!");
            }
        }
}
