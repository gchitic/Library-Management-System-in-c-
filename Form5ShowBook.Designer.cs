namespace Practica_Bibioteca
{
    partial class Form5ShowBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            userControl_form5_vizualizareCarte1 = new UserControl_form5_vizualizareCarte();
            userControl_form5_AddAutor1 = new UserControl_form5_AddAutor();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(199, 161, 50);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(64, 842);
            panel1.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.manuscript___Copy;
            pictureBox2.Location = new Point(0, 133);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 304);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.eye_2531412;
            pictureBox1.Location = new Point(14, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // userControl_form5_vizualizareCarte1
            // 
            userControl_form5_vizualizareCarte1.AutoScroll = true;
            userControl_form5_vizualizareCarte1.Location = new Point(68, 4);
            userControl_form5_vizualizareCarte1.Name = "userControl_form5_vizualizareCarte1";
            userControl_form5_vizualizareCarte1.Size = new Size(785, 525);
            userControl_form5_vizualizareCarte1.TabIndex = 11;
            // 
            // userControl_form5_AddAutor1
            // 
            userControl_form5_AddAutor1.BackColor = Color.FromArgb(52, 60, 100);
            userControl_form5_AddAutor1.Location = new Point(64, -2);
            userControl_form5_AddAutor1.Name = "userControl_form5_AddAutor1";
            userControl_form5_AddAutor1.Size = new Size(788, 540);
            userControl_form5_AddAutor1.TabIndex = 12;
            // 
            // Form5ShowBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 60, 100);
            ClientSize = new Size(848, 532);
            Controls.Add(userControl_form5_vizualizareCarte1);
            Controls.Add(panel1);
            Controls.Add(userControl_form5_AddAutor1);
            Name = "Form5ShowBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vizualizare carti";
            Load += Form5ShowBook_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private UserControl_form5_vizualizareCarte userControl_form5_vizualizareCarte1;
        private UserControl_form5_AddAutor userControl_form5_AddAutor1;
    }
}