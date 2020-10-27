using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{
    class BoolGenerator : IDTOGenerator
    {
        public Type generatedType { get; private set; }
        public Random random { get; private set; }
        public BoolGenerator(Random rand)
        {
            random = rand;
            generatedType = typeof(bool);
        }
        public object Generate()
        {
            return Convert.ToBoolean(random.Next());
        }
    }
}
