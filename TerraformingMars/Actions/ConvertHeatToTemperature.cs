using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraformingMars.Actions
{
    class ConvertHeatToTemperature : Action
    {
        private const int required = 8;

        public override void DoThisAction()
        {
            if (IsAffordable())
            {
                Global.Resources.Heat -= required;
                Global.GameState.IncreaseTemperature();
                Print();
            }
        }

        public override bool IsAffordable()
        {
            return Global.Resources.Heat >= required;
        }


        public override void Print()
        {
            Global.Log.AddEntry(Global.Resources.GetResourceStatus() + "|" + "Convert heat to temperature");
        }
    }
}
