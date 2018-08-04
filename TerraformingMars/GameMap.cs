using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraformingMars
{
    class GameMap
    {
        int currentGreenery;

        public GameMap() {
            currentGreenery = 1;
        }

        public void PlaceOcean() {
            if (Global.GameState.currentOceanSize == 1) // Ius Chasma
            {
                Global.Resources.Plants += 2;
            }
            if (Global.GameState.currentOceanSize == 2) // East of Ius Chasma
            {
                Global.Resources.Plants += 2;
                Global.Resources.Money += 2; //Adjacency bonus
            }
            if (Global.GameState.currentOceanSize == 3) // Candor Chasma
            {
                Global.Resources.Plants += 2;
                Global.Resources.Money += 2; //Adjacency bonus
            }
            if (Global.GameState.currentOceanSize == 4) // Eastern Melas Chasma
            {
                Global.Resources.Plants += 1;
                Global.Resources.Money += 2; //Adjacency bonus
            }
            if (Global.GameState.currentOceanSize == 5) // Corprates Chasma
            {
                Global.Resources.Plants += 1;
                Global.Resources.Money += 2; //Adjacency bonus
            }
            if (Global.GameState.currentOceanSize == 6) // Eos Chasma
            {
                Global.Resources.Plants += 1;
                Global.Resources.Money += 2; //Adjacency bonus
            }
            if (Global.GameState.currentOceanSize == 7) // Shalbatana Vallis
            {
                Global.Resources.Plants += 2;
            }
            if (Global.GameState.currentOceanSize == 8) // Viking Site
            {
                Global.Resources.Money += 2; //Selling card
            }
            if (Global.GameState.currentOceanSize == 9) // Kasei Valles
            {
                Global.Resources.Money += 1; //Selling card
            }
        }

        public void PlaceGreenery()
        {
            if (currentGreenery < 4) //Arsia Mons, Noctis Labyrinthys, Syria Planum
            {
                Global.Resources.Plants += 2;
            }

            if (currentGreenery == 4) //Next to Ascraeus Mons
            {
                Global.Resources.Plants += 1;
            }

            if (currentGreenery == 5) //Tithonium Chasma (west)
            {
                Global.Resources.Plants += 1;
                if (Global.GameState.currentOceanSize >= 1) {
                    Global.Resources.Money += 2;
                }
            }

            if (currentGreenery == 6) //Tithonium Chasma (east)
            {
                Global.Resources.Plants += 1;
                if (Global.GameState.currentOceanSize >= 2)
                {
                    Global.Resources.Money += 4;
                }
                else if (Global.GameState.currentOceanSize == 1) {
                    Global.Resources.Money += 2;
                }
            }

            if (currentGreenery == 7) //Hebes Chasma
            {
                Global.Resources.Plants += 2;
                if (Global.GameState.currentOceanSize >= 3)
                {
                    Global.Resources.Money += 4;
                }
                else if (Global.GameState.currentOceanSize == 2)
                {
                    Global.Resources.Money += 2;
                }
            }

            if (currentGreenery == 8) //Ophir Chasma
            {
                Global.Resources.Plants += 1;
                if (Global.GameState.currentOceanSize >= 3)
                {
                    Global.Resources.Money += 2;
                }
            }
            if (currentGreenery == 9) //Juventae Chasma
            {
                Global.Resources.Plants += 2;
                if (Global.GameState.currentOceanSize >= 6)
                {
                    Global.Resources.Money += 6;
                }
                else if (Global.GameState.currentOceanSize == 5)
                {
                    Global.Resources.Money += 4;
                }
                else if (Global.GameState.currentOceanSize == 3)
                {
                    Global.Resources.Money += 2;
                }
            }
            if (currentGreenery == 10) //Ganges Chasma (west)
            {
                Global.Resources.Plants += 2;
                if (Global.GameState.currentOceanSize >= 7)
                {
                    Global.Resources.Money += 6;
                }
                else if (Global.GameState.currentOceanSize == 6)
                {
                    Global.Resources.Money += 4;
                }
                else if (Global.GameState.currentOceanSize == 5)
                {
                    Global.Resources.Money += 2;
                }
                else if (Global.GameState.currentOceanSize == 4)
                {
                    Global.Resources.Money += 0;
                }
            }
            if (currentGreenery == 11) //Ganges Chasma (east)
            {
                Global.Resources.Plants += 2;
                if (Global.GameState.currentOceanSize >= 7)
                {
                    Global.Resources.Money += 4;
                }
                else if (Global.GameState.currentOceanSize == 4)
                {
                    Global.Resources.Money += 2;
                }
            }
            if (currentGreenery == 12) //Sinai Planum (west)
            {
                Global.Resources.Plants += 1;
                if (Global.GameState.currentOceanSize >= 1)
                {
                    Global.Resources.Money += 2;
                }
            }
            if (currentGreenery == 13) //Sinai Planum (middle)
            {
                Global.Resources.Plants += 1;
                if (Global.GameState.currentOceanSize >= 2)
                {
                    Global.Resources.Money += 4;
                }
                else if (Global.GameState.currentOceanSize == 1)
                {
                    Global.Resources.Money += 2;
                }
            }
            if (currentGreenery == 14) //Sinai Planum (east)
            {
                Global.Resources.Plants += 1;
                if (Global.GameState.currentOceanSize >= 5)
                {
                    Global.Resources.Money += 6;
                }
                else if (Global.GameState.currentOceanSize == 3)
                {
                    Global.Resources.Money += 4;
                }
                else if (Global.GameState.currentOceanSize == 2)
                {
                    Global.Resources.Money += 2;
                }
            }
            if (currentGreenery == 15) //Juventae Chasma, near Shalbatana Vallis
            {
                Global.Resources.Plants += 1;
                if (Global.GameState.currentOceanSize >= 4)
                {
                    Global.Resources.Money += 2;
                }
            }
            if (currentGreenery == 16) //Pavonis Mons
            {
                Global.Resources.Plants += 1;
            }
            if (currentGreenery == 17) //Claritas Fossae
            {
                Global.Resources.Plants += 1;
            }
            if (currentGreenery == 18) //Next to Lampland
            {
                if (Global.GameState.currentOceanSize >= 5)
                {
                    Global.Resources.Money += 2;
                }
            }
            if (currentGreenery == 19) //Lassel
            {
                Global.Resources.Plants += 1;
                if (Global.GameState.currentOceanSize >= 6)
                {
                    Global.Resources.Money += 4;
                }
                else if (Global.GameState.currentOceanSize == 5)
                {
                    Global.Resources.Money += 2;
                }
            }
            if (currentGreenery == 20) //Ritchey
            {
                if (Global.GameState.currentOceanSize >= 7)
                {
                    Global.Resources.Money += 4;
                }
                else if (Global.GameState.currentOceanSize == 6)
                {
                    Global.Resources.Money += 2;
                }
            }
            if (currentGreenery == 21) //Xanthe Terra
            {
                if (Global.GameState.currentOceanSize >= 8)
                {
                    Global.Resources.Money += 4;
                }
                else if (Global.GameState.currentOceanSize == 4)
                {
                    Global.Resources.Money += 2;
                }
            }
            if (currentGreenery == 22) //Lunae Planum
            {
                if (Global.GameState.currentOceanSize == 8)
                {
                    Global.Resources.Money += 2;
                }
            }
            if (currentGreenery == 23) //Next to Sharonov
            {
                if (Global.GameState.currentOceanSize >= 9)
                {
                    Global.Resources.Money += 4;
                }
                else if (Global.GameState.currentOceanSize == 8)
                {
                    Global.Resources.Money += 2;
                }
            }

            currentGreenery++;

        }

        public int GetGreeneryNumber() {
            return currentGreenery;
        }
    }
}

/**/
