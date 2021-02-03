using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using iteration1.HelloMessage;

namespace iteration1Test
{
    [TestClass]
    public class MessageTest
    {

        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]
            public void Message_Normal()
            {

                CustomDateTest custom = new CustomDateTest();
                CustomUserTest customUser = new CustomUserTest();
                Message msg = new Message(custom, customUser);
                string test = msg.GetHelloMessage();
                int hour = DateTime.Now.Hour;

                if (hour >= 9 && hour < 13)
                {
                    Assert.IsTrue((test).Contains("Bonjour"));
                }
                else if (hour >= 13 && hour < 18)
                {
                    Assert.IsTrue((test).Contains("Bon après-midi"));
                }
                else
                {
                    Assert.IsTrue((test).Contains("Bonsoir"));
                }
            }

        [TestMethod]
        public void Message_Matin()
        {
            CustomDateTest custom = new CustomDateTest(new DateTime(2021, 02, 2, 9, 35, 0));
            CustomUserTest customUser = new CustomUserTest();
            Message msg = new Message(custom, customUser);
            string test = msg.GetHelloMessage();

            TestContext.WriteLine(test);
            Assert.IsTrue((test).Contains("Bonjour"));
        }

        [TestMethod]
        public void Message_Aprem()
        {
            CustomDateTest custom = new CustomDateTest(new DateTime(2021, 02, 2, 13, 35, 0));
            CustomUserTest customUser = new CustomUserTest();
            Message msg = new Message(custom, customUser);
            string test = msg.GetHelloMessage();

            Assert.IsTrue((test).Contains("Bon après-midi"));
        }

        [TestMethod]
        public void Message_Soir()
        {
            CustomDateTest custom = new CustomDateTest(new DateTime(2021, 02, 2, 18, 35, 0));
            CustomUserTest customUser = new CustomUserTest();
            Message msg = new Message(custom, customUser);
            string test = msg.GetHelloMessage();

            Assert.IsTrue((test).Contains("Bonsoir"));
        }

        [TestMethod]
        public void Message_User()
        {
            CustomDateTest custom = new CustomDateTest(new DateTime(2021, 02, 2, 18, 35, 0));
            CustomUserTest customUser = new CustomUserTest();
            Message msg = new Message(custom, customUser);
            string test = msg.GetHelloMessage();

            Assert.IsTrue((test).Contains("Johnny"));
        }
    }
    }
