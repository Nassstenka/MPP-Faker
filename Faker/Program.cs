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
            public int i;
            public string j;
            public bool c;
            public override string ToString()
            {
                return $"int i = {i}, string j = {j}, bool c = {c}";
            }
        }
        class B
        {
            public A a;
        }
        public static void Main(string[] args)
        {
            Faker faker = new Faker();
            A obj = faker.Create<A>();
            Console.WriteLine(obj);
            /*List<int> result = faker.Create<List<int>>();
            if (result != null)
            {
                foreach(int i in result)
                    Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine("NULL.");
            }*/
            Console.ReadLine();
        }
    }
}
