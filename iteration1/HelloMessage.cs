using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteration1.Message
{
    class Message
    {
        private string m_HelloMessage;
        private DateTime dateNow = DateTime.Now;
        public string HelloMessage
        {
            get { return m_HelloMessage; }
            set { m_HelloMessage = value; }
        }

        public Message()
        {
            //dateNow = new DateTime(2021, 02, 6, 22, 35, 0);
            var day = this.dateNow.DayOfWeek;
            var hour = this.dateNow.Hour;
           
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

        public Message(DateTime date)
        {
            var day = date.DayOfWeek;
            var hour = date.Hour;

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

        public Message(int first, int second, int third)
        {
            var day = this.dateNow.DayOfWeek;
            var hour = this.dateNow.Hour;

            if (day != DayOfWeek.Sunday && day != DayOfWeek.Saturday)
            {
                if (hour > first && hour < second)
                {
                    this.HelloMessage = "Bonjour ";
                }
                else if (hour >= second && hour < third)
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
