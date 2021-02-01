using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteration1
{
    class Program
    {

        

        static void Main(string[] args)
        {
            var dateNow = DateTime.Now;
            dateNow = new DateTime(2021, 02, 6, 22, 35, 0);
            var day = dateNow.DayOfWeek;
            var hour = dateNow.Hour;
            String msg = null;

            if (day != DayOfWeek.Sunday && day != DayOfWeek.Saturday)
            {
                 if (hour > 9 && hour < 13){
                    msg = "Bonjour ";
                }
                else if (hour >= 13 && hour < 18) { 
                    msg = "Bon après-midi ";
                } else
                {
                    msg = "Bonsoir ";
                }
            } else
            {
                msg = "Bon week-end ";
            }

            Console.WriteLine("day: " + day + " hour: " + hour);
            Console.WriteLine(msg + Environment.UserName + " the king de la route");
        }
    }
}
