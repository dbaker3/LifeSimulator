﻿using System;
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

            Cells = new Cell[Width, Height];

            for (int i = 0; i < Width - 1; i++)
            {
                for (int j = 0; j < Height - 1; j++)
                    Cells[i, j] = new Cell(i, j, Cell.CellStates.unpopulated);
            }

            Size = Cells.GetLength(1) * Cells.GetLength(0);

            Board.Status = BoardStates.stopped;
        }

        static public int Height { get; set; }
        static public int Width { get; set; }

        static public Cell[,] Cells;
 
        public enum BoardStates { running, stopped }

        static public BoardStates Status { get; private set; }

        static public int Size { get; private set; }

        static public void Start()
        {
            Board.Status = BoardStates.running;
            // TODO: loop through cells and apply rules
        }

        static public void Stop()
        {
            Board.Status = BoardStates.stopped;
            // TODO: stop looping through cells
        }

    }
}
