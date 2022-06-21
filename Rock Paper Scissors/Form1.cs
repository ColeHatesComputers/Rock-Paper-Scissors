using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    public partial class RPS : Form
    {
        Random generator = new Random();
        int win = 0;
        int tie = 0;
        int lose = 0;
         
        public RPS()
        {
            InitializeComponent();
        }

        private void RPS_Load(object sender, EventArgs e)
        {
            radRock.Checked = false;
            imgPlayer.Image = Properties.Resources.Start;
        }
        private void radRock_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.Rock;
        }

        private void radPaper_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.Paper;
        }

        private void radScissors_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.Scissors;
        }
        
        private void Startbtn_Click(object sender, EventArgs e)
        {
            int random = generator.Next(1, 4);
            if (random == 1)
                imgOpponent.Image = Properties.Resources.Rock;
            
            else if (random == 2)
                imgOpponent.Image = Properties.Resources.Paper;
            else if (random == 3)
                imgOpponent.Image = Properties.Resources.Scissors;
            if (radRock.Checked && random == 3)
                lblMessage.Text = ("Status: Winner!");
            
            else if (radRock.Checked && random == 2)
                lblMessage.Text = ("Status: Loser!");
            
            else if (radRock.Checked && random == 1)
                lblMessage.Text = ("Status: Tie!");
            
            else if (radPaper.Checked && random == 3)
                lblMessage.Text = ("Status: Loser!");
            
            else if (radPaper.Checked && random == 2)
                lblMessage.Text = ("Status: Tie!");
            
            else if (radPaper.Checked && random == 1)
                lblMessage.Text = ("Status: Winner!");
            
            else if (radScissors.Checked && random == 3)
                lblMessage.Text = ("Status: Tie!");
            
            else if (radScissors.Checked && random == 2)
                lblMessage.Text = ("Status: Winner!");
            
            else if (radScissors.Checked && random == 1)
                lblMessage.Text = ("Status: Loser!");
            if (radRock.Checked && random == 1 || radPaper.Checked && random == 2 || radScissors.Checked && random == 3)
                tie = tie + 1;
            
            else if (radRock.Checked && random == 2 || radPaper.Checked && random == 3 || radScissors.Checked && random == 1)
                lose = lose + 1;
            
            else if (radRock.Checked && random == 3 || radPaper.Checked && random == 1 || radScissors.Checked && random == 2)
                win = win + 1;
            lblTies.Text = Convert.ToString(tie);
            
            lblLoses.Text = Convert.ToString(lose);
            
            lblWins.Text = Convert.ToString(win);
            
            radRock.Checked = false;
            radPaper.Checked = false;
            radScissors.Checked = false;
        }

        
    }
}

