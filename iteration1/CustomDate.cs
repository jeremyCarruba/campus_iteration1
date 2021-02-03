using iteration1.iCustomDate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteration1.customDate
{
    class CustomDate : ICustomDate
    {
        public DateTime Now { get; set; }
        public DateTime GetDate()
        {
            return this.Now;
        }

        public CustomDate()
        {
            this.Now = DateTime.Now;
        }
    }
}
