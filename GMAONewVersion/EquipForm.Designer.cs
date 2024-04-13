namespace GMAONewVersion
{
    partial class EquipForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridEquip = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelUser = new System.Windows.Forms.Label();
            this.ButtonOpenFormCreerEquip = new System.Windows.Forms.Button();
            this.checkBoxShowArchivageEquip = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEquip)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridEquip
            // 
            this.DataGridEquip.AllowUserToAddRows = false;
            this.DataGridEquip.AllowUserToDeleteRows = false;
            this.DataGridEquip.AllowUserToOrderColumns = true;
            this.DataGridEquip.AllowUserToResizeColumns = false;
            this.DataGridEquip.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridEquip.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridEquip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridEquip.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGridEquip.BackgroundColor = System.Drawing.Color.White;
            this.DataGridEquip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridEquip.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridEquip.ColumnHeadersHeight = 35;
            this.DataGridEquip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DataGridEquip.Location = new System.Drawing.Point(0, 112);
            this.DataGridEquip.Name = "DataGridEquip";
            this.DataGridEquip.RowHeadersVisible = false;
            this.DataGridEquip.RowTemplate.ReadOnly = true;
            this.DataGridEquip.Size = new System.Drawing.Size(753, 503);
            this.DataGridEquip.TabIndex = 1;
            this.DataGridEquip.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridEquip_CellClick);
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
            this.labelUser.Location = new System.Drawing.Point(301, 9);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(121, 25);
            this.labelUser.TabIndex = 33;
            this.labelUser.Text = "Equipements";
            // 
            // ButtonOpenFormCreerEquip
            // 
            this.ButtonOpenFormCreerEquip.Location = new System.Drawing.Point(17, 56);
            this.ButtonOpenFormCreerEquip.Name = "ButtonOpenFormCreerEquip";
            this.ButtonOpenFormCreerEquip.Size = new System.Drawing.Size(125, 34);
            this.ButtonOpenFormCreerEquip.TabIndex = 32;
            this.ButtonOpenFormCreerEquip.Text = "Créer un équipement";
            this.ButtonOpenFormCreerEquip.UseVisualStyleBackColor = true;
            this.ButtonOpenFormCreerEquip.Click += new System.EventHandler(this.kryptonCreerEquip_Click);
            // 
            // checkBoxShowArchivageEquip
            // 
            this.checkBoxShowArchivageEquip.AutoSize = true;
            this.checkBoxShowArchivageEquip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxShowArchivageEquip.Location = new System.Drawing.Point(595, 66);
            this.checkBoxShowArchivageEquip.Name = "checkBoxShowArchivageEquip";
            this.checkBoxShowArchivageEquip.Size = new System.Drawing.Size(129, 17);
            this.checkBoxShowArchivageEquip.TabIndex = 31;
            this.checkBoxShowArchivageEquip.Text = "Visualiser les archives";
            this.checkBoxShowArchivageEquip.UseVisualStyleBackColor = true;
            this.checkBoxShowArchivageEquip.CheckedChanged += new System.EventHandler(this.checkBoxShowArchivageEquip_CheckedChanged);
            // 
            // EquipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 611);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.ButtonOpenFormCreerEquip);
            this.Controls.Add(this.checkBoxShowArchivageEquip);
            this.Controls.Add(this.DataGridEquip);
            this.Name = "EquipForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EquipForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEquip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridEquip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button ButtonOpenFormCreerEquip;
        private System.Windows.Forms.CheckBox checkBoxShowArchivageEquip;
    }
}