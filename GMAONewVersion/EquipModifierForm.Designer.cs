namespace GMAONewVersion
{
    partial class EquipModifierForm
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
            this.groupBoxNomEquip = new System.Windows.Forms.GroupBox();
            this.textBoxNomEquip = new System.Windows.Forms.TextBox();
            this.labelHeaderEquip = new System.Windows.Forms.Label();
            this.groupBoxConstructeurEquip = new System.Windows.Forms.GroupBox();
            this.textBoxConstructeurEquip = new System.Windows.Forms.TextBox();
            this.groupBoxModelEquip = new System.Windows.Forms.GroupBox();
            this.textBoxModelEquip = new System.Windows.Forms.TextBox();
            this.groupBoxUsureEquip = new System.Windows.Forms.GroupBox();
            this.textBoxUsureEquip = new System.Windows.Forms.TextBox();
            this.ButtonEquipModifier = new System.Windows.Forms.Button();
            this.groupBoxNomEquip.SuspendLayout();
            this.groupBoxConstructeurEquip.SuspendLayout();
            this.groupBoxModelEquip.SuspendLayout();
            this.groupBoxUsureEquip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNomEquip
            // 
            this.groupBoxNomEquip.Controls.Add(this.textBoxNomEquip);
            this.groupBoxNomEquip.Location = new System.Drawing.Point(16, 86);
            this.groupBoxNomEquip.Name = "groupBoxNomEquip";
            this.groupBoxNomEquip.Size = new System.Drawing.Size(144, 53);
            this.groupBoxNomEquip.TabIndex = 56;
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
            this.labelHeaderEquip.Size = new System.Drawing.Size(195, 20);
            this.labelHeaderEquip.TabIndex = 55;
            this.labelHeaderEquip.Text = "Modifier l\'équipement : ";
            // 
            // groupBoxConstructeurEquip
            // 
            this.groupBoxConstructeurEquip.Controls.Add(this.textBoxConstructeurEquip);
            this.groupBoxConstructeurEquip.Location = new System.Drawing.Point(188, 86);
            this.groupBoxConstructeurEquip.Name = "groupBoxConstructeurEquip";
            this.groupBoxConstructeurEquip.Size = new System.Drawing.Size(161, 53);
            this.groupBoxConstructeurEquip.TabIndex = 57;
            this.groupBoxConstructeurEquip.TabStop = false;
            this.groupBoxConstructeurEquip.Text = "Constructeur de l\'équipement";
            // 
            // textBoxConstructeurEquip
            // 
            this.textBoxConstructeurEquip.Location = new System.Drawing.Point(6, 19);
            this.textBoxConstructeurEquip.Name = "textBoxConstructeurEquip";
            this.textBoxConstructeurEquip.Size = new System.Drawing.Size(144, 20);
            this.textBoxConstructeurEquip.TabIndex = 0;
            // 
            // groupBoxModelEquip
            // 
            this.groupBoxModelEquip.Controls.Add(this.textBoxModelEquip);
            this.groupBoxModelEquip.Location = new System.Drawing.Point(378, 86);
            this.groupBoxModelEquip.Name = "groupBoxModelEquip";
            this.groupBoxModelEquip.Size = new System.Drawing.Size(149, 53);
            this.groupBoxModelEquip.TabIndex = 58;
            this.groupBoxModelEquip.TabStop = false;
            this.groupBoxModelEquip.Text = "Model de l\'équipement";
            // 
            // textBoxModelEquip
            // 
            this.textBoxModelEquip.Location = new System.Drawing.Point(13, 19);
            this.textBoxModelEquip.Name = "textBoxModelEquip";
            this.textBoxModelEquip.Size = new System.Drawing.Size(130, 20);
            this.textBoxModelEquip.TabIndex = 0;
            // 
            // groupBoxUsureEquip
            // 
            this.groupBoxUsureEquip.Controls.Add(this.textBoxUsureEquip);
            this.groupBoxUsureEquip.Location = new System.Drawing.Point(551, 86);
            this.groupBoxUsureEquip.Name = "groupBoxUsureEquip";
            this.groupBoxUsureEquip.Size = new System.Drawing.Size(186, 53);
            this.groupBoxUsureEquip.TabIndex = 59;
            this.groupBoxUsureEquip.TabStop = false;
            this.groupBoxUsureEquip.Text = "Nombres d\'heures sur l\'équipement";
            // 
            // textBoxUsureEquip
            // 
            this.textBoxUsureEquip.Location = new System.Drawing.Point(6, 19);
            this.textBoxUsureEquip.Name = "textBoxUsureEquip";
            this.textBoxUsureEquip.Size = new System.Drawing.Size(174, 20);
            this.textBoxUsureEquip.TabIndex = 0;
            this.textBoxUsureEquip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUsureEquip_KeyPress);
            // 
            // ButtonEquipModifier
            // 
            this.ButtonEquipModifier.BackColor = System.Drawing.Color.DarkGray;
            this.ButtonEquipModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEquipModifier.Location = new System.Drawing.Point(609, 157);
            this.ButtonEquipModifier.Name = "ButtonEquipModifier";
            this.ButtonEquipModifier.Size = new System.Drawing.Size(122, 42);
            this.ButtonEquipModifier.TabIndex = 60;
            this.ButtonEquipModifier.Text = "Modifier";
            this.ButtonEquipModifier.UseVisualStyleBackColor = false;
            this.ButtonEquipModifier.Click += new System.EventHandler(this.ButtonEquipModifier_Click);
            // 
            // EquipModifierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 211);
            this.Controls.Add(this.ButtonEquipModifier);
            this.Controls.Add(this.groupBoxNomEquip);
            this.Controls.Add(this.labelHeaderEquip);
            this.Controls.Add(this.groupBoxConstructeurEquip);
            this.Controls.Add(this.groupBoxModelEquip);
            this.Controls.Add(this.groupBoxUsureEquip);
            this.Name = "EquipModifierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier un équipement";
            this.groupBoxNomEquip.ResumeLayout(false);
            this.groupBoxNomEquip.PerformLayout();
            this.groupBoxConstructeurEquip.ResumeLayout(false);
            this.groupBoxConstructeurEquip.PerformLayout();
            this.groupBoxModelEquip.ResumeLayout(false);
            this.groupBoxModelEquip.PerformLayout();
            this.groupBoxUsureEquip.ResumeLayout(false);
            this.groupBoxUsureEquip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNomEquip;
        private System.Windows.Forms.TextBox textBoxNomEquip;
        private System.Windows.Forms.Label labelHeaderEquip;
        private System.Windows.Forms.GroupBox groupBoxConstructeurEquip;
        private System.Windows.Forms.TextBox textBoxConstructeurEquip;
        private System.Windows.Forms.GroupBox groupBoxModelEquip;
        private System.Windows.Forms.TextBox textBoxModelEquip;
        private System.Windows.Forms.GroupBox groupBoxUsureEquip;
        private System.Windows.Forms.TextBox textBoxUsureEquip;
        private System.Windows.Forms.Button ButtonEquipModifier;
    }
}