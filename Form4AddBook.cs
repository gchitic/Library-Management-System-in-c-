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
    public partial class Form4AddBook : Form
    {
        public Form4AddBook()
        {
            InitializeComponent();
        }

        private void gnBtnAnuleaza_Click(object sender, EventArgs e)
        {
        }

        private void gnBtnSalveaza_Click(object sender, EventArgs e)
        {
        }

        private void Form4AddBook_Load(object sender, EventArgs e)
        {
            userControl_form4_AddBook1.BringToFront();
        }

        private void userControl_form4_AddBook1_Load(object sender, EventArgs e)
        {
        }
        private void userControl_form4_AddBook1_Hide(object sender, EventArgs e)
        {
        }
    }
}
