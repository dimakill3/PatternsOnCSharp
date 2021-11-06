using System;

namespace PatternsOnCSharp
{
    class Guide
    {
        private Tell tellType;

        public Guide(Tell tellType)
        {
            this.tellType = tellType;
        }

        public Guide()
        {
            Console.WriteLine("Default mode guide selected (without guide)");
            tellType = new WithoutTell();
        }

        public void TellDescription()
        {
            tellType.BeginTell();
        }

        public void SetTellType(Tell tellType)
        {
            this.tellType = tellType;
        }
    }
}
