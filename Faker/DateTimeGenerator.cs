using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{
    class DateTimeGenerator
    {
        public Type generatedType { get; private set; }
        public Random random { get; private set; }
        public DateTimeGenerator(Random rand)
        {
            random = rand;
            generatedType = typeof(DateTime);
        }
        public object Generate()
        {
            int[] thirtyDayMonths = { 4, 6, 9, 11 };
            int month = random.Next(1, 12);
            int days;
            if (month == 2)
            {
                days = random.Next(1, 28);
            }
            else if (Array.IndexOf(thirtyDayMonths, month) == -1)
            {
                days = random.Next(1, 31);
            }
            else 
            {
                days = random.Next(1, 30);
            }
            DateTime dateTime = new DateTime(random.Next(1900, 2000), month, days, random.Next(0, 23), random.Next(0, 59), random.Next(0, 59));
            return dateTime;
        }
    }
}
