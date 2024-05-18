namespace Practica_Bibioteca
{
    partial class Form4AddBook
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            userControl_form4_AddBook1 = new UserControl_form4_AddBook();
            userControl_form4_AddAutor1 = new UserControl_form4_AddAutor();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(199, 161, 50);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(64, 537);
            panel1.TabIndex = 9;
            // 
            // userControl_form4_AddBook1
            // 
            userControl_form4_AddBook1.BackColor = Color.FromArgb(52, 60, 100);
            userControl_form4_AddBook1.Location = new Point(58, 0);
            userControl_form4_AddBook1.Name = "userControl_form4_AddBook1";
            userControl_form4_AddBook1.Size = new Size(798, 537);
            userControl_form4_AddBook1.TabIndex = 10;
            userControl_form4_AddBook1.Load += userControl_form4_AddBook1_Load;
            // 
            // userControl_form4_AddAutor1
            // 
            userControl_form4_AddAutor1.BackColor = Color.FromArgb(52, 60, 100);
            userControl_form4_AddAutor1.Location = new Point(58, 0);
            userControl_form4_AddAutor1.Name = "userControl_form4_AddAutor1";
            userControl_form4_AddAutor1.Size = new Size(798, 534);
            userControl_form4_AddAutor1.TabIndex = 11;
            // 
            // Form4AddBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 60, 100);
            ClientSize = new Size(848, 532);
            Controls.Add(userControl_form4_AddAutor1);
            Controls.Add(userControl_form4_AddBook1);
            Controls.Add(panel1);
            Name = "Form4AddBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adauga carte";
            Load += Form4AddBook_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UserControl_form4_AddBook userControl_form4_AddBook1;
        private UserControl_form4_AddAutor userControl_form4_AddAutor1;
    }
}