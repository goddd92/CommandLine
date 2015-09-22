using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "";
            CommandInterface command = new App();
            data = Console.ReadLine();
            string[] commands = data.Split(' ');
            int result = data.CompareTo("app start");
        }
    }


    interface CommandInterface
    {
        void execute();
    }

    class App: CommandInterface
    {
        public App ()
        {
            Start start = new Start();
            Stop stop = new Stop();
        }
        void CommandInterface.execute()
        {

        }
    }
    class Start: CommandInterface
    {
        void CommandInterface.execute()
        {
           Console.WriteLine("Hello Kitty");
        }
    }
    class Stop : CommandInterface
    {
        void CommandInterface.execute()
        {
            Environment.Exit(0);
        }
    }
}
