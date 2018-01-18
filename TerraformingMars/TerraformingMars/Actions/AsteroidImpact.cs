using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraformingMars.Actions
{
    class AsteroidImpact : Action
    {
        int cost = 14;        

        public override void DoThisAction()
        {
            if (IsAffordable())
            {
                Global.Resources.Money -= cost;
                Global.GameState.IncreaseTemperature();
                Print();
            }
        }

        public override void Print()
        {
            Global.Log.AddEntry(Global.Resources.GetResourceStatus() + "|" + "Asteroid");
        }

        public override bool IsAffordable()
        {
            if (Global.GameState.HasMaxTemperature())
            {
                return false;
            }

            return Global.Resources.Money >= cost;
        }
    }
}
