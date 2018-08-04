using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraformingMars
{
    public class LogManager
    {
        List<String> logEntries ;
        List<String> logForBestGame;
        public int BestScore;
        Game game;

        public LogManager() {
            logEntries = new List<string>();
            logForBestGame = new List<string>();
            BestScore = 0;
        }


        public void SaveIfBetterElseReset() {
            //if game score is better than previously recorded, then update bestScore and update logForBestGame
            if (Global.GameState.GetScore() > BestScore)
            {
                logForBestGame = logEntries;
                logEntries = new List<string>();
                BestScore = Global.GameState.GetScore();
                IOManager.ExportToNewFile(@"C:\MyDocuments\TerraformingMarsBestResult.txt", logForBestGame);
            }
            else {
                logEntries = new List<string>();
            }
        }

        internal void SetGame(Game game)
        {
            this.game = game;
        }

        public void AddEntry(String entry) {
            logEntries.Add(entry);
        }

        public void WriteLogToConsole() {
            if (logForBestGame.Count == 0)
            {
                logForBestGame = logEntries;
            }

            foreach (string str in logForBestGame) {
                Console.WriteLine(str);
            }
        }
    }
}
