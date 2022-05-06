namespace Proiect_BD_SituatieScolara
{
    partial class FormAdaugaNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdaugaNote));
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxNumeStudent = new System.Windows.Forms.TextBox();
            this.labelMaterie = new System.Windows.Forms.Label();
            this.comboBoxMaterie = new System.Windows.Forms.ComboBox();
            this.labelFacultate = new System.Windows.Forms.Label();
            this.labelAn = new System.Windows.Forms.Label();
            this.labelStudent = new System.Windows.Forms.Label();
            this.comboBoxFacultate = new System.Windows.Forms.ComboBox();
            this.labelNotaCurs = new System.Windows.Forms.Label();
            this.comboBoxAn = new System.Windows.Forms.ComboBox();
            this.labelNotaLaborator = new System.Windows.Forms.Label();
            this.textBoxNotaLaborator = new System.Windows.Forms.TextBox();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.textBoxNotaFinala = new System.Windows.Forms.TextBox();
            this.labelNotaFinala = new System.Windows.Forms.Label();
            this.btnTrimite = new System.Windows.Forms.Button();
            this.textBoxNotaCurs = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelFormularAdaugareNota = new System.Windows.Forms.Label();
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
            this.panelForm.Size = new System.Drawing.Size(500, 430);
            this.panelForm.TabIndex = 0;
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(219)))));
            this.panelCenter.Controls.Add(this.panel1);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 76);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(500, 354);
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
            this.panel1.Size = new System.Drawing.Size(500, 354);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBoxNumeStudent);
            this.panel4.Controls.Add(this.labelMaterie);
            this.panel4.Controls.Add(this.comboBoxMaterie);
            this.panel4.Controls.Add(this.labelFacultate);
            this.panel4.Controls.Add(this.labelAn);
            this.panel4.Controls.Add(this.labelStudent);
            this.panel4.Controls.Add(this.comboBoxFacultate);
            this.panel4.Controls.Add(this.labelNotaCurs);
            this.panel4.Controls.Add(this.comboBoxAn);
            this.panel4.Controls.Add(this.labelNotaLaborator);
            this.panel4.Controls.Add(this.textBoxNotaLaborator);
            this.panel4.Controls.Add(this.btnAnuleaza);
            this.panel4.Controls.Add(this.textBoxNotaFinala);
            this.panel4.Controls.Add(this.labelNotaFinala);
            this.panel4.Controls.Add(this.btnTrimite);
            this.panel4.Controls.Add(this.textBoxNotaCurs);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(72, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(356, 354);
            this.panel4.TabIndex = 17;
            // 
            // textBoxNumeStudent
            // 
            this.textBoxNumeStudent.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeStudent.Location = new System.Drawing.Point(162, 12);
            this.textBoxNumeStudent.Name = "textBoxNumeStudent";
            this.textBoxNumeStudent.ReadOnly = true;
            this.textBoxNumeStudent.Size = new System.Drawing.Size(185, 36);
            this.textBoxNumeStudent.TabIndex = 17;
            this.textBoxNumeStudent.TabStop = false;
            // 
            // labelMaterie
            // 
            this.labelMaterie.AutoSize = true;
            this.labelMaterie.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaterie.Location = new System.Drawing.Point(6, 146);
            this.labelMaterie.Name = "labelMaterie";
            this.labelMaterie.Size = new System.Drawing.Size(86, 28);
            this.labelMaterie.TabIndex = 16;
            this.labelMaterie.Text = "Materie";
            // 
            // comboBoxMaterie
            // 
            this.comboBoxMaterie.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMaterie.FormattingEnabled = true;
            this.comboBoxMaterie.Location = new System.Drawing.Point(164, 138);
            this.comboBoxMaterie.Name = "comboBoxMaterie";
            this.comboBoxMaterie.Size = new System.Drawing.Size(185, 36);
            this.comboBoxMaterie.TabIndex = 2;
            // 
            // labelFacultate
            // 
            this.labelFacultate.AutoSize = true;
            this.labelFacultate.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacultate.Location = new System.Drawing.Point(6, 62);
            this.labelFacultate.Name = "labelFacultate";
            this.labelFacultate.Size = new System.Drawing.Size(98, 28);
            this.labelFacultate.TabIndex = 7;
            this.labelFacultate.Text = "Facultate";
            // 
            // labelAn
            // 
            this.labelAn.AutoSize = true;
            this.labelAn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAn.Location = new System.Drawing.Point(6, 104);
            this.labelAn.Name = "labelAn";
            this.labelAn.Size = new System.Drawing.Size(37, 28);
            this.labelAn.TabIndex = 5;
            this.labelAn.Text = "An";
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudent.Location = new System.Drawing.Point(6, 20);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(91, 28);
            this.labelStudent.TabIndex = 15;
            this.labelStudent.Text = "Student ";
            // 
            // comboBoxFacultate
            // 
            this.comboBoxFacultate.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFacultate.FormattingEnabled = true;
            this.comboBoxFacultate.Location = new System.Drawing.Point(164, 54);
            this.comboBoxFacultate.Name = "comboBoxFacultate";
            this.comboBoxFacultate.Size = new System.Drawing.Size(185, 36);
            this.comboBoxFacultate.TabIndex = 0;
            // 
            // labelNotaCurs
            // 
            this.labelNotaCurs.AutoSize = true;
            this.labelNotaCurs.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotaCurs.Location = new System.Drawing.Point(6, 188);
            this.labelNotaCurs.Name = "labelNotaCurs";
            this.labelNotaCurs.Size = new System.Drawing.Size(104, 28);
            this.labelNotaCurs.TabIndex = 2;
            this.labelNotaCurs.Text = "Nota Curs";
            // 
            // comboBoxAn
            // 
            this.comboBoxAn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAn.FormattingEnabled = true;
            this.comboBoxAn.Location = new System.Drawing.Point(164, 96);
            this.comboBoxAn.Name = "comboBoxAn";
            this.comboBoxAn.Size = new System.Drawing.Size(185, 36);
            this.comboBoxAn.TabIndex = 1;
            // 
            // labelNotaLaborator
            // 
            this.labelNotaLaborator.AutoSize = true;
            this.labelNotaLaborator.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotaLaborator.Location = new System.Drawing.Point(6, 225);
            this.labelNotaLaborator.Name = "labelNotaLaborator";
            this.labelNotaLaborator.Size = new System.Drawing.Size(155, 28);
            this.labelNotaLaborator.TabIndex = 1;
            this.labelNotaLaborator.Text = "Nota Laborator";
            // 
            // textBoxNotaLaborator
            // 
            this.textBoxNotaLaborator.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNotaLaborator.Location = new System.Drawing.Point(164, 217);
            this.textBoxNotaLaborator.Name = "textBoxNotaLaborator";
            this.textBoxNotaLaborator.Size = new System.Drawing.Size(185, 36);
            this.textBoxNotaLaborator.TabIndex = 4;
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnuleaza.Location = new System.Drawing.Point(205, 304);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(144, 38);
            this.btnAnuleaza.TabIndex = 7;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBoxNotaFinala
            // 
            this.textBoxNotaFinala.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNotaFinala.Location = new System.Drawing.Point(164, 255);
            this.textBoxNotaFinala.Name = "textBoxNotaFinala";
            this.textBoxNotaFinala.ReadOnly = true;
            this.textBoxNotaFinala.Size = new System.Drawing.Size(185, 36);
            this.textBoxNotaFinala.TabIndex = 5;
            // 
            // labelNotaFinala
            // 
            this.labelNotaFinala.AutoSize = true;
            this.labelNotaFinala.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotaFinala.Location = new System.Drawing.Point(6, 263);
            this.labelNotaFinala.Name = "labelNotaFinala";
            this.labelNotaFinala.Size = new System.Drawing.Size(118, 28);
            this.labelNotaFinala.TabIndex = 3;
            this.labelNotaFinala.Text = "Nota Finala";
            // 
            // btnTrimite
            // 
            this.btnTrimite.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrimite.Location = new System.Drawing.Point(6, 304);
            this.btnTrimite.Name = "btnTrimite";
            this.btnTrimite.Size = new System.Drawing.Size(144, 38);
            this.btnTrimite.TabIndex = 6;
            this.btnTrimite.Text = "Actualizeaza";
            this.btnTrimite.UseVisualStyleBackColor = true;
            // 
            // textBoxNotaCurs
            // 
            this.textBoxNotaCurs.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNotaCurs.Location = new System.Drawing.Point(164, 180);
            this.textBoxNotaCurs.Name = "textBoxNotaCurs";
            this.textBoxNotaCurs.Size = new System.Drawing.Size(185, 36);
            this.textBoxNotaCurs.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(428, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(72, 354);
            this.panel3.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(72, 354);
            this.panel2.TabIndex = 15;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(187)))));
            this.panelTop.Controls.Add(this.labelFormularAdaugareNota);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(500, 76);
            this.panelTop.TabIndex = 0;
            // 
            // labelFormularAdaugareNota
            // 
            this.labelFormularAdaugareNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFormularAdaugareNota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFormularAdaugareNota.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormularAdaugareNota.Location = new System.Drawing.Point(0, 0);
            this.labelFormularAdaugareNota.Name = "labelFormularAdaugareNota";
            this.labelFormularAdaugareNota.Size = new System.Drawing.Size(500, 76);
            this.labelFormularAdaugareNota.TabIndex = 1;
            this.labelFormularAdaugareNota.Text = "Formular Adaugare Nota";
            this.labelFormularAdaugareNota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAdaugaNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 430);
            this.Controls.Add(this.panelForm);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdaugaNote";
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
        private System.Windows.Forms.Label labelFormularAdaugareNota;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTrimite;
        private System.Windows.Forms.ComboBox comboBoxAn;
        private System.Windows.Forms.ComboBox comboBoxFacultate;
        private System.Windows.Forms.TextBox textBoxNotaFinala;
        private System.Windows.Forms.TextBox textBoxNotaLaborator;
        private System.Windows.Forms.Label labelFacultate;
        private System.Windows.Forms.TextBox textBoxNotaCurs;
        private System.Windows.Forms.Label labelAn;
        private System.Windows.Forms.Label labelNotaFinala;
        private System.Windows.Forms.Label labelNotaCurs;
        private System.Windows.Forms.Label labelNotaLaborator;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.Label labelMaterie;
        private System.Windows.Forms.ComboBox comboBoxMaterie;
        private System.Windows.Forms.TextBox textBoxNumeStudent;
    }
}

