using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteration1
{
    public class CustomUser : ICustomUser
    {

        public string User { get; set;}

        public CustomUser()
        {
            this.User = Environment.UserName;
        }
    }
}
