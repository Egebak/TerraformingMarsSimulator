using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraformingMars
{
    class GameState
    {
        int turn;
        const int finalTurn = 14;
        public const int maxOceanSize = 9;
        public const int maxTemperature = 8;
        public const int maxOxygen = 14;

        public int currentTemperature;
        public int currentOceanSize;
        public int currentOxygen;


        public GameState()
        {
            turn = 1;
            currentTemperature = -30;
            Global.Log.AddEntry("Turn " + turn);
        }

        public void UpdateTurn()
        {
            Global.Resources.Update();
            turn += 1;
            Global.Log.AddEntry("Turn "+turn);
        }

        public bool IsFinalTurn() {
            return turn > finalTurn;
        }

        public void IncreaseTemperature()
        {
            if (currentTemperature < maxTemperature)
            {
                currentTemperature += 2;
                Global.Resources.TerraformRating += 1;

                if (currentTemperature == -24)
                {
                    Global.Resources.HeatProduction += 1;
                }
                if (currentTemperature == -20)
                {
                    Global.Resources.HeatProduction += 1;
                }
                if (currentTemperature == 0)
                {
                    IncreaseOcean();
                }
            }
        }
        public void IncreaseOcean()
        {
            if (currentOceanSize < maxOceanSize)
            {
                currentOceanSize += 1;
                Global.Resources.TerraformRating += 1;
                Global.Map.PlaceOcean();
            }
        }
        public void IncreaseOxygen()
        {
            if (currentOxygen < maxOxygen)
            {
                currentOxygen += 1;
                Global.Resources.TerraformRating += 1;

                if (currentOxygen == 8)
                {
                    IncreaseTemperature();
                }
            }
        }

        public int GetScore() {
            PrintGameState();

            int score = Global.Resources.TerraformRating;
            score += Global.Map.GetGreeneryNumber();

            if (HasMaxTemperature() & HasMaxOceans() & HasMaxOxygen()) {
                score += 1000;
            }

            return score;
        }

        public void PrintGameState()
        {
            Global.Log.AddEntry("Ox: " + currentOxygen + " Oceans: " + currentOceanSize + " Temp: " + currentTemperature);
        }

        public bool HasMaxOceans()
        {
            return currentOceanSize == maxOceanSize;
        }
        public bool HasPlaceableMaxOceans()
        {
            return currentOceanSize == maxOceanSize-1;
        }
        public bool HasMaxOxygen()
        {
            return currentOxygen == maxOxygen;
        }
        public bool HasMaxTemperature()
        {
            return currentTemperature == maxTemperature;
        }
    }
}
