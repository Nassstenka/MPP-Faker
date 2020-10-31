using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{
    class CharGenerator : IDTOGenerator
    {
        public Type generatedType { get; private set; }
        public Random random { get; private set; }
        public CharGenerator(Random rand)
        {
            random = rand;
            generatedType = typeof(char);
        }
        public object Generate()
        {
            const string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
            return symbols[random.Next(symbols.Length)];
        }
    }
}
