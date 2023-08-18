using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form3 : Form
    {
        string usuario, senha;
        public Form3(string usuario, string senha)
        {
            InitializeComponent();
            this.usuario = textBox4.Text;
            this.senha = textBox5.Text;
        }
        //Metodos para retornar as variaveis do construtor
        public string MostraU()
        {
            return this.usuario;
        }

        public string MostraS()
        {
            return this.senha;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != textBox6.Text)
            {
                MessageBox.Show("Senhas incorretas");
            }
            else
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }
    }
}
