using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteration1.iCustomDate
{
    public interface ICustomDate
    {

       DateTime Now { get; set; }
        DateTime GetDate();
    }
}
