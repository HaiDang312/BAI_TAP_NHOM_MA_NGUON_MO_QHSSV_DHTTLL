namespace GUI
{
    partial class ThongKe_DS_By_Ky_Luat
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
            this.comboKT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLHSSV_TTLLDataSet2 = new GUI.QLHSSV_TTLLDataSet2();
            this.SV_Select_KyLuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SV_Select_KyLuatTableAdapter = new GUI.QLHSSV_TTLLDataSet2TableAdapters.SV_Select_KyLuatTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLHSSV_TTLLDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SV_Select_KyLuatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboKT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboLop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1392, 62);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // comboKT
            // 
            this.comboKT.FormattingEnabled = true;
            this.comboKT.Location = new System.Drawing.Point(746, 21);
            this.comboKT.Name = "comboKT";
            this.comboKT.Size = new System.Drawing.Size(288, 28);
            this.comboKT.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(515, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chọn mã khen thưởng";
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
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SV_Select_KyLuatBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ThongKeSVKyLuat.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 94);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1407, 430);
            this.reportViewer1.TabIndex = 5;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // QLHSSV_TTLLDataSet2
            // 
            this.QLHSSV_TTLLDataSet2.DataSetName = "QLHSSV_TTLLDataSet2";
            this.QLHSSV_TTLLDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SV_Select_KyLuatBindingSource
            // 
            this.SV_Select_KyLuatBindingSource.DataMember = "SV_Select_KyLuat";
            this.SV_Select_KyLuatBindingSource.DataSource = this.QLHSSV_TTLLDataSet2;
            // 
            // SV_Select_KyLuatTableAdapter
            // 
            this.SV_Select_KyLuatTableAdapter.ClearBeforeFill = true;
            // 
            // ThongKe_DS_By_Ky_Luat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.Untitled_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1416, 528);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThongKe_DS_By_Ky_Luat";
            this.Text = "ThongKe_DS_By_Ky_Luat";
            this.Load += new System.EventHandler(this.ThongKe_DS_By_Ky_Luat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLHSSV_TTLLDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SV_Select_KyLuatBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboKT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboLop;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SV_Select_KyLuatBindingSource;
        private QLHSSV_TTLLDataSet2 QLHSSV_TTLLDataSet2;
        private QLHSSV_TTLLDataSet2TableAdapters.SV_Select_KyLuatTableAdapter SV_Select_KyLuatTableAdapter;
    }
}