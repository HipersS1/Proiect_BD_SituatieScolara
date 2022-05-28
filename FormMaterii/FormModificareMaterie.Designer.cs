namespace Proiect_BD_SituatieScolara
{
    partial class FormModificareMaterie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificareMaterie));
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.comboBoxAn = new System.Windows.Forms.ComboBox();
            this.numericUpCurs = new System.Windows.Forms.NumericUpDown();
            this.labelCurs = new System.Windows.Forms.Label();
            this.numericUpLaborator = new System.Windows.Forms.NumericUpDown();
            this.labelLaborator = new System.Windows.Forms.Label();
            this.comboBoxSemestru = new System.Windows.Forms.ComboBox();
            this.labelDenumire = new System.Windows.Forms.Label();
            this.labelAn = new System.Windows.Forms.Label();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.labelSemestru = new System.Windows.Forms.Label();
            this.btnTrimite = new System.Windows.Forms.Button();
            this.textBoxDenumire = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelFormularModificare = new System.Windows.Forms.Label();
            this.panelForm.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpCurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpLaborator)).BeginInit();
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
            this.panelForm.Size = new System.Drawing.Size(491, 364);
            this.panelForm.TabIndex = 0;
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(219)))));
            this.panelCenter.Controls.Add(this.panel1);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 86);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(491, 278);
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
            this.panel1.Size = new System.Drawing.Size(491, 278);
            this.panel1.TabIndex = 1;
            // 
            // panelInputs
            // 
            this.panelInputs.Controls.Add(this.comboBoxAn);
            this.panelInputs.Controls.Add(this.numericUpCurs);
            this.panelInputs.Controls.Add(this.labelCurs);
            this.panelInputs.Controls.Add(this.numericUpLaborator);
            this.panelInputs.Controls.Add(this.labelLaborator);
            this.panelInputs.Controls.Add(this.comboBoxSemestru);
            this.panelInputs.Controls.Add(this.labelDenumire);
            this.panelInputs.Controls.Add(this.labelAn);
            this.panelInputs.Controls.Add(this.btnAnuleaza);
            this.panelInputs.Controls.Add(this.labelSemestru);
            this.panelInputs.Controls.Add(this.btnTrimite);
            this.panelInputs.Controls.Add(this.textBoxDenumire);
            this.panelInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInputs.Location = new System.Drawing.Point(72, 0);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(347, 278);
            this.panelInputs.TabIndex = 17;
            // 
            // comboBoxAn
            // 
            this.comboBoxAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAn.FormatString = "N0";
            this.comboBoxAn.FormattingEnabled = true;
            this.comboBoxAn.Location = new System.Drawing.Point(153, 54);
            this.comboBoxAn.Name = "comboBoxAn";
            this.comboBoxAn.Size = new System.Drawing.Size(188, 32);
            this.comboBoxAn.TabIndex = 2;
            // 
            // numericUpCurs
            // 
            this.numericUpCurs.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpCurs.Increment = new decimal(new int[] {
            500,
            0,
            0,
            131072});
            this.numericUpCurs.Location = new System.Drawing.Point(153, 168);
            this.numericUpCurs.Name = "numericUpCurs";
            this.numericUpCurs.Size = new System.Drawing.Size(188, 32);
            this.numericUpCurs.TabIndex = 5;
            this.numericUpCurs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpCurs.Value = new decimal(new int[] {
            5000,
            0,
            0,
            131072});
            this.numericUpCurs.ValueChanged += new System.EventHandler(this.numericUpCourse_ValueChanged);
            // 
            // labelCurs
            // 
            this.labelCurs.AutoSize = true;
            this.labelCurs.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurs.Location = new System.Drawing.Point(10, 172);
            this.labelCurs.Name = "labelCurs";
            this.labelCurs.Size = new System.Drawing.Size(75, 28);
            this.labelCurs.TabIndex = 19;
            this.labelCurs.Text = "Curs %";
            // 
            // numericUpLaborator
            // 
            this.numericUpLaborator.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpLaborator.Increment = new decimal(new int[] {
            500,
            0,
            0,
            131072});
            this.numericUpLaborator.Location = new System.Drawing.Point(153, 130);
            this.numericUpLaborator.Name = "numericUpLaborator";
            this.numericUpLaborator.Size = new System.Drawing.Size(188, 32);
            this.numericUpLaborator.TabIndex = 4;
            this.numericUpLaborator.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpLaborator.Value = new decimal(new int[] {
            5000,
            0,
            0,
            131072});
            this.numericUpLaborator.ValueChanged += new System.EventHandler(this.numericUpLaboratory_ValueChanged);
            // 
            // labelLaborator
            // 
            this.labelLaborator.AutoSize = true;
            this.labelLaborator.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLaborator.Location = new System.Drawing.Point(10, 134);
            this.labelLaborator.Name = "labelLaborator";
            this.labelLaborator.Size = new System.Drawing.Size(122, 28);
            this.labelLaborator.TabIndex = 17;
            this.labelLaborator.Text = "Laborator %";
            // 
            // comboBoxSemestru
            // 
            this.comboBoxSemestru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSemestru.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSemestru.FormatString = "N0";
            this.comboBoxSemestru.FormattingEnabled = true;
            this.comboBoxSemestru.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxSemestru.Location = new System.Drawing.Point(153, 92);
            this.comboBoxSemestru.Name = "comboBoxSemestru";
            this.comboBoxSemestru.Size = new System.Drawing.Size(188, 32);
            this.comboBoxSemestru.TabIndex = 3;
            // 
            // labelDenumire
            // 
            this.labelDenumire.AutoSize = true;
            this.labelDenumire.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDenumire.Location = new System.Drawing.Point(10, 20);
            this.labelDenumire.Name = "labelDenumire";
            this.labelDenumire.Size = new System.Drawing.Size(102, 28);
            this.labelDenumire.TabIndex = 2;
            this.labelDenumire.Text = "Denumire";
            // 
            // labelAn
            // 
            this.labelAn.AutoSize = true;
            this.labelAn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAn.Location = new System.Drawing.Point(10, 58);
            this.labelAn.Name = "labelAn";
            this.labelAn.Size = new System.Drawing.Size(37, 28);
            this.labelAn.TabIndex = 1;
            this.labelAn.Text = "An";
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnuleaza.Location = new System.Drawing.Point(197, 223);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(144, 43);
            this.btnAnuleaza.TabIndex = 7;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelSemestru
            // 
            this.labelSemestru.AutoSize = true;
            this.labelSemestru.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemestru.Location = new System.Drawing.Point(10, 96);
            this.labelSemestru.Name = "labelSemestru";
            this.labelSemestru.Size = new System.Drawing.Size(98, 28);
            this.labelSemestru.TabIndex = 3;
            this.labelSemestru.Text = "Semestru";
            // 
            // btnTrimite
            // 
            this.btnTrimite.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrimite.Location = new System.Drawing.Point(15, 221);
            this.btnTrimite.Name = "btnTrimite";
            this.btnTrimite.Size = new System.Drawing.Size(144, 43);
            this.btnTrimite.TabIndex = 6;
            this.btnTrimite.Text = "Actualizeaza";
            this.btnTrimite.UseVisualStyleBackColor = true;
            this.btnTrimite.Click += new System.EventHandler(this.btnTrimite_Click);
            // 
            // textBoxDenumire
            // 
            this.textBoxDenumire.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDenumire.Location = new System.Drawing.Point(153, 12);
            this.textBoxDenumire.Name = "textBoxDenumire";
            this.textBoxDenumire.Size = new System.Drawing.Size(188, 36);
            this.textBoxDenumire.TabIndex = 1;
            this.textBoxDenumire.Enter += new System.EventHandler(this.textBoxPlaceholder_Enter);
            this.textBoxDenumire.Leave += new System.EventHandler(this.textBoxPlaceholder_Leave);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(419, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(72, 278);
            this.panel3.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(72, 278);
            this.panel2.TabIndex = 15;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(187)))));
            this.panelTop.Controls.Add(this.labelFormularModificare);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(491, 86);
            this.panelTop.TabIndex = 0;
            // 
            // labelFormularModificare
            // 
            this.labelFormularModificare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFormularModificare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFormularModificare.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormularModificare.Location = new System.Drawing.Point(0, 0);
            this.labelFormularModificare.Name = "labelFormularModificare";
            this.labelFormularModificare.Size = new System.Drawing.Size(491, 86);
            this.labelFormularModificare.TabIndex = 1;
            this.labelFormularModificare.Text = "Formular Modificare Materie";
            this.labelFormularModificare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormModificareMaterie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 364);
            this.Controls.Add(this.panelForm);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModificareMaterie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University Manager";
            this.Load += new System.EventHandler(this.FormModificareMaterie_Load);
            this.panelForm.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelInputs.ResumeLayout(false);
            this.panelInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpCurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpLaborator)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelFormularModificare;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTrimite;
        private System.Windows.Forms.TextBox textBoxDenumire;
        private System.Windows.Forms.Label labelSemestru;
        private System.Windows.Forms.Label labelDenumire;
        private System.Windows.Forms.Label labelAn;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.Panel panelInputs;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxSemestru;
        private System.Windows.Forms.Label labelCurs;
        private System.Windows.Forms.NumericUpDown numericUpLaborator;
        private System.Windows.Forms.Label labelLaborator;
        private System.Windows.Forms.NumericUpDown numericUpCurs;
        private System.Windows.Forms.ComboBox comboBoxAn;
    }
}

