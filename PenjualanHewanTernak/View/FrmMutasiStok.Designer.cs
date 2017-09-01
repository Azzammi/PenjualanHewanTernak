namespace PenjualanHewanTernak.View
{
    partial class FrmMutasiStok
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
            System.Windows.Forms.Label keteranganLabel;
            System.Windows.Forms.Label kodeHewanLabel;
            System.Windows.Forms.Label kodeKandangLabel;
            System.Windows.Forms.Label noRefLabel;
            System.Windows.Forms.Label tglTransaksiLabel;
            System.Windows.Forms.Label nomorTransaksiLabel;
            this.keluarLabel = new System.Windows.Forms.Label();
            this.masukLabel = new System.Windows.Forms.Label();
            this.mutasiStokItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.keluarTextBox = new System.Windows.Forms.TextBox();
            this.keteranganTextBox = new System.Windows.Forms.TextBox();
            this.kodeHewanComboBox = new System.Windows.Forms.ComboBox();
            this.cattleItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kodeKandangComboBox = new System.Windows.Forms.ComboBox();
            this.kandangItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masukTextBox = new System.Windows.Forms.TextBox();
            this.noRefComboBox = new System.Windows.Forms.ComboBox();
            this.posMutasiStokItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tglTransaksiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CancelBtn = new System.Windows.Forms.ToolStripButton();
            this.SaveBtn = new System.Windows.Forms.ToolStripButton();
            this.nomorTransaksiTextBox = new System.Windows.Forms.TextBox();
            keteranganLabel = new System.Windows.Forms.Label();
            kodeHewanLabel = new System.Windows.Forms.Label();
            kodeKandangLabel = new System.Windows.Forms.Label();
            noRefLabel = new System.Windows.Forms.Label();
            tglTransaksiLabel = new System.Windows.Forms.Label();
            nomorTransaksiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mutasiStokItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cattleItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kandangItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posMutasiStokItemBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // keteranganLabel
            // 
            keteranganLabel.AutoSize = true;
            keteranganLabel.Location = new System.Drawing.Point(41, 230);
            keteranganLabel.Name = "keteranganLabel";
            keteranganLabel.Size = new System.Drawing.Size(65, 13);
            keteranganLabel.TabIndex = 15;
            keteranganLabel.Text = "Keterangan:";
            // 
            // kodeHewanLabel
            // 
            kodeHewanLabel.AutoSize = true;
            kodeHewanLabel.Location = new System.Drawing.Point(41, 124);
            kodeHewanLabel.Name = "kodeHewanLabel";
            kodeHewanLabel.Size = new System.Drawing.Size(72, 13);
            kodeHewanLabel.TabIndex = 11;
            kodeHewanLabel.Text = "Kode Hewan:";
            // 
            // kodeKandangLabel
            // 
            kodeKandangLabel.AutoSize = true;
            kodeKandangLabel.Location = new System.Drawing.Point(41, 151);
            kodeKandangLabel.Name = "kodeKandangLabel";
            kodeKandangLabel.Size = new System.Drawing.Size(81, 13);
            kodeKandangLabel.TabIndex = 12;
            kodeKandangLabel.Text = "Kode Kandang:";
            // 
            // noRefLabel
            // 
            noRefLabel.AutoSize = true;
            noRefLabel.Location = new System.Drawing.Point(41, 66);
            noRefLabel.Name = "noRefLabel";
            noRefLabel.Size = new System.Drawing.Size(44, 13);
            noRefLabel.TabIndex = 9;
            noRefLabel.Text = "No Ref:";
            // 
            // tglTransaksiLabel
            // 
            tglTransaksiLabel.AutoSize = true;
            tglTransaksiLabel.Location = new System.Drawing.Point(41, 94);
            tglTransaksiLabel.Name = "tglTransaksiLabel";
            tglTransaksiLabel.Size = new System.Drawing.Size(74, 13);
            tglTransaksiLabel.TabIndex = 10;
            tglTransaksiLabel.Text = "Tgl Transaksi:";
            // 
            // nomorTransaksiLabel
            // 
            nomorTransaksiLabel.AutoSize = true;
            nomorTransaksiLabel.Location = new System.Drawing.Point(41, 36);
            nomorTransaksiLabel.Name = "nomorTransaksiLabel";
            nomorTransaksiLabel.Size = new System.Drawing.Size(90, 13);
            nomorTransaksiLabel.TabIndex = 16;
            nomorTransaksiLabel.Text = "Nomor Transaksi:";
            // 
            // keluarLabel
            // 
            this.keluarLabel.AutoSize = true;
            this.keluarLabel.Location = new System.Drawing.Point(41, 204);
            this.keluarLabel.Name = "keluarLabel";
            this.keluarLabel.Size = new System.Drawing.Size(40, 13);
            this.keluarLabel.TabIndex = 14;
            this.keluarLabel.Text = "Keluar:";
            // 
            // masukLabel
            // 
            this.masukLabel.AutoSize = true;
            this.masukLabel.Location = new System.Drawing.Point(41, 178);
            this.masukLabel.Name = "masukLabel";
            this.masukLabel.Size = new System.Drawing.Size(42, 13);
            this.masukLabel.TabIndex = 13;
            this.masukLabel.Text = "Masuk:";
            // 
            // mutasiStokItemBindingSource
            // 
            this.mutasiStokItemBindingSource.DataSource = typeof(PenjualanHewanTernak.Model.MutasiStokItem);
            this.mutasiStokItemBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.mutasiStokItemBindingSource_AddingNew);
            // 
            // keluarTextBox
            // 
            this.keluarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mutasiStokItemBindingSource, "Keluar", true));
            this.keluarTextBox.Location = new System.Drawing.Point(137, 201);
            this.keluarTextBox.Name = "keluarTextBox";
            this.keluarTextBox.Size = new System.Drawing.Size(200, 20);
            this.keluarTextBox.TabIndex = 5;
            // 
            // keteranganTextBox
            // 
            this.keteranganTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mutasiStokItemBindingSource, "Keterangan", true));
            this.keteranganTextBox.Location = new System.Drawing.Point(137, 227);
            this.keteranganTextBox.Name = "keteranganTextBox";
            this.keteranganTextBox.Size = new System.Drawing.Size(200, 20);
            this.keteranganTextBox.TabIndex = 6;
            // 
            // kodeHewanComboBox
            // 
            this.kodeHewanComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mutasiStokItemBindingSource, "KodeHewan", true));
            this.kodeHewanComboBox.DataSource = this.cattleItemBindingSource;
            this.kodeHewanComboBox.DisplayMember = "NamaHewan";
            this.kodeHewanComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kodeHewanComboBox.FormattingEnabled = true;
            this.kodeHewanComboBox.Location = new System.Drawing.Point(137, 121);
            this.kodeHewanComboBox.Name = "kodeHewanComboBox";
            this.kodeHewanComboBox.Size = new System.Drawing.Size(200, 21);
            this.kodeHewanComboBox.TabIndex = 2;
            this.kodeHewanComboBox.ValueMember = "KodeHewan";
            // 
            // cattleItemBindingSource
            // 
            this.cattleItemBindingSource.DataSource = typeof(PenjualanHewanTernak.Model.CattleItem);
            // 
            // kodeKandangComboBox
            // 
            this.kodeKandangComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mutasiStokItemBindingSource, "KodeKandang", true));
            this.kodeKandangComboBox.DataSource = this.kandangItemBindingSource;
            this.kodeKandangComboBox.DisplayMember = "Keterangan";
            this.kodeKandangComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kodeKandangComboBox.FormattingEnabled = true;
            this.kodeKandangComboBox.Location = new System.Drawing.Point(137, 148);
            this.kodeKandangComboBox.Name = "kodeKandangComboBox";
            this.kodeKandangComboBox.Size = new System.Drawing.Size(200, 21);
            this.kodeKandangComboBox.TabIndex = 3;
            this.kodeKandangComboBox.ValueMember = "KodeKandang";
            // 
            // kandangItemBindingSource
            // 
            this.kandangItemBindingSource.DataSource = typeof(PenjualanHewanTernak.Model.KandangItem);
            // 
            // masukTextBox
            // 
            this.masukTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mutasiStokItemBindingSource, "Masuk", true));
            this.masukTextBox.Location = new System.Drawing.Point(137, 175);
            this.masukTextBox.Name = "masukTextBox";
            this.masukTextBox.Size = new System.Drawing.Size(200, 20);
            this.masukTextBox.TabIndex = 4;
            // 
            // noRefComboBox
            // 
            this.noRefComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mutasiStokItemBindingSource, "NoRef", true));
            this.noRefComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mutasiStokItemBindingSource, "NoRef", true));
            this.noRefComboBox.DataSource = this.posMutasiStokItemBindingSource;
            this.noRefComboBox.DisplayMember = "Keterangan";
            this.noRefComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.noRefComboBox.FormattingEnabled = true;
            this.noRefComboBox.Location = new System.Drawing.Point(137, 63);
            this.noRefComboBox.Name = "noRefComboBox";
            this.noRefComboBox.Size = new System.Drawing.Size(200, 21);
            this.noRefComboBox.TabIndex = 0;
            this.noRefComboBox.ValueMember = "NoRef";
            // 
            // posMutasiStokItemBindingSource
            // 
            this.posMutasiStokItemBindingSource.DataSource = typeof(PenjualanHewanTernak.Model.PosMutasiStokItem);
            // 
            // tglTransaksiDateTimePicker
            // 
            this.tglTransaksiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mutasiStokItemBindingSource, "TglTransaksi", true));
            this.tglTransaksiDateTimePicker.Location = new System.Drawing.Point(137, 90);
            this.tglTransaksiDateTimePicker.Name = "tglTransaksiDateTimePicker";
            this.tglTransaksiDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.tglTransaksiDateTimePicker.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.posMutasiStokItemBindingSource, "IsPemasukan", true));
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(343, 65);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Penambahan Stok";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CancelBtn,
            this.SaveBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 310);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(458, 38);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.TabStop = true;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CancelBtn.Image = global::PenjualanHewanTernak.Properties.Resources.Close_Window_96px;
            this.CancelBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(76, 35);
            this.CancelBtn.Text = "Cancel / Exit";
            this.CancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SaveBtn.Image = global::PenjualanHewanTernak.Properties.Resources.Save_50px_1;
            this.SaveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(51, 35);
            this.SaveBtn.Text = "Simpan";
            this.SaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // nomorTransaksiTextBox
            // 
            this.nomorTransaksiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mutasiStokItemBindingSource, "NomorTransaksi", true));
            this.nomorTransaksiTextBox.Location = new System.Drawing.Point(137, 33);
            this.nomorTransaksiTextBox.Name = "nomorTransaksiTextBox";
            this.nomorTransaksiTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomorTransaksiTextBox.TabIndex = 17;
            // 
            // FrmMutasiStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 348);
            this.Controls.Add(nomorTransaksiLabel);
            this.Controls.Add(this.nomorTransaksiTextBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.keluarLabel);
            this.Controls.Add(this.keluarTextBox);
            this.Controls.Add(keteranganLabel);
            this.Controls.Add(this.keteranganTextBox);
            this.Controls.Add(kodeHewanLabel);
            this.Controls.Add(this.kodeHewanComboBox);
            this.Controls.Add(kodeKandangLabel);
            this.Controls.Add(this.kodeKandangComboBox);
            this.Controls.Add(this.masukLabel);
            this.Controls.Add(this.masukTextBox);
            this.Controls.Add(noRefLabel);
            this.Controls.Add(this.noRefComboBox);
            this.Controls.Add(tglTransaksiLabel);
            this.Controls.Add(this.tglTransaksiDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMutasiStok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mutasi Stok - ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMutasiStok_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.mutasiStokItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cattleItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kandangItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posMutasiStokItemBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region Properties
        public Status IsNewRow
        {
            get { return isNewRow; }
            set
            {                
                isNewRow = value;
                //Call Method in FrmMutasiStok code
                this.OnStatusChanged(new FormStatusChangedEventArgs(value));                       
            }
        }
        
        #endregion

        #region Declaration
        private System.Windows.Forms.BindingSource mutasiStokItemBindingSource;
        private System.Windows.Forms.TextBox keluarTextBox;
        private System.Windows.Forms.TextBox keteranganTextBox;
        private System.Windows.Forms.ComboBox kodeHewanComboBox;
        private System.Windows.Forms.ComboBox kodeKandangComboBox;
        private System.Windows.Forms.TextBox masukTextBox;
        private System.Windows.Forms.ComboBox noRefComboBox;
        private System.Windows.Forms.DateTimePicker tglTransaksiDateTimePicker;
        private System.Windows.Forms.BindingSource cattleItemBindingSource;
        private System.Windows.Forms.BindingSource kandangItemBindingSource;
        private System.Windows.Forms.BindingSource posMutasiStokItemBindingSource;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton CancelBtn;
        private System.Windows.Forms.ToolStripButton SaveBtn;

       
        
        private System.Windows.Forms.Label keluarLabel;
        private System.Windows.Forms.Label masukLabel;
        private System.Windows.Forms.TextBox nomorTransaksiTextBox;
        
        //User Added
        private Status isNewRow;
        //Declaration if new event - Important
        private event FormStatusChangedEventHandler statusChanged;
        #endregion

    }
}