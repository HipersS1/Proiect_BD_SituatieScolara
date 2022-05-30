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
            this.panelInputs = new System.Windows.Forms.Panel();
            this.panelProgramStudiu = new System.Windows.Forms.Panel();
            this.comboBoxProgramStudiu = new System.Windows.Forms.ComboBox();
            this.labelDurata = new System.Windows.Forms.Label();
            this.comboBoxDurata = new System.Windows.Forms.ComboBox();
            this.labelSpecializare = new System.Windows.Forms.Label();
            this.textBoxSpecializare = new System.Windows.Forms.TextBox();
            this.labelProgramStudiu = new System.Windows.Forms.Label();
            this.panelFacultate = new System.Windows.Forms.Panel();
            this.textBoxDenumire = new System.Windows.Forms.TextBox();
            this.comboBoxFacultateExistenta = new System.Windows.Forms.ComboBox();
            this.labelDenumire = new System.Windows.Forms.Label();
            this.labelAlege = new System.Windows.Forms.Label();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.btnTrimite = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelFormularAdaugare = new System.Windows.Forms.Label();
            this.panelForm.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelInputs.SuspendLayout();
            this.panelProgramStudiu.SuspendLayout();
            this.panelFacultate.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.Black;
            this.panelForm.Controls.Add(this.panelCenter);
            this.panelForm.Controls.Add(this.panelTop);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Padding = new System.Windows.Forms.Padding(1);
            this.panelForm.Size = new System.Drawing.Size(526, 384);
            this.panelForm.TabIndex = 0;
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(219)))));
            this.panelCenter.Controls.Add(this.panel1);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(1, 87);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(524, 296);
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
            this.panel1.Size = new System.Drawing.Size(524, 296);
            this.panel1.TabIndex = 1;
            // 
            // panelInputs
            // 
            this.panelInputs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(190)))), ((int)(((byte)(160)))));
            this.panelInputs.Controls.Add(this.panelProgramStudiu);
            this.panelInputs.Controls.Add(this.panelFacultate);
            this.panelInputs.Controls.Add(this.btnAnuleaza);
            this.panelInputs.Controls.Add(this.btnTrimite);
            this.panelInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInputs.Location = new System.Drawing.Point(72, 0);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(380, 296);
            this.panelInputs.TabIndex = 17;
            // 
            // panelProgramStudiu
            // 
            this.panelProgramStudiu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(190)))), ((int)(((byte)(160)))));
            this.panelProgramStudiu.Controls.Add(this.comboBoxProgramStudiu);
            this.panelProgramStudiu.Controls.Add(this.labelDurata);
            this.panelProgramStudiu.Controls.Add(this.comboBoxDurata);
            this.panelProgramStudiu.Controls.Add(this.labelSpecializare);
            this.panelProgramStudiu.Controls.Add(this.textBoxSpecializare);
            this.panelProgramStudiu.Controls.Add(this.labelProgramStudiu);
            this.panelProgramStudiu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProgramStudiu.Location = new System.Drawing.Point(0, 100);
            this.panelProgramStudiu.Name = "panelProgramStudiu";
            this.panelProgramStudiu.Size = new System.Drawing.Size(380, 142);
            this.panelProgramStudiu.TabIndex = 9;
            // 
            // comboBoxProgramStudiu
            // 
            this.comboBoxProgramStudiu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProgramStudiu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProgramStudiu.FormatString = "N0";
            this.comboBoxProgramStudiu.FormattingEnabled = true;
            this.comboBoxProgramStudiu.Location = new System.Drawing.Point(163, 7);
            this.comboBoxProgramStudiu.Name = "comboBoxProgramStudiu";
            this.comboBoxProgramStudiu.Size = new System.Drawing.Size(211, 39);
            this.comboBoxProgramStudiu.TabIndex = 1;
            // 
            // labelDurata
            // 
            this.labelDurata.AutoSize = true;
            this.labelDurata.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDurata.Location = new System.Drawing.Point(6, 101);
            this.labelDurata.Name = "labelDurata";
            this.labelDurata.Size = new System.Drawing.Size(83, 31);
            this.labelDurata.TabIndex = 4;
            this.labelDurata.Text = "Durata";
            // 
            // comboBoxDurata
            // 
            this.comboBoxDurata.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDurata.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDurata.FormatString = "N0";
            this.comboBoxDurata.FormattingEnabled = true;
            this.comboBoxDurata.Location = new System.Drawing.Point(163, 92);
            this.comboBoxDurata.Name = "comboBoxDurata";
            this.comboBoxDurata.Size = new System.Drawing.Size(211, 39);
            this.comboBoxDurata.TabIndex = 3;
            // 
            // labelSpecializare
            // 
            this.labelSpecializare.AutoSize = true;
            this.labelSpecializare.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpecializare.Location = new System.Drawing.Point(6, 59);
            this.labelSpecializare.Name = "labelSpecializare";
            this.labelSpecializare.Size = new System.Drawing.Size(135, 31);
            this.labelSpecializare.TabIndex = 3;
            this.labelSpecializare.Text = "Specializare";
            // 
            // textBoxSpecializare
            // 
            this.textBoxSpecializare.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSpecializare.Location = new System.Drawing.Point(163, 50);
            this.textBoxSpecializare.Name = "textBoxSpecializare";
            this.textBoxSpecializare.Size = new System.Drawing.Size(211, 38);
            this.textBoxSpecializare.TabIndex = 2;
            // 
            // labelProgramStudiu
            // 
            this.labelProgramStudiu.AutoSize = true;
            this.labelProgramStudiu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgramStudiu.Location = new System.Drawing.Point(6, 16);
            this.labelProgramStudiu.Name = "labelProgramStudiu";
            this.labelProgramStudiu.Size = new System.Drawing.Size(172, 31);
            this.labelProgramStudiu.TabIndex = 1;
            this.labelProgramStudiu.Text = "Program studiu";
            // 
            // panelFacultate
            // 
            this.panelFacultate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(190)))), ((int)(((byte)(160)))));
            this.panelFacultate.Controls.Add(this.textBoxDenumire);
            this.panelFacultate.Controls.Add(this.comboBoxFacultateExistenta);
            this.panelFacultate.Controls.Add(this.labelDenumire);
            this.panelFacultate.Controls.Add(this.labelAlege);
            this.panelFacultate.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFacultate.Location = new System.Drawing.Point(0, 0);
            this.panelFacultate.Name = "panelFacultate";
            this.panelFacultate.Size = new System.Drawing.Size(380, 100);
            this.panelFacultate.TabIndex = 8;
            // 
            // textBoxDenumire
            // 
            this.textBoxDenumire.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDenumire.Location = new System.Drawing.Point(162, 54);
            this.textBoxDenumire.Name = "textBoxDenumire";
            this.textBoxDenumire.Size = new System.Drawing.Size(212, 38);
            this.textBoxDenumire.TabIndex = 0;
            // 
            // comboBoxFacultateExistenta
            // 
            this.comboBoxFacultateExistenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFacultateExistenta.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFacultateExistenta.FormatString = "N0";
            this.comboBoxFacultateExistenta.FormattingEnabled = true;
            this.comboBoxFacultateExistenta.Location = new System.Drawing.Point(162, 10);
            this.comboBoxFacultateExistenta.Name = "comboBoxFacultateExistenta";
            this.comboBoxFacultateExistenta.Size = new System.Drawing.Size(212, 39);
            this.comboBoxFacultateExistenta.TabIndex = 6;
            this.comboBoxFacultateExistenta.DropDown += new System.EventHandler(this.comboBox_DropDown);
            this.comboBoxFacultateExistenta.SelectedIndexChanged += new System.EventHandler(this.comboBoxFacultateExistenta_SelectedIndexChanged);
            // 
            // labelDenumire
            // 
            this.labelDenumire.AutoSize = true;
            this.labelDenumire.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDenumire.Location = new System.Drawing.Point(5, 63);
            this.labelDenumire.Name = "labelDenumire";
            this.labelDenumire.Size = new System.Drawing.Size(114, 31);
            this.labelDenumire.TabIndex = 2;
            this.labelDenumire.Text = "Denumire";
            // 
            // labelAlege
            // 
            this.labelAlege.AutoSize = true;
            this.labelAlege.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlege.Location = new System.Drawing.Point(5, 19);
            this.labelAlege.Name = "labelAlege";
            this.labelAlege.Size = new System.Drawing.Size(121, 31);
            this.labelAlege.TabIndex = 7;
            this.labelAlege.Text = "Selecteaza";
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnuleaza.Location = new System.Drawing.Point(230, 248);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(144, 43);
            this.btnAnuleaza.TabIndex = 5;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnTrimite
            // 
            this.btnTrimite.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrimite.Location = new System.Drawing.Point(11, 248);
            this.btnTrimite.Name = "btnTrimite";
            this.btnTrimite.Size = new System.Drawing.Size(144, 43);
            this.btnTrimite.TabIndex = 4;
            this.btnTrimite.Text = "Adauga";
            this.btnTrimite.UseVisualStyleBackColor = true;
            this.btnTrimite.Click += new System.EventHandler(this.btnTrimite_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(190)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(452, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(72, 296);
            this.panel3.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(190)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(72, 296);
            this.panel2.TabIndex = 15;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(187)))));
            this.panelTop.Controls.Add(this.labelFormularAdaugare);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(1, 1);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(524, 86);
            this.panelTop.TabIndex = 0;
            // 
            // labelFormularAdaugare
            // 
            this.labelFormularAdaugare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(140)))), ((int)(((byte)(110)))));
            this.labelFormularAdaugare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFormularAdaugare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFormularAdaugare.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormularAdaugare.Location = new System.Drawing.Point(0, 0);
            this.labelFormularAdaugare.Name = "labelFormularAdaugare";
            this.labelFormularAdaugare.Size = new System.Drawing.Size(524, 86);
            this.labelFormularAdaugare.TabIndex = 1;
            this.labelFormularAdaugare.Text = "Formular Adaugare Facultate";
            this.labelFormularAdaugare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAdaugareFacultate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 384);
            this.Controls.Add(this.panelForm);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdaugareFacultate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University Manager";
            this.Load += new System.EventHandler(this.FormAdaugareFacultate_Load);
            this.panelForm.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelInputs.ResumeLayout(false);
            this.panelProgramStudiu.ResumeLayout(false);
            this.panelProgramStudiu.PerformLayout();
            this.panelFacultate.ResumeLayout(false);
            this.panelFacultate.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBoxProgramStudiu;
        private System.Windows.Forms.ComboBox comboBoxDurata;
        private System.Windows.Forms.ComboBox comboBoxFacultateExistenta;
        private System.Windows.Forms.Label labelAlege;
        private System.Windows.Forms.Panel panelProgramStudiu;
        private System.Windows.Forms.Panel panelFacultate;
    }
}

