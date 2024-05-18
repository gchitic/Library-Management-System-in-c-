namespace Practica_Bibioteca
{
    partial class Form6AddCititor
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
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            userControl_form6_addCititor1 = new UserControl_form6_addCititor();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            pictureBox1.Image = Properties.Resources.plus_2623086;
            pictureBox1.Location = new Point(14, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(199, 161, 50);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(64, 537);
            panel1.TabIndex = 10;
            // 
            // userControl_form6_addCititor1
            // 
            userControl_form6_addCititor1.BackColor = Color.FromArgb(52, 60, 100);
            userControl_form6_addCititor1.Location = new Point(65, -1);
            userControl_form6_addCititor1.Name = "userControl_form6_addCititor1";
            userControl_form6_addCititor1.Size = new Size(784, 535);
            userControl_form6_addCititor1.TabIndex = 11;
            // 
            // Form6AddCititor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 60, 100);
            ClientSize = new Size(848, 532);
            Controls.Add(userControl_form6_addCititor1);
            Controls.Add(panel1);
            Name = "Form6AddCititor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adauga cititor";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private UserControl_form6_addCititor userControl_form6_addCititor1;
    }
}