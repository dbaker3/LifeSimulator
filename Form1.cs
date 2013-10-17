using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show(Board.Width.ToString());
           
        }

        private void toolStripButtonPlay_Click(object sender, EventArgs e)
        {
            // Testing
            MessageBox.Show(Board.Cells[0,0].MyState.ToString());
            MessageBox.Show(Board.Size.ToString());
            Board.Cells[0, 0].MyState = Cell.CellStates.populated;
            MessageBox.Show(Board.Cells[0,0].MyState.ToString());
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            // Testing
            Board.Cells[0, 1].MyState = Cell.CellStates.populated;
            MessageBox.Show("Cell[0,1]: " + Board.Cells[0,1].MyState.ToString());
        }

    



  

  
    }
}
