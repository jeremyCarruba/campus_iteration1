using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iteration1.HelloMessage;

namespace iteration1
{
    class Program
    {
        public static void Main()
        {

            //dateNow = new DateTime(2021, 02, 6, 22, 35, 0);

            Message msg = new Message();
            msg.GetHelloMessage();
            while (true)
            {
                Console.WriteLine("coucou écris exit ou tapes sur entrée tsé");
                string userInput = Console.ReadLine();
                if (userInput == "exit")
                {
                    break;
                } else if (userInput == "" || Console.ReadKey().Key == ConsoleKey.Enter){
                    Console.WriteLine(msg.HelloMessage);
                }
                
            }
        }
    }
}
