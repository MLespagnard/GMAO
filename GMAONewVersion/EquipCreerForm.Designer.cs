namespace GMAONewVersion
{
    partial class EquipCreerForm
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
            this.groupBoxUsureEquip = new System.Windows.Forms.GroupBox();
            this.textBoxUsureEquip = new System.Windows.Forms.TextBox();
            this.groupBoxModelEquip = new System.Windows.Forms.GroupBox();
            this.textBoxModelEquip = new System.Windows.Forms.TextBox();
            this.groupBoxConstructeurEquip = new System.Windows.Forms.GroupBox();
            this.textBoxConstructeurEquip = new System.Windows.Forms.TextBox();
            this.groupBoxNomEquip = new System.Windows.Forms.GroupBox();
            this.textBoxNomEquip = new System.Windows.Forms.TextBox();
            this.labelHeaderEquip = new System.Windows.Forms.Label();
            this.ButtonEquipCreer = new System.Windows.Forms.Button();
            this.groupBoxUsureEquip.SuspendLayout();
            this.groupBoxModelEquip.SuspendLayout();
            this.groupBoxConstructeurEquip.SuspendLayout();
            this.groupBoxNomEquip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUsureEquip
            // 
            this.groupBoxUsureEquip.Controls.Add(this.textBoxUsureEquip);
            this.groupBoxUsureEquip.Location = new System.Drawing.Point(555, 85);
            this.groupBoxUsureEquip.Name = "groupBoxUsureEquip";
            this.groupBoxUsureEquip.Size = new System.Drawing.Size(185, 53);
            this.groupBoxUsureEquip.TabIndex = 53;
            this.groupBoxUsureEquip.TabStop = false;
            this.groupBoxUsureEquip.Text = "Nombres d\'heures sur l\'équipement";
            // 
            // textBoxUsureEquip
            // 
            this.textBoxUsureEquip.Location = new System.Drawing.Point(6, 19);
            this.textBoxUsureEquip.Name = "textBoxUsureEquip";
            this.textBoxUsureEquip.Size = new System.Drawing.Size(173, 20);
            this.textBoxUsureEquip.TabIndex = 0;
            this.textBoxUsureEquip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUsureEquip_KeyPress);
            // 
            // groupBoxModelEquip
            // 
            this.groupBoxModelEquip.Controls.Add(this.textBoxModelEquip);
            this.groupBoxModelEquip.Location = new System.Drawing.Point(383, 85);
            this.groupBoxModelEquip.Name = "groupBoxModelEquip";
            this.groupBoxModelEquip.Size = new System.Drawing.Size(149, 53);
            this.groupBoxModelEquip.TabIndex = 52;
            this.groupBoxModelEquip.TabStop = false;
            this.groupBoxModelEquip.Text = "Model de l\'équipement";
            // 
            // textBoxModelEquip
            // 
            this.textBoxModelEquip.Location = new System.Drawing.Point(6, 19);
            this.textBoxModelEquip.Name = "textBoxModelEquip";
            this.textBoxModelEquip.Size = new System.Drawing.Size(137, 20);
            this.textBoxModelEquip.TabIndex = 0;
            // 
            // groupBoxConstructeurEquip
            // 
            this.groupBoxConstructeurEquip.Controls.Add(this.textBoxConstructeurEquip);
            this.groupBoxConstructeurEquip.Location = new System.Drawing.Point(186, 85);
            this.groupBoxConstructeurEquip.Name = "groupBoxConstructeurEquip";
            this.groupBoxConstructeurEquip.Size = new System.Drawing.Size(161, 53);
            this.groupBoxConstructeurEquip.TabIndex = 51;
            this.groupBoxConstructeurEquip.TabStop = false;
            this.groupBoxConstructeurEquip.Text = "Constructeur de l\'équipement";
            // 
            // textBoxConstructeurEquip
            // 
            this.textBoxConstructeurEquip.Location = new System.Drawing.Point(6, 19);
            this.textBoxConstructeurEquip.Name = "textBoxConstructeurEquip";
            this.textBoxConstructeurEquip.Size = new System.Drawing.Size(146, 20);
            this.textBoxConstructeurEquip.TabIndex = 0;
            // 
            // groupBoxNomEquip
            // 
            this.groupBoxNomEquip.Controls.Add(this.textBoxNomEquip);
            this.groupBoxNomEquip.Location = new System.Drawing.Point(12, 85);
            this.groupBoxNomEquip.Name = "groupBoxNomEquip";
            this.groupBoxNomEquip.Size = new System.Drawing.Size(144, 53);
            this.groupBoxNomEquip.TabIndex = 50;
            this.groupBoxNomEquip.TabStop = false;
            this.groupBoxNomEquip.Text = "Nom de l\'équipement";
            // 
            // textBoxNomEquip
            // 
            this.textBoxNomEquip.Location = new System.Drawing.Point(6, 19);
            this.textBoxNomEquip.Name = "textBoxNomEquip";
            this.textBoxNomEquip.Size = new System.Drawing.Size(132, 20);
            this.textBoxNomEquip.TabIndex = 0;
            // 
            // labelHeaderEquip
            // 
            this.labelHeaderEquip.AutoSize = true;
            this.labelHeaderEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderEquip.Location = new System.Drawing.Point(14, 27);
            this.labelHeaderEquip.Name = "labelHeaderEquip";
            this.labelHeaderEquip.Size = new System.Drawing.Size(192, 20);
            this.labelHeaderEquip.TabIndex = 49;
            this.labelHeaderEquip.Text = "Créer un équipement : ";
            // 
            // ButtonEquipCreer
            // 
            this.ButtonEquipCreer.Location = new System.Drawing.Point(600, 158);
            this.ButtonEquipCreer.Name = "ButtonEquipCreer";
            this.ButtonEquipCreer.Size = new System.Drawing.Size(82, 28);
            this.ButtonEquipCreer.TabIndex = 54;
            this.ButtonEquipCreer.Text = "Créer";
            this.ButtonEquipCreer.UseVisualStyleBackColor = true;
            this.ButtonEquipCreer.Click += new System.EventHandler(this.ButtonEquipCreerValider_Click);
            // 
            // EquipCreerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 211);
            this.Controls.Add(this.ButtonEquipCreer);
            this.Controls.Add(this.groupBoxUsureEquip);
            this.Controls.Add(this.groupBoxModelEquip);
            this.Controls.Add(this.groupBoxConstructeurEquip);
            this.Controls.Add(this.groupBoxNomEquip);
            this.Controls.Add(this.labelHeaderEquip);
            this.Name = "EquipCreerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EquipCreerForm";
            this.groupBoxUsureEquip.ResumeLayout(false);
            this.groupBoxUsureEquip.PerformLayout();
            this.groupBoxModelEquip.ResumeLayout(false);
            this.groupBoxModelEquip.PerformLayout();
            this.groupBoxConstructeurEquip.ResumeLayout(false);
            this.groupBoxConstructeurEquip.PerformLayout();
            this.groupBoxNomEquip.ResumeLayout(false);
            this.groupBoxNomEquip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUsureEquip;
        private System.Windows.Forms.TextBox textBoxUsureEquip;
        private System.Windows.Forms.GroupBox groupBoxModelEquip;
        private System.Windows.Forms.TextBox textBoxModelEquip;
        private System.Windows.Forms.GroupBox groupBoxConstructeurEquip;
        private System.Windows.Forms.TextBox textBoxConstructeurEquip;
        private System.Windows.Forms.GroupBox groupBoxNomEquip;
        private System.Windows.Forms.TextBox textBoxNomEquip;
        private System.Windows.Forms.Label labelHeaderEquip;
        private System.Windows.Forms.Button ButtonEquipCreer;
    }
}