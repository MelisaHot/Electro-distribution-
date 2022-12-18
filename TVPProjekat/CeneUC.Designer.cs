namespace TVPProjekat
{
    partial class CeneUC
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
            this.ceneDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tVPProjekatDataSet = new TVPProjekat.TVPProjekatDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNizaPlava = new ns1.BunifuMaterialTextbox();
            this.txNizaZel = new ns1.BunifuMaterialTextbox();
            this.txtNizaCrvena = new ns1.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVisaCrvena = new ns1.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVisaPlava = new ns1.BunifuMaterialTextbox();
            this.txtVisaZel = new ns1.BunifuMaterialTextbox();
            this.txtAkciza = new ns1.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPDV = new ns1.BunifuMaterialTextbox();
            this.ceneTableAdapter = new TVPProjekat.TVPProjekatDataSetTableAdapters.CeneTableAdapter();
            this.tableAdapterManager = new TVPProjekat.TVPProjekatDataSetTableAdapters.TableAdapterManager();
            this.btnAzuriraj = new ns1.BunifuFlatButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ceneDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tVPProjekatDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ceneDataGridView
            // 
            this.ceneDataGridView.AllowUserToAddRows = false;
            this.ceneDataGridView.AllowUserToDeleteRows = false;
            this.ceneDataGridView.AutoGenerateColumns = false;
            this.ceneDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.ceneDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ceneDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.ceneDataGridView.DataSource = this.ceneBindingSource;
            this.ceneDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.ceneDataGridView.Location = new System.Drawing.Point(24, 12);
            this.ceneDataGridView.Name = "ceneDataGridView";
            this.ceneDataGridView.ReadOnly = true;
            this.ceneDataGridView.Size = new System.Drawing.Size(678, 185);
            this.ceneDataGridView.TabIndex = 0;
            this.ceneDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ceneDataGridView_RowHeaderMouseClick);
            this.ceneDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ceneDataGridView_RowHeaderMouseDoubleClick);
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NizaZelena";
            this.dataGridViewTextBoxColumn2.HeaderText = "NizaZelena";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NizaPlava";
            this.dataGridViewTextBoxColumn3.HeaderText = "NizaPlava";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NizaCrvena";
            this.dataGridViewTextBoxColumn4.HeaderText = "NizaCrvena";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "VisaZelena";
            this.dataGridViewTextBoxColumn5.HeaderText = "VisaZelena";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "VisaPlava";
            this.dataGridViewTextBoxColumn6.HeaderText = "VisaPlava";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "VisaCrvena";
            this.dataGridViewTextBoxColumn7.HeaderText = "VisaCrvena";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PDV";
            this.dataGridViewTextBoxColumn8.HeaderText = "PDV";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 75;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Akciza";
            this.dataGridViewTextBoxColumn9.HeaderText = "Akciza";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 75;
            // 
            // ceneBindingSource
            // 
            this.ceneBindingSource.DataMember = "Cene";
            this.ceneBindingSource.DataSource = this.tVPProjekatDataSet;
            // 
            // tVPProjekatDataSet
            // 
            this.tVPProjekatDataSet.DataSetName = "TVPProjekatDataSet";
            this.tVPProjekatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "label2";
            // 
            // txtNizaPlava
            // 
            this.txtNizaPlava.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNizaPlava.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNizaPlava.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtNizaPlava.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.txtNizaPlava.HintText = "Niža tarifa - Plava zona";
            this.txtNizaPlava.isPassword = false;
            this.txtNizaPlava.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtNizaPlava.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtNizaPlava.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtNizaPlava.LineThickness = 4;
            this.txtNizaPlava.Location = new System.Drawing.Point(271, 269);
            this.txtNizaPlava.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNizaPlava.Name = "txtNizaPlava";
            this.txtNizaPlava.Size = new System.Drawing.Size(195, 39);
            this.txtNizaPlava.TabIndex = 2;
            this.txtNizaPlava.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNizaPlava.OnValueChanged += new System.EventHandler(this.txtNizaPlava_OnValueChanged);
            this.txtNizaPlava.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txNizaZel_KeyPress);
            // 
            // txNizaZel
            // 
            this.txNizaZel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txNizaZel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNizaZel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txNizaZel.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.txNizaZel.HintText = "Niža tarifa - Zelena zona";
            this.txNizaZel.isPassword = false;
            this.txNizaZel.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txNizaZel.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txNizaZel.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txNizaZel.LineThickness = 4;
            this.txNizaZel.Location = new System.Drawing.Point(22, 269);
            this.txNizaZel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txNizaZel.Name = "txNizaZel";
            this.txNizaZel.Size = new System.Drawing.Size(203, 39);
            this.txNizaZel.TabIndex = 1;
            this.txNizaZel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txNizaZel.OnValueChanged += new System.EventHandler(this.txNizaZel_OnValueChanged);
            this.txNizaZel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txNizaZel_KeyPress);
            // 
            // txtNizaCrvena
            // 
            this.txtNizaCrvena.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNizaCrvena.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNizaCrvena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtNizaCrvena.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.txtNizaCrvena.HintText = "Niža tarifa - Crvena zona";
            this.txtNizaCrvena.isPassword = false;
            this.txtNizaCrvena.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtNizaCrvena.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtNizaCrvena.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtNizaCrvena.LineThickness = 4;
            this.txtNizaCrvena.Location = new System.Drawing.Point(505, 269);
            this.txtNizaCrvena.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNizaCrvena.Name = "txtNizaCrvena";
            this.txtNizaCrvena.Size = new System.Drawing.Size(195, 39);
            this.txtNizaCrvena.TabIndex = 3;
            this.txtNizaCrvena.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNizaCrvena.OnValueChanged += new System.EventHandler(this.txtNizaCrvena_OnValueChanged);
            this.txtNizaCrvena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txNizaZel_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nove cene:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "label5";
            // 
            // txtVisaCrvena
            // 
            this.txtVisaCrvena.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVisaCrvena.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisaCrvena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtVisaCrvena.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.txtVisaCrvena.HintText = "Viša tarifa - Crvena zona";
            this.txtVisaCrvena.isPassword = false;
            this.txtVisaCrvena.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtVisaCrvena.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtVisaCrvena.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtVisaCrvena.LineThickness = 4;
            this.txtVisaCrvena.Location = new System.Drawing.Point(505, 348);
            this.txtVisaCrvena.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtVisaCrvena.Name = "txtVisaCrvena";
            this.txtVisaCrvena.Size = new System.Drawing.Size(195, 39);
            this.txtVisaCrvena.TabIndex = 6;
            this.txtVisaCrvena.Text = "Niža tarifa - Crvena zona";
            this.txtVisaCrvena.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtVisaCrvena.OnValueChanged += new System.EventHandler(this.txtVisaCrvena_OnValueChanged);
            this.txtVisaCrvena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txNizaZel_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "label7";
            // 
            // txtVisaPlava
            // 
            this.txtVisaPlava.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVisaPlava.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisaPlava.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtVisaPlava.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtVisaPlava.HintText = "Viša tarifa - Plava zona";
            this.txtVisaPlava.isPassword = false;
            this.txtVisaPlava.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtVisaPlava.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtVisaPlava.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtVisaPlava.LineThickness = 4;
            this.txtVisaPlava.Location = new System.Drawing.Point(271, 348);
            this.txtVisaPlava.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtVisaPlava.Name = "txtVisaPlava";
            this.txtVisaPlava.Size = new System.Drawing.Size(195, 39);
            this.txtVisaPlava.TabIndex = 5;
            this.txtVisaPlava.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtVisaPlava.OnValueChanged += new System.EventHandler(this.txtVisaPlava_OnValueChanged);
            this.txtVisaPlava.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txNizaZel_KeyPress);
            // 
            // txtVisaZel
            // 
            this.txtVisaZel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVisaZel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisaZel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtVisaZel.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtVisaZel.HintText = "Viša tarifa - Zelena zona";
            this.txtVisaZel.isPassword = false;
            this.txtVisaZel.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtVisaZel.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtVisaZel.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtVisaZel.LineThickness = 4;
            this.txtVisaZel.Location = new System.Drawing.Point(22, 348);
            this.txtVisaZel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtVisaZel.Name = "txtVisaZel";
            this.txtVisaZel.Size = new System.Drawing.Size(203, 39);
            this.txtVisaZel.TabIndex = 4;
            this.txtVisaZel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtVisaZel.OnValueChanged += new System.EventHandler(this.txtVisaZel_OnValueChanged);
            this.txtVisaZel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txNizaZel_KeyPress);
            // 
            // txtAkciza
            // 
            this.txtAkciza.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAkciza.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAkciza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtAkciza.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.txtAkciza.HintText = "Akciza";
            this.txtAkciza.isPassword = false;
            this.txtAkciza.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtAkciza.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtAkciza.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtAkciza.LineThickness = 4;
            this.txtAkciza.Location = new System.Drawing.Point(274, 439);
            this.txtAkciza.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAkciza.Name = "txtAkciza";
            this.txtAkciza.Size = new System.Drawing.Size(195, 39);
            this.txtAkciza.TabIndex = 8;
            this.txtAkciza.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAkciza.OnValueChanged += new System.EventHandler(this.txtAkciza_OnValueChanged);
            this.txtAkciza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txNizaZel_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 483);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(271, 483);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "label9";
            // 
            // txtPDV
            // 
            this.txtPDV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPDV.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPDV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtPDV.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.txtPDV.HintText = "PDV";
            this.txtPDV.isPassword = false;
            this.txtPDV.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtPDV.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtPDV.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtPDV.LineThickness = 4;
            this.txtPDV.Location = new System.Drawing.Point(21, 439);
            this.txtPDV.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPDV.Name = "txtPDV";
            this.txtPDV.Size = new System.Drawing.Size(204, 39);
            this.txtPDV.TabIndex = 7;
            this.txtPDV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPDV.OnValueChanged += new System.EventHandler(this.txtPDV_OnValueChanged);
            this.txtPDV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txNizaZel_KeyPress);
            // 
            // ceneTableAdapter
            // 
            this.ceneTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CeneTableAdapter = this.ceneTableAdapter;
            this.tableAdapterManager.StrujomerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TVPProjekat.TVPProjekatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VlasnikTableAdapter = null;
            this.tableAdapterManager.ZaposleniTableAdapter = null;
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
            this.btnAzuriraj.Iconimage = global::TVPProjekat.Properties.Resources.ceneupdate;
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
            this.btnAzuriraj.Location = new System.Drawing.Point(259, 579);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(5);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnAzuriraj.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(188)))));
            this.btnAzuriraj.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.btnAzuriraj.selected = false;
            this.btnAzuriraj.Size = new System.Drawing.Size(155, 59);
            this.btnAzuriraj.TabIndex = 50;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAzuriraj.Textcolor = System.Drawing.Color.Black;
            this.btnAzuriraj.TextFont = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(105, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Niža tarifa - zelena zona";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(355, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Niža tarifa - plava zona";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(580, 313);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Niža tarifa - crvena zona";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(106, 392);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "Viša tarifa - zelena zona";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(355, 392);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 13);
            this.label14.TabIndex = 55;
            this.label14.Text = "Viša tarifa - plava zona";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(581, 392);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 13);
            this.label15.TabIndex = 56;
            this.label15.Text = "Viša tarifa - crvena zona";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(196, 483);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 57;
            this.label16.Text = "PDV";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(430, 483);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 58;
            this.label17.Text = "Akciza";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(224, 283);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 13);
            this.label18.TabIndex = 59;
            this.label18.Text = "DIN";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(461, 283);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 13);
            this.label19.TabIndex = 60;
            this.label19.Text = "DIN";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(698, 283);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(26, 13);
            this.label20.TabIndex = 61;
            this.label20.Text = "DIN";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(698, 361);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(26, 13);
            this.label21.TabIndex = 64;
            this.label21.Text = "DIN";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(461, 361);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(26, 13);
            this.label22.TabIndex = 63;
            this.label22.Text = "DIN";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(224, 361);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(26, 13);
            this.label23.TabIndex = 62;
            this.label23.Text = "DIN";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(472, 453);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(15, 13);
            this.label24.TabIndex = 66;
            this.label24.Text = "%";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(224, 453);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(15, 13);
            this.label25.TabIndex = 65;
            this.label25.Text = "%";
            // 
            // CeneUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.txtAkciza);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPDV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVisaCrvena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtVisaPlava);
            this.Controls.Add(this.txtVisaZel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNizaCrvena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNizaPlava);
            this.Controls.Add(this.txNizaZel);
            this.Controls.Add(this.ceneDataGridView);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.Name = "CeneUC";
            this.Size = new System.Drawing.Size(740, 725);
            ((System.ComponentModel.ISupportInitialize)(this.ceneDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tVPProjekatDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TVPProjekatDataSet tVPProjekatDataSet;
        private System.Windows.Forms.BindingSource ceneBindingSource;
        private TVPProjekatDataSetTableAdapters.CeneTableAdapter ceneTableAdapter;
        private TVPProjekatDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView ceneDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ns1.BunifuMaterialTextbox txtNizaPlava;
        private ns1.BunifuMaterialTextbox txNizaZel;
        private ns1.BunifuMaterialTextbox txtNizaCrvena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private ns1.BunifuMaterialTextbox txtVisaCrvena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private ns1.BunifuMaterialTextbox txtVisaPlava;
        private ns1.BunifuMaterialTextbox txtVisaZel;
        private ns1.BunifuMaterialTextbox txtAkciza;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private ns1.BunifuMaterialTextbox txtPDV;
        private ns1.BunifuFlatButton btnAzuriraj;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
    }
}
