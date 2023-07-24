using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static cSharp_LambaExpressions.Program;

namespace cSharp_LambaExpressions
{
    internal class SomeClass
    {
        public SomeClass(MathOperation mathOperation) 
        {
            int result = mathOperation(5, 2);
        }
    }
}
