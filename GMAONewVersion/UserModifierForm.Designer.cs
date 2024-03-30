namespace GMAONewVersion
{
    partial class UserModifierForm
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
            this.groupBoxFirstNameUser = new System.Windows.Forms.GroupBox();
            this.textBoxFirstNameUser = new System.Windows.Forms.TextBox();
            this.groupBoxLastNameUser = new System.Windows.Forms.GroupBox();
            this.textBoxLastNameUser = new System.Windows.Forms.TextBox();
            this.groupBoxIdConnectionUser = new System.Windows.Forms.GroupBox();
            this.textBoxIdConnectionUser = new System.Windows.Forms.TextBox();
            this.groupBoxPasswordUser = new System.Windows.Forms.GroupBox();
            this.textBoxPasswordUser = new System.Windows.Forms.TextBox();
            this.groupBoxLevelAccesUser = new System.Windows.Forms.GroupBox();
            this.comboBoxRankForUser = new System.Windows.Forms.ComboBox();
            this.labelHeaderCreateUser = new System.Windows.Forms.Label();
            this.ButtonModifierUser = new System.Windows.Forms.Button();
            this.groupBoxFirstNameUser.SuspendLayout();
            this.groupBoxLastNameUser.SuspendLayout();
            this.groupBoxIdConnectionUser.SuspendLayout();
            this.groupBoxPasswordUser.SuspendLayout();
            this.groupBoxLevelAccesUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFirstNameUser
            // 
            this.groupBoxFirstNameUser.Controls.Add(this.textBoxFirstNameUser);
            this.groupBoxFirstNameUser.Location = new System.Drawing.Point(16, 96);
            this.groupBoxFirstNameUser.Name = "groupBoxFirstNameUser";
            this.groupBoxFirstNameUser.Size = new System.Drawing.Size(137, 55);
            this.groupBoxFirstNameUser.TabIndex = 55;
            this.groupBoxFirstNameUser.TabStop = false;
            this.groupBoxFirstNameUser.Text = "Prénom";
            // 
            // textBoxFirstNameUser
            // 
            this.textBoxFirstNameUser.Enabled = false;
            this.textBoxFirstNameUser.Location = new System.Drawing.Point(8, 23);
            this.textBoxFirstNameUser.MaxLength = 50;
            this.textBoxFirstNameUser.Name = "textBoxFirstNameUser";
            this.textBoxFirstNameUser.Size = new System.Drawing.Size(120, 20);
            this.textBoxFirstNameUser.TabIndex = 0;
            // 
            // groupBoxLastNameUser
            // 
            this.groupBoxLastNameUser.Controls.Add(this.textBoxLastNameUser);
            this.groupBoxLastNameUser.Location = new System.Drawing.Point(164, 96);
            this.groupBoxLastNameUser.Name = "groupBoxLastNameUser";
            this.groupBoxLastNameUser.Size = new System.Drawing.Size(132, 55);
            this.groupBoxLastNameUser.TabIndex = 56;
            this.groupBoxLastNameUser.TabStop = false;
            this.groupBoxLastNameUser.Text = "Nom de famille";
            // 
            // textBoxLastNameUser
            // 
            this.textBoxLastNameUser.Enabled = false;
            this.textBoxLastNameUser.Location = new System.Drawing.Point(6, 23);
            this.textBoxLastNameUser.MaxLength = 50;
            this.textBoxLastNameUser.Name = "textBoxLastNameUser";
            this.textBoxLastNameUser.Size = new System.Drawing.Size(120, 20);
            this.textBoxLastNameUser.TabIndex = 2;
            // 
            // groupBoxIdConnectionUser
            // 
            this.groupBoxIdConnectionUser.Controls.Add(this.textBoxIdConnectionUser);
            this.groupBoxIdConnectionUser.Location = new System.Drawing.Point(302, 96);
            this.groupBoxIdConnectionUser.Name = "groupBoxIdConnectionUser";
            this.groupBoxIdConnectionUser.Size = new System.Drawing.Size(137, 55);
            this.groupBoxIdConnectionUser.TabIndex = 57;
            this.groupBoxIdConnectionUser.TabStop = false;
            this.groupBoxIdConnectionUser.Text = "Nom d\'utilisateur";
            // 
            // textBoxIdConnectionUser
            // 
            this.textBoxIdConnectionUser.Enabled = false;
            this.textBoxIdConnectionUser.Location = new System.Drawing.Point(8, 23);
            this.textBoxIdConnectionUser.MaxLength = 50;
            this.textBoxIdConnectionUser.Name = "textBoxIdConnectionUser";
            this.textBoxIdConnectionUser.Size = new System.Drawing.Size(120, 20);
            this.textBoxIdConnectionUser.TabIndex = 0;
            // 
            // groupBoxPasswordUser
            // 
            this.groupBoxPasswordUser.Controls.Add(this.textBoxPasswordUser);
            this.groupBoxPasswordUser.Location = new System.Drawing.Point(445, 96);
            this.groupBoxPasswordUser.Name = "groupBoxPasswordUser";
            this.groupBoxPasswordUser.Size = new System.Drawing.Size(145, 55);
            this.groupBoxPasswordUser.TabIndex = 58;
            this.groupBoxPasswordUser.TabStop = false;
            this.groupBoxPasswordUser.Text = "Mot de passe";
            // 
            // textBoxPasswordUser
            // 
            this.textBoxPasswordUser.Location = new System.Drawing.Point(6, 23);
            this.textBoxPasswordUser.MaxLength = 50;
            this.textBoxPasswordUser.Name = "textBoxPasswordUser";
            this.textBoxPasswordUser.Size = new System.Drawing.Size(133, 20);
            this.textBoxPasswordUser.TabIndex = 2;
            // 
            // groupBoxLevelAccesUser
            // 
            this.groupBoxLevelAccesUser.Controls.Add(this.comboBoxRankForUser);
            this.groupBoxLevelAccesUser.Location = new System.Drawing.Point(596, 96);
            this.groupBoxLevelAccesUser.Name = "groupBoxLevelAccesUser";
            this.groupBoxLevelAccesUser.Size = new System.Drawing.Size(141, 55);
            this.groupBoxLevelAccesUser.TabIndex = 59;
            this.groupBoxLevelAccesUser.TabStop = false;
            this.groupBoxLevelAccesUser.Text = "Niveau d\'accès";
            // 
            // comboBoxRankForUser
            // 
            this.comboBoxRankForUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRankForUser.FormattingEnabled = true;
            this.comboBoxRankForUser.Items.AddRange(new object[] {
            "Technicien",
            "Magasinier",
            "Administrateur"});
            this.comboBoxRankForUser.Location = new System.Drawing.Point(6, 23);
            this.comboBoxRankForUser.Name = "comboBoxRankForUser";
            this.comboBoxRankForUser.Size = new System.Drawing.Size(129, 21);
            this.comboBoxRankForUser.TabIndex = 3;
            // 
            // labelHeaderCreateUser
            // 
            this.labelHeaderCreateUser.AutoSize = true;
            this.labelHeaderCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderCreateUser.Location = new System.Drawing.Point(12, 33);
            this.labelHeaderCreateUser.Name = "labelHeaderCreateUser";
            this.labelHeaderCreateUser.Size = new System.Drawing.Size(180, 20);
            this.labelHeaderCreateUser.TabIndex = 60;
            this.labelHeaderCreateUser.Text = "Modifier l\'utilisateur:  ";
            // 
            // ButtonModifierUser
            // 
            this.ButtonModifierUser.Location = new System.Drawing.Point(623, 171);
            this.ButtonModifierUser.Name = "ButtonModifierUser";
            this.ButtonModifierUser.Size = new System.Drawing.Size(82, 28);
            this.ButtonModifierUser.TabIndex = 61;
            this.ButtonModifierUser.Text = "Modifier";
            this.ButtonModifierUser.UseVisualStyleBackColor = true;
            this.ButtonModifierUser.Click += new System.EventHandler(this.ButtonModifierUser_Click);
            // 
            // UserModifierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 211);
            this.Controls.Add(this.ButtonModifierUser);
            this.Controls.Add(this.groupBoxFirstNameUser);
            this.Controls.Add(this.groupBoxLastNameUser);
            this.Controls.Add(this.groupBoxIdConnectionUser);
            this.Controls.Add(this.groupBoxPasswordUser);
            this.Controls.Add(this.groupBoxLevelAccesUser);
            this.Controls.Add(this.labelHeaderCreateUser);
            this.Name = "UserModifierForm";
            this.Text = "UserModifierForm";
            this.groupBoxFirstNameUser.ResumeLayout(false);
            this.groupBoxFirstNameUser.PerformLayout();
            this.groupBoxLastNameUser.ResumeLayout(false);
            this.groupBoxLastNameUser.PerformLayout();
            this.groupBoxIdConnectionUser.ResumeLayout(false);
            this.groupBoxIdConnectionUser.PerformLayout();
            this.groupBoxPasswordUser.ResumeLayout(false);
            this.groupBoxPasswordUser.PerformLayout();
            this.groupBoxLevelAccesUser.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFirstNameUser;
        private System.Windows.Forms.TextBox textBoxFirstNameUser;
        private System.Windows.Forms.GroupBox groupBoxLastNameUser;
        private System.Windows.Forms.TextBox textBoxLastNameUser;
        private System.Windows.Forms.GroupBox groupBoxIdConnectionUser;
        private System.Windows.Forms.TextBox textBoxIdConnectionUser;
        private System.Windows.Forms.GroupBox groupBoxPasswordUser;
        private System.Windows.Forms.TextBox textBoxPasswordUser;
        private System.Windows.Forms.GroupBox groupBoxLevelAccesUser;
        private System.Windows.Forms.ComboBox comboBoxRankForUser;
        private System.Windows.Forms.Label labelHeaderCreateUser;
        private System.Windows.Forms.Button ButtonModifierUser;
    }
}