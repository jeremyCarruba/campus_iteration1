using iteration1.customDate;
using iteration1.iCustomDate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteration1.HelloMessage
{
    public class Message
    {
        private string m_HelloMessage;
        
        public ICustomDate CustomDate { get; set; }
        public ICustomUser CustomUser { get; set; }
        private int m_first;
        private int m_second;
        private int m_third;
        public string HelloMessage
        {
            get { return m_HelloMessage; }
            set { m_HelloMessage = value; }
        }
        public int First { get => m_first; set => m_first = value; }
        public int Second { get => m_second; set => m_second = value; }
        public int Third { get => m_third; set => m_third = value; }
        

        public string GetHelloMessage()
        {
            var day = this.CustomDate.Now.DayOfWeek;
            var hour = this.CustomDate.Now.Hour;

            if (day != DayOfWeek.Sunday && day != DayOfWeek.Saturday)
            {
                if (hour >= this.First && hour < this.Second)
                {
                    this.HelloMessage = "Bonjour " + this.CustomUser.User;
                }
                else if (hour >= this.Second && hour < this.Third)
                {
                    this.HelloMessage = "Bon après-midi " + this.CustomUser.User;
                }
                else
                {
                    this.HelloMessage = "Bonsoir " + this.CustomUser.User;
                }
            }
            else
            {
                this.HelloMessage = "Bon week-end ";
            }
            return this.HelloMessage;
        }

        public Message()
            :this(new CustomDate(), new CustomUser())
        {
        }

        public Message(ICustomDate date, ICustomUser user)
        {
            this.CustomDate = date;
            this.CustomUser = user;
            this.First = 9;
            this.Second = 13;
            this.Third = 18;
        }

        public Message(int first, int second, int third)
        {
            this.CustomDate.Now = DateTime.Now;
            this.First = first;
            this.Second = second;
            this.Third = third;
        }

    }
}
