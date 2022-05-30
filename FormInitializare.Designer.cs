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
            this.panelBackground = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.pictureBoxUSVLogo = new System.Windows.Forms.PictureBox();
            this.btnMenuStudents = new System.Windows.Forms.Button();
            this.btnMenuMaterii = new System.Windows.Forms.Button();
            this.btnMenuUniversity = new System.Windows.Forms.Button();
            this.btnFake = new System.Windows.Forms.Button();
            this.panelBottomMenu = new System.Windows.Forms.Panel();
            this.panelUpMenu = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelMenu = new System.Windows.Forms.Label();
            this.panelForm.SuspendLayout();
            this.panelBackground.SuspendLayout();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUSVLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.panelBackground);
            this.panelForm.Controls.Add(this.panelTop);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1100, 610);
            this.panelForm.TabIndex = 0;
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelBackground.Controls.Add(this.panelCenter);
            this.panelBackground.Controls.Add(this.panelBottomMenu);
            this.panelBackground.Controls.Add(this.panelUpMenu);
            this.panelBackground.Controls.Add(this.panelLeft);
            this.panelBackground.Controls.Add(this.panelRight);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 86);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1100, 524);
            this.panelBackground.TabIndex = 3;
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(140)))), ((int)(((byte)(110)))));
            this.panelCenter.Controls.Add(this.pictureBoxUSVLogo);
            this.panelCenter.Controls.Add(this.btnMenuStudents);
            this.panelCenter.Controls.Add(this.btnMenuMaterii);
            this.panelCenter.Controls.Add(this.btnMenuUniversity);
            this.panelCenter.Controls.Add(this.btnFake);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(300, 20);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(500, 484);
            this.panelCenter.TabIndex = 7;
            // 
            // pictureBoxUSVLogo
            // 
            this.pictureBoxUSVLogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBoxUSVLogo.Image = global::Proiect_BD_SituatieScolara.Properties.Resources._640px_Ștefan_cel_Mare_University_of_Suceava_logo_svg;
            this.pictureBoxUSVLogo.InitialImage = global::Proiect_BD_SituatieScolara.Properties.Resources.universitatea_suceava_usv_968x460;
            this.pictureBoxUSVLogo.Location = new System.Drawing.Point(0, 439);
            this.pictureBoxUSVLogo.Name = "pictureBoxUSVLogo";
            this.pictureBoxUSVLogo.Size = new System.Drawing.Size(500, 45);
            this.pictureBoxUSVLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUSVLogo.TabIndex = 0;
            this.pictureBoxUSVLogo.TabStop = false;
            // 
            // btnMenuStudents
            // 
            this.btnMenuStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(125)))));
            this.btnMenuStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuStudents.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(140)))), ((int)(((byte)(110)))));
            this.btnMenuStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuStudents.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuStudents.Location = new System.Drawing.Point(0, 250);
            this.btnMenuStudents.Margin = new System.Windows.Forms.Padding(50);
            this.btnMenuStudents.Name = "btnMenuStudents";
            this.btnMenuStudents.Size = new System.Drawing.Size(500, 85);
            this.btnMenuStudents.TabIndex = 2;
            this.btnMenuStudents.Text = "Studenti";
            this.btnMenuStudents.UseVisualStyleBackColor = false;
            this.btnMenuStudents.Click += new System.EventHandler(this.btnMenuStudents_Click);
            // 
            // btnMenuMaterii
            // 
            this.btnMenuMaterii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(125)))));
            this.btnMenuMaterii.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuMaterii.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(140)))), ((int)(((byte)(110)))));
            this.btnMenuMaterii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuMaterii.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuMaterii.Location = new System.Drawing.Point(0, 165);
            this.btnMenuMaterii.Margin = new System.Windows.Forms.Padding(50);
            this.btnMenuMaterii.Name = "btnMenuMaterii";
            this.btnMenuMaterii.Size = new System.Drawing.Size(500, 85);
            this.btnMenuMaterii.TabIndex = 1;
            this.btnMenuMaterii.Text = "Materii";
            this.btnMenuMaterii.UseVisualStyleBackColor = false;
            this.btnMenuMaterii.Click += new System.EventHandler(this.btnMenuMaterii_Click);
            // 
            // btnMenuUniversity
            // 
            this.btnMenuUniversity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(125)))));
            this.btnMenuUniversity.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuUniversity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(140)))), ((int)(((byte)(110)))));
            this.btnMenuUniversity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuUniversity.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuUniversity.Location = new System.Drawing.Point(0, 80);
            this.btnMenuUniversity.Margin = new System.Windows.Forms.Padding(50);
            this.btnMenuUniversity.Name = "btnMenuUniversity";
            this.btnMenuUniversity.Size = new System.Drawing.Size(500, 85);
            this.btnMenuUniversity.TabIndex = 0;
            this.btnMenuUniversity.Text = "Facultati";
            this.btnMenuUniversity.UseVisualStyleBackColor = false;
            this.btnMenuUniversity.Click += new System.EventHandler(this.btnMenuUniversity_Click);
            // 
            // btnFake
            // 
            this.btnFake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(125)))));
            this.btnFake.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFake.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(125)))));
            this.btnFake.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(125)))));
            this.btnFake.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(125)))));
            this.btnFake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFake.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFake.Location = new System.Drawing.Point(0, 0);
            this.btnFake.Name = "btnFake";
            this.btnFake.Size = new System.Drawing.Size(500, 80);
            this.btnFake.TabIndex = 2;
            this.btnFake.TabStop = false;
            this.btnFake.Text = "Selecteaza meniul";
            this.btnFake.UseVisualStyleBackColor = false;
            // 
            // panelBottomMenu
            // 
            this.panelBottomMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(190)))), ((int)(((byte)(160)))));
            this.panelBottomMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomMenu.Location = new System.Drawing.Point(300, 504);
            this.panelBottomMenu.Name = "panelBottomMenu";
            this.panelBottomMenu.Size = new System.Drawing.Size(500, 20);
            this.panelBottomMenu.TabIndex = 6;
            // 
            // panelUpMenu
            // 
            this.panelUpMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(140)))), ((int)(((byte)(110)))));
            this.panelUpMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpMenu.Location = new System.Drawing.Point(300, 0);
            this.panelUpMenu.Name = "panelUpMenu";
            this.panelUpMenu.Size = new System.Drawing.Size(500, 20);
            this.panelUpMenu.TabIndex = 5;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(190)))), ((int)(((byte)(160)))));
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(300, 524);
            this.panelLeft.TabIndex = 4;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(190)))), ((int)(((byte)(160)))));
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(800, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(300, 524);
            this.panelRight.TabIndex = 2;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(140)))), ((int)(((byte)(110)))));
            this.panelTop.Controls.Add(this.pictureBox2);
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Controls.Add(this.labelMenu);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1100, 86);
            this.panelTop.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::Proiect_BD_SituatieScolara.Properties.Resources.University;
            this.pictureBox2.Location = new System.Drawing.Point(800, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Proiect_BD_SituatieScolara.Properties.Resources.University;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelMenu
            // 
            this.labelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMenu.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.Location = new System.Drawing.Point(0, 0);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(1100, 86);
            this.labelMenu.TabIndex = 2;
            this.labelMenu.Text = "University Manager";
            this.labelMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormInitializare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 610);
            this.Controls.Add(this.panelForm);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInitializare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University Manager";
            this.panelForm.ResumeLayout(false);
            this.panelBackground.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUSVLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnMenuStudents;
        private System.Windows.Forms.Button btnMenuUniversity;
        private System.Windows.Forms.PictureBox pictureBoxUSVLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button btnMenuMaterii;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Panel panelUpMenu;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Button btnFake;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelBottomMenu;
    }
}

