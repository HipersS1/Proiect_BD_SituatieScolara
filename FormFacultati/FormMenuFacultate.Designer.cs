namespace Proiect_BD_SituatieScolara
{
    partial class FormMenuFacultate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuFacultate));
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelDelimiterBottom = new System.Windows.Forms.Panel();
            this.panelDelimiterTop = new System.Windows.Forms.Panel();
            this.panelDelimiterCenter = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelNumarElemente = new System.Windows.Forms.Label();
            this.panelMenuHeader = new System.Windows.Forms.Panel();
            this.labelMenuHeader = new System.Windows.Forms.Label();
            this.buttonClearSearch = new System.Windows.Forms.Button();
            this.comboBoxCicluStudiu = new System.Windows.Forms.ComboBox();
            this.labelCicluStudiu = new System.Windows.Forms.Label();
            this.comboBoxDurata = new System.Windows.Forms.ComboBox();
            this.labelDurata = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBoxCampNume = new System.Windows.Forms.TextBox();
            this.labelCampNume = new System.Windows.Forms.Label();
            this.panelDelimiterRight = new System.Windows.Forms.Panel();
            this.panelDelimiterLeft = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.buttonVizualizeazaMaterii = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.buttonVizualizeazaPrograme = new System.Windows.Forms.Button();
            this.btnStergeFacultate = new System.Windows.Forms.Button();
            this.pictureBoxUSVLogo = new System.Windows.Forms.PictureBox();
            this.btnModificaFacultate = new System.Windows.Forms.Button();
            this.btnAdaugaFacultate = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelMeniuFacultate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelForm.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.panelDelimiterCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelMenuHeader.SuspendLayout();
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
            this.panelCenter.Location = new System.Drawing.Point(140, 86);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(960, 524);
            this.panelCenter.TabIndex = 2;
            // 
            // panelDelimiterBottom
            // 
            this.panelDelimiterBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(190)))), ((int)(((byte)(160)))));
            this.panelDelimiterBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDelimiterBottom.Location = new System.Drawing.Point(44, 508);
            this.panelDelimiterBottom.Name = "panelDelimiterBottom";
            this.panelDelimiterBottom.Size = new System.Drawing.Size(872, 16);
            this.panelDelimiterBottom.TabIndex = 4;
            // 
            // panelDelimiterTop
            // 
            this.panelDelimiterTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(190)))), ((int)(((byte)(160)))));
            this.panelDelimiterTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDelimiterTop.Location = new System.Drawing.Point(44, 0);
            this.panelDelimiterTop.Name = "panelDelimiterTop";
            this.panelDelimiterTop.Size = new System.Drawing.Size(872, 16);
            this.panelDelimiterTop.TabIndex = 3;
            // 
            // panelDelimiterCenter
            // 
            this.panelDelimiterCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(125)))));
            this.panelDelimiterCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDelimiterCenter.Controls.Add(this.btnSearch);
            this.panelDelimiterCenter.Controls.Add(this.dataGridView1);
            this.panelDelimiterCenter.Controls.Add(this.labelNumarElemente);
            this.panelDelimiterCenter.Controls.Add(this.panelMenuHeader);
            this.panelDelimiterCenter.Controls.Add(this.buttonClearSearch);
            this.panelDelimiterCenter.Controls.Add(this.comboBoxCicluStudiu);
            this.panelDelimiterCenter.Controls.Add(this.labelCicluStudiu);
            this.panelDelimiterCenter.Controls.Add(this.comboBoxDurata);
            this.panelDelimiterCenter.Controls.Add(this.labelDurata);
            this.panelDelimiterCenter.Controls.Add(this.textBoxCampNume);
            this.panelDelimiterCenter.Controls.Add(this.labelCampNume);
            this.panelDelimiterCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDelimiterCenter.Location = new System.Drawing.Point(44, 0);
            this.panelDelimiterCenter.Name = "panelDelimiterCenter";
            this.panelDelimiterCenter.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.panelDelimiterCenter.Size = new System.Drawing.Size(872, 524);
            this.panelDelimiterCenter.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(140)))), ((int)(((byte)(110)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(125)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(190)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(14, 110);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(842, 369);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged_1);
            // 
            // labelNumarElemente
            // 
            this.labelNumarElemente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumarElemente.AutoSize = true;
            this.labelNumarElemente.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumarElemente.Location = new System.Drawing.Point(724, 479);
            this.labelNumarElemente.Name = "labelNumarElemente";
            this.labelNumarElemente.Size = new System.Drawing.Size(112, 25);
            this.labelNumarElemente.TabIndex = 17;
            this.labelNumarElemente.Text = "nr.elemente";
            this.labelNumarElemente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelMenuHeader
            // 
            this.panelMenuHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenuHeader.BackColor = System.Drawing.Color.Yellow;
            this.panelMenuHeader.Controls.Add(this.labelMenuHeader);
            this.panelMenuHeader.Location = new System.Drawing.Point(0, 15);
            this.panelMenuHeader.Name = "panelMenuHeader";
            this.panelMenuHeader.Size = new System.Drawing.Size(870, 42);
            this.panelMenuHeader.TabIndex = 16;
            // 
            // labelMenuHeader
            // 
            this.labelMenuHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMenuHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(125)))));
            this.labelMenuHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuHeader.Location = new System.Drawing.Point(0, 0);
            this.labelMenuHeader.Name = "labelMenuHeader";
            this.labelMenuHeader.Size = new System.Drawing.Size(870, 42);
            this.labelMenuHeader.TabIndex = 2;
            this.labelMenuHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClearSearch
            // 
            this.buttonClearSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearSearch.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonClearSearch.Location = new System.Drawing.Point(725, 66);
            this.buttonClearSearch.Name = "buttonClearSearch";
            this.buttonClearSearch.Size = new System.Drawing.Size(40, 33);
            this.buttonClearSearch.TabIndex = 15;
            this.buttonClearSearch.Text = "q";
            this.buttonClearSearch.UseVisualStyleBackColor = true;
            this.buttonClearSearch.Click += new System.EventHandler(this.buttonClearSearch_Click);
            // 
            // comboBoxCicluStudiu
            // 
            this.comboBoxCicluStudiu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCicluStudiu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxCicluStudiu.FormatString = "N0";
            this.comboBoxCicluStudiu.FormattingEnabled = true;
            this.comboBoxCicluStudiu.Location = new System.Drawing.Point(426, 60);
            this.comboBoxCicluStudiu.Name = "comboBoxCicluStudiu";
            this.comboBoxCicluStudiu.Size = new System.Drawing.Size(95, 36);
            this.comboBoxCicluStudiu.TabIndex = 6;
            // 
            // labelCicluStudiu
            // 
            this.labelCicluStudiu.AutoSize = true;
            this.labelCicluStudiu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCicluStudiu.Location = new System.Drawing.Point(316, 68);
            this.labelCicluStudiu.Name = "labelCicluStudiu";
            this.labelCicluStudiu.Size = new System.Drawing.Size(140, 28);
            this.labelCicluStudiu.TabIndex = 12;
            this.labelCicluStudiu.Text = "Ciclu de studiu";
            // 
            // comboBoxDurata
            // 
            this.comboBoxDurata.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDurata.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxDurata.FormatString = "N0";
            this.comboBoxDurata.FormattingEnabled = true;
            this.comboBoxDurata.Location = new System.Drawing.Point(604, 60);
            this.comboBoxDurata.Name = "comboBoxDurata";
            this.comboBoxDurata.Size = new System.Drawing.Size(72, 36);
            this.comboBoxDurata.TabIndex = 7;
            // 
            // labelDurata
            // 
            this.labelDurata.AutoSize = true;
            this.labelDurata.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDurata.Location = new System.Drawing.Point(527, 71);
            this.labelDurata.Name = "labelDurata";
            this.labelDurata.Size = new System.Drawing.Size(71, 28);
            this.labelDurata.TabIndex = 10;
            this.labelDurata.Text = "Durata";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSearch.Location = new System.Drawing.Point(771, 66);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 33);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Cauta";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBoxCampNume
            // 
            this.textBoxCampNume.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxCampNume.Location = new System.Drawing.Point(103, 63);
            this.textBoxCampNume.Name = "textBoxCampNume";
            this.textBoxCampNume.Size = new System.Drawing.Size(207, 34);
            this.textBoxCampNume.TabIndex = 4;
            // 
            // labelCampNume
            // 
            this.labelCampNume.AutoSize = true;
            this.labelCampNume.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCampNume.Location = new System.Drawing.Point(9, 71);
            this.labelCampNume.Name = "labelCampNume";
            this.labelCampNume.Size = new System.Drawing.Size(97, 28);
            this.labelCampNume.TabIndex = 1;
            this.labelCampNume.Text = "Denumire";
            // 
            // panelDelimiterRight
            // 
            this.panelDelimiterRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(190)))), ((int)(((byte)(160)))));
            this.panelDelimiterRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDelimiterRight.Location = new System.Drawing.Point(916, 0);
            this.panelDelimiterRight.Name = "panelDelimiterRight";
            this.panelDelimiterRight.Size = new System.Drawing.Size(44, 524);
            this.panelDelimiterRight.TabIndex = 1;
            // 
            // panelDelimiterLeft
            // 
            this.panelDelimiterLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(190)))), ((int)(((byte)(160)))));
            this.panelDelimiterLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDelimiterLeft.Location = new System.Drawing.Point(0, 0);
            this.panelDelimiterLeft.Name = "panelDelimiterLeft";
            this.panelDelimiterLeft.Size = new System.Drawing.Size(44, 524);
            this.panelDelimiterLeft.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(140)))), ((int)(((byte)(110)))));
            this.panelLeft.Controls.Add(this.buttonVizualizeazaMaterii);
            this.panelLeft.Controls.Add(this.btnReturn);
            this.panelLeft.Controls.Add(this.buttonVizualizeazaPrograme);
            this.panelLeft.Controls.Add(this.btnStergeFacultate);
            this.panelLeft.Controls.Add(this.pictureBoxUSVLogo);
            this.panelLeft.Controls.Add(this.btnModificaFacultate);
            this.panelLeft.Controls.Add(this.btnAdaugaFacultate);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 86);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.panelLeft.Size = new System.Drawing.Size(140, 524);
            this.panelLeft.TabIndex = 1;
            // 
            // buttonVizualizeazaMaterii
            // 
            this.buttonVizualizeazaMaterii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(125)))));
            this.buttonVizualizeazaMaterii.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVizualizeazaMaterii.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVizualizeazaMaterii.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(140)))), ((int)(((byte)(110)))));
            this.buttonVizualizeazaMaterii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVizualizeazaMaterii.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonVizualizeazaMaterii.Location = new System.Drawing.Point(3, 307);
            this.buttonVizualizeazaMaterii.Name = "buttonVizualizeazaMaterii";
            this.buttonVizualizeazaMaterii.Size = new System.Drawing.Size(134, 73);
            this.buttonVizualizeazaMaterii.TabIndex = 5;
            this.buttonVizualizeazaMaterii.Text = "Vizualizeaza Materii";
            this.buttonVizualizeazaMaterii.UseVisualStyleBackColor = false;
            this.buttonVizualizeazaMaterii.Visible = false;
            this.buttonVizualizeazaMaterii.Click += new System.EventHandler(this.buttonVizualizeazaMaterii_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(125)))));
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(140)))), ((int)(((byte)(110)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnReturn.Location = new System.Drawing.Point(3, 392);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(134, 73);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Meniu Principal";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // buttonVizualizeazaPrograme
            // 
            this.buttonVizualizeazaPrograme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(125)))));
            this.buttonVizualizeazaPrograme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVizualizeazaPrograme.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVizualizeazaPrograme.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(140)))), ((int)(((byte)(110)))));
            this.buttonVizualizeazaPrograme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVizualizeazaPrograme.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonVizualizeazaPrograme.Location = new System.Drawing.Point(3, 234);
            this.buttonVizualizeazaPrograme.Name = "buttonVizualizeazaPrograme";
            this.buttonVizualizeazaPrograme.Size = new System.Drawing.Size(134, 73);
            this.buttonVizualizeazaPrograme.TabIndex = 3;
            this.buttonVizualizeazaPrograme.Text = "Vizualizeaza Programe Studii\r\n";
            this.buttonVizualizeazaPrograme.UseVisualStyleBackColor = false;
            this.buttonVizualizeazaPrograme.Click += new System.EventHandler(this.buttonVizualizeazaPrograme_Click);
            // 
            // btnStergeFacultate
            // 
            this.btnStergeFacultate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(125)))));
            this.btnStergeFacultate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStergeFacultate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStergeFacultate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(140)))), ((int)(((byte)(110)))));
            this.btnStergeFacultate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStergeFacultate.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnStergeFacultate.Location = new System.Drawing.Point(3, 161);
            this.btnStergeFacultate.Name = "btnStergeFacultate";
            this.btnStergeFacultate.Size = new System.Drawing.Size(134, 73);
            this.btnStergeFacultate.TabIndex = 2;
            this.btnStergeFacultate.Text = "Elimina";
            this.btnStergeFacultate.UseVisualStyleBackColor = false;
            this.btnStergeFacultate.Click += new System.EventHandler(this.btnStergeFacultate_Click);
            // 
            // pictureBoxUSVLogo
            // 
            this.pictureBoxUSVLogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBoxUSVLogo.Image = global::Proiect_BD_SituatieScolara.Properties.Resources._640px_Ștefan_cel_Mare_University_of_Suceava_logo_svg;
            this.pictureBoxUSVLogo.InitialImage = global::Proiect_BD_SituatieScolara.Properties.Resources.universitatea_suceava_usv_968x460;
            this.pictureBoxUSVLogo.Location = new System.Drawing.Point(3, 465);
            this.pictureBoxUSVLogo.Name = "pictureBoxUSVLogo";
            this.pictureBoxUSVLogo.Size = new System.Drawing.Size(134, 59);
            this.pictureBoxUSVLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUSVLogo.TabIndex = 0;
            this.pictureBoxUSVLogo.TabStop = false;
            // 
            // btnModificaFacultate
            // 
            this.btnModificaFacultate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(125)))));
            this.btnModificaFacultate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificaFacultate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificaFacultate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(140)))), ((int)(((byte)(110)))));
            this.btnModificaFacultate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificaFacultate.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnModificaFacultate.Location = new System.Drawing.Point(3, 88);
            this.btnModificaFacultate.Name = "btnModificaFacultate";
            this.btnModificaFacultate.Size = new System.Drawing.Size(134, 73);
            this.btnModificaFacultate.TabIndex = 1;
            this.btnModificaFacultate.Text = "Modifica";
            this.btnModificaFacultate.UseVisualStyleBackColor = false;
            this.btnModificaFacultate.Click += new System.EventHandler(this.btnModifyFaculty_Click);
            // 
            // btnAdaugaFacultate
            // 
            this.btnAdaugaFacultate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(125)))));
            this.btnAdaugaFacultate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdaugaFacultate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdaugaFacultate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(140)))), ((int)(((byte)(110)))));
            this.btnAdaugaFacultate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdaugaFacultate.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnAdaugaFacultate.Location = new System.Drawing.Point(3, 15);
            this.btnAdaugaFacultate.Name = "btnAdaugaFacultate";
            this.btnAdaugaFacultate.Size = new System.Drawing.Size(134, 73);
            this.btnAdaugaFacultate.TabIndex = 0;
            this.btnAdaugaFacultate.Text = "Adauga";
            this.btnAdaugaFacultate.UseVisualStyleBackColor = false;
            this.btnAdaugaFacultate.Click += new System.EventHandler(this.btnAddFaculty_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(140)))), ((int)(((byte)(110)))));
            this.panelTop.Controls.Add(this.labelMeniuFacultate);
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1100, 86);
            this.panelTop.TabIndex = 0;
            // 
            // labelMeniuFacultate
            // 
            this.labelMeniuFacultate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(140)))), ((int)(((byte)(110)))));
            this.labelMeniuFacultate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMeniuFacultate.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold);
            this.labelMeniuFacultate.Location = new System.Drawing.Point(140, 0);
            this.labelMeniuFacultate.Name = "labelMeniuFacultate";
            this.labelMeniuFacultate.Size = new System.Drawing.Size(960, 86);
            this.labelMeniuFacultate.TabIndex = 1;
            this.labelMeniuFacultate.Text = "Administrare Facultati";
            this.labelMeniuFacultate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Proiect_BD_SituatieScolara.Properties.Resources.University;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMenuFacultate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 610);
            this.Controls.Add(this.panelForm);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenuFacultate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenuFacultate_FormClosing);
            this.Load += new System.EventHandler(this.FormMenuFacultate_Load);
            this.panelForm.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.panelDelimiterCenter.ResumeLayout(false);
            this.panelDelimiterCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelMenuHeader.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnModificaFacultate;
        private System.Windows.Forms.Button btnAdaugaFacultate;
        private System.Windows.Forms.PictureBox pictureBoxUSVLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDelimiterLeft;
        private System.Windows.Forms.Panel panelDelimiterCenter;
        private System.Windows.Forms.Panel panelDelimiterRight;
        private System.Windows.Forms.Panel panelDelimiterBottom;
        private System.Windows.Forms.Panel panelDelimiterTop;
        private System.Windows.Forms.TextBox textBoxCampNume;
        private System.Windows.Forms.Label labelCampNume;
        private System.Windows.Forms.Button btnStergeFacultate;
        private System.Windows.Forms.Label labelMeniuFacultate;
        private System.Windows.Forms.Button buttonVizualizeazaPrograme;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboBoxDurata;
        private System.Windows.Forms.Label labelDurata;
        private System.Windows.Forms.ComboBox comboBoxCicluStudiu;
        private System.Windows.Forms.Label labelCicluStudiu;
        private System.Windows.Forms.Button buttonClearSearch;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button buttonVizualizeazaMaterii;
        private System.Windows.Forms.Panel panelMenuHeader;
        private System.Windows.Forms.Label labelMenuHeader;
        private System.Windows.Forms.Label labelNumarElemente;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

