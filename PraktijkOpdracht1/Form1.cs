using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PraktijkOpdracht1.Enums;

namespace PraktijkOpdracht1
{
    public partial class Form1 : Form
    {
        private TicTacToeEngine t;
        public Form1()
        {
            InitializeComponent();
            t = new TicTacToeEngine();
        }

        public void Choose(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            bool result = t.ChooseCell("" + b.TabIndex);

            if (result && t.Status == GameStatus.PlayerXPlays)
            {
                b.Text = "O";
            }
            else if (result && t.Status == GameStatus.PlayerOPlays)
            {
                b.Text = "X";
            }

            if ((result) && !(t.Status == GameStatus.PlayerOPlays) && !(t.Status == GameStatus.PlayerXPlays))
            {
                t.Reset();
                this.button1.Text = ""; this.button2.Text = ""; this.button3.Text = "";
                this.button4.Text = ""; this.button5.Text = ""; this.button6.Text = "";
                this.button7.Text = ""; this.button8.Text = ""; this.button9.Text = "";
            }
        }
    }
}
