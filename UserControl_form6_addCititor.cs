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
    public partial class UserControl_form6_addCititor : UserControl
    {
        public UserControl_form6_addCititor()
        {
            InitializeComponent();
        }

        private void gnBtnAnuleaza_Click(object sender, EventArgs e)
        {
            //Stergem toate campurile
            gn2TextBoxNume.Text = string.Empty;
            gn2TextBoxPrenume.Text = string.Empty;
            gn2TextBoxAdress.Text = string.Empty;
            gn2TextBox_NrTel.Text = string.Empty;

            //Inchidem forma

            Form6AddCititor form6 = (Form6AddCititor)Parent;
            form6.Close();
        }

        private void gnBtnSalveaza_Click(object sender, EventArgs e)
        {
            //Verificam daca toate campurile s-au completat
            if(gn2TextBoxNume.Text != string.Empty && gn2TextBoxPrenume.Text != string.Empty &&
                gn2TextBoxAdress.Text != string.Empty && gn2TextBox_NrTel.Text != string.Empty)
            {
                //Aparitia unui dialog care intreaba daca dorim sa introducem o carte noua
                if (MessageBox.Show("Salvare cu succes! Vrei sa adaugi o alta carte?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    Form6AddCititor form6 = (Form6AddCititor)this.Parent;
                    form6.Close();
                }

                //Stergem campurile
                gn2TextBoxNume.Text = string.Empty;
                gn2TextBoxPrenume.Text = string.Empty;
                gn2TextBoxAdress.Text = string.Empty;
                gn2TextBox_NrTel.Text = string.Empty;
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "ERROR: Introduceti datele necesare!";
            }
        }
    }
}
