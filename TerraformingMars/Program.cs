using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraformingMars
{
    class Program
    {
        static void Main(string[] args)
        {
            Global.Log = new LogManager();

            Game game = new Game();

            int counter = 10000000; // Int32.MaxValue;  30000000;

            for (int i= 0; i < counter; i++) {
                game.Run();
                Global.Log.SaveIfBetterElseReset();
                
                if (i % 10000 == 0) {
                    Console.WriteLine(i + " " + Global.Log.BestScore);

                }
                game.Reset();

            }
            /*
            game.Reset();
            game.Run();
            game.Reset();
            game.Run();
            game.Reset();
            game.Run();
            game.Reset();
            game.Run();
            game.Reset();
            */



            Global.Log.WriteLogToConsole();
            
            Console.ReadKey();

        }
    }
}
