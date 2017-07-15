namespace GUI
{
    partial class InDanhSachSinhVienTheoLop
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataDT = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLHSSV_TTLLDataSet4 = new GUI.QLHSSV_TTLLDataSet4();
            this.SV_Select_MaLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SV_Select_MaLopTableAdapter = new GUI.QLHSSV_TTLLDataSet4TableAdapters.SV_Select_MaLopTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLHSSV_TTLLDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SV_Select_MaLopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboLop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1114, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(592, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Xem thông tin trước khi in";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboLop
            // 
            this.comboLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboLop.FormattingEnabled = true;
            this.comboLop.Location = new System.Drawing.Point(179, 19);
            this.comboLop.Name = "comboLop";
            this.comboLop.Size = new System.Drawing.Size(337, 28);
            this.comboLop.TabIndex = 1;
            this.comboLop.SelectedIndexChanged += new System.EventHandler(this.comboLop_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn lớp cần in:";
            // 
            // dataDT
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SV_Select_MaLopBindingSource;
            this.dataDT.LocalReport.DataSources.Add(reportDataSource1);
            this.dataDT.LocalReport.ReportEmbeddedResource = "QLHSSV_DHTTLL.inLop.rdlc";
            this.dataDT.Location = new System.Drawing.Point(0, 95);
            this.dataDT.Name = "dataDT";
            this.dataDT.Size = new System.Drawing.Size(1138, 676);
            this.dataDT.TabIndex = 1;
            this.dataDT.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // QLHSSV_TTLLDataSet4
            // 
            this.QLHSSV_TTLLDataSet4.DataSetName = "QLHSSV_TTLLDataSet4";
            this.QLHSSV_TTLLDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SV_Select_MaLopBindingSource
            // 
            this.SV_Select_MaLopBindingSource.DataMember = "SV_Select_MaLop";
            this.SV_Select_MaLopBindingSource.DataSource = this.QLHSSV_TTLLDataSet4;
            // 
            // SV_Select_MaLopTableAdapter
            // 
            this.SV_Select_MaLopTableAdapter.ClearBeforeFill = true;
            // 
            // InDanhSachSinhVienTheoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.Untitled_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1138, 771);
            this.Controls.Add(this.dataDT);
            this.Controls.Add(this.groupBox1);
            this.Name = "InDanhSachSinhVienTheoLop";
            this.Text = "InDanhSachSinhVienTheoLop";
            this.Load += new System.EventHandler(this.InDanhSachSinhVienTheoLop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLHSSV_TTLLDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SV_Select_MaLopBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboLop;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer dataDT;
        private System.Windows.Forms.BindingSource SV_Select_MaLopBindingSource;
        private QLHSSV_TTLLDataSet4 QLHSSV_TTLLDataSet4;
        private QLHSSV_TTLLDataSet4TableAdapters.SV_Select_MaLopTableAdapter SV_Select_MaLopTableAdapter;
    }
}