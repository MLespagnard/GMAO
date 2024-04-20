namespace GMAONewVersion
{
    partial class BTForm
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
            this.DataGridBT = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxShowArchivageBT = new System.Windows.Forms.CheckBox();
            this.ButtonOpenFormCreerBT = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.labelUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBT)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridBT
            // 
            this.DataGridBT.AllowUserToAddRows = false;
            this.DataGridBT.AllowUserToDeleteRows = false;
            this.DataGridBT.AllowUserToOrderColumns = true;
            this.DataGridBT.AllowUserToResizeColumns = false;
            this.DataGridBT.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridBT.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridBT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridBT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGridBT.BackgroundColor = System.Drawing.Color.White;
            this.DataGridBT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridBT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridBT.ColumnHeadersHeight = 35;
            this.DataGridBT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DataGridBT.Location = new System.Drawing.Point(5, 112);
            this.DataGridBT.Name = "DataGridBT";
            this.DataGridBT.RowHeadersVisible = false;
            this.DataGridBT.RowTemplate.ReadOnly = true;
            this.DataGridBT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridBT.Size = new System.Drawing.Size(741, 503);
            this.DataGridBT.TabIndex = 0;
            this.DataGridBT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridBT_CellContentClick);
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
            // checkBoxShowArchivageBT
            // 
            this.checkBoxShowArchivageBT.AutoSize = true;
            this.checkBoxShowArchivageBT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxShowArchivageBT.Location = new System.Drawing.Point(595, 66);
            this.checkBoxShowArchivageBT.Name = "checkBoxShowArchivageBT";
            this.checkBoxShowArchivageBT.Size = new System.Drawing.Size(129, 17);
            this.checkBoxShowArchivageBT.TabIndex = 7;
            this.checkBoxShowArchivageBT.Text = "Visualiser les archives";
            this.checkBoxShowArchivageBT.UseVisualStyleBackColor = true;
            this.checkBoxShowArchivageBT.CheckedChanged += new System.EventHandler(this.checkBoxShowArchivageBT_CheckedChanged);
            // 
            // ButtonOpenFormCreerBT
            // 
            this.ButtonOpenFormCreerBT.Location = new System.Drawing.Point(17, 56);
            this.ButtonOpenFormCreerBT.Name = "ButtonOpenFormCreerBT";
            this.ButtonOpenFormCreerBT.Size = new System.Drawing.Size(125, 34);
            this.ButtonOpenFormCreerBT.TabIndex = 8;
            this.ButtonOpenFormCreerBT.Text = "Créer un bon de travail";
            this.ButtonOpenFormCreerBT.UseVisualStyleBackColor = true;
            this.ButtonOpenFormCreerBT.Click += new System.EventHandler(this.ButtonOpenFormCreerBT_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // labelUser
            // 
            this.labelUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelUser.Location = new System.Drawing.Point(301, 9);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(135, 25);
            this.labelUser.TabIndex = 30;
            this.labelUser.Text = "Bons de travail";
            // 
            // BTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 611);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.ButtonOpenFormCreerBT);
            this.Controls.Add(this.checkBoxShowArchivageBT);
            this.Controls.Add(this.DataGridBT);
            this.Name = "BTForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BTForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridBT;
        private System.Windows.Forms.CheckBox checkBoxShowArchivageBT;
        private System.Windows.Forms.Button ButtonOpenFormCreerBT;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label labelUser;
    }
}