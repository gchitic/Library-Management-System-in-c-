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
    public partial class UserControl_form8_Imprumut : UserControl
    {
        public UserControl_form8_Imprumut()
        {
            InitializeComponent();
        }
        
        //Cauta carte btn
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UserControl_form8_cautaCarte userControl_Form8_CautaCarte = new UserControl_form8_cautaCarte();
            this.SendToBack();
            userControl_Form8_CautaCarte.BringToFront();
        }

        private void gn2BtnImprumut_Click(object sender, EventArgs e)
        {
            //Verificam daca campurile sunt completate
            if (gn2TextBoxCititor.Text != string.Empty && guna2TextBoxCarte.Text != string.Empty)
            {
                lblError.Visible = false;
                MessageBox.Show("Imprumut executat cu succes!");
                //Stergem campurile
                gn2TextBoxCititor.Text = string.Empty;
                guna2TextBoxCarte.Text = string.Empty;
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "ERROR: Completati campurile.";
            }
        }

        private void UserControl_form8_Imprumut_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }
    }
}
