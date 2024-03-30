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
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCreateUser
            // 
            this.ButtonCreateUser.Location = new System.Drawing.Point(12, 59);
            this.ButtonCreateUser.Name = "ButtonCreateUser";
            this.ButtonCreateUser.Size = new System.Drawing.Size(105, 32);
            this.ButtonCreateUser.TabIndex = 27;
            this.ButtonCreateUser.Text = "Créer";
            this.ButtonCreateUser.UseVisualStyleBackColor = true;
            this.ButtonCreateUser.Click += new System.EventHandler(this.ButtonCreateUser_Click);
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
            this.DataGridViewUser.Location = new System.Drawing.Point(0, 123);
            this.DataGridViewUser.Name = "DataGridViewUser";
            this.DataGridViewUser.RowHeadersVisible = false;
            this.DataGridViewUser.RowTemplate.ReadOnly = true;
            this.DataGridViewUser.Size = new System.Drawing.Size(753, 492);
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
            this.checkBoxShowArchivageUser.Location = new System.Drawing.Point(608, 74);
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
            this.Name = "UserForm";
            this.Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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