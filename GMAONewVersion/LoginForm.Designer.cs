namespace GMAONewVersion
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBoxLoginForm = new System.Windows.Forms.PictureBox();
            this.panelLoginForm = new System.Windows.Forms.Panel();
            this.labelConnectionId = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxConnectionId = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelLoginForm = new System.Windows.Forms.Label();
            this.buttonConnectionLoginForm = new System.Windows.Forms.Button();
            this.pictureBoxAlternPassword = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginForm)).BeginInit();
            this.panelLoginForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlternPassword)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxLoginForm
            // 
            this.pictureBoxLoginForm.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoginForm.Image")));
            this.pictureBoxLoginForm.Location = new System.Drawing.Point(-12, -4);
            this.pictureBoxLoginForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxLoginForm.Name = "pictureBoxLoginForm";
            this.pictureBoxLoginForm.Size = new System.Drawing.Size(671, 457);
            this.pictureBoxLoginForm.TabIndex = 0;
            this.pictureBoxLoginForm.TabStop = false;
            // 
            // panelLoginForm
            // 
            this.panelLoginForm.BackColor = System.Drawing.Color.White;
            this.panelLoginForm.Controls.Add(this.panel1);
            this.panelLoginForm.Controls.Add(this.buttonConnectionLoginForm);
            this.panelLoginForm.Controls.Add(this.labelLoginForm);
            this.panelLoginForm.Controls.Add(this.textBoxPassword);
            this.panelLoginForm.Controls.Add(this.textBoxConnectionId);
            this.panelLoginForm.Controls.Add(this.labelPassword);
            this.panelLoginForm.Controls.Add(this.labelConnectionId);
            this.panelLoginForm.Location = new System.Drawing.Point(143, 74);
            this.panelLoginForm.Margin = new System.Windows.Forms.Padding(4);
            this.panelLoginForm.Name = "panelLoginForm";
            this.panelLoginForm.Size = new System.Drawing.Size(349, 308);
            this.panelLoginForm.TabIndex = 1;
            // 
            // labelConnectionId
            // 
            this.labelConnectionId.AutoSize = true;
            this.labelConnectionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnectionId.Location = new System.Drawing.Point(75, 65);
            this.labelConnectionId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConnectionId.Name = "labelConnectionId";
            this.labelConnectionId.Size = new System.Drawing.Size(140, 20);
            this.labelConnectionId.TabIndex = 0;
            this.labelConnectionId.Text = "Nom d\'utilisateur:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(75, 187);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(115, 20);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Mot de passe:";
            // 
            // textBoxConnectionId
            // 
            this.textBoxConnectionId.Location = new System.Drawing.Point(79, 90);
            this.textBoxConnectionId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxConnectionId.Name = "textBoxConnectionId";
            this.textBoxConnectionId.Size = new System.Drawing.Size(187, 22);
            this.textBoxConnectionId.TabIndex = 2;
            this.textBoxConnectionId.Text = "m";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(79, 212);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(187, 22);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.Text = "m";
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelLoginForm
            // 
            this.labelLoginForm.AutoSize = true;
            this.labelLoginForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginForm.Location = new System.Drawing.Point(104, 14);
            this.labelLoginForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoginForm.Name = "labelLoginForm";
            this.labelLoginForm.Size = new System.Drawing.Size(128, 25);
            this.labelLoginForm.TabIndex = 4;
            this.labelLoginForm.Text = "Se connecter";
            // 
            // buttonConnectionLoginForm
            // 
            this.buttonConnectionLoginForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnectionLoginForm.Location = new System.Drawing.Point(107, 261);
            this.buttonConnectionLoginForm.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConnectionLoginForm.Name = "buttonConnectionLoginForm";
            this.buttonConnectionLoginForm.Size = new System.Drawing.Size(136, 28);
            this.buttonConnectionLoginForm.TabIndex = 2;
            this.buttonConnectionLoginForm.Text = "Connection";
            this.buttonConnectionLoginForm.UseVisualStyleBackColor = true;
            this.buttonConnectionLoginForm.Click += new System.EventHandler(this.buttonConnectionLoginForm_Click);
            // 
            // pictureBoxAlternPassword
            // 
            this.pictureBoxAlternPassword.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAlternPassword.Image")));
            this.pictureBoxAlternPassword.Location = new System.Drawing.Point(3, 9);
            this.pictureBoxAlternPassword.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pictureBoxAlternPassword.Name = "pictureBoxAlternPassword";
            this.pictureBoxAlternPassword.Size = new System.Drawing.Size(27, 31);
            this.pictureBoxAlternPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAlternPassword.TabIndex = 5;
            this.pictureBoxAlternPassword.TabStop = false;
            this.pictureBoxAlternPassword.Click += new System.EventHandler(this.pictureBoxAlternPassword_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBoxAlternPassword);
            this.panel1.Location = new System.Drawing.Point(273, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(35, 31);
            this.panel1.TabIndex = 6;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 444);
            this.Controls.Add(this.panelLoginForm);
            this.Controls.Add(this.pictureBoxLoginForm);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginForm)).EndInit();
            this.panelLoginForm.ResumeLayout(false);
            this.panelLoginForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlternPassword)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxLoginForm;
        private System.Windows.Forms.Panel panelLoginForm;
        private System.Windows.Forms.PictureBox pictureBoxAlternPassword;
        private System.Windows.Forms.Button buttonConnectionLoginForm;
        private System.Windows.Forms.Label labelLoginForm;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxConnectionId;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelConnectionId;
        private System.Windows.Forms.Panel panel1;
    }
}