using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_game
{
    public partial class Form1 : Form
    {
        //list related to snake
        private List<Circle> Snake = new List<Circle> ();

        private Circle food = new Circle ();
        
        int maxWidth;
        int maxHeight;
        
        int score;
        int highScore;

        Random random = new Random ();

        bool goLeft, goRight, goUp, goDown;

        public Form1()
        {
            InitializeComponent();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

        }

        private void StartGame(object sender, EventArgs e)
        {

        }

        private void TakeSnapShot(object sender, EventArgs e)
        {

        }

        private void GameTimerEvent(object sender, EventArgs e)
        {

        }

        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {

        }

        //area of the custom functions (below)
        private void RestartGame() 
        { 
        
        }

        private void EatFood()
        { 
        
        }

        private void GameOver()
        {

        }

    }
}
