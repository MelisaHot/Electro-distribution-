namespace TVPProjekat
{
    partial class Vlasnici
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vlasnici));
            this.tVPProjekatDataSet = new TVPProjekat.TVPProjekatDataSet();
            this.vlasnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vlasnikTableAdapter = new TVPProjekat.TVPProjekatDataSetTableAdapters.VlasnikTableAdapter();
            this.tableAdapterManager = new TVPProjekat.TVPProjekatDataSetTableAdapters.TableAdapterManager();
            this.vlasnikDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJMBG = new ns1.BunifuMaterialTextbox();
            this.txtTelefon = new ns1.BunifuMaterialTextbox();
            this.txtAdresa = new ns1.BunifuMaterialTextbox();
            this.txtPrezime = new ns1.BunifuMaterialTextbox();
            this.txtIme = new ns1.BunifuMaterialTextbox();
            this.btnObrisi = new ns1.BunifuFlatButton();
            this.btnAzuriraj = new ns1.BunifuFlatButton();
            this.btnDodaj = new ns1.BunifuFlatButton();
            this.txtPretraga = new ns1.BunifuTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.tVPProjekatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlasnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlasnikDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tVPProjekatDataSet
            // 
            this.tVPProjekatDataSet.DataSetName = "TVPProjekatDataSet";
            this.tVPProjekatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vlasnikBindingSource
            // 
            this.vlasnikBindingSource.DataMember = "Vlasnik";
            this.vlasnikBindingSource.DataSource = this.tVPProjekatDataSet;
            // 
            // vlasnikTableAdapter
            // 
            this.vlasnikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CeneTableAdapter = null;
            this.tableAdapterManager.StanjeStrujomeraTableAdapter = null;
            this.tableAdapterManager.StrujomerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TVPProjekat.TVPProjekatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VlasnikTableAdapter = this.vlasnikTableAdapter;
            this.tableAdapterManager.ZaposleniTableAdapter = null;
            // 
            // vlasnikDataGridView
            // 
            this.vlasnikDataGridView.AllowUserToAddRows = false;
            this.vlasnikDataGridView.AllowUserToDeleteRows = false;
            this.vlasnikDataGridView.AutoGenerateColumns = false;
            this.vlasnikDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.vlasnikDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vlasnikDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.vlasnikDataGridView.DataSource = this.vlasnikBindingSource;
            this.vlasnikDataGridView.Location = new System.Drawing.Point(42, 51);
            this.vlasnikDataGridView.Name = "vlasnikDataGridView";
            this.vlasnikDataGridView.ReadOnly = true;
            this.vlasnikDataGridView.Size = new System.Drawing.Size(550, 220);
            this.vlasnikDataGridView.TabIndex = 0;
            this.vlasnikDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.vlasnikDataGridView_RowHeaderMouseClick);
            this.vlasnikDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.vlasnikDataGridView_RowHeaderMouseDoubleClick);
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "JMBG";
            this.dataGridViewTextBoxColumn4.HeaderText = "JMBG";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Adresa";
            this.dataGridViewTextBoxColumn5.HeaderText = "Adresa";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Telefon";
            this.dataGridViewTextBoxColumn6.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Novi vlasnik:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 521);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "label2";
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
            this.txtJMBG.Location = new System.Drawing.Point(42, 392);
            this.txtJMBG.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(220, 46);
            this.txtJMBG.TabIndex = 3;
            this.txtJMBG.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtJMBG.OnValueChanged += new System.EventHandler(this.txtJMBG_OnValueChanged);
            this.txtJMBG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJMBG_KeyPress);
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
            this.txtTelefon.Location = new System.Drawing.Point(42, 477);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(220, 39);
            this.txtTelefon.TabIndex = 5;
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
            this.txtAdresa.Location = new System.Drawing.Point(342, 399);
            this.txtAdresa.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(220, 39);
            this.txtAdresa.TabIndex = 4;
            this.txtAdresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAdresa.OnValueChanged += new System.EventHandler(this.txtAdresa_OnValueChanged);
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
            this.txtPrezime.Location = new System.Drawing.Point(342, 327);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(220, 39);
            this.txtPrezime.TabIndex = 2;
            this.txtPrezime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrezime.OnValueChanged += new System.EventHandler(this.txtPrezime_OnValueChanged);
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
            this.txtIme.Location = new System.Drawing.Point(42, 327);
            this.txtIme.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(220, 39);
            this.txtIme.TabIndex = 1;
            this.txtIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIme.OnValueChanged += new System.EventHandler(this.txtIme_OnValueChanged);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnObrisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnObrisi.BorderRadius = 0;
            this.btnObrisi.ButtonText = "Obriši";
            this.btnObrisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObrisi.DisabledColor = System.Drawing.Color.Gray;
            this.btnObrisi.ForeColor = System.Drawing.Color.Black;
            this.btnObrisi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnObrisi.Iconimage = global::TVPProjekat.Properties.Resources.delete_737_475058;
            this.btnObrisi.Iconimage_right = null;
            this.btnObrisi.Iconimage_right_Selected = null;
            this.btnObrisi.Iconimage_Selected = null;
            this.btnObrisi.IconMarginLeft = 0;
            this.btnObrisi.IconMarginRight = 0;
            this.btnObrisi.IconRightVisible = true;
            this.btnObrisi.IconRightZoom = 0D;
            this.btnObrisi.IconVisible = true;
            this.btnObrisi.IconZoom = 90D;
            this.btnObrisi.IsTab = false;
            this.btnObrisi.Location = new System.Drawing.Point(470, 549);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnObrisi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(188)))));
            this.btnObrisi.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.btnObrisi.selected = false;
            this.btnObrisi.Size = new System.Drawing.Size(155, 59);
            this.btnObrisi.TabIndex = 8;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrisi.Textcolor = System.Drawing.Color.Black;
            this.btnObrisi.TextFont = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
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
            this.btnAzuriraj.Location = new System.Drawing.Point(259, 549);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(5);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnAzuriraj.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(188)))));
            this.btnAzuriraj.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.btnAzuriraj.selected = false;
            this.btnAzuriraj.Size = new System.Drawing.Size(155, 59);
            this.btnAzuriraj.TabIndex = 7;
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
            this.btnDodaj.Location = new System.Drawing.Point(25, 549);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnDodaj.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(188)))));
            this.btnDodaj.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.btnDodaj.selected = false;
            this.btnDodaj.Size = new System.Drawing.Size(155, 59);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodaj.Textcolor = System.Drawing.Color.Black;
            this.btnDodaj.TextFont = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.txtPretraga.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPretraga.BackgroundImage")));
            this.txtPretraga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtPretraga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtPretraga.Icon = ((System.Drawing.Image)(resources.GetObject("txtPretraga.Icon")));
            this.txtPretraga.Location = new System.Drawing.Point(134, 4);
            this.txtPretraga.Margin = new System.Windows.Forms.Padding(4);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(419, 31);
            this.txtPretraga.TabIndex = 17;
            this.txtPretraga.text = "";
            this.txtPretraga.KeyPress += new System.EventHandler(this.txtPretraga_KeyPress);
            // 
            // Vlasnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtJMBG);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.vlasnikDataGridView);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.Name = "Vlasnici";
            this.Size = new System.Drawing.Size(675, 686);
            this.Load += new System.EventHandler(this.Vlasnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tVPProjekatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlasnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlasnikDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TVPProjekatDataSet tVPProjekatDataSet;
        private System.Windows.Forms.BindingSource vlasnikBindingSource;
        private TVPProjekatDataSetTableAdapters.VlasnikTableAdapter vlasnikTableAdapter;
        private TVPProjekatDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView vlasnikDataGridView;
        private ns1.BunifuTextbox txtPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ns1.BunifuMaterialTextbox txtJMBG;
        private ns1.BunifuMaterialTextbox txtTelefon;
        private ns1.BunifuMaterialTextbox txtAdresa;
        private ns1.BunifuMaterialTextbox txtPrezime;
        private ns1.BunifuMaterialTextbox txtIme;
        private ns1.BunifuFlatButton btnObrisi;
        private ns1.BunifuFlatButton btnAzuriraj;
        private ns1.BunifuFlatButton btnDodaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
