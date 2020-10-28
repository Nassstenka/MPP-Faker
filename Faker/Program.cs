using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{
    class Program
    {
        class A
        {
            public B b;
        }
        class B
        {
            public A a;
        }
        public static void Main(string[] args)
        {
            Faker faker = new Faker();
            object result = faker.Create<A>();
            if (result != null)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("NULL.");
            }
            Console.ReadLine();
        }
    }
}
