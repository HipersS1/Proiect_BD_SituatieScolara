namespace Proiect_BD_SituatieScolara
{
    partial class FormAdaugareMaterie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdaugareMaterie));
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.buttonClearSearch = new System.Windows.Forms.Button();
            this.comboBoxAn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpCurs = new System.Windows.Forms.NumericUpDown();
            this.labelCurs = new System.Windows.Forms.Label();
            this.numericUpLaborator = new System.Windows.Forms.NumericUpDown();
            this.labelLaborator = new System.Windows.Forms.Label();
            this.comboBoxSemestru = new System.Windows.Forms.ComboBox();
            this.labelDenumire = new System.Windows.Forms.Label();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.labelSemestru = new System.Windows.Forms.Label();
            this.btnTrimite = new System.Windows.Forms.Button();
            this.textDenumire = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelFormularAdaugare = new System.Windows.Forms.Label();
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
            this.panelForm.BackColor = System.Drawing.Color.Black;
            this.panelForm.Controls.Add(this.panelCenter);
            this.panelForm.Controls.Add(this.panelTop);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Padding = new System.Windows.Forms.Padding(1);
            this.panelForm.Size = new System.Drawing.Size(537, 373);
            this.panelForm.TabIndex = 0;
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(219)))));
            this.panelCenter.Controls.Add(this.panel1);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(1, 87);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(535, 285);
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
            this.panel1.Size = new System.Drawing.Size(535, 285);
            this.panel1.TabIndex = 1;
            // 
            // panelInputs
            // 
            this.panelInputs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(190)))), ((int)(((byte)(160)))));
            this.panelInputs.Controls.Add(this.buttonClearSearch);
            this.panelInputs.Controls.Add(this.comboBoxAn);
            this.panelInputs.Controls.Add(this.label1);
            this.panelInputs.Controls.Add(this.numericUpCurs);
            this.panelInputs.Controls.Add(this.labelCurs);
            this.panelInputs.Controls.Add(this.numericUpLaborator);
            this.panelInputs.Controls.Add(this.labelLaborator);
            this.panelInputs.Controls.Add(this.comboBoxSemestru);
            this.panelInputs.Controls.Add(this.labelDenumire);
            this.panelInputs.Controls.Add(this.btnAnuleaza);
            this.panelInputs.Controls.Add(this.labelSemestru);
            this.panelInputs.Controls.Add(this.btnTrimite);
            this.panelInputs.Controls.Add(this.textDenumire);
            this.panelInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInputs.Location = new System.Drawing.Point(72, 0);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(391, 285);
            this.panelInputs.TabIndex = 17;
            // 
            // buttonClearSearch
            // 
            this.buttonClearSearch.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonClearSearch.Location = new System.Drawing.Point(335, 226);
            this.buttonClearSearch.Name = "buttonClearSearch";
            this.buttonClearSearch.Size = new System.Drawing.Size(37, 43);
            this.buttonClearSearch.TabIndex = 28;
            this.buttonClearSearch.Text = "q";
            this.buttonClearSearch.UseVisualStyleBackColor = true;
            this.buttonClearSearch.Click += new System.EventHandler(this.buttonClearSearch_Click);
            // 
            // comboBoxAn
            // 
            this.comboBoxAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAn.FormattingEnabled = true;
            this.comboBoxAn.Location = new System.Drawing.Point(184, 52);
            this.comboBoxAn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxAn.Name = "comboBoxAn";
            this.comboBoxAn.Size = new System.Drawing.Size(188, 36);
            this.comboBoxAn.TabIndex = 25;
            this.comboBoxAn.EnabledChanged += new System.EventHandler(this.comboBox_EnabledChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "An";
            // 
            // numericUpCurs
            // 
            this.numericUpCurs.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.numericUpCurs.Increment = new decimal(new int[] {
            500,
            0,
            0,
            131072});
            this.numericUpCurs.Location = new System.Drawing.Point(184, 177);
            this.numericUpCurs.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numericUpCurs.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpCurs.Name = "numericUpCurs";
            this.numericUpCurs.ReadOnly = true;
            this.numericUpCurs.Size = new System.Drawing.Size(188, 34);
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
            this.labelCurs.Location = new System.Drawing.Point(19, 183);
            this.labelCurs.Name = "labelCurs";
            this.labelCurs.Size = new System.Drawing.Size(75, 28);
            this.labelCurs.TabIndex = 19;
            this.labelCurs.Text = "Curs %";
            // 
            // numericUpLaborator
            // 
            this.numericUpLaborator.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.numericUpLaborator.Increment = new decimal(new int[] {
            500,
            0,
            0,
            131072});
            this.numericUpLaborator.Location = new System.Drawing.Point(184, 137);
            this.numericUpLaborator.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numericUpLaborator.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpLaborator.Name = "numericUpLaborator";
            this.numericUpLaborator.ReadOnly = true;
            this.numericUpLaborator.Size = new System.Drawing.Size(188, 34);
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
            this.labelLaborator.Location = new System.Drawing.Point(19, 143);
            this.labelLaborator.Name = "labelLaborator";
            this.labelLaborator.Size = new System.Drawing.Size(122, 28);
            this.labelLaborator.TabIndex = 17;
            this.labelLaborator.Text = "Laborator %";
            // 
            // comboBoxSemestru
            // 
            this.comboBoxSemestru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSemestru.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxSemestru.FormatString = "N0";
            this.comboBoxSemestru.FormattingEnabled = true;
            this.comboBoxSemestru.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxSemestru.Location = new System.Drawing.Point(184, 95);
            this.comboBoxSemestru.Name = "comboBoxSemestru";
            this.comboBoxSemestru.Size = new System.Drawing.Size(188, 36);
            this.comboBoxSemestru.TabIndex = 3;
            // 
            // labelDenumire
            // 
            this.labelDenumire.AutoSize = true;
            this.labelDenumire.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDenumire.Location = new System.Drawing.Point(19, 18);
            this.labelDenumire.Name = "labelDenumire";
            this.labelDenumire.Size = new System.Drawing.Size(102, 28);
            this.labelDenumire.TabIndex = 2;
            this.labelDenumire.Text = "Denumire";
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnuleaza.Location = new System.Drawing.Point(185, 226);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(144, 43);
            this.btnAnuleaza.TabIndex = 7;
            this.btnAnuleaza.Text = "Inchide";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelSemestru
            // 
            this.labelSemestru.AutoSize = true;
            this.labelSemestru.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemestru.Location = new System.Drawing.Point(16, 103);
            this.labelSemestru.Name = "labelSemestru";
            this.labelSemestru.Size = new System.Drawing.Size(98, 28);
            this.labelSemestru.TabIndex = 3;
            this.labelSemestru.Text = "Semestru";
            // 
            // btnTrimite
            // 
            this.btnTrimite.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrimite.Location = new System.Drawing.Point(21, 226);
            this.btnTrimite.Name = "btnTrimite";
            this.btnTrimite.Size = new System.Drawing.Size(144, 43);
            this.btnTrimite.TabIndex = 6;
            this.btnTrimite.Text = "Adauga";
            this.btnTrimite.UseVisualStyleBackColor = true;
            this.btnTrimite.Click += new System.EventHandler(this.btnTrimite_Click);
            // 
            // textDenumire
            // 
            this.textDenumire.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDenumire.Location = new System.Drawing.Point(184, 12);
            this.textDenumire.Name = "textDenumire";
            this.textDenumire.Size = new System.Drawing.Size(188, 34);
            this.textDenumire.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(190)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(463, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(72, 285);
            this.panel3.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(190)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(72, 285);
            this.panel2.TabIndex = 15;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(187)))));
            this.panelTop.Controls.Add(this.labelFormularAdaugare);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(1, 1);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(535, 86);
            this.panelTop.TabIndex = 0;
            // 
            // labelFormularAdaugare
            // 
            this.labelFormularAdaugare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(140)))), ((int)(((byte)(110)))));
            this.labelFormularAdaugare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFormularAdaugare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFormularAdaugare.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormularAdaugare.Location = new System.Drawing.Point(0, 0);
            this.labelFormularAdaugare.Name = "labelFormularAdaugare";
            this.labelFormularAdaugare.Size = new System.Drawing.Size(535, 86);
            this.labelFormularAdaugare.TabIndex = 1;
            this.labelFormularAdaugare.Text = "Formular Adaugare Materie";
            this.labelFormularAdaugare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAdaugareMaterie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 373);
            this.Controls.Add(this.panelForm);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdaugareMaterie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University Manager";
            this.Load += new System.EventHandler(this.FormAdaugareMaterie_Load);
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
        private System.Windows.Forms.Label labelFormularAdaugare;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTrimite;
        private System.Windows.Forms.TextBox textDenumire;
        private System.Windows.Forms.Label labelSemestru;
        private System.Windows.Forms.Label labelDenumire;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.Panel panelInputs;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxSemestru;
        private System.Windows.Forms.Label labelCurs;
        private System.Windows.Forms.NumericUpDown numericUpLaborator;
        private System.Windows.Forms.Label labelLaborator;
        private System.Windows.Forms.NumericUpDown numericUpCurs;
        private System.Windows.Forms.Button buttonClearSearch;
        private System.Windows.Forms.ComboBox comboBoxAn;
        private System.Windows.Forms.Label label1;
    }
}

