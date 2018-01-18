using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraformingMars
{
    public class PlayerResources
    {
        public int TerraformRating { get; set; }
        public int Money { get; set; }
        public int Plants { get; set; }
        public int Heat { get; set; }
        public int Power { get; set; }

        public int MoneyProduction { get; set; }
        public int HeatProduction { get; set; }
        public int PlantProduction { get; set; }
        public int PowerProduction { get; set; }

        public PlayerResources() {
            TerraformRating = 14;

            Money = 42;
            MoneyProduction = 0;

            Plants = 0;
            PlantProduction = 0;

            Heat = 0;
            HeatProduction = 3;

            Power = 0;
            PowerProduction = 0;        
        }

        public void Update() {
            Money += TerraformRating + MoneyProduction;

            Plants += PlantProduction;

            Heat += HeatProduction + Power; //all existing power gets converted to Heat

            Power = PowerProduction;
        }
        public String GetResourceStatus() {

            return "TR:" + TerraformRating + " Money:" + Money + " Plants:" + Plants+ " Heat:"+Heat+ " HeatProd:"+HeatProduction;
        }

    }
}
