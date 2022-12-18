namespace TVPProjekat
{
    partial class StanjaNisuUneta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StanjaNisuUneta));
            this.dgvStrujomer = new System.Windows.Forms.DataGridView();
            this.txtBrojStrujomera = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new ns1.BunifuFlatButton();
            this.txtNovoVise = new ns1.BunifuMaterialTextbox();
            this.txtNovoNize = new ns1.BunifuMaterialTextbox();
            this.lblNema = new System.Windows.Forms.Label();
            this.stanjeStrujomeraDataGridView = new System.Windows.Forms.DataGridView();
            this.bunifuTextbox1 = new ns1.BunifuTextbox();
            this.btnStampanje = new ns1.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStrujomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanjeStrujomeraDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStrujomer
            // 
            this.dgvStrujomer.AllowUserToAddRows = false;
            this.dgvStrujomer.AllowUserToDeleteRows = false;
            this.dgvStrujomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.dgvStrujomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStrujomer.Location = new System.Drawing.Point(12, 84);
            this.dgvStrujomer.Name = "dgvStrujomer";
            this.dgvStrujomer.ReadOnly = true;
            this.dgvStrujomer.Size = new System.Drawing.Size(736, 216);
            this.dgvStrujomer.TabIndex = 0;
            this.dgvStrujomer.Visible = false;
            this.dgvStrujomer.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStrujomer_RowHeaderMouseClick);
            this.dgvStrujomer.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStrujomer_RowHeaderMouseDoubleClick);
            // 
            // txtBrojStrujomera
            // 
            this.txtBrojStrujomera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.txtBrojStrujomera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojStrujomera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.txtBrojStrujomera.Location = new System.Drawing.Point(12, 329);
            this.txtBrojStrujomera.Name = "txtBrojStrujomera";
            this.txtBrojStrujomera.Size = new System.Drawing.Size(220, 26);
            this.txtBrojStrujomera.TabIndex = 0;
            this.txtBrojStrujomera.Visible = false;
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
            this.btnSacuvaj.Location = new System.Drawing.Point(51, 409);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnSacuvaj.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(188)))));
            this.btnSacuvaj.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.btnSacuvaj.selected = false;
            this.btnSacuvaj.Size = new System.Drawing.Size(155, 59);
            this.btnSacuvaj.TabIndex = 3;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSacuvaj.Textcolor = System.Drawing.Color.Black;
            this.btnSacuvaj.TextFont = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Visible = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
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
            this.txtNovoVise.Location = new System.Drawing.Point(528, 306);
            this.txtNovoVise.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNovoVise.Name = "txtNovoVise";
            this.txtNovoVise.Size = new System.Drawing.Size(220, 39);
            this.txtNovoVise.TabIndex = 2;
            this.txtNovoVise.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNovoVise.Visible = false;
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
            this.txtNovoNize.Location = new System.Drawing.Point(287, 306);
            this.txtNovoNize.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNovoNize.Name = "txtNovoNize";
            this.txtNovoNize.Size = new System.Drawing.Size(220, 39);
            this.txtNovoNize.TabIndex = 1;
            this.txtNovoNize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNovoNize.Visible = false;
            // 
            // lblNema
            // 
            this.lblNema.AutoSize = true;
            this.lblNema.Location = new System.Drawing.Point(13, 13);
            this.lblNema.Name = "lblNema";
            this.lblNema.Size = new System.Drawing.Size(35, 13);
            this.lblNema.TabIndex = 11;
            this.lblNema.Text = "label1";
            // 
            // stanjeStrujomeraDataGridView
            // 
            this.stanjeStrujomeraDataGridView.AllowUserToAddRows = false;
            this.stanjeStrujomeraDataGridView.AllowUserToDeleteRows = false;
            this.stanjeStrujomeraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stanjeStrujomeraDataGridView.Location = new System.Drawing.Point(558, 367);
            this.stanjeStrujomeraDataGridView.Name = "stanjeStrujomeraDataGridView";
            this.stanjeStrujomeraDataGridView.ReadOnly = true;
            this.stanjeStrujomeraDataGridView.Size = new System.Drawing.Size(151, 116);
            this.stanjeStrujomeraDataGridView.TabIndex = 34;
            this.stanjeStrujomeraDataGridView.Visible = false;
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(257, 13);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(250, 42);
            this.bunifuTextbox1.TabIndex = 5;
            this.bunifuTextbox1.text = "";
            this.bunifuTextbox1.OnTextChange += new System.EventHandler(this.bunifuTextbox1_OnTextChange);
            // 
            // btnStampanje
            // 
            this.btnStampanje.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnStampanje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnStampanje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStampanje.BorderRadius = 0;
            this.btnStampanje.ButtonText = "Štampaj";
            this.btnStampanje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStampanje.DisabledColor = System.Drawing.Color.Gray;
            this.btnStampanje.ForeColor = System.Drawing.Color.Black;
            this.btnStampanje.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStampanje.Iconimage = global::TVPProjekat.Properties.Resources.img_533275;
            this.btnStampanje.Iconimage_right = null;
            this.btnStampanje.Iconimage_right_Selected = null;
            this.btnStampanje.Iconimage_Selected = null;
            this.btnStampanje.IconMarginLeft = 0;
            this.btnStampanje.IconMarginRight = 0;
            this.btnStampanje.IconRightVisible = true;
            this.btnStampanje.IconRightZoom = 0D;
            this.btnStampanje.IconVisible = true;
            this.btnStampanje.IconZoom = 90D;
            this.btnStampanje.IsTab = false;
            this.btnStampanje.Location = new System.Drawing.Point(273, 409);
            this.btnStampanje.Margin = new System.Windows.Forms.Padding(4);
            this.btnStampanje.Name = "btnStampanje";
            this.btnStampanje.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnStampanje.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(188)))));
            this.btnStampanje.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.btnStampanje.selected = false;
            this.btnStampanje.Size = new System.Drawing.Size(155, 59);
            this.btnStampanje.TabIndex = 4;
            this.btnStampanje.Text = "Štampaj";
            this.btnStampanje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStampanje.Textcolor = System.Drawing.Color.Black;
            this.btnStampanje.TextFont = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStampanje.Visible = false;
            this.btnStampanje.Click += new System.EventHandler(this.btnStampanje_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.label1.Location = new System.Drawing.Point(156, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Broj strujomera";
            // 
            // StanjaNisuUneta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(760, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStampanje);
            this.Controls.Add(this.bunifuTextbox1);
            this.Controls.Add(this.stanjeStrujomeraDataGridView);
            this.Controls.Add(this.lblNema);
            this.Controls.Add(this.txtBrojStrujomera);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtNovoVise);
            this.Controls.Add(this.txtNovoNize);
            this.Controls.Add(this.dgvStrujomer);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StanjaNisuUneta";
            this.Text = "StanjaNisuUneta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStrujomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanjeStrujomeraDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStrujomer;
        private System.Windows.Forms.TextBox txtBrojStrujomera;
        private ns1.BunifuFlatButton btnSacuvaj;
        private ns1.BunifuMaterialTextbox txtNovoVise;
        private ns1.BunifuMaterialTextbox txtNovoNize;
        private System.Windows.Forms.Label lblNema;
        private System.Windows.Forms.DataGridView stanjeStrujomeraDataGridView;
        private ns1.BunifuTextbox bunifuTextbox1;
        private ns1.BunifuFlatButton btnStampanje;
        private System.Windows.Forms.Label label1;
    }
}