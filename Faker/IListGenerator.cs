using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{
    interface IListGenerator
    {
        public object Generate(Type type);
        public Random random { get; }
        public Type generatedType { get; }
        public Faker faker { get; }
    }
}
