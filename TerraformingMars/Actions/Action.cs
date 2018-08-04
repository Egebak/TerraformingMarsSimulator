using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraformingMars
{
    abstract class Action
    {
        abstract public void Print();
        abstract public bool IsAffordable();
        abstract public void DoThisAction();


    }
}
