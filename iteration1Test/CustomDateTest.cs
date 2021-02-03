using iteration1.iCustomDate;       
using System;

namespace iteration1Test
{
    public class CustomDateTest : ICustomDate
    {
        public DateTime Now { get; set; }

        public DateTime DataToReturn { get; set; }

        public DateTime GetDate()
        {
            return this.Now;
        }

        public CustomDateTest()
        {
            this.Now = DateTime.Now;
        }
        public CustomDateTest(DateTime date)
        {
            this.Now = date;
        }

    }
}
