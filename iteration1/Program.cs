using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iteration1.Properties.Message;

namespace iteration1
{
    class Program
    {



        static void Main(string[] args)
        {

            Message msg = new Message();
            Console.WriteLine(msg.HelloMessage + Environment.UserName + " the king de la route");
        }
    }
}
