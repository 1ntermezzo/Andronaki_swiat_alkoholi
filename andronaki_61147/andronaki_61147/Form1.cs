using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace andronaki_61147
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 2022; i >= 1900; i--)
            {
                comboBox3.Items.Add(i);
            }
            panel1.Visible = false;
        }
        private void show()
        {
            panel1.Visible = true;
        }
        private void hide()
        {
            panel1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(comboBox3.Text) <= 2003)
            {
                show();
            }
            else
            {
                MessageBox.Show("Jesteś Niepełnoletni");
            }

            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0 || textBox5.Text.Length == 0)
            {
                MessageBox.Show("Brak Danych Klienta!");
            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text.Length != 0)
            {
                richTextBox1.Text += comboBox4.Text;
                richTextBox1.Text += ", ";
            }
            else
            {

            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = @"D:\" + textBox2.Text + "_" + textBox1.Text + ".txt";
            string tekst = "Dane klienta: \r\n ";
            tekst += "Nazwisko: " + textBox2.Text + " " + "Imie: " + " " + textBox1.Text + "\r\n ";
            tekst += "Dane kontaktowe: \r\n";
            tekst += "E-Mail " + textBox5.Text + "\r\n";
            tekst += "Adres: " + textBox3.Text + "\r\n";
            tekst += "Nr.Lokalu: " + textBox4.Text + "\r\n";
            tekst += "Zamówienie: " + richTextBox1.Text + "\r\n";
            tekst += "Czas Zamówienia: " + DateTime.Now.ToString("dddd, dd MM yyyy") + "\r\n";          
        }
     
    }
    }
    
    

