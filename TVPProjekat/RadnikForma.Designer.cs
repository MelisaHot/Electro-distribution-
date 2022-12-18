namespace TVPProjekat
{
    partial class RadnikForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadnikForma));
            this.txtNovoVise = new ns1.BunifuMaterialTextbox();
            this.txtNovoNize = new ns1.BunifuMaterialTextbox();
            this.txtBrojStrujomera = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnStampaj = new ns1.BunifuFlatButton();
            this.btnSacuvaj = new ns1.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tVPProjekatDataSet = new TVPProjekat.TVPProjekatDataSet();
            this.strujomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.strujomerTableAdapter = new TVPProjekat.TVPProjekatDataSetTableAdapters.StrujomerTableAdapter();
            this.tableAdapterManager = new TVPProjekat.TVPProjekatDataSetTableAdapters.TableAdapterManager();
            this.stanjeStrujomeraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stanjeStrujomeraTableAdapter = new TVPProjekat.TVPProjekatDataSetTableAdapters.StanjeStrujomeraTableAdapter();
            this.btnOdjava = new ns1.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tVPProjekatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strujomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanjeStrujomeraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNovoVise
            // 
            this.txtNovoVise.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNovoVise.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovoVise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtNovoVise.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.txtNovoVise.HintText = "Novo stanje više tarife";
            this.txtNovoVise.isPassword = false;
            this.txtNovoVise.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtNovoVise.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtNovoVise.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtNovoVise.LineThickness = 4;
            this.txtNovoVise.Location = new System.Drawing.Point(67, 189);
            this.txtNovoVise.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNovoVise.Name = "txtNovoVise";
            this.txtNovoVise.Size = new System.Drawing.Size(220, 39);
            this.txtNovoVise.TabIndex = 3;
            this.txtNovoVise.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNovoVise.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNovoVise_KeyDown);
            // 
            // txtNovoNize
            // 
            this.txtNovoNize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNovoNize.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovoNize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtNovoNize.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.txtNovoNize.HintText = "Novo stanje niže tarife";
            this.txtNovoNize.isPassword = false;
            this.txtNovoNize.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtNovoNize.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtNovoNize.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtNovoNize.LineThickness = 4;
            this.txtNovoNize.Location = new System.Drawing.Point(67, 104);
            this.txtNovoNize.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNovoNize.Name = "txtNovoNize";
            this.txtNovoNize.Size = new System.Drawing.Size(220, 39);
            this.txtNovoNize.TabIndex = 2;
            this.txtNovoNize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtBrojStrujomera
            // 
            this.txtBrojStrujomera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.txtBrojStrujomera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojStrujomera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtBrojStrujomera.Location = new System.Drawing.Point(67, 41);
            this.txtBrojStrujomera.Name = "txtBrojStrujomera";
            this.txtBrojStrujomera.Size = new System.Drawing.Size(220, 26);
            this.txtBrojStrujomera.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(375, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(263, 187);
            this.dataGridView1.TabIndex = 29;
            // 
            // btnStampaj
            // 
            this.btnStampaj.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnStampaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnStampaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStampaj.BorderRadius = 0;
            this.btnStampaj.ButtonText = "Štampaj";
            this.btnStampaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStampaj.DisabledColor = System.Drawing.Color.Gray;
            this.btnStampaj.ForeColor = System.Drawing.Color.Black;
            this.btnStampaj.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStampaj.Iconimage = global::TVPProjekat.Properties.Resources.img_533275;
            this.btnStampaj.Iconimage_right = null;
            this.btnStampaj.Iconimage_right_Selected = null;
            this.btnStampaj.Iconimage_Selected = null;
            this.btnStampaj.IconMarginLeft = 0;
            this.btnStampaj.IconMarginRight = 0;
            this.btnStampaj.IconRightVisible = true;
            this.btnStampaj.IconRightZoom = 0D;
            this.btnStampaj.IconVisible = true;
            this.btnStampaj.IconZoom = 90D;
            this.btnStampaj.IsTab = false;
            this.btnStampaj.Location = new System.Drawing.Point(282, 278);
            this.btnStampaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnStampaj.Name = "btnStampaj";
            this.btnStampaj.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnStampaj.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(188)))));
            this.btnStampaj.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.btnStampaj.selected = false;
            this.btnStampaj.Size = new System.Drawing.Size(155, 59);
            this.btnStampaj.TabIndex = 5;
            this.btnStampaj.Text = "Štampaj";
            this.btnStampaj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStampaj.Textcolor = System.Drawing.Color.Black;
            this.btnStampaj.TextFont = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStampaj.Click += new System.EventHandler(this.btnStampaj_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnSacuvaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnSacuvaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSacuvaj.BorderRadius = 0;
            this.btnSacuvaj.ButtonText = "Sačuvaj";
            this.btnSacuvaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSacuvaj.DisabledColor = System.Drawing.Color.Gray;
            this.btnSacuvaj.ForeColor = System.Drawing.Color.Black;
            this.btnSacuvaj.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSacuvaj.Iconimage = global::TVPProjekat.Properties.Resources._61183;
            this.btnSacuvaj.Iconimage_right = null;
            this.btnSacuvaj.Iconimage_right_Selected = null;
            this.btnSacuvaj.Iconimage_Selected = null;
            this.btnSacuvaj.IconMarginLeft = 0;
            this.btnSacuvaj.IconMarginRight = 0;
            this.btnSacuvaj.IconRightVisible = true;
            this.btnSacuvaj.IconRightZoom = 0D;
            this.btnSacuvaj.IconVisible = true;
            this.btnSacuvaj.IconZoom = 90D;
            this.btnSacuvaj.IsTab = false;
            this.btnSacuvaj.Location = new System.Drawing.Point(67, 278);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnSacuvaj.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(188)))));
            this.btnSacuvaj.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.btnSacuvaj.selected = false;
            this.btnSacuvaj.Size = new System.Drawing.Size(155, 59);
            this.btnSacuvaj.TabIndex = 4;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSacuvaj.Textcolor = System.Drawing.Color.Black;
            this.btnSacuvaj.TextFont = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Broj strujomera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Niža tarifa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Viša tarifa";
            // 
            // tVPProjekatDataSet
            // 
            this.tVPProjekatDataSet.DataSetName = "TVPProjekatDataSet";
            this.tVPProjekatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // strujomerBindingSource
            // 
            this.strujomerBindingSource.DataMember = "Strujomer";
            this.strujomerBindingSource.DataSource = this.tVPProjekatDataSet;
            // 
            // strujomerTableAdapter
            // 
            this.strujomerTableAdapter.ClearBeforeFill = true;
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
            // stanjeStrujomeraBindingSource
            // 
            this.stanjeStrujomeraBindingSource.DataMember = "StanjeStrujomera";
            this.stanjeStrujomeraBindingSource.DataSource = this.tVPProjekatDataSet;
            // 
            // stanjeStrujomeraTableAdapter
            // 
            this.stanjeStrujomeraTableAdapter.ClearBeforeFill = true;
            // 
            // btnOdjava
            // 
            this.btnOdjava.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnOdjava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnOdjava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOdjava.BorderRadius = 0;
            this.btnOdjava.ButtonText = "Odjavi se";
            this.btnOdjava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdjava.DisabledColor = System.Drawing.Color.Gray;
            this.btnOdjava.ForeColor = System.Drawing.Color.Black;
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
            this.btnOdjava.Location = new System.Drawing.Point(540, 278);
            this.btnOdjava.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnOdjava.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(188)))));
            this.btnOdjava.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.btnOdjava.selected = false;
            this.btnOdjava.Size = new System.Drawing.Size(155, 59);
            this.btnOdjava.TabIndex = 6;
            this.btnOdjava.Text = "Odjavi se";
            this.btnOdjava.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdjava.Textcolor = System.Drawing.Color.Black;
            this.btnOdjava.TextFont = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Strujomeri";
            // 
            // RadnikForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(978, 365);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStampaj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBrojStrujomera);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtNovoVise);
            this.Controls.Add(this.txtNovoNize);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RadnikForma";
            this.Text = "RadnikForma";
            this.Load += new System.EventHandler(this.RadnikForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tVPProjekatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strujomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanjeStrujomeraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuFlatButton btnSacuvaj;
        private ns1.BunifuMaterialTextbox txtNovoVise;
        private ns1.BunifuMaterialTextbox txtNovoNize;
        private System.Windows.Forms.TextBox txtBrojStrujomera;
        private TVPProjekatDataSet tVPProjekatDataSet;
        private System.Windows.Forms.BindingSource strujomerBindingSource;
        private TVPProjekatDataSetTableAdapters.StrujomerTableAdapter strujomerTableAdapter;
        private TVPProjekatDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ns1.BunifuFlatButton btnStampaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource stanjeStrujomeraBindingSource;
        private TVPProjekatDataSetTableAdapters.StanjeStrujomeraTableAdapter stanjeStrujomeraTableAdapter;
        private ns1.BunifuFlatButton btnOdjava;
        private System.Windows.Forms.Label label4;
    }
}