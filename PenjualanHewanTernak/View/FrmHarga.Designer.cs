namespace PenjualanHewanTernak.View
{
    partial class FrmHarga
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
            System.Windows.Forms.Label beforePriceLabel;
            System.Windows.Forms.Label currentPriceLabel;
            System.Windows.Forms.Label statLabel;
            System.Windows.Forms.Label kodeGradeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHarga));
            this.hargaItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hargaItemBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.beforePriceTextBox = new System.Windows.Forms.TextBox();
            this.beforePriceDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.currentPriceTextBox = new System.Windows.Forms.TextBox();
            this.currentPriceDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.gradeItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cattleItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statCheckBox = new System.Windows.Forms.CheckBox();
            this.hargaItemListBox = new System.Windows.Forms.ListBox();
            this.gantiHargaBtn = new System.Windows.Forms.Button();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.CancelBtn = new System.Windows.Forms.ToolStripButton();
            this.DeleteBtn = new System.Windows.Forms.ToolStripButton();
            this.SaveBtn = new System.Windows.Forms.ToolStripButton();
            this.AddBtn = new System.Windows.Forms.ToolStripButton();
            this.kodeGradeComboBox = new System.Windows.Forms.ComboBox();
            beforePriceLabel = new System.Windows.Forms.Label();
            currentPriceLabel = new System.Windows.Forms.Label();
            statLabel = new System.Windows.Forms.Label();
            kodeGradeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hargaItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hargaItemBindingNavigator)).BeginInit();
            this.hargaItemBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cattleItemBindingSource)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // beforePriceLabel
            // 
            beforePriceLabel.AutoSize = true;
            beforePriceLabel.Location = new System.Drawing.Point(342, 106);
            beforePriceLabel.Name = "beforePriceLabel";
            beforePriceLabel.Size = new System.Drawing.Size(68, 13);
            beforePriceLabel.TabIndex = 1;
            beforePriceLabel.Text = "Before Price:";
            // 
            // currentPriceLabel
            // 
            currentPriceLabel.AutoSize = true;
            currentPriceLabel.Location = new System.Drawing.Point(342, 132);
            currentPriceLabel.Name = "currentPriceLabel";
            currentPriceLabel.Size = new System.Drawing.Size(71, 13);
            currentPriceLabel.TabIndex = 5;
            currentPriceLabel.Text = "Current Price:";
            // 
            // statLabel
            // 
            statLabel.AutoSize = true;
            statLabel.Location = new System.Drawing.Point(342, 160);
            statLabel.Name = "statLabel";
            statLabel.Size = new System.Drawing.Size(29, 13);
            statLabel.TabIndex = 13;
            statLabel.Text = "Stat:";
            // 
            // kodeGradeLabel
            // 
            kodeGradeLabel.AutoSize = true;
            kodeGradeLabel.Location = new System.Drawing.Point(372, 47);
            kodeGradeLabel.Name = "kodeGradeLabel";
            kodeGradeLabel.Size = new System.Drawing.Size(67, 13);
            kodeGradeLabel.TabIndex = 17;
            kodeGradeLabel.Text = "Kode Grade:";
            // 
            // hargaItemBindingSource
            // 
            this.hargaItemBindingSource.DataSource = typeof(PenjualanHewanTernak.Model.HargaItem);
            // 
            // hargaItemBindingNavigator
            // 
            this.hargaItemBindingNavigator.AddNewItem = null;
            this.hargaItemBindingNavigator.BindingSource = this.hargaItemBindingSource;
            this.hargaItemBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hargaItemBindingNavigator.DeleteItem = null;
            this.hargaItemBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1});
            this.hargaItemBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hargaItemBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hargaItemBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hargaItemBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hargaItemBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hargaItemBindingNavigator.Name = "hargaItemBindingNavigator";
            this.hargaItemBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hargaItemBindingNavigator.Size = new System.Drawing.Size(684, 28);
            this.hargaItemBindingNavigator.TabIndex = 0;
            this.hargaItemBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 25);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 28);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(79, 25);
            this.toolStripLabel1.Text = "HARGA";
            // 
            // beforePriceTextBox
            // 
            this.beforePriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hargaItemBindingSource, "BeforePrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.beforePriceTextBox.Location = new System.Drawing.Point(445, 103);
            this.beforePriceTextBox.Name = "beforePriceTextBox";
            this.beforePriceTextBox.Size = new System.Drawing.Size(81, 20);
            this.beforePriceTextBox.TabIndex = 2;
            // 
            // beforePriceDateDateTimePicker
            // 
            this.beforePriceDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hargaItemBindingSource, "BeforePriceDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.beforePriceDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.beforePriceDateDateTimePicker.Location = new System.Drawing.Point(528, 103);
            this.beforePriceDateDateTimePicker.Name = "beforePriceDateDateTimePicker";
            this.beforePriceDateDateTimePicker.Size = new System.Drawing.Size(117, 20);
            this.beforePriceDateDateTimePicker.TabIndex = 4;
            // 
            // currentPriceTextBox
            // 
            this.currentPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hargaItemBindingSource, "CurrentPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.currentPriceTextBox.Location = new System.Drawing.Point(445, 129);
            this.currentPriceTextBox.Name = "currentPriceTextBox";
            this.currentPriceTextBox.Size = new System.Drawing.Size(81, 20);
            this.currentPriceTextBox.TabIndex = 6;
            // 
            // currentPriceDateDateTimePicker
            // 
            this.currentPriceDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hargaItemBindingSource, "CurrentPriceDate", true));
            this.currentPriceDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.currentPriceDateDateTimePicker.Location = new System.Drawing.Point(528, 129);
            this.currentPriceDateDateTimePicker.Name = "currentPriceDateDateTimePicker";
            this.currentPriceDateDateTimePicker.Size = new System.Drawing.Size(117, 20);
            this.currentPriceDateDateTimePicker.TabIndex = 8;
            // 
            // gradeItemBindingSource
            // 
            this.gradeItemBindingSource.DataSource = typeof(PenjualanHewanTernak.Model.GradeItem);
            // 
            // cattleItemBindingSource
            // 
            this.cattleItemBindingSource.DataSource = typeof(PenjualanHewanTernak.Model.CattleItem);
            // 
            // statCheckBox
            // 
            this.statCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.hargaItemBindingSource, "Stat", true));
            this.statCheckBox.Location = new System.Drawing.Point(445, 155);
            this.statCheckBox.Name = "statCheckBox";
            this.statCheckBox.Size = new System.Drawing.Size(200, 24);
            this.statCheckBox.TabIndex = 14;
            this.statCheckBox.Text = "checkBox1";
            this.statCheckBox.UseVisualStyleBackColor = true;
            // 
            // hargaItemListBox
            // 
            this.hargaItemListBox.DataSource = this.hargaItemBindingSource;
            this.hargaItemListBox.DisplayMember = "KodeGrade";
            this.hargaItemListBox.FormattingEnabled = true;
            this.hargaItemListBox.Location = new System.Drawing.Point(12, 31);
            this.hargaItemListBox.Name = "hargaItemListBox";
            this.hargaItemListBox.Size = new System.Drawing.Size(324, 251);
            this.hargaItemListBox.TabIndex = 15;
            this.hargaItemListBox.ValueMember = "BeforePrice";
            // 
            // gantiHargaBtn
            // 
            this.gantiHargaBtn.Location = new System.Drawing.Point(495, 185);
            this.gantiHargaBtn.Name = "gantiHargaBtn";
            this.gantiHargaBtn.Size = new System.Drawing.Size(150, 23);
            this.gantiHargaBtn.TabIndex = 16;
            this.gantiHargaBtn.Text = "Ganti Harga";
            this.gantiHargaBtn.UseVisualStyleBackColor = true;
            this.gantiHargaBtn.Click += new System.EventHandler(this.gantiHargaBtn_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CancelBtn,
            this.DeleteBtn,
            this.SaveBtn,
            this.AddBtn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 302);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(684, 38);
            this.toolStrip2.TabIndex = 17;
            this.toolStrip2.TabStop = true;
            this.toolStrip2.Text = "toolStrip2";
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
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
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
            // kodeGradeComboBox
            // 
            this.kodeGradeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hargaItemBindingSource, "KodeGrade", true));
            this.kodeGradeComboBox.DataSource = this.gradeItemBindingSource;
            this.kodeGradeComboBox.DisplayMember = "Keterangan";
            this.kodeGradeComboBox.FormattingEnabled = true;
            this.kodeGradeComboBox.Location = new System.Drawing.Point(445, 44);
            this.kodeGradeComboBox.Name = "kodeGradeComboBox";
            this.kodeGradeComboBox.Size = new System.Drawing.Size(121, 21);
            this.kodeGradeComboBox.TabIndex = 18;
            this.kodeGradeComboBox.ValueMember = "KodeGrade";
            // 
            // FrmHarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 340);
            this.Controls.Add(kodeGradeLabel);
            this.Controls.Add(this.kodeGradeComboBox);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.gantiHargaBtn);
            this.Controls.Add(this.hargaItemListBox);
            this.Controls.Add(beforePriceLabel);
            this.Controls.Add(this.beforePriceTextBox);
            this.Controls.Add(this.beforePriceDateDateTimePicker);
            this.Controls.Add(currentPriceLabel);
            this.Controls.Add(this.currentPriceTextBox);
            this.Controls.Add(this.currentPriceDateDateTimePicker);
            this.Controls.Add(statLabel);
            this.Controls.Add(this.statCheckBox);
            this.Controls.Add(this.hargaItemBindingNavigator);
            this.Name = "FrmHarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHarga";
            this.Load += new System.EventHandler(this.FrmHarga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hargaItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hargaItemBindingNavigator)).EndInit();
            this.hargaItemBindingNavigator.ResumeLayout(false);
            this.hargaItemBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cattleItemBindingSource)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource hargaItemBindingSource;
        private System.Windows.Forms.BindingNavigator hargaItemBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox beforePriceTextBox;
        private System.Windows.Forms.DateTimePicker beforePriceDateDateTimePicker;
        private System.Windows.Forms.TextBox currentPriceTextBox;
        private System.Windows.Forms.DateTimePicker currentPriceDateDateTimePicker;
        private System.Windows.Forms.CheckBox statCheckBox;
        private System.Windows.Forms.ListBox hargaItemListBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button gantiHargaBtn;
        private System.Windows.Forms.BindingSource gradeItemBindingSource;
        private System.Windows.Forms.BindingSource cattleItemBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton CancelBtn;
        private System.Windows.Forms.ToolStripButton DeleteBtn;
        private System.Windows.Forms.ToolStripButton SaveBtn;
        private System.Windows.Forms.ToolStripButton AddBtn;
        private System.Windows.Forms.ComboBox kodeGradeComboBox;
    }
}