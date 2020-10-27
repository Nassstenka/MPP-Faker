using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{
    class LongGenerator : IDTOGenerator
    {
        public Type generatedType { get; private set; }
        public Random random { get; private set; }
        public LongGenerator(Random rand)
        {
            random = rand;
            generatedType = typeof(long);
        }
        public object Generate()
        {
            byte[] buf = new byte[8];
            random.NextBytes(buf);
            return BitConverter.ToInt64(buf, 0);
        }
    }
}
