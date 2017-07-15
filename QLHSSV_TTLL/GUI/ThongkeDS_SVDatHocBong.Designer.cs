namespace GUI
{
    partial class ThongkeDS_SVDatHocBong
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
            this.dataDT = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SV_Select_MaLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLHSSV_TTLLDataSet = new GUI.QLHSSV_TTLLDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.comboLop = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SV_Select_MaLopTableAdapter = new GUI.QLHSSV_TTLLDataSetTableAdapters.SV_Select_MaLopTableAdapter();
            this.QLHSSV_TTLLDataSet5 = new GUI.QLHSSV_TTLLDataSet5();
            this.SV_Select_HocBongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SV_Select_HocBongTableAdapter = new GUI.QLHSSV_TTLLDataSet5TableAdapters.SV_Select_HocBongTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SV_Select_MaLopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLHSSV_TTLLDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLHSSV_TTLLDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SV_Select_HocBongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDT
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.SV_Select_HocBongBindingSource;
            this.dataDT.LocalReport.DataSources.Add(reportDataSource2);
            this.dataDT.LocalReport.ReportEmbeddedResource = "GUI.ThongKeDanhSachSVDatHocBong.rdlc";
            this.dataDT.Location = new System.Drawing.Point(2, 90);
            this.dataDT.Name = "dataDT";
            this.dataDT.Size = new System.Drawing.Size(1233, 634);
            this.dataDT.TabIndex = 4;
            // 
            // SV_Select_MaLopBindingSource
            // 
            this.SV_Select_MaLopBindingSource.DataMember = "SV_Select_MaLop";
            this.SV_Select_MaLopBindingSource.DataSource = this.QLHSSV_TTLLDataSet;
            // 
            // QLHSSV_TTLLDataSet
            // 
            this.QLHSSV_TTLLDataSet.DataSetName = "QLHSSV_TTLLDataSet";
            this.QLHSSV_TTLLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboLop
            // 
            this.comboLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboLop.FormattingEnabled = true;
            this.comboLop.Location = new System.Drawing.Point(179, 19);
            this.comboLop.Name = "comboLop";
            this.comboLop.Size = new System.Drawing.Size(337, 28);
            this.comboLop.TabIndex = 1;
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
            this.groupBox1.Size = new System.Drawing.Size(1223, 62);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
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
            // SV_Select_MaLopTableAdapter
            // 
            this.SV_Select_MaLopTableAdapter.ClearBeforeFill = true;
            // 
            // QLHSSV_TTLLDataSet5
            // 
            this.QLHSSV_TTLLDataSet5.DataSetName = "QLHSSV_TTLLDataSet5";
            this.QLHSSV_TTLLDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SV_Select_HocBongBindingSource
            // 
            this.SV_Select_HocBongBindingSource.DataMember = "SV_Select_HocBong";
            this.SV_Select_HocBongBindingSource.DataSource = this.QLHSSV_TTLLDataSet5;
            // 
            // SV_Select_HocBongTableAdapter
            // 
            this.SV_Select_HocBongTableAdapter.ClearBeforeFill = true;
            // 
            // ThongkeDS_SVDatHocBong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 726);
            this.Controls.Add(this.dataDT);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThongkeDS_SVDatHocBong";
            this.Text = "ThongkeDS_SVDatHocBong";
            this.Load += new System.EventHandler(this.ThongkeDS_SVDatHocBong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SV_Select_MaLopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLHSSV_TTLLDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLHSSV_TTLLDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SV_Select_HocBongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer dataDT;
        private System.Windows.Forms.BindingSource SV_Select_HocBongBindingSource;
        private QLHSSV_TTLLDataSet5 QLHSSV_TTLLDataSet5;
        private System.Windows.Forms.BindingSource SV_Select_MaLopBindingSource;
        private QLHSSV_TTLLDataSet QLHSSV_TTLLDataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboLop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private QLHSSV_TTLLDataSetTableAdapters.SV_Select_MaLopTableAdapter SV_Select_MaLopTableAdapter;
        private QLHSSV_TTLLDataSet5TableAdapters.SV_Select_HocBongTableAdapter SV_Select_HocBongTableAdapter;
    }
}