namespace TVPProjekat
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIme = new ns1.BunifuMaterialTextbox();
            this.txtPrezime = new ns1.BunifuMaterialTextbox();
            this.txtTelefon = new ns1.BunifuMaterialTextbox();
            this.txtAdresa = new ns1.BunifuMaterialTextbox();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.txtKorisnicko = new ns1.BunifuMaterialTextbox();
            this.txtLozinka = new ns1.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJMBG = new ns1.BunifuMaterialTextbox();
            this.zaposleniDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposleniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tVPProjekatDataSet = new TVPProjekat.TVPProjekatDataSet();
            this.zaposleniTableAdapter = new TVPProjekat.TVPProjekatDataSetTableAdapters.ZaposleniTableAdapter();
            this.tableAdapterManager = new TVPProjekat.TVPProjekatDataSetTableAdapters.TableAdapterManager();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPretraga = new ns1.BunifuTextbox();
            this.btnOdjava = new ns1.BunifuFlatButton();
            this.bunifuFlatButton3 = new ns1.BunifuFlatButton();
            this.btnCene = new ns1.BunifuFlatButton();
            this.btnStrujomeri = new ns1.BunifuFlatButton();
            this.btnVlasnici = new ns1.BunifuFlatButton();
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton2 = new ns1.BunifuFlatButton();
            this.btnAzuriraj = new ns1.BunifuFlatButton();
            this.btnDodaj = new ns1.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tVPProjekatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.panel1.Controls.Add(this.btnOdjava);
            this.panel1.Controls.Add(this.bunifuFlatButton3);
            this.panel1.Controls.Add(this.btnCene);
            this.panel1.Controls.Add(this.btnStrujomeri);
            this.panel1.Controls.Add(this.btnVlasnici);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 725);
            this.panel1.TabIndex = 0;
            // 
            // txtIme
            // 
            this.txtIme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIme.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtIme.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtIme.HintText = "Ime";
            this.txtIme.isPassword = false;
            this.txtIme.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtIme.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtIme.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtIme.LineThickness = 4;
            this.txtIme.Location = new System.Drawing.Point(298, 334);
            this.txtIme.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(220, 39);
            this.txtIme.TabIndex = 1;
            this.txtIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIme.OnValueChanged += new System.EventHandler(this.txtIme_OnValueChanged);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrezime.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtPrezime.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtPrezime.HintText = "Prezime";
            this.txtPrezime.isPassword = false;
            this.txtPrezime.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtPrezime.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtPrezime.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtPrezime.LineThickness = 4;
            this.txtPrezime.Location = new System.Drawing.Point(679, 334);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(220, 39);
            this.txtPrezime.TabIndex = 2;
            this.txtPrezime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrezime.OnValueChanged += new System.EventHandler(this.txtPrezime_OnValueChanged);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefon.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtTelefon.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtTelefon.HintText = "Telefon";
            this.txtTelefon.isPassword = false;
            this.txtTelefon.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtTelefon.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtTelefon.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtTelefon.LineThickness = 4;
            this.txtTelefon.Location = new System.Drawing.Point(679, 406);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(220, 39);
            this.txtTelefon.TabIndex = 4;
            this.txtTelefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefon.OnValueChanged += new System.EventHandler(this.txtTelefon_OnValueChanged);
            this.txtTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefon_KeyPress);
            // 
            // txtAdresa
            // 
            this.txtAdresa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdresa.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtAdresa.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtAdresa.HintText = "Adresa";
            this.txtAdresa.isPassword = false;
            this.txtAdresa.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtAdresa.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtAdresa.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtAdresa.LineThickness = 4;
            this.txtAdresa.Location = new System.Drawing.Point(298, 406);
            this.txtAdresa.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(220, 39);
            this.txtAdresa.TabIndex = 3;
            this.txtAdresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAdresa.OnValueChanged += new System.EventHandler(this.txtAdresa_OnValueChanged);
            // 
            // cbTip
            // 
            this.cbTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.cbTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTip.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Items.AddRange(new object[] {
            "Administrator",
            "Radnik"});
            this.cbTip.Location = new System.Drawing.Point(298, 488);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(220, 28);
            this.cbTip.TabIndex = 5;
            // 
            // txtKorisnicko
            // 
            this.txtKorisnicko.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKorisnicko.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKorisnicko.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtKorisnicko.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtKorisnicko.HintText = "Korisničko ime";
            this.txtKorisnicko.isPassword = false;
            this.txtKorisnicko.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtKorisnicko.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtKorisnicko.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtKorisnicko.LineThickness = 4;
            this.txtKorisnicko.Location = new System.Drawing.Point(299, 557);
            this.txtKorisnicko.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtKorisnicko.Name = "txtKorisnicko";
            this.txtKorisnicko.Size = new System.Drawing.Size(220, 39);
            this.txtKorisnicko.TabIndex = 7;
            this.txtKorisnicko.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKorisnicko.OnValueChanged += new System.EventHandler(this.txtKorisnicko_OnValueChanged);
            // 
            // txtLozinka
            // 
            this.txtLozinka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.txtLozinka.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLozinka.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLozinka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtLozinka.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtLozinka.HintText = "Lozinka";
            this.txtLozinka.isPassword = false;
            this.txtLozinka.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtLozinka.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtLozinka.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtLozinka.LineThickness = 4;
            this.txtLozinka.Location = new System.Drawing.Point(679, 557);
            this.txtLozinka.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(220, 39);
            this.txtLozinka.TabIndex = 8;
            this.txtLozinka.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLozinka.OnValueChanged += new System.EventHandler(this.txtLozinka_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Novi zaposleni:";
            // 
            // txtJMBG
            // 
            this.txtJMBG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJMBG.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJMBG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtJMBG.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtJMBG.HintText = "JMBG";
            this.txtJMBG.isPassword = false;
            this.txtJMBG.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtJMBG.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtJMBG.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtJMBG.LineThickness = 4;
            this.txtJMBG.Location = new System.Drawing.Point(679, 470);
            this.txtJMBG.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(220, 46);
            this.txtJMBG.TabIndex = 6;
            this.txtJMBG.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtJMBG.OnValueChanged += new System.EventHandler(this.txtJMBG_OnValueChanged);
            this.txtJMBG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJMBG_KeyPress);
            // 
            // zaposleniDataGridView
            // 
            this.zaposleniDataGridView.AllowUserToAddRows = false;
            this.zaposleniDataGridView.AllowUserToDeleteRows = false;
            this.zaposleniDataGridView.AutoGenerateColumns = false;
            this.zaposleniDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.zaposleniDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zaposleniDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.zaposleniDataGridView.DataSource = this.zaposleniBindingSource;
            this.zaposleniDataGridView.Location = new System.Drawing.Point(272, 62);
            this.zaposleniDataGridView.Name = "zaposleniDataGridView";
            this.zaposleniDataGridView.ReadOnly = true;
            this.zaposleniDataGridView.Size = new System.Drawing.Size(722, 220);
            this.zaposleniDataGridView.TabIndex = 17;
            this.zaposleniDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.zaposleniDataGridView_RowHeaderMouseClick);
            this.zaposleniDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.zaposleniDataGridView_RowHeaderMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ime";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prezime";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prezime";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Adresa";
            this.dataGridViewTextBoxColumn4.HeaderText = "Adresa";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefon";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Tip";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tip";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Korisnickoime";
            this.dataGridViewTextBoxColumn7.HeaderText = "Korisnickoime";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Lozinka";
            this.dataGridViewTextBoxColumn8.HeaderText = "Lozinka";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "JMBG";
            this.dataGridViewTextBoxColumn9.HeaderText = "JMBG";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // zaposleniBindingSource
            // 
            this.zaposleniBindingSource.DataMember = "Zaposleni";
            this.zaposleniBindingSource.DataSource = this.tVPProjekatDataSet;
            // 
            // tVPProjekatDataSet
            // 
            this.tVPProjekatDataSet.DataSetName = "TVPProjekatDataSet";
            this.tVPProjekatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zaposleniTableAdapter
            // 
            this.zaposleniTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CeneTableAdapter = null;
            this.tableAdapterManager.StanjeStrujomeraTableAdapter = null;
            this.tableAdapterManager.StrujomerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TVPProjekat.TVPProjekatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VlasnikTableAdapter = null;
            this.tableAdapterManager.ZaposleniTableAdapter = this.zaposleniTableAdapter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(676, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(676, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(676, 521);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 601);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(676, 601);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "label8";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(266, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 725);
            this.panel2.TabIndex = 43;
            // 
            // txtPretraga
            // 
            this.txtPretraga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.txtPretraga.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPretraga.BackgroundImage")));
            this.txtPretraga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtPretraga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtPretraga.Icon = ((System.Drawing.Image)(resources.GetObject("txtPretraga.Icon")));
            this.txtPretraga.Location = new System.Drawing.Point(427, 14);
            this.txtPretraga.Margin = new System.Windows.Forms.Padding(4);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(386, 41);
            this.txtPretraga.TabIndex = 42;
            this.txtPretraga.text = "";
            this.txtPretraga.KeyPress += new System.EventHandler(this.txtPretraga_KeyPress);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(188)))));
            this.btnOdjava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnOdjava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOdjava.BorderRadius = 0;
            this.btnOdjava.ButtonText = "    Odjavi se";
            this.btnOdjava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdjava.DisabledColor = System.Drawing.Color.Gray;
            this.btnOdjava.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjava.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOdjava.Iconimage = global::TVPProjekat.Properties.Resources._1333_door_512;
            this.btnOdjava.Iconimage_right = null;
            this.btnOdjava.Iconimage_right_Selected = null;
            this.btnOdjava.Iconimage_Selected = null;
            this.btnOdjava.IconMarginLeft = 0;
            this.btnOdjava.IconMarginRight = 0;
            this.btnOdjava.IconRightVisible = true;
            this.btnOdjava.IconRightZoom = 0D;
            this.btnOdjava.IconVisible = true;
            this.btnOdjava.IconZoom = 90D;
            this.btnOdjava.IsTab = false;
            this.btnOdjava.Location = new System.Drawing.Point(0, 661);
            this.btnOdjava.Margin = new System.Windows.Forms.Padding(5);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnOdjava.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(188)))));
            this.btnOdjava.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.btnOdjava.selected = false;
            this.btnOdjava.Size = new System.Drawing.Size(272, 59);
            this.btnOdjava.TabIndex = 17;
            this.btnOdjava.Text = "    Odjavi se";
            this.btnOdjava.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdjava.Textcolor = System.Drawing.Color.Black;
            this.btnOdjava.TextFont = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(188)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Stanja strujomera";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = global::TVPProjekat.Properties.Resources.stanje;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(9, 378);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(188)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(272, 59);
            this.bunifuFlatButton3.TabIndex = 16;
            this.bunifuFlatButton3.Text = "Stanja strujomera";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // btnCene
            // 
            this.btnCene.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(188)))));
            this.btnCene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnCene.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCene.BorderRadius = 0;
            this.btnCene.ButtonText = "    Cenovnik";
            this.btnCene.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCene.DisabledColor = System.Drawing.Color.Gray;
            this.btnCene.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCene.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCene.Iconimage = global::TVPProjekat.Properties.Resources.money_icon_1320184267002448371;
            this.btnCene.Iconimage_right = null;
            this.btnCene.Iconimage_right_Selected = null;
            this.btnCene.Iconimage_Selected = null;
            this.btnCene.IconMarginLeft = 0;
            this.btnCene.IconMarginRight = 0;
            this.btnCene.IconRightVisible = true;
            this.btnCene.IconRightZoom = 0D;
            this.btnCene.IconVisible = true;
            this.btnCene.IconZoom = 90D;
            this.btnCene.IsTab = false;
            this.btnCene.Location = new System.Drawing.Point(5, 470);
            this.btnCene.Margin = new System.Windows.Forms.Padding(5);
            this.btnCene.Name = "btnCene";
            this.btnCene.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnCene.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(188)))));
            this.btnCene.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.btnCene.selected = false;
            this.btnCene.Size = new System.Drawing.Size(272, 59);
            this.btnCene.TabIndex = 15;
            this.btnCene.Text = "    Cenovnik";
            this.btnCene.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCene.Textcolor = System.Drawing.Color.Black;
            this.btnCene.TextFont = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCene.Click += new System.EventHandler(this.btnCene_Click);
            // 
            // btnStrujomeri
            // 
            this.btnStrujomeri.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(188)))));
            this.btnStrujomeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnStrujomeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStrujomeri.BorderRadius = 0;
            this.btnStrujomeri.ButtonText = "    Strujomeri";
            this.btnStrujomeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStrujomeri.DisabledColor = System.Drawing.Color.Gray;
            this.btnStrujomeri.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStrujomeri.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStrujomeri.Iconimage = global::TVPProjekat.Properties.Resources.Untitled_13_03_512;
            this.btnStrujomeri.Iconimage_right = null;
            this.btnStrujomeri.Iconimage_right_Selected = null;
            this.btnStrujomeri.Iconimage_Selected = null;
            this.btnStrujomeri.IconMarginLeft = 0;
            this.btnStrujomeri.IconMarginRight = 0;
            this.btnStrujomeri.IconRightVisible = true;
            this.btnStrujomeri.IconRightZoom = 0D;
            this.btnStrujomeri.IconVisible = true;
            this.btnStrujomeri.IconZoom = 90D;
            this.btnStrujomeri.IsTab = false;
            this.btnStrujomeri.Location = new System.Drawing.Point(5, 285);
            this.btnStrujomeri.Margin = new System.Windows.Forms.Padding(5);
            this.btnStrujomeri.Name = "btnStrujomeri";
            this.btnStrujomeri.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnStrujomeri.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(188)))));
            this.btnStrujomeri.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.btnStrujomeri.selected = false;
            this.btnStrujomeri.Size = new System.Drawing.Size(272, 59);
            this.btnStrujomeri.TabIndex = 14;
            this.btnStrujomeri.Text = "    Strujomeri";
            this.btnStrujomeri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStrujomeri.Textcolor = System.Drawing.Color.Black;
            this.btnStrujomeri.TextFont = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStrujomeri.Click += new System.EventHandler(this.btnStrujomeri_Click);
            // 
            // btnVlasnici
            // 
            this.btnVlasnici.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(188)))));
            this.btnVlasnici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnVlasnici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVlasnici.BorderRadius = 0;
            this.btnVlasnici.ButtonText = "Vlasnici strujomera";
            this.btnVlasnici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVlasnici.DisabledColor = System.Drawing.Color.Gray;
            this.btnVlasnici.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVlasnici.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVlasnici.Iconimage = global::TVPProjekat.Properties.Resources.people;
            this.btnVlasnici.Iconimage_right = null;
            this.btnVlasnici.Iconimage_right_Selected = null;
            this.btnVlasnici.Iconimage_Selected = null;
            this.btnVlasnici.IconMarginLeft = 0;
            this.btnVlasnici.IconMarginRight = 0;
            this.btnVlasnici.IconRightVisible = true;
            this.btnVlasnici.IconRightZoom = 0D;
            this.btnVlasnici.IconVisible = true;
            this.btnVlasnici.IconZoom = 90D;
            this.btnVlasnici.IsTab = false;
            this.btnVlasnici.Location = new System.Drawing.Point(5, 190);
            this.btnVlasnici.Margin = new System.Windows.Forms.Padding(5);
            this.btnVlasnici.Name = "btnVlasnici";
            this.btnVlasnici.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnVlasnici.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(188)))));
            this.btnVlasnici.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.btnVlasnici.selected = false;
            this.btnVlasnici.Size = new System.Drawing.Size(291, 59);
            this.btnVlasnici.TabIndex = 13;
            this.btnVlasnici.Text = "Vlasnici strujomera";
            this.btnVlasnici.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVlasnici.Textcolor = System.Drawing.Color.Black;
            this.btnVlasnici.TextFont = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVlasnici.Click += new System.EventHandler(this.btnVlasnici_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.bunifuImageButton1.Image = global::TVPProjekat.Properties.Resources._29178;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(9, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(254, 71);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 12;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(188)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "     Zaposleni";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::TVPProjekat.Properties.Resources._33308;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(13, 111);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(188)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(241, 48);
            this.bunifuFlatButton1.TabIndex = 1;
            this.bunifuFlatButton1.Text = "     Zaposleni";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Obriši";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.ForeColor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::TVPProjekat.Properties.Resources.delete_737_475058;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(744, 626);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(188)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(155, 59);
            this.bunifuFlatButton2.TabIndex = 11;
            this.bunifuFlatButton2.Text = "Obriši";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnAzuriraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnAzuriraj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAzuriraj.BorderRadius = 0;
            this.btnAzuriraj.ButtonText = "Ažuriraj";
            this.btnAzuriraj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAzuriraj.DisabledColor = System.Drawing.Color.Gray;
            this.btnAzuriraj.ForeColor = System.Drawing.Color.Black;
            this.btnAzuriraj.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAzuriraj.Iconimage = global::TVPProjekat.Properties.Resources.update_1779719_1512754;
            this.btnAzuriraj.Iconimage_right = null;
            this.btnAzuriraj.Iconimage_right_Selected = null;
            this.btnAzuriraj.Iconimage_Selected = null;
            this.btnAzuriraj.IconMarginLeft = 0;
            this.btnAzuriraj.IconMarginRight = 0;
            this.btnAzuriraj.IconRightVisible = true;
            this.btnAzuriraj.IconRightZoom = 0D;
            this.btnAzuriraj.IconVisible = true;
            this.btnAzuriraj.IconZoom = 90D;
            this.btnAzuriraj.IsTab = false;
            this.btnAzuriraj.Location = new System.Drawing.Point(525, 628);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(5);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnAzuriraj.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(188)))));
            this.btnAzuriraj.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.btnAzuriraj.selected = false;
            this.btnAzuriraj.Size = new System.Drawing.Size(155, 59);
            this.btnAzuriraj.TabIndex = 10;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAzuriraj.Textcolor = System.Drawing.Color.Black;
            this.btnAzuriraj.TextFont = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDodaj.BorderRadius = 0;
            this.btnDodaj.ButtonText = "Dodaj";
            this.btnDodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodaj.DisabledColor = System.Drawing.Color.Gray;
            this.btnDodaj.ForeColor = System.Drawing.Color.Black;
            this.btnDodaj.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDodaj.Iconimage = global::TVPProjekat.Properties.Resources._196436_200;
            this.btnDodaj.Iconimage_right = null;
            this.btnDodaj.Iconimage_right_Selected = null;
            this.btnDodaj.Iconimage_Selected = null;
            this.btnDodaj.IconMarginLeft = 0;
            this.btnDodaj.IconMarginRight = 0;
            this.btnDodaj.IconRightVisible = true;
            this.btnDodaj.IconRightZoom = 0D;
            this.btnDodaj.IconVisible = true;
            this.btnDodaj.IconZoom = 90D;
            this.btnDodaj.IsTab = false;
            this.btnDodaj.Location = new System.Drawing.Point(299, 629);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnDodaj.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(188)))));
            this.btnDodaj.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.btnDodaj.selected = false;
            this.btnDodaj.Size = new System.Drawing.Size(155, 59);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodaj.Textcolor = System.Drawing.Color.Black;
            this.btnDodaj.TextFont = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1006, 725);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.zaposleniDataGridView);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtJMBG);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorisnicko);
            this.Controls.Add(this.cbTip);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projekat TVP";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tVPProjekatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuFlatButton bunifuFlatButton1;
        private ns1.BunifuMaterialTextbox txtIme;
        private ns1.BunifuMaterialTextbox txtPrezime;
        private ns1.BunifuMaterialTextbox txtTelefon;
        private ns1.BunifuMaterialTextbox txtAdresa;
        private System.Windows.Forms.ComboBox cbTip;
        private ns1.BunifuMaterialTextbox txtKorisnicko;
        private ns1.BunifuMaterialTextbox txtLozinka;
        private ns1.BunifuFlatButton btnDodaj;
        private ns1.BunifuFlatButton btnAzuriraj;
        private ns1.BunifuFlatButton bunifuFlatButton2;
        private ns1.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuMaterialTextbox txtJMBG;
        private TVPProjekatDataSet tVPProjekatDataSet;
        private System.Windows.Forms.BindingSource zaposleniBindingSource;
        private TVPProjekatDataSetTableAdapters.ZaposleniTableAdapter zaposleniTableAdapter;
        private TVPProjekatDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView zaposleniDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private ns1.BunifuFlatButton btnVlasnici;
        private ns1.BunifuFlatButton btnStrujomeri;
        private ns1.BunifuFlatButton btnCene;
        private ns1.BunifuTextbox txtPretraga;
        private System.Windows.Forms.Panel panel2;
        private ns1.BunifuFlatButton bunifuFlatButton3;
        private ns1.BunifuFlatButton btnOdjava;
    }
}