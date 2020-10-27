using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{
    class FloatGenerator : IDTOGenerator
    {
        public Type generatedType { get; private set; }
        public Random random { get; private set; }
        public FloatGenerator(Random rand)
        {
            random = rand;
            generatedType = typeof(float);
        }
        public object Generate()
        {
            return (float)random.NextDouble();
        }
    }
}
