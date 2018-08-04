using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraformingMars.Actions
{
    class PlaceOcean : Action
    {
        int cost = 18;

        public override void DoThisAction()
        {
            if (IsAffordable())
            {
                Global.Resources.Money -= cost;
                Global.GameState.IncreaseOcean();
                Print();
            }
        }

        public override bool IsAffordable()
        {
            if (Global.GameState.HasPlaceableMaxOceans()) {
                return false;
            }

            return Global.Resources.Money >= cost;
        }


        public override void Print()
        {
            Global.Log.AddEntry(Global.Resources.GetResourceStatus() + "|" + "Place ocean");
        }
    }
}
