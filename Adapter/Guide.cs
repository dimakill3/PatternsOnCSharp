using System;

namespace PatternsOnCSharp
{
    class Guide
    {
        private Tell tellType;

        public Guide(Tell tellType)
        {
            SetTellType(tellType);
        }

        public Guide()
        {
            Console.WriteLine("Default mode guide selected (without guide)");
            tellType = new WithoutTell();
        }

        public void BeginTellDescription()
        {
            tellType.Accept(new BeginTellingVisitor());
        }

        public void StopTellDescription()
        {
            tellType.Accept(new StopTellingVisitor());
        }

        public void SetTellType(Tell tellType)
        {
            this.tellType = tellType;
            Console.WriteLine($"Гид сменился на {tellType.GetType().Name}");
        }
    }
}
