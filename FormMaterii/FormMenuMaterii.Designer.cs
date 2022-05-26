namespace Proiect_BD_SituatieScolara
{
    partial class FormMenuMaterii
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuMaterii));
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelDelimiterBottom = new System.Windows.Forms.Panel();
            this.panelDelimiterTop = new System.Windows.Forms.Panel();
            this.panelDelimiterCenter = new System.Windows.Forms.Panel();
            this.buttonClearSearch = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();
            this.comboBoxSemestru = new System.Windows.Forms.ComboBox();
            this.comboBoxAn = new System.Windows.Forms.ComboBox();
            this.comboBoxProgramStudiu = new System.Windows.Forms.ComboBox();
            this.labelProgramStudiu = new System.Windows.Forms.Label();
            this.comboBoxSpecializare = new System.Windows.Forms.ComboBox();
            this.labelSpecializare = new System.Windows.Forms.Label();
            this.comboBoxFacultate = new System.Windows.Forms.ComboBox();
            this.labelFacultate = new System.Windows.Forms.Label();
            this.labelSemestru = new System.Windows.Forms.Label();
            this.labelAn = new System.Windows.Forms.Label();
            this.textBoxDenumire = new System.Windows.Forms.TextBox();
            this.labelDenumire = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelDelimiterRight = new System.Windows.Forms.Panel();
            this.panelDelimiterLeft = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnEliminaMaterie = new System.Windows.Forms.Button();
            this.pictureBoxUSVLogo = new System.Windows.Forms.PictureBox();
            this.btnModificaMaterie = new System.Windows.Forms.Button();
            this.btnAdaguaMaterie = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelMenuSubjects = new System.Windows.Forms.Label();
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
            this.panelDelimiterCenter.Controls.Add(this.comboBoxSemestru);
            this.panelDelimiterCenter.Controls.Add(this.comboBoxAn);
            this.panelDelimiterCenter.Controls.Add(this.comboBoxProgramStudiu);
            this.panelDelimiterCenter.Controls.Add(this.labelProgramStudiu);
            this.panelDelimiterCenter.Controls.Add(this.comboBoxSpecializare);
            this.panelDelimiterCenter.Controls.Add(this.labelSpecializare);
            this.panelDelimiterCenter.Controls.Add(this.comboBoxFacultate);
            this.panelDelimiterCenter.Controls.Add(this.labelFacultate);
            this.panelDelimiterCenter.Controls.Add(this.labelSemestru);
            this.panelDelimiterCenter.Controls.Add(this.labelAn);
            this.panelDelimiterCenter.Controls.Add(this.textBoxDenumire);
            this.panelDelimiterCenter.Controls.Add(this.labelDenumire);
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
            this.buttonClearSearch.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonClearSearch.Location = new System.Drawing.Point(740, 113);
            this.buttonClearSearch.Name = "buttonClearSearch";
            this.buttonClearSearch.Size = new System.Drawing.Size(33, 33);
            this.buttonClearSearch.TabIndex = 11;
            this.buttonClearSearch.Text = "q";
            this.buttonClearSearch.UseVisualStyleBackColor = true;
            this.buttonClearSearch.Click += new System.EventHandler(this.buttonClearSearch_Click);
            // 
            // btnCauta
            // 
            this.btnCauta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauta.Location = new System.Drawing.Point(779, 113);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(88, 33);
            this.btnCauta.TabIndex = 10;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // comboBoxSemestru
            // 
            this.comboBoxSemestru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSemestru.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.comboBoxSemestru.FormatString = "N0";
            this.comboBoxSemestru.FormattingEnabled = true;
            this.comboBoxSemestru.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxSemestru.Location = new System.Drawing.Point(116, 107);
            this.comboBoxSemestru.Name = "comboBoxSemestru";
            this.comboBoxSemestru.Size = new System.Drawing.Size(190, 39);
            this.comboBoxSemestru.TabIndex = 6;
            // 
            // comboBoxAn
            // 
            this.comboBoxAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAn.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.comboBoxAn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxAn.FormattingEnabled = true;
            this.comboBoxAn.Location = new System.Drawing.Point(116, 62);
            this.comboBoxAn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxAn.Name = "comboBoxAn";
            this.comboBoxAn.Size = new System.Drawing.Size(190, 39);
            this.comboBoxAn.TabIndex = 5;
            // 
            // comboBoxProgramStudiu
            // 
            this.comboBoxProgramStudiu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProgramStudiu.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.comboBoxProgramStudiu.FormattingEnabled = true;
            this.comboBoxProgramStudiu.Location = new System.Drawing.Point(477, 62);
            this.comboBoxProgramStudiu.Name = "comboBoxProgramStudiu";
            this.comboBoxProgramStudiu.Size = new System.Drawing.Size(188, 39);
            this.comboBoxProgramStudiu.TabIndex = 8;
            this.comboBoxProgramStudiu.SelectedIndexChanged += new System.EventHandler(this.comboBoxProgramStudiu_SelectedIndexChanged);
            // 
            // labelProgramStudiu
            // 
            this.labelProgramStudiu.AutoSize = true;
            this.labelProgramStudiu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgramStudiu.Location = new System.Drawing.Point(322, 73);
            this.labelProgramStudiu.Name = "labelProgramStudiu";
            this.labelProgramStudiu.Size = new System.Drawing.Size(149, 28);
            this.labelProgramStudiu.TabIndex = 17;
            this.labelProgramStudiu.Text = "Program Studiu";
            // 
            // comboBoxSpecializare
            // 
            this.comboBoxSpecializare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpecializare.DropDownWidth = 144;
            this.comboBoxSpecializare.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.comboBoxSpecializare.FormattingEnabled = true;
            this.comboBoxSpecializare.Location = new System.Drawing.Point(477, 107);
            this.comboBoxSpecializare.Name = "comboBoxSpecializare";
            this.comboBoxSpecializare.Size = new System.Drawing.Size(188, 39);
            this.comboBoxSpecializare.TabIndex = 9;
            this.comboBoxSpecializare.DropDown += new System.EventHandler(this.comboBox_DropDown);
            // 
            // labelSpecializare
            // 
            this.labelSpecializare.AutoSize = true;
            this.labelSpecializare.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpecializare.Location = new System.Drawing.Point(322, 118);
            this.labelSpecializare.Name = "labelSpecializare";
            this.labelSpecializare.Size = new System.Drawing.Size(115, 28);
            this.labelSpecializare.TabIndex = 15;
            this.labelSpecializare.Text = "Specializare";
            // 
            // comboBoxFacultate
            // 
            this.comboBoxFacultate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFacultate.DropDownWidth = 144;
            this.comboBoxFacultate.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.comboBoxFacultate.FormattingEnabled = true;
            this.comboBoxFacultate.ItemHeight = 31;
            this.comboBoxFacultate.Location = new System.Drawing.Point(477, 20);
            this.comboBoxFacultate.Name = "comboBoxFacultate";
            this.comboBoxFacultate.Size = new System.Drawing.Size(188, 39);
            this.comboBoxFacultate.TabIndex = 7;
            this.comboBoxFacultate.DropDown += new System.EventHandler(this.comboBox_DropDown);
            this.comboBoxFacultate.SelectedIndexChanged += new System.EventHandler(this.comboBoxFacultate_SelectedIndexChanged);
            // 
            // labelFacultate
            // 
            this.labelFacultate.AutoSize = true;
            this.labelFacultate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacultate.Location = new System.Drawing.Point(322, 31);
            this.labelFacultate.Name = "labelFacultate";
            this.labelFacultate.Size = new System.Drawing.Size(90, 28);
            this.labelFacultate.TabIndex = 12;
            this.labelFacultate.Text = "Facultate";
            // 
            // labelSemestru
            // 
            this.labelSemestru.AutoSize = true;
            this.labelSemestru.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemestru.Location = new System.Drawing.Point(17, 118);
            this.labelSemestru.Name = "labelSemestru";
            this.labelSemestru.Size = new System.Drawing.Size(93, 28);
            this.labelSemestru.TabIndex = 5;
            this.labelSemestru.Text = "Semestru";
            // 
            // labelAn
            // 
            this.labelAn.AutoSize = true;
            this.labelAn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAn.Location = new System.Drawing.Point(17, 73);
            this.labelAn.Name = "labelAn";
            this.labelAn.Size = new System.Drawing.Size(36, 28);
            this.labelAn.TabIndex = 3;
            this.labelAn.Text = "An";
            // 
            // textBoxDenumire
            // 
            this.textBoxDenumire.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDenumire.Location = new System.Drawing.Point(116, 21);
            this.textBoxDenumire.Name = "textBoxDenumire";
            this.textBoxDenumire.Size = new System.Drawing.Size(190, 38);
            this.textBoxDenumire.TabIndex = 4;
            // 
            // labelDenumire
            // 
            this.labelDenumire.AutoSize = true;
            this.labelDenumire.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDenumire.Location = new System.Drawing.Point(17, 31);
            this.labelDenumire.Name = "labelDenumire";
            this.labelDenumire.Size = new System.Drawing.Size(97, 28);
            this.labelDenumire.TabIndex = 1;
            this.labelDenumire.Text = "Denumire";
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(14, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(853, 339);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.TabStop = false;
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
            this.panelLeft.Controls.Add(this.btnEliminaMaterie);
            this.panelLeft.Controls.Add(this.pictureBoxUSVLogo);
            this.panelLeft.Controls.Add(this.btnModificaMaterie);
            this.panelLeft.Controls.Add(this.btnAdaguaMaterie);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 86);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(0, 11, 0, 0);
            this.panelLeft.Size = new System.Drawing.Size(131, 524);
            this.panelLeft.TabIndex = 1;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(183)))), ((int)(((byte)(160)))));
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Wingdings 3", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnReturn.Location = new System.Drawing.Point(0, 230);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(131, 73);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "O";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // btnEliminaMaterie
            // 
            this.btnEliminaMaterie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(183)))), ((int)(((byte)(160)))));
            this.btnEliminaMaterie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminaMaterie.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminaMaterie.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.btnEliminaMaterie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminaMaterie.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminaMaterie.Location = new System.Drawing.Point(0, 157);
            this.btnEliminaMaterie.Name = "btnEliminaMaterie";
            this.btnEliminaMaterie.Size = new System.Drawing.Size(131, 73);
            this.btnEliminaMaterie.TabIndex = 2;
            this.btnEliminaMaterie.Text = "Elimina";
            this.btnEliminaMaterie.UseVisualStyleBackColor = false;
            this.btnEliminaMaterie.Click += new System.EventHandler(this.btnEliminaMaterie_Click);
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
            // btnModificaMaterie
            // 
            this.btnModificaMaterie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(183)))), ((int)(((byte)(160)))));
            this.btnModificaMaterie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificaMaterie.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificaMaterie.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.btnModificaMaterie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificaMaterie.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificaMaterie.Location = new System.Drawing.Point(0, 84);
            this.btnModificaMaterie.Name = "btnModificaMaterie";
            this.btnModificaMaterie.Size = new System.Drawing.Size(131, 73);
            this.btnModificaMaterie.TabIndex = 1;
            this.btnModificaMaterie.Text = "Modifica";
            this.btnModificaMaterie.UseVisualStyleBackColor = false;
            this.btnModificaMaterie.Click += new System.EventHandler(this.btnModificaMaterie_Click);
            // 
            // btnAdaguaMaterie
            // 
            this.btnAdaguaMaterie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(183)))), ((int)(((byte)(160)))));
            this.btnAdaguaMaterie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdaguaMaterie.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdaguaMaterie.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.btnAdaguaMaterie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdaguaMaterie.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaguaMaterie.Location = new System.Drawing.Point(0, 11);
            this.btnAdaguaMaterie.Name = "btnAdaguaMaterie";
            this.btnAdaguaMaterie.Size = new System.Drawing.Size(131, 73);
            this.btnAdaguaMaterie.TabIndex = 0;
            this.btnAdaguaMaterie.Text = "Adauga";
            this.btnAdaguaMaterie.UseVisualStyleBackColor = false;
            this.btnAdaguaMaterie.Click += new System.EventHandler(this.btnAdaguaMaterie_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(205)))), ((int)(((byte)(187)))));
            this.panelTop.Controls.Add(this.labelMenuSubjects);
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1100, 86);
            this.panelTop.TabIndex = 0;
            // 
            // labelMenuSubjects
            // 
            this.labelMenuSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMenuSubjects.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuSubjects.Location = new System.Drawing.Point(131, 0);
            this.labelMenuSubjects.Name = "labelMenuSubjects";
            this.labelMenuSubjects.Size = new System.Drawing.Size(969, 86);
            this.labelMenuSubjects.TabIndex = 1;
            this.labelMenuSubjects.Text = "Meniu Materii";
            this.labelMenuSubjects.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // FormMenuMaterii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 610);
            this.Controls.Add(this.panelForm);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenuMaterii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenuMaterii_FormClosing);
            this.Load += new System.EventHandler(this.FormMenuMaterii_Load);
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
        private System.Windows.Forms.Button btnModificaMaterie;
        private System.Windows.Forms.Button btnAdaguaMaterie;
        private System.Windows.Forms.PictureBox pictureBoxUSVLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDelimiterLeft;
        private System.Windows.Forms.Panel panelDelimiterCenter;
        private System.Windows.Forms.Panel panelDelimiterRight;
        private System.Windows.Forms.Panel panelDelimiterBottom;
        private System.Windows.Forms.Panel panelDelimiterTop;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelAn;
        private System.Windows.Forms.TextBox textBoxDenumire;
        private System.Windows.Forms.Label labelDenumire;
        private System.Windows.Forms.Button btnEliminaMaterie;
        private System.Windows.Forms.Label labelMenuSubjects;
        private System.Windows.Forms.Label labelSemestru;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox comboBoxProgramStudiu;
        private System.Windows.Forms.Label labelProgramStudiu;
        private System.Windows.Forms.ComboBox comboBoxSpecializare;
        private System.Windows.Forms.Label labelSpecializare;
        private System.Windows.Forms.ComboBox comboBoxFacultate;
        private System.Windows.Forms.Label labelFacultate;
        private System.Windows.Forms.ComboBox comboBoxAn;
        private System.Windows.Forms.ComboBox comboBoxSemestru;
        private System.Windows.Forms.Button buttonClearSearch;
        private System.Windows.Forms.Button btnCauta;
    }
}

