using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraformingMars.Actions
{
    class PlaceGreenery : Action
    {
        int cost = 23;

        public override void DoThisAction()
        {
            if (IsAffordable())
            {
                Global.Resources.Money -= cost;
                Global.GameState.IncreaseOxygen();
                Global.Map.PlaceGreenery();
                Print();
            }
        }

        public override bool IsAffordable()
        {
            if (Global.GameState.HasMaxOxygen())
            {
                return false;
            }
            return Global.Resources.Money >= cost;
        }

        public override void Print()
        {
            Global.Log.AddEntry(Global.Resources.GetResourceStatus() + "|" + "Place greenery");
        }
    }
}
