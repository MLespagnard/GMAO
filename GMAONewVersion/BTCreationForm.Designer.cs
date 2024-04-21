namespace GMAONewVersion
{
    partial class BTCreationForm
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
            this.groupBoxPieceRechangeBT = new System.Windows.Forms.GroupBox();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.checkedListBoxPieceRechangeBT = new System.Windows.Forms.CheckedListBox();
            this.comboBoxMotifBT = new System.Windows.Forms.ComboBox();
            this.textBoxIntituleBT = new System.Windows.Forms.TextBox();
            this.comboBoxEquipementConcerneBT = new System.Windows.Forms.ComboBox();
            this.textBoxNbHeuresBT = new System.Windows.Forms.TextBox();
            this.comboBoxNomInterBT = new System.Windows.Forms.ComboBox();
            this.groupBoxNomInterBT = new System.Windows.Forms.GroupBox();
            this.groupBoxNbHeuresBT = new System.Windows.Forms.GroupBox();
            this.groupBoxEquipementConcerneBT = new System.Windows.Forms.GroupBox();
            this.groupBoxIntituleBT = new System.Windows.Forms.GroupBox();
            this.groupBoxMotifBT = new System.Windows.Forms.GroupBox();
            this.textBoxCreateurBT = new System.Windows.Forms.TextBox();
            this.groupBoxCreateurBT = new System.Windows.Forms.GroupBox();
            this.groupBoxTravailRealiserBT = new System.Windows.Forms.GroupBox();
            this.RichTextBoxTravailRealiserBT = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelNumeros = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxIsFinish = new System.Windows.Forms.CheckBox();
            this.groupBoxDatePrestaBT = new System.Windows.Forms.GroupBox();
            this.textBoxTempsPresteBT = new System.Windows.Forms.TextBox();
            this.groupBoxTempsPresteBT = new System.Windows.Forms.GroupBox();
            this.kryptonButtonBTCreerValider = new System.Windows.Forms.Button();
            this.RichTextBoxCommentaireInterBT = new System.Windows.Forms.RichTextBox();
            this.groupBoxCommentaireInterBT = new System.Windows.Forms.GroupBox();
            this.groupBoxPieceRechangeBT.SuspendLayout();
            this.groupBoxNomInterBT.SuspendLayout();
            this.groupBoxNbHeuresBT.SuspendLayout();
            this.groupBoxEquipementConcerneBT.SuspendLayout();
            this.groupBoxIntituleBT.SuspendLayout();
            this.groupBoxMotifBT.SuspendLayout();
            this.groupBoxCreateurBT.SuspendLayout();
            this.groupBoxTravailRealiserBT.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxDatePrestaBT.SuspendLayout();
            this.groupBoxTempsPresteBT.SuspendLayout();
            this.groupBoxCommentaireInterBT.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHeaderBT
            // 
            this.labelHeaderBT.AutoSize = true;
            this.labelHeaderBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderBT.Location = new System.Drawing.Point(39, 25);
            this.labelHeaderBT.Name = "labelHeaderBT";
            this.labelHeaderBT.Size = new System.Drawing.Size(206, 20);
            this.labelHeaderBT.TabIndex = 55;
            this.labelHeaderBT.Text = "Créer un bon de travail : ";
            // 
            // groupBoxPieceRechangeBT
            // 
            this.groupBoxPieceRechangeBT.Controls.Add(this.textBoxFilter);
            this.groupBoxPieceRechangeBT.Controls.Add(this.checkedListBoxPieceRechangeBT);
            this.groupBoxPieceRechangeBT.Location = new System.Drawing.Point(449, 76);
            this.groupBoxPieceRechangeBT.Name = "groupBoxPieceRechangeBT";
            this.groupBoxPieceRechangeBT.Size = new System.Drawing.Size(143, 321);
            this.groupBoxPieceRechangeBT.TabIndex = 54;
            this.groupBoxPieceRechangeBT.TabStop = false;
            this.groupBoxPieceRechangeBT.Text = " Pièces de rechange concerné";
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(6, 35);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(131, 20);
            this.textBoxFilter.TabIndex = 1;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // checkedListBoxPieceRechangeBT
            // 
            this.checkedListBoxPieceRechangeBT.FormattingEnabled = true;
            this.checkedListBoxPieceRechangeBT.IntegralHeight = false;
            this.checkedListBoxPieceRechangeBT.Location = new System.Drawing.Point(6, 62);
            this.checkedListBoxPieceRechangeBT.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBoxPieceRechangeBT.Name = "checkedListBoxPieceRechangeBT";
            this.checkedListBoxPieceRechangeBT.Size = new System.Drawing.Size(131, 252);
            this.checkedListBoxPieceRechangeBT.TabIndex = 0;
            this.checkedListBoxPieceRechangeBT.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxPieceRechangeBT_ItemCheck);
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
            // textBoxIntituleBT
            // 
            this.textBoxIntituleBT.Location = new System.Drawing.Point(8, 23);
            this.textBoxIntituleBT.MaxLength = 50;
            this.textBoxIntituleBT.Name = "textBoxIntituleBT";
            this.textBoxIntituleBT.Size = new System.Drawing.Size(120, 20);
            this.textBoxIntituleBT.TabIndex = 0;
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
            // textBoxNbHeuresBT
            // 
            this.textBoxNbHeuresBT.Location = new System.Drawing.Point(10, 31);
            this.textBoxNbHeuresBT.MaxLength = 6;
            this.textBoxNbHeuresBT.Name = "textBoxNbHeuresBT";
            this.textBoxNbHeuresBT.Size = new System.Drawing.Size(114, 20);
            this.textBoxNbHeuresBT.TabIndex = 1;
            this.textBoxNbHeuresBT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNbHeuresBT_KeyPress);
            // 
            // comboBoxNomInterBT
            // 
            this.comboBoxNomInterBT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNomInterBT.FormattingEnabled = true;
            this.comboBoxNomInterBT.Location = new System.Drawing.Point(8, 23);
            this.comboBoxNomInterBT.Name = "comboBoxNomInterBT";
            this.comboBoxNomInterBT.Size = new System.Drawing.Size(117, 21);
            this.comboBoxNomInterBT.TabIndex = 2;
            // 
            // groupBoxNomInterBT
            // 
            this.groupBoxNomInterBT.Controls.Add(this.comboBoxNomInterBT);
            this.groupBoxNomInterBT.Location = new System.Drawing.Point(21, 271);
            this.groupBoxNomInterBT.Name = "groupBoxNomInterBT";
            this.groupBoxNomInterBT.Size = new System.Drawing.Size(132, 55);
            this.groupBoxNomInterBT.TabIndex = 50;
            this.groupBoxNomInterBT.TabStop = false;
            this.groupBoxNomInterBT.Text = "Nom de l’intervenant";
            // 
            // groupBoxNbHeuresBT
            // 
            this.groupBoxNbHeuresBT.Controls.Add(this.textBoxNbHeuresBT);
            this.groupBoxNbHeuresBT.Location = new System.Drawing.Point(311, 171);
            this.groupBoxNbHeuresBT.Name = "groupBoxNbHeuresBT";
            this.groupBoxNbHeuresBT.Size = new System.Drawing.Size(132, 76);
            this.groupBoxNbHeuresBT.TabIndex = 47;
            this.groupBoxNbHeuresBT.TabStop = false;
            this.groupBoxNbHeuresBT.Text = "Nombre d’heures de l’équipement";
            // 
            // groupBoxEquipementConcerneBT
            // 
            this.groupBoxEquipementConcerneBT.Controls.Add(this.comboBoxEquipementConcerneBT);
            this.groupBoxEquipementConcerneBT.Location = new System.Drawing.Point(311, 76);
            this.groupBoxEquipementConcerneBT.Name = "groupBoxEquipementConcerneBT";
            this.groupBoxEquipementConcerneBT.Size = new System.Drawing.Size(132, 78);
            this.groupBoxEquipementConcerneBT.TabIndex = 46;
            this.groupBoxEquipementConcerneBT.TabStop = false;
            this.groupBoxEquipementConcerneBT.Text = "Équipement concerné";
            // 
            // groupBoxIntituleBT
            // 
            this.groupBoxIntituleBT.Controls.Add(this.textBoxIntituleBT);
            this.groupBoxIntituleBT.Location = new System.Drawing.Point(153, 76);
            this.groupBoxIntituleBT.Name = "groupBoxIntituleBT";
            this.groupBoxIntituleBT.Size = new System.Drawing.Size(137, 78);
            this.groupBoxIntituleBT.TabIndex = 45;
            this.groupBoxIntituleBT.TabStop = false;
            this.groupBoxIntituleBT.Text = "Intitulé du BT";
            // 
            // groupBoxMotifBT
            // 
            this.groupBoxMotifBT.Controls.Add(this.comboBoxMotifBT);
            this.groupBoxMotifBT.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBoxMotifBT.Location = new System.Drawing.Point(21, 76);
            this.groupBoxMotifBT.Name = "groupBoxMotifBT";
            this.groupBoxMotifBT.Size = new System.Drawing.Size(113, 78);
            this.groupBoxMotifBT.TabIndex = 44;
            this.groupBoxMotifBT.TabStop = false;
            this.groupBoxMotifBT.Text = "Motif du BT";
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
            // groupBoxCreateurBT
            // 
            this.groupBoxCreateurBT.Controls.Add(this.textBoxCreateurBT);
            this.groupBoxCreateurBT.Location = new System.Drawing.Point(159, 271);
            this.groupBoxCreateurBT.Name = "groupBoxCreateurBT";
            this.groupBoxCreateurBT.Size = new System.Drawing.Size(134, 55);
            this.groupBoxCreateurBT.TabIndex = 53;
            this.groupBoxCreateurBT.TabStop = false;
            this.groupBoxCreateurBT.Text = "Créateur du BT";
            // 
            // groupBoxTravailRealiserBT
            // 
            this.groupBoxTravailRealiserBT.Controls.Add(this.RichTextBoxTravailRealiserBT);
            this.groupBoxTravailRealiserBT.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBoxTravailRealiserBT.Location = new System.Drawing.Point(21, 171);
            this.groupBoxTravailRealiserBT.Name = "groupBoxTravailRealiserBT";
            this.groupBoxTravailRealiserBT.Size = new System.Drawing.Size(269, 76);
            this.groupBoxTravailRealiserBT.TabIndex = 48;
            this.groupBoxTravailRealiserBT.TabStop = false;
            this.groupBoxTravailRealiserBT.Text = "Travail à réaliser";
            // 
            // RichTextBoxTravailRealiserBT
            // 
            this.RichTextBoxTravailRealiserBT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxTravailRealiserBT.Location = new System.Drawing.Point(6, 19);
            this.RichTextBoxTravailRealiserBT.MaxLength = 80;
            this.RichTextBoxTravailRealiserBT.Name = "RichTextBoxTravailRealiserBT";
            this.RichTextBoxTravailRealiserBT.Size = new System.Drawing.Size(254, 45);
            this.RichTextBoxTravailRealiserBT.TabIndex = 3;
            this.RichTextBoxTravailRealiserBT.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanelNumeros);
            this.groupBox1.Location = new System.Drawing.Point(598, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 321);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Pièces de rechange concerné";
            // 
            // flowLayoutPanelNumeros
            // 
            this.flowLayoutPanelNumeros.AutoScroll = true;
            this.flowLayoutPanelNumeros.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelNumeros.Location = new System.Drawing.Point(6, 16);
            this.flowLayoutPanelNumeros.Name = "flowLayoutPanelNumeros";
            this.flowLayoutPanelNumeros.Size = new System.Drawing.Size(117, 302);
            this.flowLayoutPanelNumeros.TabIndex = 0;
            // 
            // checkBoxIsFinish
            // 
            this.checkBoxIsFinish.AutoSize = true;
            this.checkBoxIsFinish.Enabled = false;
            this.checkBoxIsFinish.Location = new System.Drawing.Point(24, 34);
            this.checkBoxIsFinish.Name = "checkBoxIsFinish";
            this.checkBoxIsFinish.Size = new System.Drawing.Size(42, 17);
            this.checkBoxIsFinish.TabIndex = 0;
            this.checkBoxIsFinish.Text = "Oui";
            this.checkBoxIsFinish.UseVisualStyleBackColor = true;
            // 
            // groupBoxDatePrestaBT
            // 
            this.groupBoxDatePrestaBT.Controls.Add(this.checkBoxIsFinish);
            this.groupBoxDatePrestaBT.Location = new System.Drawing.Point(163, 534);
            this.groupBoxDatePrestaBT.Name = "groupBoxDatePrestaBT";
            this.groupBoxDatePrestaBT.Size = new System.Drawing.Size(113, 79);
            this.groupBoxDatePrestaBT.TabIndex = 52;
            this.groupBoxDatePrestaBT.TabStop = false;
            this.groupBoxDatePrestaBT.Text = "Cloturer";
            // 
            // textBoxTempsPresteBT
            // 
            this.textBoxTempsPresteBT.Location = new System.Drawing.Point(6, 34);
            this.textBoxTempsPresteBT.MaxLength = 50;
            this.textBoxTempsPresteBT.Name = "textBoxTempsPresteBT";
            this.textBoxTempsPresteBT.Size = new System.Drawing.Size(120, 20);
            this.textBoxTempsPresteBT.TabIndex = 2;
            this.textBoxTempsPresteBT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTempsPresteBT_KeyPress);
            // 
            // groupBoxTempsPresteBT
            // 
            this.groupBoxTempsPresteBT.Controls.Add(this.textBoxTempsPresteBT);
            this.groupBoxTempsPresteBT.Location = new System.Drawing.Point(12, 534);
            this.groupBoxTempsPresteBT.Name = "groupBoxTempsPresteBT";
            this.groupBoxTempsPresteBT.Size = new System.Drawing.Size(134, 79);
            this.groupBoxTempsPresteBT.TabIndex = 51;
            this.groupBoxTempsPresteBT.TabStop = false;
            this.groupBoxTempsPresteBT.Text = "Temps presté";
            // 
            // kryptonButtonBTCreerValider
            // 
            this.kryptonButtonBTCreerValider.BackColor = System.Drawing.Color.Transparent;
            this.kryptonButtonBTCreerValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButtonBTCreerValider.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kryptonButtonBTCreerValider.Location = new System.Drawing.Point(570, 538);
            this.kryptonButtonBTCreerValider.Name = "kryptonButtonBTCreerValider";
            this.kryptonButtonBTCreerValider.Size = new System.Drawing.Size(122, 42);
            this.kryptonButtonBTCreerValider.TabIndex = 69;
            this.kryptonButtonBTCreerValider.Text = "Créer";
            this.kryptonButtonBTCreerValider.UseVisualStyleBackColor = false;
            this.kryptonButtonBTCreerValider.Click += new System.EventHandler(this.kryptonButtonBTCreerValider_Click);
            // 
            // RichTextBoxCommentaireInterBT
            // 
            this.RichTextBoxCommentaireInterBT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxCommentaireInterBT.Location = new System.Drawing.Point(8, 19);
            this.RichTextBoxCommentaireInterBT.MaxLength = 80;
            this.RichTextBoxCommentaireInterBT.Name = "RichTextBoxCommentaireInterBT";
            this.RichTextBoxCommentaireInterBT.Size = new System.Drawing.Size(241, 51);
            this.RichTextBoxCommentaireInterBT.TabIndex = 4;
            this.RichTextBoxCommentaireInterBT.Text = "";
            // 
            // groupBoxCommentaireInterBT
            // 
            this.groupBoxCommentaireInterBT.Controls.Add(this.RichTextBoxCommentaireInterBT);
            this.groupBoxCommentaireInterBT.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBoxCommentaireInterBT.Location = new System.Drawing.Point(18, 430);
            this.groupBoxCommentaireInterBT.Name = "groupBoxCommentaireInterBT";
            this.groupBoxCommentaireInterBT.Size = new System.Drawing.Size(258, 85);
            this.groupBoxCommentaireInterBT.TabIndex = 49;
            this.groupBoxCommentaireInterBT.TabStop = false;
            this.groupBoxCommentaireInterBT.Text = "Commentaire de l’intervenant";
            // 
            // BTCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(736, 625);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kryptonButtonBTCreerValider);
            this.Controls.Add(this.labelHeaderBT);
            this.Controls.Add(this.groupBoxPieceRechangeBT);
            this.Controls.Add(this.groupBoxNomInterBT);
            this.Controls.Add(this.groupBoxTempsPresteBT);
            this.Controls.Add(this.groupBoxNbHeuresBT);
            this.Controls.Add(this.groupBoxEquipementConcerneBT);
            this.Controls.Add(this.groupBoxDatePrestaBT);
            this.Controls.Add(this.groupBoxIntituleBT);
            this.Controls.Add(this.groupBoxMotifBT);
            this.Controls.Add(this.groupBoxCreateurBT);
            this.Controls.Add(this.groupBoxCommentaireInterBT);
            this.Controls.Add(this.groupBoxTravailRealiserBT);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "BTCreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Création d\'un bon de travail";
            this.groupBoxPieceRechangeBT.ResumeLayout(false);
            this.groupBoxPieceRechangeBT.PerformLayout();
            this.groupBoxNomInterBT.ResumeLayout(false);
            this.groupBoxNbHeuresBT.ResumeLayout(false);
            this.groupBoxNbHeuresBT.PerformLayout();
            this.groupBoxEquipementConcerneBT.ResumeLayout(false);
            this.groupBoxIntituleBT.ResumeLayout(false);
            this.groupBoxIntituleBT.PerformLayout();
            this.groupBoxMotifBT.ResumeLayout(false);
            this.groupBoxCreateurBT.ResumeLayout(false);
            this.groupBoxCreateurBT.PerformLayout();
            this.groupBoxTravailRealiserBT.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxDatePrestaBT.ResumeLayout(false);
            this.groupBoxDatePrestaBT.PerformLayout();
            this.groupBoxTempsPresteBT.ResumeLayout(false);
            this.groupBoxTempsPresteBT.PerformLayout();
            this.groupBoxCommentaireInterBT.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeaderBT;
        private System.Windows.Forms.GroupBox groupBoxPieceRechangeBT;
        private System.Windows.Forms.CheckedListBox checkedListBoxPieceRechangeBT;
        private System.Windows.Forms.ComboBox comboBoxMotifBT;
        private System.Windows.Forms.TextBox textBoxIntituleBT;
        private System.Windows.Forms.ComboBox comboBoxEquipementConcerneBT;
        private System.Windows.Forms.TextBox textBoxNbHeuresBT;
        private System.Windows.Forms.ComboBox comboBoxNomInterBT;
        private System.Windows.Forms.GroupBox groupBoxNomInterBT;
        private System.Windows.Forms.GroupBox groupBoxNbHeuresBT;
        private System.Windows.Forms.GroupBox groupBoxEquipementConcerneBT;
        private System.Windows.Forms.GroupBox groupBoxIntituleBT;
        private System.Windows.Forms.GroupBox groupBoxMotifBT;
        private System.Windows.Forms.TextBox textBoxCreateurBT;
        private System.Windows.Forms.GroupBox groupBoxCreateurBT;
        private System.Windows.Forms.GroupBox groupBoxTravailRealiserBT;
        private System.Windows.Forms.RichTextBox RichTextBoxTravailRealiserBT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNumeros;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.CheckBox checkBoxIsFinish;
        private System.Windows.Forms.GroupBox groupBoxDatePrestaBT;
        private System.Windows.Forms.TextBox textBoxTempsPresteBT;
        private System.Windows.Forms.GroupBox groupBoxTempsPresteBT;
        private System.Windows.Forms.Button kryptonButtonBTCreerValider;
        private System.Windows.Forms.RichTextBox RichTextBoxCommentaireInterBT;
        private System.Windows.Forms.GroupBox groupBoxCommentaireInterBT;
    }
}