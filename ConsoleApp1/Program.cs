namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TV provaider = new TV(new string[] { "ALA-TV", "O-TV", "MegaLine-TV" }, "Dear subscriber, please choose a TV provider, which one do you prefer? \n ALA-TV, O-TV, MegaLine-TV");
            TV channel = new TV(new string[] { "Sport", "KTRK", "Mir", "Music", "History" }, "Choose the channel you want to watch \n Sport, KTRK, Mir, Music, History");
            ISwitchable[] channels = { provaider, channel };
            foreach (TV tv in channels)
            {
                tv.SwitchTurnOn();
            }
            TV.PrintChannels(channels);

            Console.WriteLine("If you want to turn off then press OFF");
            string off = Console.ReadLine();
            if (off == "OFF")
            {
                channel.SwitchTurnOff();
            }
            else
            {
                Console.WriteLine("press OFF");
                off = Console.ReadLine();
                channel.SwitchTurnOff();
            }

            Microwave microvolnovka = new Microwave();
            microvolnovka.SwitchTurnOn();
            microvolnovka.SwitchTurnOff();
        }
    }

    class Microwave: ISwitchable
    {
       public void SwitchTurnOn()
       {
        Console.WriteLine("microwave is onn");
       }

        public void SwitchTurnOff()
        {
            Console.WriteLine("microwave is off");
        }
    }

}
