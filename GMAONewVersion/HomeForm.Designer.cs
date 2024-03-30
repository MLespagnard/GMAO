namespace GMAONewVersion
{
    partial class HomeForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.buttonBT = new System.Windows.Forms.Button();
            this.buttonPR = new System.Windows.Forms.Button();
            this.buttonEquip = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(109, 71);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(104, 22);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Bienvenue";
            // 
            // buttonBT
            // 
            this.buttonBT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonBT.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBT.Location = new System.Drawing.Point(113, 400);
            this.buttonBT.Name = "buttonBT";
            this.buttonBT.Size = new System.Drawing.Size(189, 107);
            this.buttonBT.TabIndex = 1;
            this.buttonBT.Text = "Bons de travail";
            this.buttonBT.UseVisualStyleBackColor = false;
            this.buttonBT.Click += new System.EventHandler(this.buttonBT_Click);
            // 
            // buttonPR
            // 
            this.buttonPR.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonPR.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPR.Location = new System.Drawing.Point(461, 179);
            this.buttonPR.Name = "buttonPR";
            this.buttonPR.Size = new System.Drawing.Size(189, 107);
            this.buttonPR.TabIndex = 2;
            this.buttonPR.Text = "Pièces de rechange";
            this.buttonPR.UseVisualStyleBackColor = false;
            this.buttonPR.Click += new System.EventHandler(this.buttonPR_Click);
            // 
            // buttonEquip
            // 
            this.buttonEquip.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonEquip.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEquip.Location = new System.Drawing.Point(113, 179);
            this.buttonEquip.Name = "buttonEquip";
            this.buttonEquip.Size = new System.Drawing.Size(189, 107);
            this.buttonEquip.TabIndex = 3;
            this.buttonEquip.Text = "Equipements";
            this.buttonEquip.UseVisualStyleBackColor = false;
            this.buttonEquip.Click += new System.EventHandler(this.buttonEquip_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonUser.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUser.Location = new System.Drawing.Point(461, 400);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(189, 107);
            this.buttonUser.TabIndex = 4;
            this.buttonUser.Text = "Gestion des utilisateurs";
            this.buttonUser.UseVisualStyleBackColor = false;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 611);
            this.Controls.Add(this.buttonUser);
            this.Controls.Add(this.buttonEquip);
            this.Controls.Add(this.buttonPR);
            this.Controls.Add(this.buttonBT);
            this.Controls.Add(this.labelName);
            this.Name = "HomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonBT;
        private System.Windows.Forms.Button buttonPR;
        private System.Windows.Forms.Button buttonEquip;
        private System.Windows.Forms.Button buttonUser;
    }
}