namespace GUI
{
    partial class ThongKeSinhVienTheoLop
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboLop = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QLHSSV_TTLLDataSet = new GUI.QLHSSV_TTLLDataSet();
            this.SV_Select_MaLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SV_Select_MaLopTableAdapter = new GUI.QLHSSV_TTLLDataSetTableAdapters.SV_Select_MaLopTableAdapter();
            this.dataDT = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLHSSV_TTLLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SV_Select_MaLopBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(1114, 62);
            this.groupBox1.TabIndex = 1;
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
            // QLHSSV_TTLLDataSet
            // 
            this.QLHSSV_TTLLDataSet.DataSetName = "QLHSSV_TTLLDataSet";
            this.QLHSSV_TTLLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SV_Select_MaLopBindingSource
            // 
            this.SV_Select_MaLopBindingSource.DataMember = "SV_Select_MaLop";
            this.SV_Select_MaLopBindingSource.DataSource = this.QLHSSV_TTLLDataSet;
            // 
            // SV_Select_MaLopTableAdapter
            // 
            this.SV_Select_MaLopTableAdapter.ClearBeforeFill = true;
            // 
            // dataDT
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SV_Select_MaLopBindingSource;
            this.dataDT.LocalReport.DataSources.Add(reportDataSource1);
            this.dataDT.LocalReport.ReportEmbeddedResource = "GUI.ThongKeSVTheoLop.rdlc";
            this.dataDT.Location = new System.Drawing.Point(2, 90);
            this.dataDT.Name = "dataDT";
            this.dataDT.Size = new System.Drawing.Size(1124, 463);
            this.dataDT.TabIndex = 2;
            // 
            // ThongKeSinhVienTheoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.Untitled_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1131, 556);
            this.Controls.Add(this.dataDT);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThongKeSinhVienTheoLop";
            this.Text = "ThongKeSinhVienTheoLop";
            this.Load += new System.EventHandler(this.ThongKeSinhVienTheoLop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLHSSV_TTLLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SV_Select_MaLopBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboLop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource SV_Select_MaLopBindingSource;
        private QLHSSV_TTLLDataSet QLHSSV_TTLLDataSet;
        private QLHSSV_TTLLDataSetTableAdapters.SV_Select_MaLopTableAdapter SV_Select_MaLopTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer dataDT;
    }
}