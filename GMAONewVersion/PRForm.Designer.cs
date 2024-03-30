namespace GMAONewVersion
{
    partial class PRForm
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
            this.DataGridPR = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelUser = new System.Windows.Forms.Label();
            this.ButtonOpenFormCreerPR = new System.Windows.Forms.Button();
            this.checkBoxShowArchivagePR = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPR)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridPR
            // 
            this.DataGridPR.AllowUserToAddRows = false;
            this.DataGridPR.AllowUserToDeleteRows = false;
            this.DataGridPR.AllowUserToOrderColumns = true;
            this.DataGridPR.AllowUserToResizeColumns = false;
            this.DataGridPR.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridPR.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridPR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridPR.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGridPR.BackgroundColor = System.Drawing.Color.White;
            this.DataGridPR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridPR.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridPR.ColumnHeadersHeight = 35;
            this.DataGridPR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DataGridPR.Location = new System.Drawing.Point(0, 112);
            this.DataGridPR.Name = "DataGridPR";
            this.DataGridPR.RowHeadersVisible = false;
            this.DataGridPR.RowTemplate.ReadOnly = true;
            this.DataGridPR.Size = new System.Drawing.Size(753, 503);
            this.DataGridPR.TabIndex = 2;
            this.DataGridPR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridPR_CellContentClick);
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
            this.labelUser.Location = new System.Drawing.Point(281, 9);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(171, 25);
            this.labelUser.TabIndex = 36;
            this.labelUser.Text = "Pièces de rechange";
            // 
            // ButtonOpenFormCreerPR
            // 
            this.ButtonOpenFormCreerPR.Location = new System.Drawing.Point(17, 56);
            this.ButtonOpenFormCreerPR.Name = "ButtonOpenFormCreerPR";
            this.ButtonOpenFormCreerPR.Size = new System.Drawing.Size(125, 34);
            this.ButtonOpenFormCreerPR.TabIndex = 35;
            this.ButtonOpenFormCreerPR.Text = "Créer un équipement";
            this.ButtonOpenFormCreerPR.UseVisualStyleBackColor = true;
            this.ButtonOpenFormCreerPR.Click += new System.EventHandler(this.ButtonCreerPR_Click);
            // 
            // checkBoxShowArchivagePR
            // 
            this.checkBoxShowArchivagePR.AutoSize = true;
            this.checkBoxShowArchivagePR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxShowArchivagePR.Location = new System.Drawing.Point(608, 66);
            this.checkBoxShowArchivagePR.Name = "checkBoxShowArchivagePR";
            this.checkBoxShowArchivagePR.Size = new System.Drawing.Size(129, 17);
            this.checkBoxShowArchivagePR.TabIndex = 34;
            this.checkBoxShowArchivagePR.Text = "Visualiser les archives";
            this.checkBoxShowArchivagePR.UseVisualStyleBackColor = true;
            this.checkBoxShowArchivagePR.CheckedChanged += new System.EventHandler(this.checkBoxShowArchivagePR_CheckedChanged);
            // 
            // PRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 611);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.ButtonOpenFormCreerPR);
            this.Controls.Add(this.checkBoxShowArchivagePR);
            this.Controls.Add(this.DataGridPR);
            this.Name = "PRForm";
            this.Text = "PRForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridPR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button ButtonOpenFormCreerPR;
        private System.Windows.Forms.CheckBox checkBoxShowArchivagePR;
    }
}