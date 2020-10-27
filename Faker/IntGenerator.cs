using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{
    class IntGenerator : IDTOGenerator
    {
        public Type generatedType { get; private set; }
        public Random random { get; private set; }
        public IntGenerator(Random rand)
        {
            random = rand;
            generatedType = typeof(int);
        }
        public object Generate()
        {
            return random.Next();
        }
       
    }
}
