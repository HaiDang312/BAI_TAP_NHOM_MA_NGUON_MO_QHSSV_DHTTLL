namespace GUI
{
    partial class ThongKeDiemSVTheoLop
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
            this.SV_Select_DiemMonHocTheoLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLHSSV_TTLLDataSet1 = new GUI.QLHSSV_TTLLDataSet1();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combMon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.comboLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SV_Select_DiemMonHocTheoLopTableAdapter = new GUI.QLHSSV_TTLLDataSet1TableAdapters.SV_Select_DiemMonHocTheoLopTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SV_Select_DiemMonHocTheoLopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLHSSV_TTLLDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SV_Select_DiemMonHocTheoLopBindingSource
            // 
            this.SV_Select_DiemMonHocTheoLopBindingSource.DataMember = "SV_Select_DiemMonHocTheoLop";
            this.SV_Select_DiemMonHocTheoLopBindingSource.DataSource = this.QLHSSV_TTLLDataSet1;
            // 
            // QLHSSV_TTLLDataSet1
            // 
            this.QLHSSV_TTLLDataSet1.DataSetName = "QLHSSV_TTLLDataSet1";
            this.QLHSSV_TTLLDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.combMon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnXem);
            this.groupBox1.Controls.Add(this.comboLop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1405, 62);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // combMon
            // 
            this.combMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.combMon.FormattingEnabled = true;
            this.combMon.Location = new System.Drawing.Point(679, 23);
            this.combMon.Name = "combMon";
            this.combMon.Size = new System.Drawing.Size(272, 28);
            this.combMon.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(518, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn môn hoc:";
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXem.Location = new System.Drawing.Point(1004, 18);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(296, 38);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem thông tin trước khi in";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // comboLop
            // 
            this.comboLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboLop.FormattingEnabled = true;
            this.comboLop.Location = new System.Drawing.Point(230, 24);
            this.comboLop.Name = "comboLop";
            this.comboLop.Size = new System.Drawing.Size(272, 28);
            this.comboLop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(70, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn lớp cần in:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SV_Select_DiemMonHocTheoLopBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ThongKeDiemSinhVienTheoLop.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 90);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1425, 656);
            this.reportViewer1.TabIndex = 3;
            // 
            // SV_Select_DiemMonHocTheoLopTableAdapter
            // 
            this.SV_Select_DiemMonHocTheoLopTableAdapter.ClearBeforeFill = true;
            // 
            // ThongKeDiemSVTheoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.Untitled_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1429, 746);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThongKeDiemSVTheoLop";
            this.Text = "ThongKeDiemSVTheoLop";
            this.Load += new System.EventHandler(this.ThongKeDiemSVTheoLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SV_Select_DiemMonHocTheoLopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLHSSV_TTLLDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox comboLop;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SV_Select_DiemMonHocTheoLopBindingSource;
        private QLHSSV_TTLLDataSet1 QLHSSV_TTLLDataSet1;
        private QLHSSV_TTLLDataSet1TableAdapters.SV_Select_DiemMonHocTheoLopTableAdapter SV_Select_DiemMonHocTheoLopTableAdapter;
    }
}