using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraformingMars.Actions;

namespace TerraformingMars
{
    class ActionManager
    {
        public static List<Action> GetFullActionSet() {

            List<Action> set = new List<Action>();

            set.Add(new AsteroidImpact());
            set.Add(new BuildPowerPlant());
            set.Add(new ConvertHeatToTemperature());
            set.Add(new ConvertPlantToGreenery());
            set.Add(new PlaceGreenery());
            set.Add(new PlaceOcean());
            set.Add(new PassTurn());

            return set;
        }

        public static List<Action> GetAffordableActionSet()
        {
            List<Action> set = GetFullActionSet();
            List<Action> affordableSet = new List<Action>();

            foreach (Action action in set) {
                if (action.IsAffordable()) {
                    affordableSet.Add(action);
                }        
            }

            /*
            if (affordableSet.Count == 0) {
                affordableSet.Add(new PassTurn());
            }
            */
            return affordableSet;
        }
    }
}
