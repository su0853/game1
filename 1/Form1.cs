using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        int score=0;
        int hscore=0;
        int time = 60;
       
        bool []lv = { false, false, false, false, false };
        int[] s1 = { 50, 70, 90, 110 };
        int[] s2 = { 90, 70, 110, 50 };
        int[] s3 = { 90, 110, 50, 70 };
        public void End() 
        {
            if (score>hscore)
            {
                hscore = score;
            }
            timer1.Enabled=false;
            timer2.Enabled=false;
            timer3.Enabled=false;
            timer4.Enabled=false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            label2.Text = Convert.ToString("最高紀錄" +hscore + "分");
            time = 60;
            x1.Top = 0;
            x2.Top = 0;
            x3.Top = 0;
            score = 0;
            button4.Enabled = true;
            label1.Text = Convert.ToString("時間60s 分數0分");
        }
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a.Left = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a.Left = 500;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            a.Left = 250;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled=false;
            timer1.Enabled = true;
            timer2.Enabled=true;
            timer3.Enabled=true;
            timer4.Enabled=true;
            button1.Enabled=true;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            Random random1 = new Random();
            int r1 = random1.Next(0, 3);
            if (x2.Top >= 600)
            {
                if(a.Top-x2.Top<200&&a.Left==x2.Left)
                {
                    score = score + 1;
                }
                x2.Top = 0;
            }
            x2.Top = x2.Top + s1[r1];
        }

        private void timer3_Tick(object sender, EventArgs e)
        {


            Random random2 = new Random();
            int r2 = random2.Next(0, 3);
            if (x1.Top >= 600)
            {
               if(a.Top-x1.Top<200&&a.Left==x1.Left)
                {
                    score=score + 1;
                }
                x1.Top = 0;
            }
            x1.Top = x1.Top + s2[r2];
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Random random3 = new Random();

            int r3 = random3.Next(0, 3);

            if (x3.Top >= 600)
            {
                if(a.Top-x3.Top<200&&a.Left==x3.Left)
                {
                    score=score + 1;
                }
                x3.Top = 0;
            }
            x3.Top = x3.Top + s3[r3];
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString("時間:" + time + "s "+"分數"+score+"分");
            time=time-1;
            for (int i = 1; i < lv.Length; i++) {
                if (score == i*7 && lv[i] == false)
                {
                    lv[i] = true;
                    time = time + 10;
                    label3.Text = Convert.ToString("等級"+i);
                    timer2.Interval -= 130;
                    timer3.Interval -= 130;
                    timer4.Interval -= 130;

                }
            }
            if(time==0)
            {
                End();
            }
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            End();
        }
        private void x1_Click(object sender, EventArgs e)
        {

        }
        private void x3_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void a_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
//label1.Text = Convert.ToString("時間:" + time + "s");