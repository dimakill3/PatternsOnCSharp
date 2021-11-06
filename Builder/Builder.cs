using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsOnCSharp
{
    interface Builder<T>
    {
        public void builder();
        public T Build();
    }
}
