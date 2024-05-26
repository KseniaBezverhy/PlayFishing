using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Fishing
{
    public partial class Form1 : Form
    {
        private bool lose = false;
        private int countFish = 0;
        private int countLife = 3;
        private int speed = 5;
        private int secondsExtraLife = 10;
        private bool isUsedExtraLife = false;
        private int secondChangeColor = 2;


        public Form1()
        {
            InitializeComponent();

            labellose.Visible = false;
            buttonStart.Visible = false;
            KeyPreview = true;
            timerExtraLife.Enabled = false;
            timerChangeColor.Enabled = false;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            frog1.Top += speed;
            frog2.Top += speed;
            fish2.Top += speed;
            fish1.Top += speed;
            seaweed.Top += speed;

            if (fish2.Top >= 600) GetCoordinate(fish2);
            if (fish1.Top >= 600) GetCoordinate(fish1);
            if (seaweed.Top >= 600) GetCoordinate(seaweed);
            if (frog1.Top >= 600) GetCoordinate(frog1);
            if (frog2.Top >= 600) GetCoordinate(frog2);
            
            GetCoordinateIfIntersects(frog1, false);
            GetCoordinateIfIntersects(frog2, false);
            GetCoordinateIfIntersects(fish2, true);
            GetCoordinateIfIntersects(seaweed, false);
            GetCoordinateIfIntersects(fish1, true);

            if (countLife == 0)
            {
                timer.Enabled = false;
                timerExtraLife.Enabled = false;
                labellose.Visible = true;
                buttonStart.Visible = true;
                lose = true;
            }
        }

        private void GetCoordinateIfIntersects(PictureBox name, bool isFish)
        {
            if (player.Bounds.IntersectsWith(name.Bounds))
            {
                if (isFish)
                {
                    countFish++;
                    labelfish.Text = "Рыбки: " + countFish.ToString();
                }
                else
                {
                    countLife--;
                    labelLife.Text = "Жизни: " + countLife.ToString();
                    timerChangeColor.Enabled = true;
                }
                GetCoordinate(name);
            }
        }

        private static void GetCoordinate(PictureBox name)
        {
            name.Top = -600;
            Random rand = new Random();
            name.Left = rand.Next(0, 800 - name.Left);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (lose) return;
            int speed = 5;
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && player.Left > 0)
                player.Left -= speed;
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && player.Right < 600)
                player.Left += speed;
        }

        private void buttonRestorationHeart_Click(object sender, EventArgs e)
        {
            if (!isUsedExtraLife)
            {
                timerExtraLife.Start();
                speed = 10;
            }
            
        }

        private void timerExtraLife_Tick(object sender, EventArgs e)
        {
            secondsExtraLife = secondsExtraLife - 1;
            labelExtraLife.Text = secondsExtraLife.ToString();
            if (secondsExtraLife <= 0)
            {
                speed = 5;
                isUsedExtraLife = true;
                countLife++;
                labelLife.Text = "Жизни: " + countLife.ToString();
                timerExtraLife.Stop();
            }
            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            frog1.Top = -130;
            frog2.Top = -400;
            seaweed.Top = -600;
            secondsExtraLife = 10;
            isUsedExtraLife = false;
            timerExtraLife.Enabled = false;
            labelExtraLife.Text = secondsExtraLife.ToString();
            labellose.Visible = false;
            buttonStart.Visible = false;
            timer.Enabled = true;
            lose = false;
            countFish = 0;
            countLife = 3;
            labelfish.Text = "Рыбки: 0";
            labelLife.Text = "Жизни: 3";
            fish2.Top = -550;
        }

        private void timerChangeColor_Tick(object sender, EventArgs e)
        {
            secondChangeColor = secondChangeColor - 1;
            player.BackColor = Color.Red;
            if (secondChangeColor <= 0)
            { 
                player.BackColor = Color.Transparent;
                secondChangeColor = 2;
                timerChangeColor.Stop();
            }
        }
    }
}
