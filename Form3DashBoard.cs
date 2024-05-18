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
    public partial class Form3DashBoard : Form
    {
        public Form3DashBoard()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void delogareToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void setarileContuluiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        //Submeniu DELOGARE
        private void limbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Aparitia unui dialog care intreaba daca suntem siguri ca vrem sa iesim
            if (MessageBox.Show("Esti sigur ca vrei sa te deloghezi?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //deschidem forma de logare
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Close();
            }
        }

        private void adaugaOCarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4AddBook form4 = new Form4AddBook();
            form4.ShowDialog();
        }

        private void afiseazaCartileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5ShowBook form5 = new Form5ShowBook();
            form5.ShowDialog();
        }

        private void adaugareCititorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6AddCititor form6 = new Form6AddCititor();
            form6.ShowDialog();
        }

        private void afisareCititoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7_ShowCititor form7 = new Form7_ShowCititor();
            form7.ShowDialog();
        }

        private void iMPRUMUTDECARTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
