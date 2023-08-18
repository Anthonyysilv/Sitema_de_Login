namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3("Teste","1234");
            string usuario = form3.MostraU();
            string senha = form3.MostraS();
            textBox1.Text = usuario;
            textBox2.Text = senha;
            if ((textBox1.Text == usuario) && (textBox2.Text == senha))
            {
                Form2 form = new Form2();
                form.Show();
                this.Hide();
            }
            if ((textBox1.Text != usuario) && (textBox2.Text == senha))
            {
                MessageBox.Show("Usuário está errado!!!");
            }

            if ((textBox1.Text == usuario) && (textBox2.Text != senha))
            {
                MessageBox.Show("Sua senha está errada!!!");
            }
            if ((textBox1.Text != usuario) && (textBox2.Text != senha))
            {
                MessageBox.Show("Usuário e Senha Inválidos");
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3("Teste","1234");
            form3.Show();
            this.Hide();


        }
    }
}