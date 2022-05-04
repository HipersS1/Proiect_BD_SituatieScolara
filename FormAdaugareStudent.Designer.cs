namespace Proiect_BD_SituatieScolara
{
    partial class FormAdaugareStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdaugareStudent));
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelFirstNameStudent = new System.Windows.Forms.Label();
            this.labelLastNameStudent = new System.Windows.Forms.Label();
            this.textBoxLastNameStudent = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBoxEmailStudent = new System.Windows.Forms.TextBox();
            this.labelEmailStudent = new System.Windows.Forms.Label();
            this.labelFacultyStudent = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.textBoxPhoneStudent = new System.Windows.Forms.TextBox();
            this.labelPhoneStudent = new System.Windows.Forms.Label();
            this.textBoxFirstNameStudent = new System.Windows.Forms.TextBox();
            this.comboBoxYearStudent = new System.Windows.Forms.ComboBox();
            this.comboBoxFacultyStudent = new System.Windows.Forms.ComboBox();
            this.labelYearStudent = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelFormularAdaugare = new System.Windows.Forms.Label();
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
            this.panelForm.Size = new System.Drawing.Size(539, 518);
            this.panelForm.TabIndex = 0;
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(219)))));
            this.panelCenter.Controls.Add(this.panel1);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 81);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(539, 437);
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
            this.panel1.Size = new System.Drawing.Size(539, 437);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelFirstNameStudent);
            this.panel4.Controls.Add(this.labelLastNameStudent);
            this.panel4.Controls.Add(this.textBoxLastNameStudent);
            this.panel4.Controls.Add(this.btnCancel);
            this.panel4.Controls.Add(this.textBoxEmailStudent);
            this.panel4.Controls.Add(this.labelEmailStudent);
            this.panel4.Controls.Add(this.labelFacultyStudent);
            this.panel4.Controls.Add(this.btnSubmit);
            this.panel4.Controls.Add(this.textBoxPhoneStudent);
            this.panel4.Controls.Add(this.labelPhoneStudent);
            this.panel4.Controls.Add(this.textBoxFirstNameStudent);
            this.panel4.Controls.Add(this.comboBoxYearStudent);
            this.panel4.Controls.Add(this.comboBoxFacultyStudent);
            this.panel4.Controls.Add(this.labelYearStudent);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(82, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(375, 437);
            this.panel4.TabIndex = 17;
            // 
            // labelFirstNameStudent
            // 
            this.labelFirstNameStudent.AutoSize = true;
            this.labelFirstNameStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstNameStudent.Location = new System.Drawing.Point(6, 55);
            this.labelFirstNameStudent.Name = "labelFirstNameStudent";
            this.labelFirstNameStudent.Size = new System.Drawing.Size(111, 29);
            this.labelFirstNameStudent.TabIndex = 2;
            this.labelFirstNameStudent.Text = "Prenume";
            // 
            // labelLastNameStudent
            // 
            this.labelLastNameStudent.AutoSize = true;
            this.labelLastNameStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastNameStudent.Location = new System.Drawing.Point(6, 95);
            this.labelLastNameStudent.Name = "labelLastNameStudent";
            this.labelLastNameStudent.Size = new System.Drawing.Size(78, 29);
            this.labelLastNameStudent.TabIndex = 1;
            this.labelLastNameStudent.Text = "Nume";
            // 
            // textBoxLastNameStudent
            // 
            this.textBoxLastNameStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastNameStudent.Location = new System.Drawing.Point(143, 90);
            this.textBoxLastNameStudent.Name = "textBoxLastNameStudent";
            this.textBoxLastNameStudent.Size = new System.Drawing.Size(214, 34);
            this.textBoxLastNameStudent.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(205, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 41);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Anuleaza";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBoxEmailStudent
            // 
            this.textBoxEmailStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmailStudent.Location = new System.Drawing.Point(143, 130);
            this.textBoxEmailStudent.Name = "textBoxEmailStudent";
            this.textBoxEmailStudent.Size = new System.Drawing.Size(214, 34);
            this.textBoxEmailStudent.TabIndex = 9;
            // 
            // labelEmailStudent
            // 
            this.labelEmailStudent.AutoSize = true;
            this.labelEmailStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailStudent.Location = new System.Drawing.Point(6, 135);
            this.labelEmailStudent.Name = "labelEmailStudent";
            this.labelEmailStudent.Size = new System.Drawing.Size(82, 29);
            this.labelEmailStudent.TabIndex = 3;
            this.labelEmailStudent.Text = "E-mail";
            // 
            // labelFacultyStudent
            // 
            this.labelFacultyStudent.AutoSize = true;
            this.labelFacultyStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacultyStudent.Location = new System.Drawing.Point(6, 218);
            this.labelFacultyStudent.Name = "labelFacultyStudent";
            this.labelFacultyStudent.Size = new System.Drawing.Size(111, 29);
            this.labelFacultyStudent.TabIndex = 7;
            this.labelFacultyStudent.Text = "Facultate";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(6, 350);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(164, 41);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Adauga";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // textBoxPhoneStudent
            // 
            this.textBoxPhoneStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhoneStudent.Location = new System.Drawing.Point(143, 170);
            this.textBoxPhoneStudent.Name = "textBoxPhoneStudent";
            this.textBoxPhoneStudent.Size = new System.Drawing.Size(214, 34);
            this.textBoxPhoneStudent.TabIndex = 10;
            // 
            // labelPhoneStudent
            // 
            this.labelPhoneStudent.AutoSize = true;
            this.labelPhoneStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoneStudent.Location = new System.Drawing.Point(6, 175);
            this.labelPhoneStudent.Name = "labelPhoneStudent";
            this.labelPhoneStudent.Size = new System.Drawing.Size(96, 29);
            this.labelPhoneStudent.TabIndex = 4;
            this.labelPhoneStudent.Text = "Telefon";
            // 
            // textBoxFirstNameStudent
            // 
            this.textBoxFirstNameStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstNameStudent.Location = new System.Drawing.Point(143, 50);
            this.textBoxFirstNameStudent.Name = "textBoxFirstNameStudent";
            this.textBoxFirstNameStudent.Size = new System.Drawing.Size(214, 34);
            this.textBoxFirstNameStudent.TabIndex = 6;
            // 
            // comboBoxYearStudent
            // 
            this.comboBoxYearStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxYearStudent.FormattingEnabled = true;
            this.comboBoxYearStudent.Location = new System.Drawing.Point(143, 253);
            this.comboBoxYearStudent.Name = "comboBoxYearStudent";
            this.comboBoxYearStudent.Size = new System.Drawing.Size(214, 37);
            this.comboBoxYearStudent.TabIndex = 12;
            // 
            // comboBoxFacultyStudent
            // 
            this.comboBoxFacultyStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFacultyStudent.FormattingEnabled = true;
            this.comboBoxFacultyStudent.Location = new System.Drawing.Point(144, 210);
            this.comboBoxFacultyStudent.Name = "comboBoxFacultyStudent";
            this.comboBoxFacultyStudent.Size = new System.Drawing.Size(213, 37);
            this.comboBoxFacultyStudent.TabIndex = 11;
            // 
            // labelYearStudent
            // 
            this.labelYearStudent.AutoSize = true;
            this.labelYearStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYearStudent.Location = new System.Drawing.Point(6, 261);
            this.labelYearStudent.Name = "labelYearStudent";
            this.labelYearStudent.Size = new System.Drawing.Size(41, 29);
            this.labelYearStudent.TabIndex = 5;
            this.labelYearStudent.Text = "An";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(457, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(82, 437);
            this.panel3.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(82, 437);
            this.panel2.TabIndex = 15;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(187)))));
            this.panelTop.Controls.Add(this.labelFormularAdaugare);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(539, 81);
            this.panelTop.TabIndex = 0;
            // 
            // labelFormularAdaugare
            // 
            this.labelFormularAdaugare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFormularAdaugare.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormularAdaugare.Location = new System.Drawing.Point(0, 0);
            this.labelFormularAdaugare.Name = "labelFormularAdaugare";
            this.labelFormularAdaugare.Size = new System.Drawing.Size(539, 81);
            this.labelFormularAdaugare.TabIndex = 1;
            this.labelFormularAdaugare.Text = "Formular Student";
            this.labelFormularAdaugare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAdaugareStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 518);
            this.Controls.Add(this.panelForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdaugareStudent";
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
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox comboBoxYearStudent;
        private System.Windows.Forms.ComboBox comboBoxFacultyStudent;
        private System.Windows.Forms.TextBox textBoxPhoneStudent;
        private System.Windows.Forms.TextBox textBoxEmailStudent;
        private System.Windows.Forms.TextBox textBoxLastNameStudent;
        private System.Windows.Forms.Label labelFacultyStudent;
        private System.Windows.Forms.TextBox textBoxFirstNameStudent;
        private System.Windows.Forms.Label labelYearStudent;
        private System.Windows.Forms.Label labelPhoneStudent;
        private System.Windows.Forms.Label labelEmailStudent;
        private System.Windows.Forms.Label labelFirstNameStudent;
        private System.Windows.Forms.Label labelLastNameStudent;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}

