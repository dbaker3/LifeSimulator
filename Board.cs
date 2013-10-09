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
            Height = Properties.Settings.Default.BoardHeight;
            Width = Properties.Settings.Default.BoardWidth;
        }

        public static int Height { get; set; }
        public static int Width { get; set; }

 
        public enum BoardStates { running, stopped }
        
        static Cell[,] theBoard = new Cell[Width,Height];


    }
}
