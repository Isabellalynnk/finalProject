using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
            bool jumping = false;
            int pipeSpeed = 5;
            int gravity = 5;
            int inScore = 0;

            public Form1()
            {
            InitializeComponent();
            endText1.Text = "Game Over!";
            endText2.Text = " Your final score is:" + inScore;
            gameDesigner.Text = "Game Desgined By Carter and Isabelle";

            endText1.Visible = false;
            endText2.Visible = false;
            gameDesigner.Visible = false;


            }
        private void pipeBottom_Click(object sender, EventArgs e)
        {
            pipeTop.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            flappyTortilla.Top += gravity;
            scoreText.Text = "" + inScore;

            if (pipeBottom.Left < -80)   
            {
                pipeBottom.Left = 1000;
                inScore += 1;
            }
            else if (pipeTop.Left < -95)
            {
                pipeTop.Left = 1100;
                inScore += 1;
            }
            else if (flappyTortilla.Bounds.IntersectsWith(pipeBottom.Bounds))
            {
                endGame();
            }
            else if (flappyTortilla.Bounds.IntersectsWith(pipeTop.Bounds))
            {
                endGame();
            }
        }
        private void GameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jumping = true;
                gravity = -5;
            }
        }
        private void GameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jumping = false;
                gravity = 5;
            }
        }
        private void endGame()
        {
            gameTimer.Stop();
            endText1.Visible = true;
            endText2.Visible = true;
            gameDesigner.Visible = true;
        }

        private void flappyTortilla_Click(object sender, EventArgs e)
        {
            if (flappyTortilla.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }
        }

        private void flappyTortilla_Click_1(object sender, EventArgs e)
        {

        }
    }
}
