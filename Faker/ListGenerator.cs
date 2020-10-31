using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{
    class ListGenerator : IListGenerator
    {
        public Random random { get; private set; }
        public Type generatedType { get; private set; }
        public Faker faker { get; private set; }
        public ListGenerator(Random rand)
        {
            random = rand;
            generatedType = typeof(List<>);
            faker = new Faker();
        }
        public object Generate(Type type)
        {
            List<object> list = new List<object>();
            const int MinLength = 3;
            const int MaxLength = 10;
            int length = random.Next(MinLength, MaxLength);
            

            for (int i = 0; i < length; i++)
            {
                list.Add(faker.Create(type));
            }
            return list;
        }
    }
}
