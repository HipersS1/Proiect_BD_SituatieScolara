namespace Proiect_BD_SituatieScolara
{
    partial class FormMenuStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuStudent));
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelDelimiterBottom = new System.Windows.Forms.Panel();
            this.panelDelimiterTop = new System.Windows.Forms.Panel();
            this.panelDelimiterCenter = new System.Windows.Forms.Panel();
            this.buttonClearSearch = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();
            this.comboBoxCicluStudiu = new System.Windows.Forms.ComboBox();
            this.labelProgramStudiu = new System.Windows.Forms.Label();
            this.comboBoxSpecializare = new System.Windows.Forms.ComboBox();
            this.labelSpecializare = new System.Windows.Forms.Label();
            this.comboBoxFacultate = new System.Windows.Forms.ComboBox();
            this.labelFacultate = new System.Windows.Forms.Label();
            this.textBoxPrenume = new System.Windows.Forms.TextBox();
            this.labelPrenume = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.labelNume = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelDelimiterRight = new System.Windows.Forms.Panel();
            this.panelDelimiterLeft = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAdaugaNote = new System.Windows.Forms.Button();
            this.btnEliminaStudent = new System.Windows.Forms.Button();
            this.pictureBoxUSVLogo = new System.Windows.Forms.PictureBox();
            this.btnModificaStudent = new System.Windows.Forms.Button();
            this.btnAdaugaStudent = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelMenuStudents = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelForm.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.panelDelimiterCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panelCenter.Controls.Add(this.panelDelimiterBottom);
            this.panelCenter.Controls.Add(this.panelDelimiterTop);
            this.panelCenter.Controls.Add(this.panelDelimiterCenter);
            this.panelCenter.Controls.Add(this.panelDelimiterRight);
            this.panelCenter.Controls.Add(this.panelDelimiterLeft);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(131, 86);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(969, 524);
            this.panelCenter.TabIndex = 2;
            // 
            // panelDelimiterBottom
            // 
            this.panelDelimiterBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDelimiterBottom.Location = new System.Drawing.Point(44, 508);
            this.panelDelimiterBottom.Name = "panelDelimiterBottom";
            this.panelDelimiterBottom.Size = new System.Drawing.Size(881, 16);
            this.panelDelimiterBottom.TabIndex = 4;
            // 
            // panelDelimiterTop
            // 
            this.panelDelimiterTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDelimiterTop.Location = new System.Drawing.Point(44, 0);
            this.panelDelimiterTop.Name = "panelDelimiterTop";
            this.panelDelimiterTop.Size = new System.Drawing.Size(881, 16);
            this.panelDelimiterTop.TabIndex = 3;
            // 
            // panelDelimiterCenter
            // 
            this.panelDelimiterCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(187)))));
            this.panelDelimiterCenter.Controls.Add(this.buttonClearSearch);
            this.panelDelimiterCenter.Controls.Add(this.btnCauta);
            this.panelDelimiterCenter.Controls.Add(this.comboBoxCicluStudiu);
            this.panelDelimiterCenter.Controls.Add(this.labelProgramStudiu);
            this.panelDelimiterCenter.Controls.Add(this.comboBoxSpecializare);
            this.panelDelimiterCenter.Controls.Add(this.labelSpecializare);
            this.panelDelimiterCenter.Controls.Add(this.comboBoxFacultate);
            this.panelDelimiterCenter.Controls.Add(this.labelFacultate);
            this.panelDelimiterCenter.Controls.Add(this.textBoxPrenume);
            this.panelDelimiterCenter.Controls.Add(this.labelPrenume);
            this.panelDelimiterCenter.Controls.Add(this.textBoxNume);
            this.panelDelimiterCenter.Controls.Add(this.labelNume);
            this.panelDelimiterCenter.Controls.Add(this.dataGridView1);
            this.panelDelimiterCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDelimiterCenter.Location = new System.Drawing.Point(44, 0);
            this.panelDelimiterCenter.Name = "panelDelimiterCenter";
            this.panelDelimiterCenter.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.panelDelimiterCenter.Size = new System.Drawing.Size(881, 524);
            this.panelDelimiterCenter.TabIndex = 2;
            // 
            // buttonClearSearch
            // 
            this.buttonClearSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearSearch.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonClearSearch.Location = new System.Drawing.Point(740, 77);
            this.buttonClearSearch.Name = "buttonClearSearch";
            this.buttonClearSearch.Size = new System.Drawing.Size(33, 33);
            this.buttonClearSearch.TabIndex = 12;
            this.buttonClearSearch.Text = "q";
            this.buttonClearSearch.UseVisualStyleBackColor = true;
            this.buttonClearSearch.Click += new System.EventHandler(this.buttonClearSearch_Click);
            // 
            // btnCauta
            // 
            this.btnCauta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCauta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauta.Location = new System.Drawing.Point(779, 77);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(88, 33);
            this.btnCauta.TabIndex = 11;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // comboBoxCicluStudiu
            // 
            this.comboBoxCicluStudiu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCicluStudiu.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCicluStudiu.FormattingEnabled = true;
            this.comboBoxCicluStudiu.Location = new System.Drawing.Point(364, 69);
            this.comboBoxCicluStudiu.Name = "comboBoxCicluStudiu";
            this.comboBoxCicluStudiu.Size = new System.Drawing.Size(188, 36);
            this.comboBoxCicluStudiu.TabIndex = 9;
            this.comboBoxCicluStudiu.SelectedIndexChanged += new System.EventHandler(this.comboBoxProgramStudiu_SelectedIndexChanged);
            // 
            // labelProgramStudiu
            // 
            this.labelProgramStudiu.AutoSize = true;
            this.labelProgramStudiu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgramStudiu.Location = new System.Drawing.Point(247, 78);
            this.labelProgramStudiu.Name = "labelProgramStudiu";
            this.labelProgramStudiu.Size = new System.Drawing.Size(145, 28);
            this.labelProgramStudiu.TabIndex = 11;
            this.labelProgramStudiu.Text = "Ciclul de studiu";
            // 
            // comboBoxSpecializare
            // 
            this.comboBoxSpecializare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpecializare.DropDownWidth = 144;
            this.comboBoxSpecializare.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSpecializare.FormattingEnabled = true;
            this.comboBoxSpecializare.Location = new System.Drawing.Point(679, 23);
            this.comboBoxSpecializare.Name = "comboBoxSpecializare";
            this.comboBoxSpecializare.Size = new System.Drawing.Size(188, 36);
            this.comboBoxSpecializare.TabIndex = 10;
            this.comboBoxSpecializare.DropDown += new System.EventHandler(this.comboBox_DropDown);
            // 
            // labelSpecializare
            // 
            this.labelSpecializare.AutoSize = true;
            this.labelSpecializare.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpecializare.Location = new System.Drawing.Point(558, 30);
            this.labelSpecializare.Name = "labelSpecializare";
            this.labelSpecializare.Size = new System.Drawing.Size(115, 28);
            this.labelSpecializare.TabIndex = 9;
            this.labelSpecializare.Text = "Specializare";
            // 
            // comboBoxFacultate
            // 
            this.comboBoxFacultate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFacultate.DropDownWidth = 144;
            this.comboBoxFacultate.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFacultate.FormattingEnabled = true;
            this.comboBoxFacultate.ItemHeight = 28;
            this.comboBoxFacultate.Location = new System.Drawing.Point(364, 23);
            this.comboBoxFacultate.Name = "comboBoxFacultate";
            this.comboBoxFacultate.Size = new System.Drawing.Size(188, 36);
            this.comboBoxFacultate.TabIndex = 8;
            this.comboBoxFacultate.DropDown += new System.EventHandler(this.comboBox_DropDown);
            this.comboBoxFacultate.SelectedIndexChanged += new System.EventHandler(this.comboBoxFacultate_SelectedIndexChanged);
            // 
            // labelFacultate
            // 
            this.labelFacultate.AutoSize = true;
            this.labelFacultate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacultate.Location = new System.Drawing.Point(247, 31);
            this.labelFacultate.Name = "labelFacultate";
            this.labelFacultate.Size = new System.Drawing.Size(90, 28);
            this.labelFacultate.TabIndex = 5;
            this.labelFacultate.Text = "Facultate";
            // 
            // textBoxPrenume
            // 
            this.textBoxPrenume.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrenume.Location = new System.Drawing.Point(98, 68);
            this.textBoxPrenume.Name = "textBoxPrenume";
            this.textBoxPrenume.Size = new System.Drawing.Size(145, 36);
            this.textBoxPrenume.TabIndex = 7;
            // 
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenume.Location = new System.Drawing.Point(9, 76);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(89, 28);
            this.labelPrenume.TabIndex = 3;
            this.labelPrenume.Text = "Prenume";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNume.Location = new System.Drawing.Point(98, 22);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(145, 36);
            this.textBoxNume.TabIndex = 6;
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNume.Location = new System.Drawing.Point(9, 31);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(65, 28);
            this.labelNume.TabIndex = 1;
            this.labelNume.Text = "Nume";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(187)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(14, 116);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(853, 375);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            // 
            // panelDelimiterRight
            // 
            this.panelDelimiterRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDelimiterRight.Location = new System.Drawing.Point(925, 0);
            this.panelDelimiterRight.Name = "panelDelimiterRight";
            this.panelDelimiterRight.Size = new System.Drawing.Size(44, 524);
            this.panelDelimiterRight.TabIndex = 1;
            // 
            // panelDelimiterLeft
            // 
            this.panelDelimiterLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDelimiterLeft.Location = new System.Drawing.Point(0, 0);
            this.panelDelimiterLeft.Name = "panelDelimiterLeft";
            this.panelDelimiterLeft.Size = new System.Drawing.Size(44, 524);
            this.panelDelimiterLeft.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(187)))));
            this.panelLeft.Controls.Add(this.btnReturn);
            this.panelLeft.Controls.Add(this.btnAdaugaNote);
            this.panelLeft.Controls.Add(this.btnEliminaStudent);
            this.panelLeft.Controls.Add(this.pictureBoxUSVLogo);
            this.panelLeft.Controls.Add(this.btnModificaStudent);
            this.panelLeft.Controls.Add(this.btnAdaugaStudent);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 86);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.panelLeft.Size = new System.Drawing.Size(131, 524);
            this.panelLeft.TabIndex = 1;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(183)))), ((int)(((byte)(160)))));
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(187)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Wingdings 3", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnReturn.Location = new System.Drawing.Point(0, 392);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(131, 73);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "O";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAdaugaNote
            // 
            this.btnAdaugaNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(183)))), ((int)(((byte)(160)))));
            this.btnAdaugaNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdaugaNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdaugaNote.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(187)))));
            this.btnAdaugaNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdaugaNote.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaNote.Location = new System.Drawing.Point(0, 234);
            this.btnAdaugaNote.Name = "btnAdaugaNote";
            this.btnAdaugaNote.Size = new System.Drawing.Size(131, 73);
            this.btnAdaugaNote.TabIndex = 3;
            this.btnAdaugaNote.Text = "Adauga Note";
            this.btnAdaugaNote.UseVisualStyleBackColor = false;
            this.btnAdaugaNote.Click += new System.EventHandler(this.btnAdaugaNote_Click);
            // 
            // btnEliminaStudent
            // 
            this.btnEliminaStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(183)))), ((int)(((byte)(160)))));
            this.btnEliminaStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminaStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminaStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(187)))));
            this.btnEliminaStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminaStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminaStudent.Location = new System.Drawing.Point(0, 161);
            this.btnEliminaStudent.Name = "btnEliminaStudent";
            this.btnEliminaStudent.Size = new System.Drawing.Size(131, 73);
            this.btnEliminaStudent.TabIndex = 2;
            this.btnEliminaStudent.Text = "Elimina";
            this.btnEliminaStudent.UseVisualStyleBackColor = false;
            this.btnEliminaStudent.Click += new System.EventHandler(this.btnEliminaStudent_Click);
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
            // btnModificaStudent
            // 
            this.btnModificaStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(183)))), ((int)(((byte)(160)))));
            this.btnModificaStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificaStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificaStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(187)))));
            this.btnModificaStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificaStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificaStudent.Location = new System.Drawing.Point(0, 88);
            this.btnModificaStudent.Name = "btnModificaStudent";
            this.btnModificaStudent.Size = new System.Drawing.Size(131, 73);
            this.btnModificaStudent.TabIndex = 1;
            this.btnModificaStudent.Text = "Modifica";
            this.btnModificaStudent.UseVisualStyleBackColor = false;
            this.btnModificaStudent.Click += new System.EventHandler(this.btnModificaStudent_Click);
            // 
            // btnAdaugaStudent
            // 
            this.btnAdaugaStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(183)))), ((int)(((byte)(160)))));
            this.btnAdaugaStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdaugaStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdaugaStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(187)))));
            this.btnAdaugaStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdaugaStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaStudent.Location = new System.Drawing.Point(0, 15);
            this.btnAdaugaStudent.Name = "btnAdaugaStudent";
            this.btnAdaugaStudent.Size = new System.Drawing.Size(131, 73);
            this.btnAdaugaStudent.TabIndex = 0;
            this.btnAdaugaStudent.Text = "Adauga";
            this.btnAdaugaStudent.UseVisualStyleBackColor = false;
            this.btnAdaugaStudent.Click += new System.EventHandler(this.btnAdaugaStudent_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(187)))));
            this.panelTop.Controls.Add(this.labelMenuStudents);
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1100, 86);
            this.panelTop.TabIndex = 0;
            // 
            // labelMenuStudents
            // 
            this.labelMenuStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMenuStudents.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold);
            this.labelMenuStudents.Location = new System.Drawing.Point(131, 0);
            this.labelMenuStudents.Name = "labelMenuStudents";
            this.labelMenuStudents.Size = new System.Drawing.Size(969, 86);
            this.labelMenuStudents.TabIndex = 1;
            this.labelMenuStudents.Text = "Administrare Studenti";
            this.labelMenuStudents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // FormMenuStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 610);
            this.Controls.Add(this.panelForm);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenuStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenuStudent_FormClosing);
            this.Load += new System.EventHandler(this.FormMenuStudent_Load);
            this.panelForm.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.panelDelimiterCenter.ResumeLayout(false);
            this.panelDelimiterCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button btnModificaStudent;
        private System.Windows.Forms.Button btnAdaugaStudent;
        private System.Windows.Forms.PictureBox pictureBoxUSVLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDelimiterLeft;
        private System.Windows.Forms.Panel panelDelimiterCenter;
        private System.Windows.Forms.Panel panelDelimiterRight;
        private System.Windows.Forms.Panel panelDelimiterBottom;
        private System.Windows.Forms.Panel panelDelimiterTop;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxPrenume;
        private System.Windows.Forms.Label labelPrenume;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Button btnEliminaStudent;
        private System.Windows.Forms.Label labelMenuStudents;
        private System.Windows.Forms.Label labelFacultate;
        private System.Windows.Forms.Button btnAdaugaNote;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox comboBoxFacultate;
        private System.Windows.Forms.ComboBox comboBoxSpecializare;
        private System.Windows.Forms.Label labelSpecializare;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.ComboBox comboBoxCicluStudiu;
        private System.Windows.Forms.Label labelProgramStudiu;
        private System.Windows.Forms.Button buttonClearSearch;
    }
}

