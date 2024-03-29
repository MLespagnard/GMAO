namespace GMAONewVersion
{
    partial class BTTModifierForm
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
            this.labelHeaderBT = new System.Windows.Forms.Label();
            this.comboBoxMotifBT = new System.Windows.Forms.ComboBox();
            this.groupBoxIntituleBT = new System.Windows.Forms.GroupBox();
            this.textBoxIntituleBT = new System.Windows.Forms.TextBox();
            this.groupBoxEquipementConcerneBT = new System.Windows.Forms.GroupBox();
            this.comboBoxEquipementConcerneBT = new System.Windows.Forms.ComboBox();
            this.groupBoxPieceRechangeBT = new System.Windows.Forms.GroupBox();
            this.checkedListBoxPieceRechangeBT = new System.Windows.Forms.CheckedListBox();
            this.groupBoxNbHeuresBT = new System.Windows.Forms.GroupBox();
            this.textBoxNbHeuresBT = new System.Windows.Forms.TextBox();
            this.groupBoxMotifBT = new System.Windows.Forms.GroupBox();
            this.groupBoxTravailRealiserBT = new System.Windows.Forms.GroupBox();
            this.groupBoxNomInterBT = new System.Windows.Forms.GroupBox();
            this.comboBoxNomInterBT = new System.Windows.Forms.ComboBox();
            this.groupBoxTempsPresteBT = new System.Windows.Forms.GroupBox();
            this.textBoxTempsPresteBT = new System.Windows.Forms.TextBox();
            this.groupBoxDatePrestaBT = new System.Windows.Forms.GroupBox();
            this.groupBoxCreateurBT = new System.Windows.Forms.GroupBox();
            this.textBoxCreateurBT = new System.Windows.Forms.TextBox();
            this.groupBoxCommentaireInterBT = new System.Windows.Forms.GroupBox();
            this.RichTextBoxCommentaireInterBT = new System.Windows.Forms.RichTextBox();
            this.RichTextBoxTravailRealiserBT = new System.Windows.Forms.RichTextBox();
            this.kryptonButtonBTCreerValider = new System.Windows.Forms.Button();
            this.groupBoxIntituleBT.SuspendLayout();
            this.groupBoxEquipementConcerneBT.SuspendLayout();
            this.groupBoxPieceRechangeBT.SuspendLayout();
            this.groupBoxNbHeuresBT.SuspendLayout();
            this.groupBoxMotifBT.SuspendLayout();
            this.groupBoxTravailRealiserBT.SuspendLayout();
            this.groupBoxNomInterBT.SuspendLayout();
            this.groupBoxTempsPresteBT.SuspendLayout();
            this.groupBoxCreateurBT.SuspendLayout();
            this.groupBoxCommentaireInterBT.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHeaderBT
            // 
            this.labelHeaderBT.AutoSize = true;
            this.labelHeaderBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderBT.Location = new System.Drawing.Point(39, 25);
            this.labelHeaderBT.Name = "labelHeaderBT";
            this.labelHeaderBT.Size = new System.Drawing.Size(220, 20);
            this.labelHeaderBT.TabIndex = 54;
            this.labelHeaderBT.Text = "Modifier le bon de travail : ";
            // 
            // comboBoxMotifBT
            // 
            this.comboBoxMotifBT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMotifBT.FormattingEnabled = true;
            this.comboBoxMotifBT.Items.AddRange(new object[] {
            "Préventif",
            "Correctif",
            "Curatif"});
            this.comboBoxMotifBT.Location = new System.Drawing.Point(10, 22);
            this.comboBoxMotifBT.Name = "comboBoxMotifBT";
            this.comboBoxMotifBT.Size = new System.Drawing.Size(91, 21);
            this.comboBoxMotifBT.TabIndex = 0;
            // 
            // groupBoxIntituleBT
            // 
            this.groupBoxIntituleBT.Controls.Add(this.textBoxIntituleBT);
            this.groupBoxIntituleBT.Location = new System.Drawing.Point(189, 76);
            this.groupBoxIntituleBT.Name = "groupBoxIntituleBT";
            this.groupBoxIntituleBT.Size = new System.Drawing.Size(137, 78);
            this.groupBoxIntituleBT.TabIndex = 43;
            this.groupBoxIntituleBT.TabStop = false;
            this.groupBoxIntituleBT.Text = "Intitulé du BT";
            // 
            // textBoxIntituleBT
            // 
            this.textBoxIntituleBT.Location = new System.Drawing.Point(8, 23);
            this.textBoxIntituleBT.MaxLength = 50;
            this.textBoxIntituleBT.Name = "textBoxIntituleBT";
            this.textBoxIntituleBT.Size = new System.Drawing.Size(120, 20);
            this.textBoxIntituleBT.TabIndex = 0;
            // 
            // groupBoxEquipementConcerneBT
            // 
            this.groupBoxEquipementConcerneBT.Controls.Add(this.comboBoxEquipementConcerneBT);
            this.groupBoxEquipementConcerneBT.Location = new System.Drawing.Point(357, 76);
            this.groupBoxEquipementConcerneBT.Name = "groupBoxEquipementConcerneBT";
            this.groupBoxEquipementConcerneBT.Size = new System.Drawing.Size(132, 78);
            this.groupBoxEquipementConcerneBT.TabIndex = 44;
            this.groupBoxEquipementConcerneBT.TabStop = false;
            this.groupBoxEquipementConcerneBT.Text = "Équipement concerné";
            // 
            // comboBoxEquipementConcerneBT
            // 
            this.comboBoxEquipementConcerneBT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEquipementConcerneBT.FormattingEnabled = true;
            this.comboBoxEquipementConcerneBT.Location = new System.Drawing.Point(9, 23);
            this.comboBoxEquipementConcerneBT.Name = "comboBoxEquipementConcerneBT";
            this.comboBoxEquipementConcerneBT.Size = new System.Drawing.Size(115, 21);
            this.comboBoxEquipementConcerneBT.TabIndex = 1;
            // 
            // groupBoxPieceRechangeBT
            // 
            this.groupBoxPieceRechangeBT.Controls.Add(this.checkedListBoxPieceRechangeBT);
            this.groupBoxPieceRechangeBT.Location = new System.Drawing.Point(526, 76);
            this.groupBoxPieceRechangeBT.Name = "groupBoxPieceRechangeBT";
            this.groupBoxPieceRechangeBT.Size = new System.Drawing.Size(172, 200);
            this.groupBoxPieceRechangeBT.TabIndex = 45;
            this.groupBoxPieceRechangeBT.TabStop = false;
            this.groupBoxPieceRechangeBT.Text = " Pièces de rechange concerné";
            // 
            // checkedListBoxPieceRechangeBT
            // 
            this.checkedListBoxPieceRechangeBT.FormattingEnabled = true;
            this.checkedListBoxPieceRechangeBT.Location = new System.Drawing.Point(6, 19);
            this.checkedListBoxPieceRechangeBT.Name = "checkedListBoxPieceRechangeBT";
            this.checkedListBoxPieceRechangeBT.Size = new System.Drawing.Size(160, 154);
            this.checkedListBoxPieceRechangeBT.TabIndex = 0;
            // 
            // groupBoxNbHeuresBT
            // 
            this.groupBoxNbHeuresBT.Controls.Add(this.textBoxNbHeuresBT);
            this.groupBoxNbHeuresBT.Location = new System.Drawing.Point(357, 171);
            this.groupBoxNbHeuresBT.Name = "groupBoxNbHeuresBT";
            this.groupBoxNbHeuresBT.Size = new System.Drawing.Size(132, 76);
            this.groupBoxNbHeuresBT.TabIndex = 46;
            this.groupBoxNbHeuresBT.TabStop = false;
            this.groupBoxNbHeuresBT.Text = "Nombre d’heures de l’équipement";
            // 
            // textBoxNbHeuresBT
            // 
            this.textBoxNbHeuresBT.Location = new System.Drawing.Point(10, 31);
            this.textBoxNbHeuresBT.MaxLength = 6;
            this.textBoxNbHeuresBT.Name = "textBoxNbHeuresBT";
            this.textBoxNbHeuresBT.Size = new System.Drawing.Size(114, 20);
            this.textBoxNbHeuresBT.TabIndex = 1;
            // 
            // groupBoxMotifBT
            // 
            this.groupBoxMotifBT.Controls.Add(this.comboBoxMotifBT);
            this.groupBoxMotifBT.Enabled = false;
            this.groupBoxMotifBT.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBoxMotifBT.Location = new System.Drawing.Point(43, 76);
            this.groupBoxMotifBT.Name = "groupBoxMotifBT";
            this.groupBoxMotifBT.Size = new System.Drawing.Size(113, 78);
            this.groupBoxMotifBT.TabIndex = 53;
            this.groupBoxMotifBT.TabStop = false;
            this.groupBoxMotifBT.Text = "Motif du BT";
            // 
            // groupBoxTravailRealiserBT
            // 
            this.groupBoxTravailRealiserBT.Controls.Add(this.RichTextBoxTravailRealiserBT);
            this.groupBoxTravailRealiserBT.Location = new System.Drawing.Point(43, 171);
            this.groupBoxTravailRealiserBT.Name = "groupBoxTravailRealiserBT";
            this.groupBoxTravailRealiserBT.Size = new System.Drawing.Size(283, 105);
            this.groupBoxTravailRealiserBT.TabIndex = 47;
            this.groupBoxTravailRealiserBT.TabStop = false;
            this.groupBoxTravailRealiserBT.Text = "Travail à réaliser";
            // 
            // groupBoxNomInterBT
            // 
            this.groupBoxNomInterBT.Controls.Add(this.comboBoxNomInterBT);
            this.groupBoxNomInterBT.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBoxNomInterBT.Location = new System.Drawing.Point(357, 298);
            this.groupBoxNomInterBT.Name = "groupBoxNomInterBT";
            this.groupBoxNomInterBT.Size = new System.Drawing.Size(215, 85);
            this.groupBoxNomInterBT.TabIndex = 49;
            this.groupBoxNomInterBT.TabStop = false;
            this.groupBoxNomInterBT.Text = "Nom de l’intervenant";
            // 
            // comboBoxNomInterBT
            // 
            this.comboBoxNomInterBT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNomInterBT.FormattingEnabled = true;
            this.comboBoxNomInterBT.Location = new System.Drawing.Point(9, 31);
            this.comboBoxNomInterBT.Name = "comboBoxNomInterBT";
            this.comboBoxNomInterBT.Size = new System.Drawing.Size(190, 21);
            this.comboBoxNomInterBT.TabIndex = 2;
            // 
            // groupBoxTempsPresteBT
            // 
            this.groupBoxTempsPresteBT.Controls.Add(this.textBoxTempsPresteBT);
            this.groupBoxTempsPresteBT.Location = new System.Drawing.Point(43, 409);
            this.groupBoxTempsPresteBT.Name = "groupBoxTempsPresteBT";
            this.groupBoxTempsPresteBT.Size = new System.Drawing.Size(113, 79);
            this.groupBoxTempsPresteBT.TabIndex = 50;
            this.groupBoxTempsPresteBT.TabStop = false;
            this.groupBoxTempsPresteBT.Text = "Temps presté";
            // 
            // textBoxTempsPresteBT
            // 
            this.textBoxTempsPresteBT.Location = new System.Drawing.Point(6, 34);
            this.textBoxTempsPresteBT.MaxLength = 50;
            this.textBoxTempsPresteBT.Name = "textBoxTempsPresteBT";
            this.textBoxTempsPresteBT.Size = new System.Drawing.Size(95, 20);
            this.textBoxTempsPresteBT.TabIndex = 2;
            // 
            // groupBoxDatePrestaBT
            // 
            this.groupBoxDatePrestaBT.Location = new System.Drawing.Point(189, 409);
            this.groupBoxDatePrestaBT.Name = "groupBoxDatePrestaBT";
            this.groupBoxDatePrestaBT.Size = new System.Drawing.Size(193, 79);
            this.groupBoxDatePrestaBT.TabIndex = 51;
            this.groupBoxDatePrestaBT.TabStop = false;
            this.groupBoxDatePrestaBT.Text = "Date de prestation";
            // 
            // groupBoxCreateurBT
            // 
            this.groupBoxCreateurBT.Controls.Add(this.textBoxCreateurBT);
            this.groupBoxCreateurBT.Enabled = false;
            this.groupBoxCreateurBT.Location = new System.Drawing.Point(43, 545);
            this.groupBoxCreateurBT.Name = "groupBoxCreateurBT";
            this.groupBoxCreateurBT.Size = new System.Drawing.Size(134, 55);
            this.groupBoxCreateurBT.TabIndex = 52;
            this.groupBoxCreateurBT.TabStop = false;
            this.groupBoxCreateurBT.Text = "Créateur du BT";
            // 
            // textBoxCreateurBT
            // 
            this.textBoxCreateurBT.Enabled = false;
            this.textBoxCreateurBT.Location = new System.Drawing.Point(8, 23);
            this.textBoxCreateurBT.MaxLength = 50;
            this.textBoxCreateurBT.Name = "textBoxCreateurBT";
            this.textBoxCreateurBT.Size = new System.Drawing.Size(120, 20);
            this.textBoxCreateurBT.TabIndex = 1;
            // 
            // groupBoxCommentaireInterBT
            // 
            this.groupBoxCommentaireInterBT.Controls.Add(this.RichTextBoxCommentaireInterBT);
            this.groupBoxCommentaireInterBT.Location = new System.Drawing.Point(43, 298);
            this.groupBoxCommentaireInterBT.Name = "groupBoxCommentaireInterBT";
            this.groupBoxCommentaireInterBT.Size = new System.Drawing.Size(283, 105);
            this.groupBoxCommentaireInterBT.TabIndex = 48;
            this.groupBoxCommentaireInterBT.TabStop = false;
            this.groupBoxCommentaireInterBT.Text = "Commentaire de l’intervenant";
            // 
            // RichTextBoxCommentaireInterBT
            // 
            this.RichTextBoxCommentaireInterBT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxCommentaireInterBT.Location = new System.Drawing.Point(7, 26);
            this.RichTextBoxCommentaireInterBT.Name = "RichTextBoxCommentaireInterBT";
            this.RichTextBoxCommentaireInterBT.Size = new System.Drawing.Size(267, 73);
            this.RichTextBoxCommentaireInterBT.TabIndex = 71;
            this.RichTextBoxCommentaireInterBT.Text = "";
            // 
            // RichTextBoxTravailRealiserBT
            // 
            this.RichTextBoxTravailRealiserBT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxTravailRealiserBT.Location = new System.Drawing.Point(7, 26);
            this.RichTextBoxTravailRealiserBT.Name = "RichTextBoxTravailRealiserBT";
            this.RichTextBoxTravailRealiserBT.Size = new System.Drawing.Size(267, 73);
            this.RichTextBoxTravailRealiserBT.TabIndex = 70;
            this.RichTextBoxTravailRealiserBT.Text = "";
            // 
            // kryptonButtonBTCreerValider
            // 
            this.kryptonButtonBTCreerValider.BackColor = System.Drawing.Color.Transparent;
            this.kryptonButtonBTCreerValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButtonBTCreerValider.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kryptonButtonBTCreerValider.Location = new System.Drawing.Point(589, 551);
            this.kryptonButtonBTCreerValider.Name = "kryptonButtonBTCreerValider";
            this.kryptonButtonBTCreerValider.Size = new System.Drawing.Size(122, 42);
            this.kryptonButtonBTCreerValider.TabIndex = 72;
            this.kryptonButtonBTCreerValider.Text = "Modifier";
            this.kryptonButtonBTCreerValider.UseVisualStyleBackColor = false;
            this.kryptonButtonBTCreerValider.Click += new System.EventHandler(this.kryptonButtonBTModifierValider_Click);
            // 
            // BTTModifierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 625);
            this.Controls.Add(this.kryptonButtonBTCreerValider);
            this.Controls.Add(this.labelHeaderBT);
            this.Controls.Add(this.groupBoxIntituleBT);
            this.Controls.Add(this.groupBoxEquipementConcerneBT);
            this.Controls.Add(this.groupBoxPieceRechangeBT);
            this.Controls.Add(this.groupBoxNbHeuresBT);
            this.Controls.Add(this.groupBoxMotifBT);
            this.Controls.Add(this.groupBoxTravailRealiserBT);
            this.Controls.Add(this.groupBoxNomInterBT);
            this.Controls.Add(this.groupBoxTempsPresteBT);
            this.Controls.Add(this.groupBoxDatePrestaBT);
            this.Controls.Add(this.groupBoxCreateurBT);
            this.Controls.Add(this.groupBoxCommentaireInterBT);
            this.Name = "BTTModifierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier un bon de travail";
            this.groupBoxIntituleBT.ResumeLayout(false);
            this.groupBoxIntituleBT.PerformLayout();
            this.groupBoxEquipementConcerneBT.ResumeLayout(false);
            this.groupBoxPieceRechangeBT.ResumeLayout(false);
            this.groupBoxNbHeuresBT.ResumeLayout(false);
            this.groupBoxNbHeuresBT.PerformLayout();
            this.groupBoxMotifBT.ResumeLayout(false);
            this.groupBoxTravailRealiserBT.ResumeLayout(false);
            this.groupBoxNomInterBT.ResumeLayout(false);
            this.groupBoxTempsPresteBT.ResumeLayout(false);
            this.groupBoxTempsPresteBT.PerformLayout();
            this.groupBoxCreateurBT.ResumeLayout(false);
            this.groupBoxCreateurBT.PerformLayout();
            this.groupBoxCommentaireInterBT.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeaderBT;
        private System.Windows.Forms.ComboBox comboBoxMotifBT;
        private System.Windows.Forms.GroupBox groupBoxIntituleBT;
        private System.Windows.Forms.TextBox textBoxIntituleBT;
        private System.Windows.Forms.GroupBox groupBoxEquipementConcerneBT;
        private System.Windows.Forms.ComboBox comboBoxEquipementConcerneBT;
        private System.Windows.Forms.GroupBox groupBoxPieceRechangeBT;
        private System.Windows.Forms.CheckedListBox checkedListBoxPieceRechangeBT;
        private System.Windows.Forms.GroupBox groupBoxNbHeuresBT;
        private System.Windows.Forms.TextBox textBoxNbHeuresBT;
        private System.Windows.Forms.GroupBox groupBoxMotifBT;
        private System.Windows.Forms.GroupBox groupBoxTravailRealiserBT;
        private System.Windows.Forms.GroupBox groupBoxNomInterBT;
        private System.Windows.Forms.ComboBox comboBoxNomInterBT;
        private System.Windows.Forms.GroupBox groupBoxTempsPresteBT;
        private System.Windows.Forms.TextBox textBoxTempsPresteBT;
        private System.Windows.Forms.GroupBox groupBoxDatePrestaBT;
        private System.Windows.Forms.GroupBox groupBoxCreateurBT;
        private System.Windows.Forms.TextBox textBoxCreateurBT;
        private System.Windows.Forms.GroupBox groupBoxCommentaireInterBT;
        private System.Windows.Forms.RichTextBox RichTextBoxTravailRealiserBT;
        private System.Windows.Forms.RichTextBox RichTextBoxCommentaireInterBT;
        private System.Windows.Forms.Button kryptonButtonBTCreerValider;
    }
}