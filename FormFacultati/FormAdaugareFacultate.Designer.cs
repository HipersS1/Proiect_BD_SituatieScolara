namespace Proiect_BD_SituatieScolara
{
    partial class FormAdaugareFacultate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdaugareFacultate));
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelDenumire = new System.Windows.Forms.Label();
            this.labelProgramStudiu = new System.Windows.Forms.Label();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.textBoxSpecializare = new System.Windows.Forms.TextBox();
            this.labelSpecializare = new System.Windows.Forms.Label();
            this.btnTrimite = new System.Windows.Forms.Button();
            this.textBoxDurata = new System.Windows.Forms.TextBox();
            this.labelDurata = new System.Windows.Forms.Label();
            this.textBoxDenumire = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelFormularAdaugare = new System.Windows.Forms.Label();
            this.comboBoxProgramStudiu = new System.Windows.Forms.ComboBox();
            this.panelForm.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.panelCenter);
            this.panelForm.Controls.Add(this.panelTop);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(500, 400);
            this.panelForm.TabIndex = 0;
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(219)))));
            this.panelCenter.Controls.Add(this.panel1);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 76);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(500, 324);
            this.panelCenter.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 324);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBoxProgramStudiu);
            this.panel4.Controls.Add(this.labelDenumire);
            this.panel4.Controls.Add(this.labelProgramStudiu);
            this.panel4.Controls.Add(this.btnAnuleaza);
            this.panel4.Controls.Add(this.textBoxSpecializare);
            this.panel4.Controls.Add(this.labelSpecializare);
            this.panel4.Controls.Add(this.btnTrimite);
            this.panel4.Controls.Add(this.textBoxDurata);
            this.panel4.Controls.Add(this.labelDurata);
            this.panel4.Controls.Add(this.textBoxDenumire);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(72, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(356, 324);
            this.panel4.TabIndex = 17;
            // 
            // labelDenumire
            // 
            this.labelDenumire.AutoSize = true;
            this.labelDenumire.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDenumire.Location = new System.Drawing.Point(4, 54);
            this.labelDenumire.Name = "labelDenumire";
            this.labelDenumire.Size = new System.Drawing.Size(103, 28);
            this.labelDenumire.TabIndex = 2;
            this.labelDenumire.Text = "Denumire";
            // 
            // labelProgramStudiu
            // 
            this.labelProgramStudiu.AutoSize = true;
            this.labelProgramStudiu.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgramStudiu.Location = new System.Drawing.Point(4, 91);
            this.labelProgramStudiu.Name = "labelProgramStudiu";
            this.labelProgramStudiu.Size = new System.Drawing.Size(155, 28);
            this.labelProgramStudiu.TabIndex = 1;
            this.labelProgramStudiu.Text = "Program studiu";
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnuleaza.Location = new System.Drawing.Point(181, 274);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(144, 38);
            this.btnAnuleaza.TabIndex = 14;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBoxSpecializare
            // 
            this.textBoxSpecializare.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSpecializare.Location = new System.Drawing.Point(161, 121);
            this.textBoxSpecializare.Name = "textBoxSpecializare";
            this.textBoxSpecializare.Size = new System.Drawing.Size(188, 36);
            this.textBoxSpecializare.TabIndex = 9;
            // 
            // labelSpecializare
            // 
            this.labelSpecializare.AutoSize = true;
            this.labelSpecializare.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpecializare.Location = new System.Drawing.Point(4, 129);
            this.labelSpecializare.Name = "labelSpecializare";
            this.labelSpecializare.Size = new System.Drawing.Size(121, 28);
            this.labelSpecializare.TabIndex = 3;
            this.labelSpecializare.Text = "Specializare";
            // 
            // btnTrimite
            // 
            this.btnTrimite.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrimite.Location = new System.Drawing.Point(9, 274);
            this.btnTrimite.Name = "btnTrimite";
            this.btnTrimite.Size = new System.Drawing.Size(144, 38);
            this.btnTrimite.TabIndex = 13;
            this.btnTrimite.Text = "Adauga";
            this.btnTrimite.UseVisualStyleBackColor = true;
            this.btnTrimite.Click += new System.EventHandler(this.btnTrimite_Click);
            // 
            // textBoxDurata
            // 
            this.textBoxDurata.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDurata.Location = new System.Drawing.Point(161, 158);
            this.textBoxDurata.Name = "textBoxDurata";
            this.textBoxDurata.Size = new System.Drawing.Size(188, 36);
            this.textBoxDurata.TabIndex = 10;
            // 
            // labelDurata
            // 
            this.labelDurata.AutoSize = true;
            this.labelDurata.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDurata.Location = new System.Drawing.Point(4, 166);
            this.labelDurata.Name = "labelDurata";
            this.labelDurata.Size = new System.Drawing.Size(76, 28);
            this.labelDurata.TabIndex = 4;
            this.labelDurata.Text = "Durata";
            // 
            // textBoxDenumire
            // 
            this.textBoxDenumire.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDenumire.Location = new System.Drawing.Point(161, 46);
            this.textBoxDenumire.Name = "textBoxDenumire";
            this.textBoxDenumire.Size = new System.Drawing.Size(188, 36);
            this.textBoxDenumire.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(428, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(72, 324);
            this.panel3.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(72, 324);
            this.panel2.TabIndex = 15;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(187)))));
            this.panelTop.Controls.Add(this.labelFormularAdaugare);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(500, 76);
            this.panelTop.TabIndex = 0;
            // 
            // labelFormularAdaugare
            // 
            this.labelFormularAdaugare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFormularAdaugare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFormularAdaugare.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormularAdaugare.Location = new System.Drawing.Point(0, 0);
            this.labelFormularAdaugare.Name = "labelFormularAdaugare";
            this.labelFormularAdaugare.Size = new System.Drawing.Size(500, 76);
            this.labelFormularAdaugare.TabIndex = 1;
            this.labelFormularAdaugare.Text = "Formular Adaugare Facultate";
            this.labelFormularAdaugare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxProgramStudiu
            // 
            this.comboBoxProgramStudiu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProgramStudiu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProgramStudiu.FormatString = "N0";
            this.comboBoxProgramStudiu.FormattingEnabled = true;
            this.comboBoxProgramStudiu.Location = new System.Drawing.Point(161, 87);
            this.comboBoxProgramStudiu.Name = "comboBoxProgramStudiu";
            this.comboBoxProgramStudiu.Size = new System.Drawing.Size(188, 32);
            this.comboBoxProgramStudiu.TabIndex = 15;
            // 
            // FormAdaugareFacultate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.panelForm);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdaugareFacultate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University Manager";
            this.panelForm.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelFormularAdaugare;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTrimite;
        private System.Windows.Forms.TextBox textBoxDurata;
        private System.Windows.Forms.TextBox textBoxSpecializare;
        private System.Windows.Forms.TextBox textBoxDenumire;
        private System.Windows.Forms.Label labelDurata;
        private System.Windows.Forms.Label labelSpecializare;
        private System.Windows.Forms.Label labelDenumire;
        private System.Windows.Forms.Label labelProgramStudiu;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxProgramStudiu;
    }
}

