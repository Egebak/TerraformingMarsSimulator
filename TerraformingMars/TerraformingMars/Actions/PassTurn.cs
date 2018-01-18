using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraformingMars.Actions
{
    class PassTurn : Action
    {
        public override void DoThisAction()
        {
            ;
        }

        public override bool IsAffordable()
        {
            return Global.Resources.Money >= 23;
        }


        public override void Print()
        {
            Global.Log.AddEntry(Global.Resources.GetResourceStatus() + "|" + "Pass turn");
        }
    }
}
