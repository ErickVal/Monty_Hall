using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private int RandomNumber(int min, int max)
        {
            int lastnum;
            Random random = new Random();
            lastnum = random.Next(min, max);

            if (lastnum % 3 == 0 || lastnum % 4 == 0)
            {
                lastnum = random.Next(min, max);
            }
            if (lastnum % 5 == 0 || lastnum % 6 == 0 || lastnum % 7 == 0)
            {
                lastnum = random.Next(min, max);
            }

            return lastnum;

        }

       
        private void button1_Click(object sender, EventArgs e)
        {

            int numero_portas = int.Parse(textBox1.Text);

            Random rand = new Random();
            int n = rand.Next(0, numero_portas);
            int x = rand.Next(0, numero_portas);

            int premiada = n;
            int porta_escolhida = x;
            int descarta;
            int troca;
            bool chave = true;
            
            
            if (radioButton1.Checked == true)
            {

                label6.Text = x.ToString(); //x=escolha
                label7.Text = n.ToString(); //n=premiado

                //VERIFICA SE A PORTA QUE ESCOLHEU ESTÁ CERTA OU ERRADA.
                if (porta_escolhida == premiada)
                {

                    label2.Text = (int.Parse(label2.Text) + 1).ToString();

                }
                else { label3.Text = (int.Parse(label3.Text) + 1).ToString(); }

            }
            else if (radioButton2.Checked == true)
            {
                //ESCOLHE 1 PORTA, MAS DEPOIS TROCA PARA UMA DIFERENTE.

                    while (chave) { 
                        descarta = rand.Next(0, numero_portas); //PORTA QUE VAI SER ABERTA NAO PODE SER PREMIADA E NEM PODE SER A QUE ESCOLHI
                        if (descarta != premiada && descarta != porta_escolhida)
                        {

                            troca = rand.Next(0, numero_portas);//PORTA QUE VOU TROCAR NAO PODE SER A QUE EU JA TINHA E NEM A JA ABERTA
                            if (troca != porta_escolhida && troca != descarta)
                            {
                            label6.Text = troca.ToString(); //x=escolha
                            label7.Text = n.ToString(); //n=premiado

                            if (troca == premiada)
                                {

                                    label2.Text = (int.Parse(label2.Text) + 1).ToString();
                                chave = false;

                                }
                                else
                                {

                                    label3.Text = (int.Parse(label3.Text) + 1).ToString();
                                    chave = false;

                            }

                            }
                        }
                    }
               


            }else
            {
                MessageBox.Show("Escolhe ae doido!! ");

            }


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = 0.ToString();
            label7.Text = 0.ToString();
            label3.Text = 0.ToString();
            label2.Text = 0.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = 0.ToString();
            label7.Text = 0.ToString();
            label3.Text = 0.ToString();
            label2.Text = 0.ToString();
        }
    }
}
