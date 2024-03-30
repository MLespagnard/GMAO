namespace GMAONewVersion
{
    partial class UserCreerForm
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
            this.ButtonCreateUser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxFirstNameUser = new System.Windows.Forms.TextBox();
            this.groupBoxRankForUser = new System.Windows.Forms.GroupBox();
            this.comboBoxRankForUser = new System.Windows.Forms.ComboBox();
            this.groupBoxPasswordForUser = new System.Windows.Forms.GroupBox();
            this.textBoxPasswordUser = new System.Windows.Forms.TextBox();
            this.groupBoxLastNameUser = new System.Windows.Forms.GroupBox();
            this.textBoxLastNameUser = new System.Windows.Forms.TextBox();
            this.labelHeaderUser = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxRankForUser.SuspendLayout();
            this.groupBoxPasswordForUser.SuspendLayout();
            this.groupBoxLastNameUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonCreateUser
            // 
            this.ButtonCreateUser.Location = new System.Drawing.Point(560, 167);
            this.ButtonCreateUser.Name = "ButtonCreateUser";
            this.ButtonCreateUser.Size = new System.Drawing.Size(105, 32);
            this.ButtonCreateUser.TabIndex = 33;
            this.ButtonCreateUser.Text = "Créer";
            this.ButtonCreateUser.UseVisualStyleBackColor = true;
            this.ButtonCreateUser.Click += new System.EventHandler(this.ButtonCreateUser_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxFirstNameUser);
            this.groupBox1.Location = new System.Drawing.Point(30, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 67);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prénom de l\'utilisateur";
            // 
            // textBoxFirstNameUser
            // 
            this.textBoxFirstNameUser.Location = new System.Drawing.Point(6, 31);
            this.textBoxFirstNameUser.MaxLength = 20;
            this.textBoxFirstNameUser.Name = "textBoxFirstNameUser";
            this.textBoxFirstNameUser.Size = new System.Drawing.Size(191, 20);
            this.textBoxFirstNameUser.TabIndex = 2;
            // 
            // groupBoxRankForUser
            // 
            this.groupBoxRankForUser.Controls.Add(this.comboBoxRankForUser);
            this.groupBoxRankForUser.Location = new System.Drawing.Point(30, 148);
            this.groupBoxRankForUser.Name = "groupBoxRankForUser";
            this.groupBoxRankForUser.Size = new System.Drawing.Size(203, 51);
            this.groupBoxRankForUser.TabIndex = 30;
            this.groupBoxRankForUser.TabStop = false;
            this.groupBoxRankForUser.Text = "Définir le niveau d\'accès";
            // 
            // comboBoxRankForUser
            // 
            this.comboBoxRankForUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRankForUser.FormattingEnabled = true;
            this.comboBoxRankForUser.Items.AddRange(new object[] {
            "Technicien",
            "Magasinier",
            "Administrateur"});
            this.comboBoxRankForUser.Location = new System.Drawing.Point(6, 19);
            this.comboBoxRankForUser.Name = "comboBoxRankForUser";
            this.comboBoxRankForUser.Size = new System.Drawing.Size(185, 21);
            this.comboBoxRankForUser.TabIndex = 2;
            // 
            // groupBoxPasswordForUser
            // 
            this.groupBoxPasswordForUser.Controls.Add(this.textBoxPasswordUser);
            this.groupBoxPasswordForUser.Location = new System.Drawing.Point(520, 66);
            this.groupBoxPasswordForUser.Name = "groupBoxPasswordForUser";
            this.groupBoxPasswordForUser.Size = new System.Drawing.Size(203, 67);
            this.groupBoxPasswordForUser.TabIndex = 29;
            this.groupBoxPasswordForUser.TabStop = false;
            this.groupBoxPasswordForUser.Text = "Mot de passe de l\'utilisateur";
            // 
            // textBoxPasswordUser
            // 
            this.textBoxPasswordUser.Location = new System.Drawing.Point(6, 31);
            this.textBoxPasswordUser.MaxLength = 20;
            this.textBoxPasswordUser.Name = "textBoxPasswordUser";
            this.textBoxPasswordUser.Size = new System.Drawing.Size(191, 20);
            this.textBoxPasswordUser.TabIndex = 3;
            // 
            // groupBoxLastNameUser
            // 
            this.groupBoxLastNameUser.Controls.Add(this.textBoxLastNameUser);
            this.groupBoxLastNameUser.Location = new System.Drawing.Point(268, 66);
            this.groupBoxLastNameUser.Name = "groupBoxLastNameUser";
            this.groupBoxLastNameUser.Size = new System.Drawing.Size(203, 67);
            this.groupBoxLastNameUser.TabIndex = 28;
            this.groupBoxLastNameUser.TabStop = false;
            this.groupBoxLastNameUser.Text = "Nom de l\'utilisateur";
            // 
            // textBoxLastNameUser
            // 
            this.textBoxLastNameUser.Location = new System.Drawing.Point(6, 31);
            this.textBoxLastNameUser.MaxLength = 20;
            this.textBoxLastNameUser.Name = "textBoxLastNameUser";
            this.textBoxLastNameUser.Size = new System.Drawing.Size(191, 20);
            this.textBoxLastNameUser.TabIndex = 3;
            // 
            // labelHeaderUser
            // 
            this.labelHeaderUser.AutoSize = true;
            this.labelHeaderUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderUser.Location = new System.Drawing.Point(29, 26);
            this.labelHeaderUser.Name = "labelHeaderUser";
            this.labelHeaderUser.Size = new System.Drawing.Size(177, 20);
            this.labelHeaderUser.TabIndex = 50;
            this.labelHeaderUser.Text = "Créer un utilisateur : ";
            // 
            // UserCreerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 233);
            this.Controls.Add(this.labelHeaderUser);
            this.Controls.Add(this.ButtonCreateUser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxRankForUser);
            this.Controls.Add(this.groupBoxPasswordForUser);
            this.Controls.Add(this.groupBoxLastNameUser);
            this.Name = "UserCreerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserCreerForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxRankForUser.ResumeLayout(false);
            this.groupBoxPasswordForUser.ResumeLayout(false);
            this.groupBoxPasswordForUser.PerformLayout();
            this.groupBoxLastNameUser.ResumeLayout(false);
            this.groupBoxLastNameUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCreateUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxFirstNameUser;
        private System.Windows.Forms.GroupBox groupBoxRankForUser;
        private System.Windows.Forms.ComboBox comboBoxRankForUser;
        private System.Windows.Forms.GroupBox groupBoxPasswordForUser;
        private System.Windows.Forms.TextBox textBoxPasswordUser;
        private System.Windows.Forms.GroupBox groupBoxLastNameUser;
        private System.Windows.Forms.TextBox textBoxLastNameUser;
        private System.Windows.Forms.Label labelHeaderUser;
    }
}