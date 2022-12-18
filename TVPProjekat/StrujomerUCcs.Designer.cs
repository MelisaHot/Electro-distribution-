namespace TVPProjekat
{
    partial class StrujomerUCcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StrujomerUCcs));
            this.tableAdapterManager = new TVPProjekat.TVPProjekatDataSetTableAdapters.TableAdapterManager();
            this.strujomerTableAdapter = new TVPProjekat.TVPProjekatDataSetTableAdapters.StrujomerTableAdapter();
            this.strujomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tVPProjekatDataSet = new TVPProjekat.TVPProjekatDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrojStrujomera = new ns1.BunifuMaterialTextbox();
            this.txtTrenutnoNize = new ns1.BunifuMaterialTextbox();
            this.txtTrenutnoVise = new ns1.BunifuMaterialTextbox();
            this.txtNovoNize = new ns1.BunifuMaterialTextbox();
            this.txtNovoVise = new ns1.BunifuMaterialTextbox();
            this.btnDodaj = new ns1.BunifuFlatButton();
            this.btnAzuriraj = new ns1.BunifuFlatButton();
            this.btnObrisi = new ns1.BunifuFlatButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.strujomerdataGridView = new System.Windows.Forms.DataGridView();
            this.txtVlasnik = new System.Windows.Forms.TextBox();
            this.txtZaposleni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblJmbgVl = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblZap = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltv = new System.Windows.Forms.Label();
            this.lbltn = new System.Windows.Forms.Label();
            this.lblnn = new System.Windows.Forms.Label();
            this.lblnv = new System.Windows.Forms.Label();
            this.txtPretraga = new ns1.BunifuTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.strujomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tVPProjekatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strujomerdataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CeneTableAdapter = null;
            this.tableAdapterManager.StanjeStrujomeraTableAdapter = null;
            this.tableAdapterManager.StrujomerTableAdapter = this.strujomerTableAdapter;
            this.tableAdapterManager.UpdateOrder = TVPProjekat.TVPProjekatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VlasnikTableAdapter = null;
            this.tableAdapterManager.ZaposleniTableAdapter = null;
            // 
            // strujomerTableAdapter
            // 
            this.strujomerTableAdapter.ClearBeforeFill = true;
            // 
            // strujomerBindingSource
            // 
            this.strujomerBindingSource.DataMember = "Strujomer";
            // 
            // tVPProjekatDataSet
            // 
            this.tVPProjekatDataSet.DataSetName = "TVPProjekatDataSet";
            this.tVPProjekatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.label1.Location = new System.Drawing.Point(14, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Novi strujomer:";
            // 
            // txtBrojStrujomera
            // 
            this.txtBrojStrujomera.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBrojStrujomera.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojStrujomera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtBrojStrujomera.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.txtBrojStrujomera.HintText = "";
            this.txtBrojStrujomera.isPassword = false;
            this.txtBrojStrujomera.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtBrojStrujomera.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtBrojStrujomera.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtBrojStrujomera.LineThickness = 4;
            this.txtBrojStrujomera.Location = new System.Drawing.Point(19, 327);
            this.txtBrojStrujomera.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtBrojStrujomera.Name = "txtBrojStrujomera";
            this.txtBrojStrujomera.Size = new System.Drawing.Size(284, 39);
            this.txtBrojStrujomera.TabIndex = 19;
            this.txtBrojStrujomera.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBrojStrujomera.OnValueChanged += new System.EventHandler(this.txtBrojStrujomera_OnValueChanged);
            // 
            // txtTrenutnoNize
            // 
            this.txtTrenutnoNize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTrenutnoNize.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrenutnoNize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtTrenutnoNize.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtTrenutnoNize.HintText = "Trenutno stanje niže tarife";
            this.txtTrenutnoNize.isPassword = false;
            this.txtTrenutnoNize.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtTrenutnoNize.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtTrenutnoNize.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtTrenutnoNize.LineThickness = 4;
            this.txtTrenutnoNize.Location = new System.Drawing.Point(19, 481);
            this.txtTrenutnoNize.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTrenutnoNize.Name = "txtTrenutnoNize";
            this.txtTrenutnoNize.Size = new System.Drawing.Size(284, 39);
            this.txtTrenutnoNize.TabIndex = 19;
            this.txtTrenutnoNize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTrenutnoNize.Visible = false;
            // 
            // txtTrenutnoVise
            // 
            this.txtTrenutnoVise.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTrenutnoVise.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrenutnoVise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtTrenutnoVise.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtTrenutnoVise.HintText = "Trenutno stanje više tarife";
            this.txtTrenutnoVise.isPassword = false;
            this.txtTrenutnoVise.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtTrenutnoVise.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtTrenutnoVise.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtTrenutnoVise.LineThickness = 4;
            this.txtTrenutnoVise.Location = new System.Drawing.Point(401, 483);
            this.txtTrenutnoVise.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTrenutnoVise.Name = "txtTrenutnoVise";
            this.txtTrenutnoVise.Size = new System.Drawing.Size(291, 39);
            this.txtTrenutnoVise.TabIndex = 19;
            this.txtTrenutnoVise.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTrenutnoVise.Visible = false;
            // 
            // txtNovoNize
            // 
            this.txtNovoNize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNovoNize.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovoNize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtNovoNize.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtNovoNize.HintText = "Novo stanje niže tarife";
            this.txtNovoNize.isPassword = false;
            this.txtNovoNize.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtNovoNize.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtNovoNize.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtNovoNize.LineThickness = 4;
            this.txtNovoNize.Location = new System.Drawing.Point(19, 553);
            this.txtNovoNize.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNovoNize.Name = "txtNovoNize";
            this.txtNovoNize.Size = new System.Drawing.Size(284, 39);
            this.txtNovoNize.TabIndex = 19;
            this.txtNovoNize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNovoNize.Visible = false;
            // 
            // txtNovoVise
            // 
            this.txtNovoVise.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNovoVise.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovoVise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtNovoVise.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtNovoVise.HintText = "Novo stanje više tarife";
            this.txtNovoVise.isPassword = false;
            this.txtNovoVise.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtNovoVise.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtNovoVise.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtNovoVise.LineThickness = 4;
            this.txtNovoVise.Location = new System.Drawing.Point(401, 555);
            this.txtNovoVise.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNovoVise.Name = "txtNovoVise";
            this.txtNovoVise.Size = new System.Drawing.Size(291, 39);
            this.txtNovoVise.TabIndex = 19;
            this.txtNovoVise.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNovoVise.Visible = false;
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
            this.btnDodaj.Iconimage = global::TVPProjekat.Properties.Resources._61183;
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
            this.btnDodaj.Location = new System.Drawing.Point(19, 652);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnDodaj.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(188)))));
            this.btnDodaj.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.btnDodaj.selected = false;
            this.btnDodaj.Size = new System.Drawing.Size(155, 59);
            this.btnDodaj.TabIndex = 20;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodaj.Textcolor = System.Drawing.Color.Black;
            this.btnDodaj.TextFont = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
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
            this.btnAzuriraj.Location = new System.Drawing.Point(296, 652);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(5);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnAzuriraj.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(188)))));
            this.btnAzuriraj.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.btnAzuriraj.selected = false;
            this.btnAzuriraj.Size = new System.Drawing.Size(155, 59);
            this.btnAzuriraj.TabIndex = 21;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAzuriraj.Textcolor = System.Drawing.Color.Black;
            this.btnAzuriraj.TextFont = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
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
            this.btnObrisi.Location = new System.Drawing.Point(553, 652);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnObrisi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(188)))));
            this.btnObrisi.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.btnObrisi.selected = false;
            this.btnObrisi.Size = new System.Drawing.Size(155, 59);
            this.btnObrisi.TabIndex = 22;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrisi.Textcolor = System.Drawing.Color.Black;
            this.btnObrisi.TextFont = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 411);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(284, 21);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // strujomerdataGridView
            // 
            this.strujomerdataGridView.AllowUserToAddRows = false;
            this.strujomerdataGridView.AllowUserToDeleteRows = false;
            this.strujomerdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.strujomerdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.strujomerdataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.strujomerdataGridView.Location = new System.Drawing.Point(19, 64);
            this.strujomerdataGridView.Name = "strujomerdataGridView";
            this.strujomerdataGridView.ReadOnly = true;
            this.strujomerdataGridView.Size = new System.Drawing.Size(699, 217);
            this.strujomerdataGridView.TabIndex = 26;
            this.strujomerdataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.strujomerdataGridView_RowHeaderMouseClick);
            this.strujomerdataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.strujomerdataGridView_RowHeaderMouseDoubleClick);
            // 
            // txtVlasnik
            // 
            this.txtVlasnik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.txtVlasnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVlasnik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtVlasnik.Location = new System.Drawing.Point(401, 349);
            this.txtVlasnik.Name = "txtVlasnik";
            this.txtVlasnik.Size = new System.Drawing.Size(291, 26);
            this.txtVlasnik.TabIndex = 27;
            this.txtVlasnik.TextChanged += new System.EventHandler(this.txtVlasnik_TextChanged);
            // 
            // txtZaposleni
            // 
            this.txtZaposleni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.txtZaposleni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZaposleni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtZaposleni.Location = new System.Drawing.Point(401, 413);
            this.txtZaposleni.Name = "txtZaposleni";
            this.txtZaposleni.Size = new System.Drawing.Size(291, 26);
            this.txtZaposleni.TabIndex = 27;
            this.txtZaposleni.Visible = false;
            this.txtZaposleni.TextChanged += new System.EventHandler(this.txtZaposleni_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.label2.Location = new System.Drawing.Point(16, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.label3.Location = new System.Drawing.Point(398, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "label3";
            // 
            // lblJmbgVl
            // 
            this.lblJmbgVl.AutoSize = true;
            this.lblJmbgVl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJmbgVl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.lblJmbgVl.Location = new System.Drawing.Point(589, 378);
            this.lblJmbgVl.Name = "lblJmbgVl";
            this.lblJmbgVl.Size = new System.Drawing.Size(103, 15);
            this.lblJmbgVl.TabIndex = 31;
            this.lblJmbgVl.Text = "JMBG Vlasnika";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.lblDatum.Location = new System.Drawing.Point(254, 434);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(49, 15);
            this.lblDatum.TabIndex = 32;
            this.lblDatum.Text = "Datum";
            // 
            // lblZap
            // 
            this.lblZap.AutoSize = true;
            this.lblZap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.lblZap.Location = new System.Drawing.Point(568, 442);
            this.lblZap.Name = "lblZap";
            this.lblZap.Size = new System.Drawing.Size(124, 15);
            this.lblZap.TabIndex = 33;
            this.lblZap.Text = "JMBG Zaposlenog";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.label4.Location = new System.Drawing.Point(398, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "label4";
            // 
            // lbltv
            // 
            this.lbltv.AutoSize = true;
            this.lbltv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.lbltv.Location = new System.Drawing.Point(519, 527);
            this.lbltv.Name = "lbltv";
            this.lbltv.Size = new System.Drawing.Size(173, 15);
            this.lbltv.TabIndex = 35;
            this.lbltv.Text = "Trenutno stanje više tarife";
            // 
            // lbltn
            // 
            this.lbltn.AutoSize = true;
            this.lbltn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.lbltn.Location = new System.Drawing.Point(130, 525);
            this.lbltn.Name = "lbltn";
            this.lbltn.Size = new System.Drawing.Size(175, 15);
            this.lbltn.TabIndex = 36;
            this.lbltn.Text = "Trenutno stanje niže tarife";
            // 
            // lblnn
            // 
            this.lblnn.AutoSize = true;
            this.lblnn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.lblnn.Location = new System.Drawing.Point(153, 597);
            this.lblnn.Name = "lblnn";
            this.lblnn.Size = new System.Drawing.Size(150, 15);
            this.lblnn.TabIndex = 37;
            this.lblnn.Text = "Novo stanje niže tarife";
            // 
            // lblnv
            // 
            this.lblnv.AutoSize = true;
            this.lblnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.lblnv.Location = new System.Drawing.Point(542, 599);
            this.lblnv.Name = "lblnv";
            this.lblnv.Size = new System.Drawing.Size(148, 15);
            this.lblnv.TabIndex = 38;
            this.lblnv.Text = "Novo stanje više tarife";
            // 
            // txtPretraga
            // 
            this.txtPretraga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.txtPretraga.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPretraga.BackgroundImage")));
            this.txtPretraga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtPretraga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtPretraga.Icon = ((System.Drawing.Image)(resources.GetObject("txtPretraga.Icon")));
            this.txtPretraga.Location = new System.Drawing.Point(200, 18);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(305, 31);
            this.txtPretraga.TabIndex = 41;
            this.txtPretraga.text = "";
            this.txtPretraga.KeyPress += new System.EventHandler(this.txtPretraga_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.label9.Location = new System.Drawing.Point(197, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 15);
            this.label9.TabIndex = 44;
            this.label9.Text = "Broj strujomera";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtPretraga);
            this.panel1.Controls.Add(this.lblnv);
            this.panel1.Controls.Add(this.lblnn);
            this.panel1.Controls.Add(this.lbltn);
            this.panel1.Controls.Add(this.lbltv);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblZap);
            this.panel1.Controls.Add(this.lblDatum);
            this.panel1.Controls.Add(this.lblJmbgVl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtZaposleni);
            this.panel1.Controls.Add(this.txtVlasnik);
            this.panel1.Controls.Add(this.strujomerdataGridView);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btnObrisi);
            this.panel1.Controls.Add(this.btnAzuriraj);
            this.panel1.Controls.Add(this.btnDodaj);
            this.panel1.Controls.Add(this.txtNovoVise);
            this.panel1.Controls.Add(this.txtNovoNize);
            this.panel1.Controls.Add(this.txtTrenutnoVise);
            this.panel1.Controls.Add(this.txtTrenutnoNize);
            this.panel1.Controls.Add(this.txtBrojStrujomera);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 725);
            this.panel1.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.label12.Location = new System.Drawing.Point(690, 567);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 15);
            this.label12.TabIndex = 48;
            this.label12.Text = "DIN";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.label13.Location = new System.Drawing.Point(302, 567);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 15);
            this.label13.TabIndex = 47;
            this.label13.Text = "DIN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.label11.Location = new System.Drawing.Point(690, 491);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 15);
            this.label11.TabIndex = 46;
            this.label11.Text = "DIN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.label10.Location = new System.Drawing.Point(302, 491);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 15);
            this.label10.TabIndex = 45;
            this.label10.Text = "DIN";
            // 
            // StrujomerUCcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "StrujomerUCcs";
            this.Size = new System.Drawing.Size(740, 725);
            ((System.ComponentModel.ISupportInitialize)(this.strujomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tVPProjekatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strujomerdataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TVPProjekatDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TVPProjekatDataSetTableAdapters.StrujomerTableAdapter strujomerTableAdapter;
        private System.Windows.Forms.BindingSource strujomerBindingSource;
        private TVPProjekatDataSet tVPProjekatDataSet;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuMaterialTextbox txtBrojStrujomera;
        private ns1.BunifuMaterialTextbox txtTrenutnoNize;
        private ns1.BunifuMaterialTextbox txtTrenutnoVise;
        private ns1.BunifuMaterialTextbox txtNovoNize;
        private ns1.BunifuMaterialTextbox txtNovoVise;
        private ns1.BunifuFlatButton btnDodaj;
        private ns1.BunifuFlatButton btnAzuriraj;
        private ns1.BunifuFlatButton btnObrisi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView strujomerdataGridView;
        private System.Windows.Forms.TextBox txtVlasnik;
        private System.Windows.Forms.TextBox txtZaposleni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblJmbgVl;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblZap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltv;
        private System.Windows.Forms.Label lbltn;
        private System.Windows.Forms.Label lblnn;
        private System.Windows.Forms.Label lblnv;
        private ns1.BunifuTextbox txtPretraga;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}
