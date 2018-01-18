using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraformingMars
{
    static class Global
    {
        public static PlayerResources Resources { get; set; }
        public static GameState GameState { get; set; }
        public static GameMap Map { get; set; }
        public static LogManager Log { get; set; }
    }
}
