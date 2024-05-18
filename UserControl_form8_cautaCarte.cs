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
    public partial class UserControl_form8_cautaCarte : UserControl
    {
        public UserControl_form8_cautaCarte()
        {
            InitializeComponent();
        }

        private void gn2BtnReset_Click(object sender, EventArgs e)
        {
            //Stergem campul
            gn2TextBoxCautaCarte.Text = string.Empty;
        }

        private void gn2BtnSelect_Click(object sender, EventArgs e)
        {
            UserControl_form8_Imprumut userControl_Form8_Imprumut = new UserControl_form8_Imprumut();
            this.SendToBack();
            userControl_Form8_Imprumut.BringToFront();
        }
    }
}
