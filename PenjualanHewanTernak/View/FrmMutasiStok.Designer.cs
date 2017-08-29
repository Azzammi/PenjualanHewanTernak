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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMutasiStok));
            this.keluarLabel = new System.Windows.Forms.Label();
            this.masukLabel = new System.Windows.Forms.Label();
            this.mutasiStokItemBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.mutasiStokItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
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
            this.DeleteBtn = new System.Windows.Forms.ToolStripButton();
            this.SaveBtn = new System.Windows.Forms.ToolStripButton();
            this.AddBtn = new System.Windows.Forms.ToolStripButton();
            keteranganLabel = new System.Windows.Forms.Label();
            kodeHewanLabel = new System.Windows.Forms.Label();
            kodeKandangLabel = new System.Windows.Forms.Label();
            noRefLabel = new System.Windows.Forms.Label();
            tglTransaksiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mutasiStokItemBindingNavigator)).BeginInit();
            this.mutasiStokItemBindingNavigator.SuspendLayout();
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
            keteranganLabel.Location = new System.Drawing.Point(44, 209);
            keteranganLabel.Name = "keteranganLabel";
            keteranganLabel.Size = new System.Drawing.Size(65, 13);
            keteranganLabel.TabIndex = 3;
            keteranganLabel.Text = "Keterangan:";
            // 
            // kodeHewanLabel
            // 
            kodeHewanLabel.AutoSize = true;
            kodeHewanLabel.Location = new System.Drawing.Point(44, 103);
            kodeHewanLabel.Name = "kodeHewanLabel";
            kodeHewanLabel.Size = new System.Drawing.Size(72, 13);
            kodeHewanLabel.TabIndex = 5;
            kodeHewanLabel.Text = "Kode Hewan:";
            // 
            // kodeKandangLabel
            // 
            kodeKandangLabel.AutoSize = true;
            kodeKandangLabel.Location = new System.Drawing.Point(44, 130);
            kodeKandangLabel.Name = "kodeKandangLabel";
            kodeKandangLabel.Size = new System.Drawing.Size(81, 13);
            kodeKandangLabel.TabIndex = 7;
            kodeKandangLabel.Text = "Kode Kandang:";
            // 
            // noRefLabel
            // 
            noRefLabel.AutoSize = true;
            noRefLabel.Location = new System.Drawing.Point(44, 45);
            noRefLabel.Name = "noRefLabel";
            noRefLabel.Size = new System.Drawing.Size(44, 13);
            noRefLabel.TabIndex = 13;
            noRefLabel.Text = "No Ref:";
            // 
            // tglTransaksiLabel
            // 
            tglTransaksiLabel.AutoSize = true;
            tglTransaksiLabel.Location = new System.Drawing.Point(44, 73);
            tglTransaksiLabel.Name = "tglTransaksiLabel";
            tglTransaksiLabel.Size = new System.Drawing.Size(74, 13);
            tglTransaksiLabel.TabIndex = 17;
            tglTransaksiLabel.Text = "Tgl Transaksi:";
            // 
            // keluarLabel
            // 
            this.keluarLabel.AutoSize = true;
            this.keluarLabel.Location = new System.Drawing.Point(44, 183);
            this.keluarLabel.Name = "keluarLabel";
            this.keluarLabel.Size = new System.Drawing.Size(40, 13);
            this.keluarLabel.TabIndex = 1;
            this.keluarLabel.Text = "Keluar:";
            // 
            // masukLabel
            // 
            this.masukLabel.AutoSize = true;
            this.masukLabel.Location = new System.Drawing.Point(44, 157);
            this.masukLabel.Name = "masukLabel";
            this.masukLabel.Size = new System.Drawing.Size(42, 13);
            this.masukLabel.TabIndex = 9;
            this.masukLabel.Text = "Masuk:";
            // 
            // mutasiStokItemBindingNavigator
            // 
            this.mutasiStokItemBindingNavigator.AddNewItem = null;
            this.mutasiStokItemBindingNavigator.BindingSource = this.mutasiStokItemBindingSource;
            this.mutasiStokItemBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mutasiStokItemBindingNavigator.DeleteItem = null;
            this.mutasiStokItemBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.mutasiStokItemBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mutasiStokItemBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mutasiStokItemBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mutasiStokItemBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mutasiStokItemBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mutasiStokItemBindingNavigator.Name = "mutasiStokItemBindingNavigator";
            this.mutasiStokItemBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mutasiStokItemBindingNavigator.Size = new System.Drawing.Size(627, 25);
            this.mutasiStokItemBindingNavigator.TabIndex = 0;
            this.mutasiStokItemBindingNavigator.Text = "bindingNavigator1";
            // 
            // mutasiStokItemBindingSource
            // 
            this.mutasiStokItemBindingSource.DataSource = typeof(PenjualanHewanTernak.Model.MutasiStokItem);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // keluarTextBox
            // 
            this.keluarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mutasiStokItemBindingSource, "Keluar", true));
            this.keluarTextBox.Location = new System.Drawing.Point(140, 180);
            this.keluarTextBox.Name = "keluarTextBox";
            this.keluarTextBox.Size = new System.Drawing.Size(200, 20);
            this.keluarTextBox.TabIndex = 2;
            this.keluarTextBox.TextChanged += new System.EventHandler(this.keluarTextBox_TextChanged);
            // 
            // keteranganTextBox
            // 
            this.keteranganTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mutasiStokItemBindingSource, "Keterangan", true));
            this.keteranganTextBox.Location = new System.Drawing.Point(140, 206);
            this.keteranganTextBox.Name = "keteranganTextBox";
            this.keteranganTextBox.Size = new System.Drawing.Size(200, 20);
            this.keteranganTextBox.TabIndex = 4;
            // 
            // kodeHewanComboBox
            // 
            this.kodeHewanComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mutasiStokItemBindingSource, "KodeHewan", true));
            this.kodeHewanComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mutasiStokItemBindingSource, "KodeHewan", true));
            this.kodeHewanComboBox.DataSource = this.cattleItemBindingSource;
            this.kodeHewanComboBox.DisplayMember = "NamaHewan";
            this.kodeHewanComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kodeHewanComboBox.FormattingEnabled = true;
            this.kodeHewanComboBox.Location = new System.Drawing.Point(140, 100);
            this.kodeHewanComboBox.Name = "kodeHewanComboBox";
            this.kodeHewanComboBox.Size = new System.Drawing.Size(200, 21);
            this.kodeHewanComboBox.TabIndex = 6;
            this.kodeHewanComboBox.ValueMember = "KodeHewan";
            // 
            // cattleItemBindingSource
            // 
            this.cattleItemBindingSource.DataSource = typeof(PenjualanHewanTernak.Model.CattleItem);
            // 
            // kodeKandangComboBox
            // 
            this.kodeKandangComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mutasiStokItemBindingSource, "KodeKandang", true));
            this.kodeKandangComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mutasiStokItemBindingSource, "KodeKandang", true));
            this.kodeKandangComboBox.DataSource = this.kandangItemBindingSource;
            this.kodeKandangComboBox.DisplayMember = "Keterangan";
            this.kodeKandangComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kodeKandangComboBox.FormattingEnabled = true;
            this.kodeKandangComboBox.Location = new System.Drawing.Point(140, 127);
            this.kodeKandangComboBox.Name = "kodeKandangComboBox";
            this.kodeKandangComboBox.Size = new System.Drawing.Size(200, 21);
            this.kodeKandangComboBox.TabIndex = 8;
            this.kodeKandangComboBox.ValueMember = "KodeKandang";
            // 
            // kandangItemBindingSource
            // 
            this.kandangItemBindingSource.DataSource = typeof(PenjualanHewanTernak.Model.KandangItem);
            // 
            // masukTextBox
            // 
            this.masukTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mutasiStokItemBindingSource, "Masuk", true));
            this.masukTextBox.Location = new System.Drawing.Point(140, 154);
            this.masukTextBox.Name = "masukTextBox";
            this.masukTextBox.Size = new System.Drawing.Size(200, 20);
            this.masukTextBox.TabIndex = 10;
            // 
            // noRefComboBox
            // 
            this.noRefComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mutasiStokItemBindingSource, "NoRef", true));
            this.noRefComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mutasiStokItemBindingSource, "NoRef", true));
            this.noRefComboBox.DataSource = this.posMutasiStokItemBindingSource;
            this.noRefComboBox.DisplayMember = "Keterangan";
            this.noRefComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.noRefComboBox.FormattingEnabled = true;
            this.noRefComboBox.Location = new System.Drawing.Point(140, 42);
            this.noRefComboBox.Name = "noRefComboBox";
            this.noRefComboBox.Size = new System.Drawing.Size(200, 21);
            this.noRefComboBox.TabIndex = 14;
            this.noRefComboBox.ValueMember = "NoRef";
            // 
            // posMutasiStokItemBindingSource
            // 
            this.posMutasiStokItemBindingSource.DataSource = typeof(PenjualanHewanTernak.Model.PosMutasiStokItem);
            // 
            // tglTransaksiDateTimePicker
            // 
            this.tglTransaksiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mutasiStokItemBindingSource, "TglTransaksi", true));
            this.tglTransaksiDateTimePicker.Location = new System.Drawing.Point(140, 69);
            this.tglTransaksiDateTimePicker.Name = "tglTransaksiDateTimePicker";
            this.tglTransaksiDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.tglTransaksiDateTimePicker.TabIndex = 18;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.posMutasiStokItemBindingSource, "IsPemasukan", true));
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(346, 44);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Penambahan Stok";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CancelBtn,
            this.DeleteBtn,
            this.SaveBtn,
            this.AddBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 274);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(627, 38);
            this.toolStrip1.TabIndex = 20;
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
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.DeleteBtn.Image = global::PenjualanHewanTernak.Properties.Resources.Delete_50px;
            this.DeleteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(57, 35);
            this.DeleteBtn.Text = "Delete(s)";
            this.DeleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            // AddBtn
            // 
            this.AddBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.AddBtn.Image = global::PenjualanHewanTernak.Properties.Resources.Plus_96px;
            this.AddBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(55, 35);
            this.AddBtn.Text = "Tambah";
            this.AddBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // FrmMutasiStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 312);
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
            this.Controls.Add(this.mutasiStokItemBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMutasiStok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMutasiStok";
            this.Load += new System.EventHandler(this.FrmMutasiStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mutasiStokItemBindingNavigator)).EndInit();
            this.mutasiStokItemBindingNavigator.ResumeLayout(false);
            this.mutasiStokItemBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.BindingNavigator mutasiStokItemBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
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
        private System.Windows.Forms.ToolStripButton DeleteBtn;
        private System.Windows.Forms.ToolStripButton SaveBtn;
        private System.Windows.Forms.ToolStripButton AddBtn;

        //User Added
        private Status isNewRow;
        private System.Windows.Forms.Label keluarLabel;
        private System.Windows.Forms.Label masukLabel;

        //Declaration if new event - Important
        private event FormStatusChangedEventHandler statusChanged;
        #endregion

    }
}