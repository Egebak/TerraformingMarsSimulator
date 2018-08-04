using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraformingMars.Actions
{
    class ConvertPlantToGreenery : Action
    {
        private const int required = 7; //8 is the default value, Ecoline has a value of 7

        public override void DoThisAction()
        {
            if (IsAffordable())
            {
                Global.Resources.Plants -= required;
                Global.GameState.IncreaseOxygen();
                Global.Map.PlaceGreenery();
                Print();
            }
        }

        public override bool IsAffordable()
        {
            return Global.Resources.Plants >= required;
        }


        public override void Print()
        {
            Global.Log.AddEntry(Global.Resources.GetResourceStatus() + "|" + "Convert plants to greenery");
        }
    }
}
