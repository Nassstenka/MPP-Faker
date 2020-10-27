using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{
    public interface IDTOGenerator
    {
        public object Generate(); 
        public Random random { get; }
        public Type generatedType { get; }
    }
}
