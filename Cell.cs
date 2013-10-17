using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSimulator
{
    class Cell
    {
        // Set new Cell's location and state
        public Cell(int x, int y, CellStates cs)
        {
            this.X = x;
            this.Y = y;
            MyState = cs;
        }
        
        public enum CellStates { unpopulated, populated }
        
        private CellStates _myState;
        public CellStates MyState
        {
            get { return _myState; }
            set { _myState = value; }
        }

        // Cell location on board
        public int X { get; private set; }
        public int Y { get; private set; }

        //      The Standard Rules
        //
        // For a space that is 'populated':
        //   Each cell with one or no neighbors dies, as if by loneliness.
        //   Each cell with four or more neighbors dies, as if by overpopulation.
        //   Each cell with two or three neighbors survives.
        //
        // For a space that is 'empty' or 'unpopulated'
        //   Each cell with three neighbors becomes populated.
        
        public void ProcessStandardRules()
        {
            int populatedNeighbors = calculateNumNeighbors();            

            if (this.MyState == CellStates.populated)
            {
                if (populatedNeighbors <= 1)
                {
                    this.MyState = CellStates.unpopulated;
                    return;
                }
                else if (populatedNeighbors >= 4)
                {
                    this.MyState = CellStates.unpopulated;
                    return;
                }
                else // (populatedNeighbors == 2 || populatedNeighbors == 3)
                {
                    this.MyState = CellStates.populated;
                    return;
                }
            }
            else // (this.MyState == CellStates.unpopulated)
            {
                if (populatedNeighbors == 3)
                {
                    this.MyState = CellStates.populated;
                    return;
                }
            } 
        }

        // Returns number of neighbors
        private int calculateNumNeighbors()
        {
            int numNeighbors = 0;

            //  | x-1, y-1 | x, y-1 | x+1, y-1 |
            //  |  x-1, y  |  x, y  |  x+1, y  |
            //  | x-1, y+1 | x, y+1 | x+1, y+1 |
            
            if (X != 0 && Y != 0)
            {
                if (Board.Cells[X - 1, Y - 1].MyState == CellStates.populated)  // Above to the Left
                    numNeighbors++;
            }

            if (X != 0)
            {
                if (Board.Cells[X - 1, Y].MyState == CellStates.populated)      // To the Left
                    numNeighbors++;
            }

            if (X != 0)
            {
                if (Board.Cells[X - 1, Y + 1].MyState == CellStates.populated)  // Below to the Left
                    numNeighbors++;
            }

            if (Y != 0)
            {
                if (Board.Cells[X, Y - 1].MyState == CellStates.populated)      // Above
                    numNeighbors++;
            }

            if (Y != 0)
            {
                if (Board.Cells[X + 1, Y - 1].MyState == CellStates.populated)  // Above to the Right
                    numNeighbors++;
            }

            if (Board.Cells[X, Y + 1].MyState == CellStates.populated)          // Below
                numNeighbors++;

            if (Board.Cells[X + 1, Y].MyState == CellStates.populated)          // To the Right
                numNeighbors++;

            if (Board.Cells[X + 1, Y + 1].MyState == CellStates.populated)      // Below to the Right
                numNeighbors++;
            
            return numNeighbors;
        }

        // TODO: Add methods for other rules



    }
}
