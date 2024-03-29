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
            this.DataGridBT = new System.Windows.Forms.DataGridView();
            this.checkBoxShowArchivageBT = new System.Windows.Forms.CheckBox();
            this.ButtonOpenFormCreerBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBT)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridBT
            // 
            this.DataGridBT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridBT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridBT.Location = new System.Drawing.Point(0, 112);
            this.DataGridBT.Name = "DataGridBT";
            this.DataGridBT.Size = new System.Drawing.Size(753, 503);
            this.DataGridBT.TabIndex = 0;
            this.DataGridBT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridBT_CellContentClick);
            // 
            // checkBoxShowArchivageBT
            // 
            this.checkBoxShowArchivageBT.AutoSize = true;
            this.checkBoxShowArchivageBT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxShowArchivageBT.Location = new System.Drawing.Point(595, 56);
            this.checkBoxShowArchivageBT.Name = "checkBoxShowArchivageBT";
            this.checkBoxShowArchivageBT.Size = new System.Drawing.Size(129, 17);
            this.checkBoxShowArchivageBT.TabIndex = 7;
            this.checkBoxShowArchivageBT.Text = "Visualiser les archives";
            this.checkBoxShowArchivageBT.UseVisualStyleBackColor = true;
            // 
            // ButtonOpenFormCreerBT
            // 
            this.ButtonOpenFormCreerBT.Location = new System.Drawing.Point(32, 39);
            this.ButtonOpenFormCreerBT.Name = "ButtonOpenFormCreerBT";
            this.ButtonOpenFormCreerBT.Size = new System.Drawing.Size(125, 34);
            this.ButtonOpenFormCreerBT.TabIndex = 8;
            this.ButtonOpenFormCreerBT.Text = "Créer un bon de travail";
            this.ButtonOpenFormCreerBT.UseVisualStyleBackColor = true;
            // 
            // BTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 611);
            this.Controls.Add(this.ButtonOpenFormCreerBT);
            this.Controls.Add(this.checkBoxShowArchivageBT);
            this.Controls.Add(this.DataGridBT);
            this.Name = "BTForm";
            this.Text = "BTForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridBT;
        private System.Windows.Forms.CheckBox checkBoxShowArchivageBT;
        private System.Windows.Forms.Button ButtonOpenFormCreerBT;
    }
}