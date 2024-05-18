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
    public partial class UserControl_form5_vizualizareCarte : UserControl
    {
        public UserControl_form5_vizualizareCarte()
        {
            InitializeComponent();
        }

        private void pictureBoxAddAutor_Click(object sender, EventArgs e)
        {
            UserControl_form5_vizualizareCarte userControl_Form5_VizualizareCarte = new UserControl_form5_vizualizareCarte();
            this.SendToBack();
            userControl_Form5_VizualizareCarte.BringToFront();
        }
    }
}
