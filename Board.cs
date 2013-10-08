using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSimulator
{
    static class Board
    {
        static Board()
        {
            
        }

        public static int Height { get; set; }
        public static int Width { get; set; }

        public enum CellStates { unpopulated, populated }
        public enum BoardStates { running, stopped }
        
        


    }
}
