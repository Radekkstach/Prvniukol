using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            try
            {
                int jedna = int.Parse(textBox1.Text); //N 
                int dva = int.Parse(textBox2.Text); //A
                int A = 1; // pomocne
                int N = 1; // pomocne

                if (checkBox1.Checked == true)
                {
                    // A na Ntou
                    for (int pomocna = jedna; pomocna != 0; pomocna--)
                    {
                        A = A * dva;
                    }
                    vysledek.Text = "A na 'Ntou' " + A;

                }
                if (checkBox2.Checked == true)
                {
                    // faktorial N
                    if (jedna == 0)
                    {
                        vysledek.Text = "\nFaktorial N! " + "1";
                    }
                    else
                    {
                        for (int pomocna = jedna; pomocna != 1; pomocna--)
                        {
                            N = N * pomocna;
                        }
                        vysledek.Text = "\nFaktorial N! " + N;
                    }

                }

                if (checkBox1.Checked == true && checkBox2.Checked == true)
                {
                    vysledek.Text = "A na 'Ntou' " + A + "\nFaktorial N! " + N;

                }

            }
            catch (FormatException x)
            {
                MessageBox.Show(x.Message);
            }
            catch(OverflowException y)
            {
                MessageBox.Show(y.Message);
            }

        }
    }
}
