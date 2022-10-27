using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sekretariat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            los();
        }
        public int rnd;

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string haslo = textBox2.Text;

            if (login == "admin" && haslo == "Qwerty1@34")
            {
                code_check();
            }
            else
            {
                MessageBox.Show("Login lub haslo prawidlowe", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            los();
            textBox3.Text = "";

        }

        public void los()
        {
            Random random = new Random();
            rnd = random.Next(0, 5);
            pictureBox1.Image = imageList1.Images[rnd];
        }

        string[] keys = {
            "befhd",
            "x3deb",
            "cg5dd",
            "74853",
            "b5nmm",
            "mxyxw"   
    };

        private void code_check()
        {

           
            if (keys[rnd] == textBox3.Text)
            {
                MessageBox.Show("Zalogowano pomyślnie");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
