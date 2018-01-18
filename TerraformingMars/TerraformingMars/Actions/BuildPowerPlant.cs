using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraformingMars.Actions
{
    class BuildPowerPlant : Action
    {
        int cost = 11; //11 is default

        public override void DoThisAction()
        {
            if (IsAffordable())
            {
                Global.Resources.Money -= cost;
                Global.Resources.PowerProduction += 1;
                Print();
            }
        }

        public override bool IsAffordable()
        {
            return Global.Resources.Money >= cost;
        }


        public override void Print()
        {
            Global.Log.AddEntry(Global.Resources.GetResourceStatus() + "|" + "Build Powerplant");
        }
    }
}
