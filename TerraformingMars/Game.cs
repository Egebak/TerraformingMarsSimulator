using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraformingMars.Actions;

namespace TerraformingMars
{
    class Game
    {
        Random rnd = new Random();

        public Game() {
            Setup();
        }

        public void Setup() {
            Global.Resources = new PlayerResources();
            Global.GameState = new GameState();
            Global.Map = new GameMap();
            //Global.Log.SetGame(this);
        }

        public void Reset() {
            Setup();
        }

        public void Run() {
            while (!Global.GameState.IsFinalTurn())
            {

                List<Action> set = ActionManager.GetAffordableActionSet();

                while (set.Count > 0)
                {
                    int max = set.Count();
                    int choice = rnd.Next(0, max);
                    Action action = set.ElementAt(choice);
                    if (action is PassTurn) {
                        continue;      
                    }
                    action.DoThisAction();
                    set = ActionManager.GetAffordableActionSet();
                }

                Global.GameState.UpdateTurn();
                Global.Log.AddEntry(Global.Resources.GetResourceStatus());
            }

            Global.Log.AddEntry(""+Global.GameState.GetScore());

        }
    }
}
