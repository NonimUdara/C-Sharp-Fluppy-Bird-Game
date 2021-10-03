using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int pipespeed = 5;
        int gravity = 10;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void end()
        {
            Mytimer.Stop();
            Over.Text = "Game Over!";
        }

        private void Timerevent(object sender, EventArgs e)
        {
            Bird.Top += gravity;
            Pipeup.Left -= pipespeed;
            Pipedown.Left -= pipespeed;
            Score.Text = "Score: " + score;

            if(Pipeup.Left < -100)
            {
                Pipeup.Left = 900;
                score++;
            }

            if (Pipedown.Left < -120)
            {
                Pipedown.Left = 1800;
            }

            if(Bird.Bounds.IntersectsWith(Pipeup.Bounds) || Bird.Bounds.IntersectsWith(Pipedown.Bounds) || Bird.Bounds.IntersectsWith(Ground.Bounds))
            {
                end();
            }
        }

        private void birdup(object sender, MouseEventArgs e)
        {
            
        }

        private void birddown(object sender, MouseEventArgs e)
        {

        }

        private void birddown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                gravity = -10;
            }
        }

        private void birdup(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Up)
            {
                gravity = 10;
            }
        }

        private void Pipedown_Click(object sender, EventArgs e)
        {

        }

        private void restart(object sender, EventArgs e)
        {

        }
    }
}
