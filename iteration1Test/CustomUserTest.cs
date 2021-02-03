using iteration1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteration1Test
{
    class CustomUserTest : ICustomUser
    {

        public string User { get; set; }

        public CustomUserTest()
        {
            this.User = "Johnny";
        }
    }
}
