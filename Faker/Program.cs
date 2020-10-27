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
            public int flex;
            public string name { get; set; }
            public double age;
            public A(double dage)
            {
                age = dage;
            }
        }
        public static void Main(string[] args)
        {
            Faker faker = new Faker();
            Console.WriteLine(faker.Create<string>());
            Console.ReadLine();
        }
    }
}
