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
    public partial class UserControl_form5_AddAutor : UserControl
    {
        public UserControl_form5_AddAutor()
        {
            InitializeComponent();
        }

        private void gnBtnAnuleaza_Click(object sender, EventArgs e)
        {
            UserControl_form5_vizualizareCarte userControl_Form5_VizualizareCarte = new UserControl_form5_vizualizareCarte();
            this.SendToBack();
            userControl_Form5_VizualizareCarte.BringToFront();
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

        private void gn2BtnAdd_Click(object sender, EventArgs e)
        {
            groupBox1AddAutor.Visible = true;   //facem vizibil adaugarea autorului
        }

        private void UserControl_form5_AddAutor_Load(object sender, EventArgs e)
        {
            groupBox1AddAutor.Visible = false;   //facem invizibil adaugarea autorului
        }
    }
}
