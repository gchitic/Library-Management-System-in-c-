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
    public partial class UserControl_form4_AddBook : UserControl
    {
        public UserControl_form4_AddBook()
        {
            InitializeComponent();
        }

        private void gnBtnAnuleaza_Click(object sender, EventArgs e)
        {
            //Stergem toate campurile
            gn2TextBoxDenumire.Text = string.Empty;
            gn2TextBoxAutor.Text = string.Empty;
            gn2ComboBoxDomeniu.Text = string.Empty;
            gn2ComboBoxEditura.Text = string.Empty;
            gn2ComboBoxAnPublicare.Text = string.Empty;
            gn2NumericUpDCantitate.ResetText();
            gn2Limba.Text = string.Empty;


            //;Inchidem forma
            Form4AddBook form4AddBook = Parent as Form4AddBook;
            form4AddBook.Close();

        }

        private void gnBtnSalveaza_Click(object sender, EventArgs e)
        {
            //Verificam daca toate campurile s-au completat
            if (gn2TextBoxDenumire.Text != string.Empty && gn2TextBoxAutor.Text != string.Empty &&
                gn2ComboBoxDomeniu.Text != string.Empty && gn2ComboBoxEditura.Text != string.Empty && gn2Limba.Text != string.Empty)
            {
                //Aparitia unui dialog care intreaba daca dorim sa introducem o carte noua
                if (MessageBox.Show("Salvare cu succes! Vrei sa adaugi o alta carte?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    Form4AddBook form4AddBook = (Form4AddBook)Parent;
                    form4AddBook.Close();
                }

                //Stergem toate campurile
                gn2TextBoxDenumire.Text = string.Empty;
                gn2TextBoxAutor.Text = string.Empty;
                gn2ComboBoxDomeniu.Text = string.Empty;
                gn2ComboBoxEditura.Text = string.Empty;
                gn2ComboBoxAnPublicare.Refresh();
                gn2NumericUpDCantitate.ResetText();
                gn2Limba.Text = string.Empty;
                lblError.Visible = false;
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "ERROR: Introduceti datele necesare!";
            }
        }

        private void UserControl_form4_AddBook_Load(object sender, EventArgs e)
        {
            //Stergem toate campurile
            lblError.Visible = false;

            //Facem invgizibile campurile necesare
                //domeniu
            gn2TextBoxAddDomeniu.Visible = false;
            pictureBoxCorrect.Visible = false;
                //editura
            gn2TextBoxAddEditura.Visible = false;
            pictureBoxCorrect2.Visible = false;
        }

        private void pictureBoxAddAutor_Click(object sender, EventArgs e)
        {
            UserControl_form4_AddAutor userControl_Form4_AddAutor = new UserControl_form4_AddAutor();
            this.SendToBack();
            userControl_Form4_AddAutor.BringToFront();
        }

        private void pictureBoxAddDomeniu_Click(object sender, EventArgs e)
        {
            //facem visibil text boxul, il pozitionam si il redimensionam
            gn2TextBoxAddDomeniu.Visible = true;
            gn2TextBoxAddDomeniu.Location = new Point(225, 189);
            gn2TextBoxAddDomeniu.Size = new Size(357, 36);

            //adaugam un buton pentru a adauga domeniul, il pozitionam
            pictureBoxCorrect.Visible = true;
            pictureBoxCorrect.Location = new Point(588, 194);

            //facem invizibil combo box-ul si butonul add new
            gn2ComboBoxDomeniu.Visible = false;
            pictureBoxAddDomeniu.Visible = false;

        }

        private void pictureBoxCorrect_Click(object sender, EventArgs e)
        {
            //Facem invizibile controlerele de adaugare a domeniului
            gn2TextBoxAddDomeniu.Visible = false;
            pictureBoxCorrect.Visible = false;

            //Facem vizibil combobox-ul si butonul +
            gn2ComboBoxDomeniu.Visible = true;
            pictureBoxAddDomeniu.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //facem visibil text boxul, il pozitionam si il redimensionam
            gn2TextBoxAddEditura.Visible = true;
            gn2TextBoxAddEditura.Location = new Point(225, 250);
            gn2TextBoxAddEditura.Size = new Size(357, 36);

            //adaugam un buton pentru a adauga editura, il pozitionam
            pictureBoxCorrect2.Visible = true;
            pictureBoxCorrect2.Location = new Point(588, 255);

            //facem invizibil combo box-ul si butonul add new
            gn2ComboBoxEditura.Visible = false;
            pictureBoxAddEditura.Visible = false;
        }

        private void pictureBoxCorrect2_Click(object sender, EventArgs e)
        {
            //facem invizibile controllerrele de aduagare
            gn2TextBoxAddEditura.Visible = false;
            pictureBoxCorrect2.Visible = false;

            //facem vizibil combo box-ul si butonul add new
            gn2ComboBoxEditura.Visible = true;
            pictureBoxAddEditura.Visible = true;
        }
    }
}
