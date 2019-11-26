using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WFA_SayisalLoto
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        Random rnd = new Random();
        int i = 0;
        int y = 0;
        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            int i = 0;
            int y = 0;
            foreach (Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "0";
                }

            }

            if (timer1.Enabled == true)
            {
                timer1.Stop();
            }
            else if(timer1.Enabled==false)
            {
                timer1.Start();

            }


        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Interval = 500;
                if (this.Controls[i] is TextBox)
                {
                    this.Controls[i].Text = Convert.ToString(rnd.Next(1, 50));
                }
            else
            {
                i++;
            }

            if (i==this.Controls.Count-1)
            {
                timer1.Stop();

            }
            else if (y<10)
            {
                y++;
               
            }
            else if(y==10)
            {
                i++;
                y = 1;

            }
            else
            {
                y++;
                i++;
            }
                

        }

            }  
        }
   
    

