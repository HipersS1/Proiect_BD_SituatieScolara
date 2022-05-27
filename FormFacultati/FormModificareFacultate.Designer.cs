namespace Proiect_BD_SituatieScolara
{
    partial class FormModificareFacultate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificareFacultate));
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.comboBoxDurata = new System.Windows.Forms.ComboBox();
            this.comboBoxCiclu = new System.Windows.Forms.ComboBox();
            this.labelDenumire = new System.Windows.Forms.Label();
            this.labelProgramStudiu = new System.Windows.Forms.Label();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.textBoxSpecializare = new System.Windows.Forms.TextBox();
            this.labelSpecializare = new System.Windows.Forms.Label();
            this.btnTrimite = new System.Windows.Forms.Button();
            this.labelDurata = new System.Windows.Forms.Label();
            this.textBoxDenumire = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelFormularAdaugare = new System.Windows.Forms.Label();
            this.panelFacultate = new System.Windows.Forms.Panel();
            this.panelProgramStudiu = new System.Windows.Forms.Panel();
            this.panelForm.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelInputs.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelFacultate.SuspendLayout();
            this.panelProgramStudiu.SuspendLayout();
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
            this.panel1.Controls.Add(this.panelInputs);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 324);
            this.panel1.TabIndex = 1;
            // 
            // panelInputs
            // 
            this.panelInputs.Controls.Add(this.panelProgramStudiu);
            this.panelInputs.Controls.Add(this.panelFacultate);
            this.panelInputs.Controls.Add(this.btnAnuleaza);
            this.panelInputs.Controls.Add(this.btnTrimite);
            this.panelInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInputs.Location = new System.Drawing.Point(72, 0);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(356, 324);
            this.panelInputs.TabIndex = 17;
            // 
            // comboBoxDurata
            // 
            this.comboBoxDurata.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDurata.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDurata.FormatString = "N0";
            this.comboBoxDurata.FormattingEnabled = true;
            this.comboBoxDurata.Location = new System.Drawing.Point(163, 81);
            this.comboBoxDurata.Name = "comboBoxDurata";
            this.comboBoxDurata.Size = new System.Drawing.Size(188, 36);
            this.comboBoxDurata.TabIndex = 16;
            // 
            // comboBoxCiclu
            // 
            this.comboBoxCiclu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCiclu.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCiclu.FormatString = "N0";
            this.comboBoxCiclu.FormattingEnabled = true;
            this.comboBoxCiclu.Location = new System.Drawing.Point(163, 6);
            this.comboBoxCiclu.Name = "comboBoxCiclu";
            this.comboBoxCiclu.Size = new System.Drawing.Size(188, 36);
            this.comboBoxCiclu.TabIndex = 15;
            // 
            // labelDenumire
            // 
            this.labelDenumire.AutoSize = true;
            this.labelDenumire.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDenumire.Location = new System.Drawing.Point(6, 47);
            this.labelDenumire.Name = "labelDenumire";
            this.labelDenumire.Size = new System.Drawing.Size(103, 28);
            this.labelDenumire.TabIndex = 2;
            this.labelDenumire.Text = "Denumire";
            // 
            // labelProgramStudiu
            // 
            this.labelProgramStudiu.AutoSize = true;
            this.labelProgramStudiu.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgramStudiu.Location = new System.Drawing.Point(6, 14);
            this.labelProgramStudiu.Name = "labelProgramStudiu";
            this.labelProgramStudiu.Size = new System.Drawing.Size(56, 28);
            this.labelProgramStudiu.TabIndex = 1;
            this.labelProgramStudiu.Text = "Ciclu";
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnuleaza.Location = new System.Drawing.Point(205, 274);
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
            this.textBoxSpecializare.Location = new System.Drawing.Point(163, 44);
            this.textBoxSpecializare.Name = "textBoxSpecializare";
            this.textBoxSpecializare.Size = new System.Drawing.Size(188, 36);
            this.textBoxSpecializare.TabIndex = 9;
            // 
            // labelSpecializare
            // 
            this.labelSpecializare.AutoSize = true;
            this.labelSpecializare.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpecializare.Location = new System.Drawing.Point(6, 52);
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
            this.btnTrimite.Text = "Actualizeaza";
            this.btnTrimite.UseVisualStyleBackColor = true;
            this.btnTrimite.Click += new System.EventHandler(this.btnTrimite_Click);
            // 
            // labelDurata
            // 
            this.labelDurata.AutoSize = true;
            this.labelDurata.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDurata.Location = new System.Drawing.Point(6, 89);
            this.labelDurata.Name = "labelDurata";
            this.labelDurata.Size = new System.Drawing.Size(76, 28);
            this.labelDurata.TabIndex = 4;
            this.labelDurata.Text = "Durata";
            // 
            // textBoxDenumire
            // 
            this.textBoxDenumire.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDenumire.Location = new System.Drawing.Point(163, 39);
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
            this.labelFormularAdaugare.Text = "Formular Modificare Facultate";
            this.labelFormularAdaugare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFacultate
            // 
            this.panelFacultate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelFacultate.Controls.Add(this.labelDenumire);
            this.panelFacultate.Controls.Add(this.textBoxDenumire);
            this.panelFacultate.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFacultate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFacultate.Location = new System.Drawing.Point(0, 0);
            this.panelFacultate.Name = "panelFacultate";
            this.panelFacultate.Size = new System.Drawing.Size(356, 84);
            this.panelFacultate.TabIndex = 17;
            // 
            // panelProgramStudiu
            // 
            this.panelProgramStudiu.BackColor = System.Drawing.Color.Teal;
            this.panelProgramStudiu.Controls.Add(this.textBoxSpecializare);
            this.panelProgramStudiu.Controls.Add(this.labelDurata);
            this.panelProgramStudiu.Controls.Add(this.comboBoxDurata);
            this.panelProgramStudiu.Controls.Add(this.labelSpecializare);
            this.panelProgramStudiu.Controls.Add(this.comboBoxCiclu);
            this.panelProgramStudiu.Controls.Add(this.labelProgramStudiu);
            this.panelProgramStudiu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProgramStudiu.Location = new System.Drawing.Point(0, 84);
            this.panelProgramStudiu.Name = "panelProgramStudiu";
            this.panelProgramStudiu.Size = new System.Drawing.Size(356, 135);
            this.panelProgramStudiu.TabIndex = 18;
            // 
            // FormModificareFacultate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.panelForm);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModificareFacultate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University Manager";
            this.panelForm.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelInputs.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelFacultate.ResumeLayout(false);
            this.panelFacultate.PerformLayout();
            this.panelProgramStudiu.ResumeLayout(false);
            this.panelProgramStudiu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelFormularAdaugare;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTrimite;
        private System.Windows.Forms.TextBox textBoxSpecializare;
        private System.Windows.Forms.TextBox textBoxDenumire;
        private System.Windows.Forms.Label labelDurata;
        private System.Windows.Forms.Label labelSpecializare;
        private System.Windows.Forms.Label labelDenumire;
        private System.Windows.Forms.Label labelProgramStudiu;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.Panel panelInputs;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxCiclu;
        private System.Windows.Forms.ComboBox comboBoxDurata;
        private System.Windows.Forms.Panel panelFacultate;
        private System.Windows.Forms.Panel panelProgramStudiu;
    }
}

