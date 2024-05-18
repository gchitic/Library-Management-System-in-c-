using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Bibioteca
{
    public partial class Form2ContNou : Form
    {
        private readonly object str;

        public Form2ContNou()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //La apasarea butonului ANULARE ne intoarcem la forma principala
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void Form2ContNou_Load(object sender, EventArgs e)
        {
            //Stergem toate campurile
            gnTextBoxName.Text = string.Empty;
            guna2TextBoxTel.Text = string.Empty;
            guna2TextUser.Text = string.Empty;
            guna2TextPass.Text = string.Empty;
            guna2TextConfPass.Text = string.Empty;
            radioBtnFem.Refresh();
            radioBtnMasc.Refresh();

            //Facem invizibile controalerele necesare
            lblError.Visible = false;
        }

        private object GetStr()
        {
            return str;
        }

        private void GnBtnCreareCont_Click(object sender, EventArgs e, object str)
        {}
    }
}
