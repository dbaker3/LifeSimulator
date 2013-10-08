using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSimulator
{
    class Cell
    {
        public Cell(Board.CellStates cs)
        {
            MyState = cs;
        }

        private Board.CellStates _myState;
        public Board.CellStates MyState
        {
            get { return _myState; }
            set { _myState = value; }
        }
        
        


    }
}
