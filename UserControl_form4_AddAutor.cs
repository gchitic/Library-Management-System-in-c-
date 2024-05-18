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
    public partial class UserControl_form4_AddAutor : UserControl
    {
        public UserControl_form4_AddAutor()
        {
            InitializeComponent();
        }

        private void gn2TextBoxDenumire_TextChanged(object sender, EventArgs e){}
        private void label4_Click(object sender, EventArgs e){}


        private void UserControl_form4_AddAutor_Load(object sender, EventArgs e)
        {
            groupBox1AddAutor.Visible = false;  //adaugarea autorului nou
        }

        private void gn2BtnAdd_Click(object sender, EventArgs e)
        {
            groupBox1AddAutor.Visible = true;   //facem vizibil adaugarea autorului
        }

        private void gnBtnAnuleaza_Click(object sender, EventArgs e)
        {
            UserControl_form4_AddBook userControl_Form4_AddBook = new UserControl_form4_AddBook();
            this.SendToBack();
            userControl_Form4_AddBook.BringToFront();

            //la inchiderea usercontrol-ului se face invizibil group box-ul de adaugare a autorului nou
            groupBox1AddAutor.Visible = false;
        }

        private void gn2Btn2Anuleaza_Click(object sender, EventArgs e)
        {
            //Stergem campurile
            gn2TextBoxNume.Text = string.Empty;
            gn2TextBoxPrenume.Text = string.Empty;
            gn2DateTimePickerData.Refresh();

            //Facem grupul de adaugare a autorului invizibil
            groupBox1AddAutor.Visible = false;

        }
    }
}
