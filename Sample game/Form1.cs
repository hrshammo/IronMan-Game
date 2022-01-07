using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//All Copyright © goes to HR Shammo (https://github.com/hrshammo/) 
namespace Sample_game
{
    public partial class Form1 : Form
    {
        int speed=10;
        int gravity=10;
        int score = 0;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();

        
        public Form1()
        {
            InitializeComponent();
            player.SoundLocation = "theme.wav";
           player1.SoundLocation = "over.wav";
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.Play();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void hero_Click(object sender, EventArgs e)
        {

        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            


            hero.Top += gravity;
            barDown.Left -= speed;
            barUp.Left -= speed;
            citory.Left -= speed;
           
            scoreText.Text = "Score: " + score;

            if (barDown.Left < -150)
            { 
                // if the bottom pipes location is -150 then we will reset it back to 800 and add 1 to the score
                barDown.Left = 1000;
                score++;
            }
            if (barUp.Left < -180)
            {
                // if the top pipe location is -180 then we will reset the pipe back to the 950 and add 1 to the score
                barUp.Left = 950;
                score++;
            }
            if (citory.Left < -80)
            {
                // if the top pipe location is -180 then we will reset the pipe back to the 950 and add 1 to the score
                citory.Left = 950;
                score++;
            }
            if (score> 5)
            {
                int speed = 40;
            }
            if (hero.Bounds.IntersectsWith(barUp.Bounds) ||
                hero.Bounds.IntersectsWith(citory.Bounds) ||
                hero.Bounds.IntersectsWith(barDown.Bounds) ||
                hero.Bounds.IntersectsWith(ground.Bounds) || hero.Top < -25
                )
            {
                // if any of the conditions are met from above then we will run the end game function
                avengerEndgame();
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                // if the space key is pressed then the gravity will be set to -15
                gravity = -10;
            }

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                // if the space key is pressed then the gravity will be set to -15
                gravity = 10;

            }

        }
        private void avengerEndgame()
        {
            GameTimer.Stop(); // stop the main timer
            scoreText.Text += " Game Over !!!";
            player.Stop();

            player1.Play();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void barUp_Click(object sender, EventArgs e)
        {

        }
    }
}
