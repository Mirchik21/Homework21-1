using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TV : ISwitchable
    {
        protected string name;
        protected bool available = false;
        string[] channelNames;
        protected string orderQuestion;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public TV(string[] channelNames, string orderQuestion)
        {
            this.channelNames = channelNames;
            this.orderQuestion = orderQuestion;
        }
        protected bool CheckAvailable()
        {
            return Array.Exists(channelNames, E => E == name);
        }

        public virtual void SwitchTurnOn()
        {
            while (!available)
            {
                Console.WriteLine(orderQuestion);
                name = Console.ReadLine();
                if (CheckAvailable())
                {
                    available = true;
                }

                if (available)
                {
                    Console.WriteLine("Ok, accepted.");
                }
                else
                {
                    Console.WriteLine("Sorry, choose something else");
                }
            }
        }
        public virtual void SwitchTurnOff()
        {
            Console.WriteLine("Thank you for choosing us, see you there!");
        }

        public override string ToString()
        {
            return name;
        }

        public static void PrintChannels(ISwitchable[] channels)
        {
            
            Console.WriteLine("You have selected a channel: ");
            int counter = 1;
            foreach (ISwitchable channel in channels)
            {
                Console.WriteLine($"{counter}) - {channel.ToString()}");
                counter++;
            }
        }
    }
}
