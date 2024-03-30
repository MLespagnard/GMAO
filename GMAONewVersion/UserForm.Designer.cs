namespace GMAONewVersion
{
    partial class UserForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelForCreatingUser = new System.Windows.Forms.Label();
            this.groupBoxRankForUser = new System.Windows.Forms.GroupBox();
            this.comboBoxRankForUser = new System.Windows.Forms.ComboBox();
            this.groupBoxPasswordForUser = new System.Windows.Forms.GroupBox();
            this.textBoxPasswordUser = new System.Windows.Forms.TextBox();
            this.groupBoxLastNameUser = new System.Windows.Forms.GroupBox();
            this.textBoxLastNameUser = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxFirstNameUser = new System.Windows.Forms.TextBox();
            this.ButtonCreateUser = new System.Windows.Forms.Button();
            this.DataGridViewUser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelUser = new System.Windows.Forms.Label();
            this.checkBoxShowArchivageUser = new System.Windows.Forms.CheckBox();
            this.groupBoxRankForUser.SuspendLayout();
            this.groupBoxPasswordForUser.SuspendLayout();
            this.groupBoxLastNameUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // labelForCreatingUser
            // 
            this.labelForCreatingUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelForCreatingUser.AutoSize = true;
            this.labelForCreatingUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelForCreatingUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelForCreatingUser.Location = new System.Drawing.Point(27, 55);
            this.labelForCreatingUser.Name = "labelForCreatingUser";
            this.labelForCreatingUser.Size = new System.Drawing.Size(165, 18);
            this.labelForCreatingUser.TabIndex = 25;
            this.labelForCreatingUser.Text = "Création d\'un utilisateur:";
            // 
            // groupBoxRankForUser
            // 
            this.groupBoxRankForUser.Controls.Add(this.comboBoxRankForUser);
            this.groupBoxRankForUser.Location = new System.Drawing.Point(30, 167);
            this.groupBoxRankForUser.Name = "groupBoxRankForUser";
            this.groupBoxRankForUser.Size = new System.Drawing.Size(203, 51);
            this.groupBoxRankForUser.TabIndex = 24;
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
            this.groupBoxPasswordForUser.Location = new System.Drawing.Point(520, 85);
            this.groupBoxPasswordForUser.Name = "groupBoxPasswordForUser";
            this.groupBoxPasswordForUser.Size = new System.Drawing.Size(203, 67);
            this.groupBoxPasswordForUser.TabIndex = 23;
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
            this.groupBoxLastNameUser.Location = new System.Drawing.Point(268, 85);
            this.groupBoxLastNameUser.Name = "groupBoxLastNameUser";
            this.groupBoxLastNameUser.Size = new System.Drawing.Size(203, 67);
            this.groupBoxLastNameUser.TabIndex = 22;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxFirstNameUser);
            this.groupBox1.Location = new System.Drawing.Point(30, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 67);
            this.groupBox1.TabIndex = 26;
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
            // ButtonCreateUser
            // 
            this.ButtonCreateUser.Location = new System.Drawing.Point(316, 186);
            this.ButtonCreateUser.Name = "ButtonCreateUser";
            this.ButtonCreateUser.Size = new System.Drawing.Size(105, 32);
            this.ButtonCreateUser.TabIndex = 27;
            this.ButtonCreateUser.Text = "Créer";
            this.ButtonCreateUser.UseVisualStyleBackColor = true;
            this.ButtonCreateUser.Click += new System.EventHandler(this.kryptonButtonCreateUser_Click);
            // 
            // DataGridViewUser
            // 
            this.DataGridViewUser.AllowUserToAddRows = false;
            this.DataGridViewUser.AllowUserToDeleteRows = false;
            this.DataGridViewUser.AllowUserToOrderColumns = true;
            this.DataGridViewUser.AllowUserToResizeColumns = false;
            this.DataGridViewUser.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridViewUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGridViewUser.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewUser.ColumnHeadersHeight = 35;
            this.DataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DataGridViewUser.Location = new System.Drawing.Point(0, 240);
            this.DataGridViewUser.Name = "DataGridViewUser";
            this.DataGridViewUser.RowHeadersVisible = false;
            this.DataGridViewUser.RowTemplate.ReadOnly = true;
            this.DataGridViewUser.Size = new System.Drawing.Size(753, 375);
            this.DataGridViewUser.TabIndex = 28;
            this.DataGridViewUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridUser_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // labelUser
            // 
            this.labelUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelUser.Location = new System.Drawing.Point(311, 9);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(107, 25);
            this.labelUser.TabIndex = 29;
            this.labelUser.Text = "Utilisateurs";
            // 
            // checkBoxShowArchivageUser
            // 
            this.checkBoxShowArchivageUser.AutoSize = true;
            this.checkBoxShowArchivageUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxShowArchivageUser.Location = new System.Drawing.Point(608, 217);
            this.checkBoxShowArchivageUser.Name = "checkBoxShowArchivageUser";
            this.checkBoxShowArchivageUser.Size = new System.Drawing.Size(129, 17);
            this.checkBoxShowArchivageUser.TabIndex = 30;
            this.checkBoxShowArchivageUser.Text = "Visualiser les archives";
            this.checkBoxShowArchivageUser.UseVisualStyleBackColor = true;
            this.checkBoxShowArchivageUser.CheckedChanged += new System.EventHandler(this.checkBoxShowArchivageBT_CheckedChanged);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 611);
            this.Controls.Add(this.checkBoxShowArchivageUser);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.DataGridViewUser);
            this.Controls.Add(this.ButtonCreateUser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelForCreatingUser);
            this.Controls.Add(this.groupBoxRankForUser);
            this.Controls.Add(this.groupBoxPasswordForUser);
            this.Controls.Add(this.groupBoxLastNameUser);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.groupBoxRankForUser.ResumeLayout(false);
            this.groupBoxPasswordForUser.ResumeLayout(false);
            this.groupBoxPasswordForUser.PerformLayout();
            this.groupBoxLastNameUser.ResumeLayout(false);
            this.groupBoxLastNameUser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelForCreatingUser;
        private System.Windows.Forms.GroupBox groupBoxRankForUser;
        private System.Windows.Forms.ComboBox comboBoxRankForUser;
        private System.Windows.Forms.GroupBox groupBoxPasswordForUser;
        private System.Windows.Forms.TextBox textBoxPasswordUser;
        private System.Windows.Forms.GroupBox groupBoxLastNameUser;
        private System.Windows.Forms.TextBox textBoxLastNameUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxFirstNameUser;
        private System.Windows.Forms.Button ButtonCreateUser;
        private System.Windows.Forms.DataGridView DataGridViewUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.CheckBox checkBoxShowArchivageUser;
    }
}