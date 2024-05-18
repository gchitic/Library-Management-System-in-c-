namespace Practica_Bibioteca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            gnTextBoxUser = new Guna.UI2.WinForms.Guna2TextBox();
            gnTextBoxPass = new Guna.UI2.WinForms.Guna2TextBox();
            pictureBox2 = new PictureBox();
            gnBtnAutentificare = new Guna.UI2.WinForms.Guna2Button();
            gnBtnContNou = new Guna.UI2.WinForms.Guna2Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logo_resize400x;
            pictureBox1.Location = new Point(134, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // gnTextBoxUser
            // 
            gnTextBoxUser.AutoRoundedCorners = true;
            gnTextBoxUser.BackColor = Color.Transparent;
            gnTextBoxUser.BorderColor = Color.Transparent;
            gnTextBoxUser.BorderRadius = 20;
            gnTextBoxUser.BorderThickness = 0;
            gnTextBoxUser.CustomizableEdges = customizableEdges1;
            gnTextBoxUser.DefaultText = "";
            gnTextBoxUser.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            gnTextBoxUser.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            gnTextBoxUser.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            gnTextBoxUser.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            gnTextBoxUser.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            gnTextBoxUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            gnTextBoxUser.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            gnTextBoxUser.Location = new Point(92, 325);
            gnTextBoxUser.Margin = new Padding(3, 4, 3, 4);
            gnTextBoxUser.Name = "gnTextBoxUser";
            gnTextBoxUser.PasswordChar = '\0';
            gnTextBoxUser.PlaceholderText = "Nume de utilizator";
            gnTextBoxUser.SelectedText = "";
            gnTextBoxUser.ShadowDecoration.CustomizableEdges = customizableEdges2;
            gnTextBoxUser.Size = new Size(286, 42);
            gnTextBoxUser.TabIndex = 3;
            // 
            // gnTextBoxPass
            // 
            gnTextBoxPass.AutoRoundedCorners = true;
            gnTextBoxPass.BackColor = Color.Transparent;
            gnTextBoxPass.BorderColor = Color.Transparent;
            gnTextBoxPass.BorderRadius = 20;
            gnTextBoxPass.BorderThickness = 0;
            gnTextBoxPass.CustomizableEdges = customizableEdges3;
            gnTextBoxPass.DefaultText = "";
            gnTextBoxPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            gnTextBoxPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            gnTextBoxPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            gnTextBoxPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            gnTextBoxPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            gnTextBoxPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            gnTextBoxPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            gnTextBoxPass.Location = new Point(92, 392);
            gnTextBoxPass.Margin = new Padding(3, 4, 3, 4);
            gnTextBoxPass.Name = "gnTextBoxPass";
            gnTextBoxPass.PasswordChar = '*';
            gnTextBoxPass.PlaceholderText = "Parola";
            gnTextBoxPass.SelectedText = "";
            gnTextBoxPass.ShadowDecoration.CustomizableEdges = customizableEdges4;
            gnTextBoxPass.Size = new Size(286, 42);
            gnTextBoxPass.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.preview_unscreen;
            pictureBox2.Location = new Point(7, 188);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(455, 179);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // gnBtnAutentificare
            // 
            gnBtnAutentificare.BackColor = Color.Transparent;
            gnBtnAutentificare.BorderRadius = 20;
            gnBtnAutentificare.CustomizableEdges = customizableEdges5;
            gnBtnAutentificare.DisabledState.BorderColor = Color.DarkGray;
            gnBtnAutentificare.DisabledState.CustomBorderColor = Color.DarkGray;
            gnBtnAutentificare.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gnBtnAutentificare.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gnBtnAutentificare.FillColor = Color.MediumOrchid;
            gnBtnAutentificare.Font = new Font("Segoe UI", 9F);
            gnBtnAutentificare.ForeColor = Color.WhiteSmoke;
            gnBtnAutentificare.Location = new Point(122, 458);
            gnBtnAutentificare.Name = "gnBtnAutentificare";
            gnBtnAutentificare.ShadowDecoration.CustomizableEdges = customizableEdges6;
            gnBtnAutentificare.Size = new Size(225, 42);
            gnBtnAutentificare.TabIndex = 6;
            gnBtnAutentificare.Text = "Autentficare";
            gnBtnAutentificare.Click += gnBtnAutentificare_Click;
            // 
            // gnBtnContNou
            // 
            gnBtnContNou.BackColor = Color.Transparent;
            gnBtnContNou.BorderRadius = 20;
            gnBtnContNou.CustomizableEdges = customizableEdges7;
            gnBtnContNou.DisabledState.BorderColor = Color.DarkGray;
            gnBtnContNou.DisabledState.CustomBorderColor = Color.DarkGray;
            gnBtnContNou.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gnBtnContNou.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gnBtnContNou.FillColor = Color.MediumOrchid;
            gnBtnContNou.Font = new Font("Segoe UI", 9F);
            gnBtnContNou.ForeColor = Color.WhiteSmoke;
            gnBtnContNou.Location = new Point(122, 506);
            gnBtnContNou.Name = "gnBtnContNou";
            gnBtnContNou.ShadowDecoration.CustomizableEdges = customizableEdges8;
            gnBtnContNou.Size = new Size(225, 42);
            gnBtnContNou.TabIndex = 7;
            gnBtnContNou.Text = "Creare cont";
            gnBtnContNou.Click += gnBtnContNou_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = Properties.Resources.eye;
            pictureBox3.Location = new Point(325, 398);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(473, 644);
            Controls.Add(pictureBox3);
            Controls.Add(gnBtnContNou);
            Controls.Add(gnBtnAutentificare);
            Controls.Add(gnTextBoxUser);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(gnTextBoxPass);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MANSCRIPT";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Guna.UI2.WinForms.Guna2TextBox gnTextBoxUser;
        private Guna.UI2.WinForms.Guna2TextBox gnTextBoxPass;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button gnBtnAutentificare;
        private Guna.UI2.WinForms.Guna2Button gnBtnContNou;
        private PictureBox pictureBox3;
    }
}
