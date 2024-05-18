namespace Practica_Bibioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        { }

        private void pictureBox2_Click(object sender, EventArgs e)
        { }

        //Apasarea pe ochi
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Animatia afisarii parolei
            if (gnTextBoxPass.PasswordChar == '\0')
                gnTextBoxPass.PasswordChar = '*';
            else
                gnTextBoxPass.PasswordChar = '\0';

        }

        private void gnBtnContNou_Click(object sender, EventArgs e)
        {
            //La apasarea butonului se deschide forma cu crearea unui cont si se inchide forma prezenta
            this.Hide();
            Form2ContNou form2ContNou = new Form2ContNou();
            form2ContNou.ShowDialog();
        }

        private void gnBtnAutentificare_Click(object sender, EventArgs e)
        {
            string utilizator = "123", parola = "123";
            //La apasarea butonului se verifica validitatea datelor introduse
            if (gnTextBoxUser.Text != utilizator && gnTextBoxPass.Text != parola)
            {
                MessageBox.Show("Autentificare esuata!");
            }
            else
            {
                this.Hide();
                Form3DashBoard form3DashBoard = new Form3DashBoard();
                form3DashBoard.ShowDialog();
                this.Close();
                //MessageBox.Show("Autentificare executata cu succes!");
            }
        }
    }
}
