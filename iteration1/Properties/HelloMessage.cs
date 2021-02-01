using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteration1.Properties.Message
{
    class Message
    {
        private string m_HelloMessage;
        public string HelloMessage
        {
            get { return m_HelloMessage; }
            set { m_HelloMessage = value; }
        }

        public Message()
        {
            var dateNow = DateTime.Now;
            //dateNow = new DateTime(2021, 02, 6, 22, 35, 0);
            var day = dateNow.DayOfWeek;
            var hour = dateNow.Hour;
           

            if (day != DayOfWeek.Sunday && day != DayOfWeek.Saturday)
            {
                if (hour > 9 && hour < 13)
                {
                    this.HelloMessage = "Bonjour ";
                }
                else if (hour >= 13 && hour < 18)
                {
                    this.HelloMessage = "Bon après-midi ";
                }
                else
                {
                    this.HelloMessage = "Bonsoir ";
                }
            }
            else
            {
                this.HelloMessage = "Bon week-end ";
            }
        }

    }
}
