namespace Proiect_BD_SituatieScolara
{
    partial class FormInitializare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInitializare));
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnMenuMa = new System.Windows.Forms.Button();
            this.pictureBoxUSVLogo = new System.Windows.Forms.PictureBox();
            this.btnMenuStudents = new System.Windows.Forms.Button();
            this.btnMenuUniversity = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelMenu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelForm.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUSVLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.panelCenter);
            this.panelForm.Controls.Add(this.panelLeft);
            this.panelForm.Controls.Add(this.panelTop);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1100, 610);
            this.panelForm.TabIndex = 0;
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(219)))));
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(131, 86);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(969, 524);
            this.panelCenter.TabIndex = 2;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(187)))));
            this.panelLeft.Controls.Add(this.btnMenuMa);
            this.panelLeft.Controls.Add(this.pictureBoxUSVLogo);
            this.panelLeft.Controls.Add(this.btnMenuStudents);
            this.panelLeft.Controls.Add(this.btnMenuUniversity);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 86);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(0, 17, 0, 0);
            this.panelLeft.Size = new System.Drawing.Size(131, 524);
            this.panelLeft.TabIndex = 1;
            // 
            // btnMenuMa
            // 
            this.btnMenuMa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(183)))), ((int)(((byte)(160)))));
            this.btnMenuMa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuMa.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.btnMenuMa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuMa.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuMa.Location = new System.Drawing.Point(0, 187);
            this.btnMenuMa.Name = "btnMenuMa";
            this.btnMenuMa.Size = new System.Drawing.Size(131, 85);
            this.btnMenuMa.TabIndex = 2;
            this.btnMenuMa.Text = "Meniu Materii";
            this.btnMenuMa.UseVisualStyleBackColor = false;
            this.btnMenuMa.Click += new System.EventHandler(this.btnMenuMa_Click);
            // 
            // pictureBoxUSVLogo
            // 
            this.pictureBoxUSVLogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBoxUSVLogo.Image = global::Proiect_BD_SituatieScolara.Properties.Resources._640px_Ștefan_cel_Mare_University_of_Suceava_logo_svg;
            this.pictureBoxUSVLogo.InitialImage = global::Proiect_BD_SituatieScolara.Properties.Resources.universitatea_suceava_usv_968x460;
            this.pictureBoxUSVLogo.Location = new System.Drawing.Point(0, 465);
            this.pictureBoxUSVLogo.Name = "pictureBoxUSVLogo";
            this.pictureBoxUSVLogo.Size = new System.Drawing.Size(131, 59);
            this.pictureBoxUSVLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUSVLogo.TabIndex = 0;
            this.pictureBoxUSVLogo.TabStop = false;
            // 
            // btnMenuStudents
            // 
            this.btnMenuStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(183)))), ((int)(((byte)(160)))));
            this.btnMenuStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuStudents.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.btnMenuStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuStudents.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuStudents.Location = new System.Drawing.Point(0, 102);
            this.btnMenuStudents.Name = "btnMenuStudents";
            this.btnMenuStudents.Size = new System.Drawing.Size(131, 85);
            this.btnMenuStudents.TabIndex = 1;
            this.btnMenuStudents.Text = "Meniu Studenti";
            this.btnMenuStudents.UseVisualStyleBackColor = false;
            this.btnMenuStudents.Click += new System.EventHandler(this.btnMenuStudents_Click);
            // 
            // btnMenuUniversity
            // 
            this.btnMenuUniversity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(183)))), ((int)(((byte)(160)))));
            this.btnMenuUniversity.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuUniversity.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.btnMenuUniversity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuUniversity.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuUniversity.Location = new System.Drawing.Point(0, 17);
            this.btnMenuUniversity.Name = "btnMenuUniversity";
            this.btnMenuUniversity.Size = new System.Drawing.Size(131, 85);
            this.btnMenuUniversity.TabIndex = 0;
            this.btnMenuUniversity.Text = "Meniu Facultate";
            this.btnMenuUniversity.UseVisualStyleBackColor = false;
            this.btnMenuUniversity.Click += new System.EventHandler(this.btnMenuUniversity_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(187)))));
            this.panelTop.Controls.Add(this.labelMenu);
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1100, 86);
            this.panelTop.TabIndex = 0;
            // 
            // labelMenu
            // 
            this.labelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMenu.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.Location = new System.Drawing.Point(131, 0);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(969, 86);
            this.labelMenu.TabIndex = 2;
            this.labelMenu.Text = "Pagina principala";
            this.labelMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Proiect_BD_SituatieScolara.Properties.Resources.University;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormInitializare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 610);
            this.Controls.Add(this.panelForm);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInitializare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University Manager";
            this.panelForm.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUSVLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnMenuStudents;
        private System.Windows.Forms.Button btnMenuUniversity;
        private System.Windows.Forms.PictureBox pictureBoxUSVLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button btnMenuMa;
    }
}

