using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using TossCoin.Properties;

namespace TossCoin
{
    public partial class Form1 : Form
    {
        private Image eagle, tails;
        public Form1()
        {
            InitializeComponent();
            tails = Resources.Coin1;
            eagle = Resources.Coin2;
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            label1.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            TossCoin();
        }

        private async void TossCoin()
        {
            label1.Text = "";
            AnimCoin();
            await Task.Delay(2000);
            Random rnd = new Random();
            int value = rnd.Next(1, 3);
            if (value == 1)
            {
                label1.Text = "Выпал: Орел";
                pictureBox1.Image = eagle;
            }
            else
            {
                label1.Text = "Выпала: Решка";
                pictureBox1.Image = tails;
            }
            button1.Enabled = true;
        }


        private async void AnimCoin()
        {
            for (int i = 0; i < 9; i++)
            {
                pictureBox1.Image = eagle;
                await Task.Delay(100);
                pictureBox1.Image = tails;
                await Task.Delay(100);
            }
        }
    }
}
