namespace GUI
{
    partial class ThongKe_SV_DoiTuong
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboDT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLHSSV_TTLLDataSet4 = new GUI.QLHSSV_TTLLDataSet4();
            this.SV_Select_SVDoiTuongTheoLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SV_Select_SVDoiTuongTheoLopTableAdapter = new GUI.QLHSSV_TTLLDataSet4TableAdapters.SV_Select_SVDoiTuongTheoLopTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLHSSV_TTLLDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SV_Select_SVDoiTuongTheoLopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboDT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboLop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1360, 62);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // comboDT
            // 
            this.comboDT.FormattingEnabled = true;
            this.comboDT.Location = new System.Drawing.Point(746, 21);
            this.comboDT.Name = "comboDT";
            this.comboDT.Size = new System.Drawing.Size(288, 28);
            this.comboDT.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(515, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chọn mã đối tượng";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(1062, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Xem thông tin trước khi in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboLop
            // 
            this.comboLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboLop.FormattingEnabled = true;
            this.comboLop.Location = new System.Drawing.Point(181, 25);
            this.comboLop.Name = "comboLop";
            this.comboLop.Size = new System.Drawing.Size(314, 28);
            this.comboLop.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn lớp cần in:";
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.SV_Select_SVDoiTuongTheoLopBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ThongKeSinhVienDoiTuongTheoLop.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 98);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1382, 469);
            this.reportViewer1.TabIndex = 6;
            // 
            // QLHSSV_TTLLDataSet4
            // 
            this.QLHSSV_TTLLDataSet4.DataSetName = "QLHSSV_TTLLDataSet4";
            this.QLHSSV_TTLLDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SV_Select_SVDoiTuongTheoLopBindingSource
            // 
            this.SV_Select_SVDoiTuongTheoLopBindingSource.DataMember = "SV_Select_SVDoiTuongTheoLop";
            this.SV_Select_SVDoiTuongTheoLopBindingSource.DataSource = this.QLHSSV_TTLLDataSet4;
            // 
            // SV_Select_SVDoiTuongTheoLopTableAdapter
            // 
            this.SV_Select_SVDoiTuongTheoLopTableAdapter.ClearBeforeFill = true;
            // 
            // ThongKe_SV_DoiTuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.Untitled_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1384, 569);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThongKe_SV_DoiTuong";
            this.Text = "ThongKe_SV_DoiTuong";
            this.Load += new System.EventHandler(this.ThongKe_SV_DoiTuong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLHSSV_TTLLDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SV_Select_SVDoiTuongTheoLopBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboLop;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SV_Select_SVDoiTuongTheoLopBindingSource;
        private QLHSSV_TTLLDataSet4 QLHSSV_TTLLDataSet4;
        private QLHSSV_TTLLDataSet4TableAdapters.SV_Select_SVDoiTuongTheoLopTableAdapter SV_Select_SVDoiTuongTheoLopTableAdapter;
    }
}