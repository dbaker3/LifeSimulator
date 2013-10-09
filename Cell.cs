using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSimulator
{
    class Cell
    {
        public Cell(CellStates cs)
        {
            MyState = cs;
        }
        
        public enum CellStates { unpopulated, populated }
        
        private CellStates _myState;
        public CellStates MyState
        {
            get { return _myState; }
            set { _myState = value; }
        }

        //      The Rules
        //
        //For a space that is 'populated':
        //  Each cell with one or no neighbors dies, as if by loneliness.
        //  Each cell with four or more neighbors dies, as if by overpopulation.
        //  Each cell with two or three neighbors survives.
        //
        //For a space that is 'empty' or 'unpopulated'
        //  Each cell with three neighbors becomes populated.
        
        public void ProcessStandardRules()
        {
            int populatedNeighbors = 0;

            //TODO: calculate number of neighbors

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


    }
}
