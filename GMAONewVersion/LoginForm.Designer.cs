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
            this.panelLoginForm = new System.Windows.Forms.Panel();
            this.buttonConnectionLoginForm = new System.Windows.Forms.Button();
            this.labelLoginForm = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxConnectionId = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelConnectionId = new System.Windows.Forms.Label();
            this.pictureBoxLoginForm = new System.Windows.Forms.PictureBox();
            this.panelLoginForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLoginForm
            // 
            this.panelLoginForm.BackColor = System.Drawing.Color.White;
            this.panelLoginForm.Controls.Add(this.buttonConnectionLoginForm);
            this.panelLoginForm.Controls.Add(this.labelLoginForm);
            this.panelLoginForm.Controls.Add(this.textBoxPassword);
            this.panelLoginForm.Controls.Add(this.textBoxConnectionId);
            this.panelLoginForm.Controls.Add(this.labelPassword);
            this.panelLoginForm.Controls.Add(this.labelConnectionId);
            this.panelLoginForm.Location = new System.Drawing.Point(107, 60);
            this.panelLoginForm.Name = "panelLoginForm";
            this.panelLoginForm.Size = new System.Drawing.Size(262, 250);
            this.panelLoginForm.TabIndex = 1;
            // 
            // buttonConnectionLoginForm
            // 
            this.buttonConnectionLoginForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnectionLoginForm.Location = new System.Drawing.Point(80, 212);
            this.buttonConnectionLoginForm.Name = "buttonConnectionLoginForm";
            this.buttonConnectionLoginForm.Size = new System.Drawing.Size(102, 23);
            this.buttonConnectionLoginForm.TabIndex = 2;
            this.buttonConnectionLoginForm.Text = "Connection";
            this.buttonConnectionLoginForm.UseVisualStyleBackColor = true;
            this.buttonConnectionLoginForm.Click += new System.EventHandler(this.buttonConnectionLoginForm_Click);
            // 
            // labelLoginForm
            // 
            this.labelLoginForm.AutoSize = true;
            this.labelLoginForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginForm.Location = new System.Drawing.Point(78, 11);
            this.labelLoginForm.Name = "labelLoginForm";
            this.labelLoginForm.Size = new System.Drawing.Size(104, 20);
            this.labelLoginForm.TabIndex = 4;
            this.labelLoginForm.Text = "Se connecter";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(59, 172);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(141, 20);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.Text = "m";
            // 
            // textBoxConnectionId
            // 
            this.textBoxConnectionId.Location = new System.Drawing.Point(59, 73);
            this.textBoxConnectionId.Name = "textBoxConnectionId";
            this.textBoxConnectionId.Size = new System.Drawing.Size(141, 20);
            this.textBoxConnectionId.TabIndex = 2;
            this.textBoxConnectionId.Text = "m";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(56, 152);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(97, 17);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Mot de passe:";
            // 
            // labelConnectionId
            // 
            this.labelConnectionId.AutoSize = true;
            this.labelConnectionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnectionId.Location = new System.Drawing.Point(56, 53);
            this.labelConnectionId.Name = "labelConnectionId";
            this.labelConnectionId.Size = new System.Drawing.Size(117, 17);
            this.labelConnectionId.TabIndex = 0;
            this.labelConnectionId.Text = "Nom d\'utilisateur:";
            // 
            // pictureBoxLoginForm
            // 
            this.pictureBoxLoginForm.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoginForm.Image")));
            this.pictureBoxLoginForm.Location = new System.Drawing.Point(-9, -3);
            this.pictureBoxLoginForm.Name = "pictureBoxLoginForm";
            this.pictureBoxLoginForm.Size = new System.Drawing.Size(503, 371);
            this.pictureBoxLoginForm.TabIndex = 0;
            this.pictureBoxLoginForm.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.panelLoginForm);
            this.Controls.Add(this.pictureBoxLoginForm);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panelLoginForm.ResumeLayout(false);
            this.panelLoginForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLoginForm;
        private System.Windows.Forms.Label labelLoginForm;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxConnectionId;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelConnectionId;
        private System.Windows.Forms.Button buttonConnectionLoginForm;
        private System.Windows.Forms.PictureBox pictureBoxLoginForm;
    }
}