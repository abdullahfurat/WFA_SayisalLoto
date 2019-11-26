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
        int[] dizi = new int[6];
        int i = 0;
        int sayac = 0;
        int sayilar = 0;
        public Form1()
        {
            InitializeComponent();

        }
        Random rnd = new Random();
        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "0";
                    i = 0;
                    sayac = 0;
                    sayilar = 0;
                }

            }
            if (timer1.Enabled == true)
            {
                timer1.Stop();
            }
            else if (timer1.Enabled == false)
            {
                timer1.Start();

            }


        }

      
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Interval = 100;

            if (i<=this.Controls.Count-1)
            {
                if (this.Controls[i] is TextBox)
                {
                    switch (sayac)
                    {
                            case 0:
                            case 1:
                            case 2:
                            case 3:
                            case 4:
                            case 5:
                            case 6:
                            case 7:
                            case 8:
                            case 9:
                            this.Controls[i].Text = rnd.Next(1, 49).ToString();
                            sayac++;
                            break;
                        case 10:

                                if (dizi.Contains(int.Parse(this.Controls[i].Text)))
                                {
                                this.Controls[i].Text = rnd.Next(1, 49).ToString(); ;
                                }
                                else
                                {
                                    dizi[sayilar] = int.Parse(this.Controls[i].Text);
                                    sayilar++;
                                    sayac = 0;
                                    i++;
                                }

                            break;
                    }
                    
                }

                else
                {
                    i++;
                    
                  
                }

               

   
            }
            if(i==this.Controls.Count-1)
            {
                Array.Sort(dizi);
                textBox6.Text = dizi[0].ToString();
                textBox4.Text = dizi[1].ToString();
                textBox2.Text = dizi[2].ToString();
                textBox5.Text = dizi[3].ToString();
                textBox3.Text = dizi[4].ToString();
                textBox1.Text = dizi[5].ToString();
                timer1.Stop();
                timer1.Enabled = false;
            }
            








        }
            


        }

    }

        
   
    

