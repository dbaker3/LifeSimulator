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
        Board TheBoard = new Board();

        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show(Board.Width.ToString());
           
        }

        private void toolStripButtonPlay_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TheBoard.Cells[0,0].MyState.ToString());
            MessageBox.Show(TheBoard.Size.ToString());
        }

    



  

  
    }
}
