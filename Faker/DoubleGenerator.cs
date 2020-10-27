using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{
    class DoubleGenerator : IDTOGenerator
    {
        public Type generatedType { get; private set; }
        public Random random { get; private set; }
        public DoubleGenerator(Random rand)
        {
            random = rand;
            generatedType = typeof(double);
        }
        public object Generate()
        {
            return random.NextDouble();
        }
    }
}
