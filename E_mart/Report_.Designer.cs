
namespace E_mart
{
    partial class Report_
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.EmployerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new E_mart.DataSet1();
            this.ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet2 = new E_mart.DataSet2();
            this.ProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet3 = new E_mart.DataSet3();
            this.InvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet4 = new E_mart.DataSet4();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EmployerTableAdapter = new E_mart.DataSet1TableAdapters.EmployerTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClientTableAdapter = new E_mart.DataSet2TableAdapters.ClientTableAdapter();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProductTableAdapter = new E_mart.DataSet3TableAdapters.ProductTableAdapter();
            this.InvoiceTableAdapter = new E_mart.DataSet4TableAdapters.InvoiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EmployerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployerBindingSource
            // 
            this.EmployerBindingSource.DataMember = "Employer";
            this.EmployerBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ClientBindingSource
            // 
            this.ClientBindingSource.DataMember = "Client";
            this.ClientBindingSource.DataSource = this.DataSet2;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProductBindingSource
            // 
            this.ProductBindingSource.DataMember = "Product";
            this.ProductBindingSource.DataSource = this.DataSet3;
            // 
            // DataSet3
            // 
            this.DataSet3.DataSetName = "DataSet3";
            this.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InvoiceBindingSource
            // 
            this.InvoiceBindingSource.DataMember = "Invoice";
            this.InvoiceBindingSource.DataSource = this.DataSet4;
            // 
            // DataSet4
            // 
            this.DataSet4.DataSetName = "DataSet4";
            this.DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EmployerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "E_mart.Report_wizard1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(9, 10);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(420, 214);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // EmployerTableAdapter
            // 
            this.EmployerTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.ClientBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "E_mart.Report_wizard2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(434, 10);
            this.reportViewer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(442, 214);
            this.reportViewer2.TabIndex = 1;
            // 
            // ClientTableAdapter
            // 
            this.ClientTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer3
            // 
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.ProductBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "E_mart.Report_wizard3.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(9, 228);
            this.reportViewer3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(420, 212);
            this.reportViewer3.TabIndex = 2;
            // 
            // reportViewer4
            // 
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.InvoiceBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "E_mart.Report_wizard4.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(434, 228);
            this.reportViewer4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(442, 212);
            this.reportViewer4.TabIndex = 3;
            // 
            // ProductTableAdapter
            // 
            this.ProductTableAdapter.ClearBeforeFill = true;
            // 
            // InvoiceTableAdapter
            // 
            this.InvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // Report_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 502);
            this.Controls.Add(this.reportViewer4);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Report_";
            this.Text = "Report_";
            this.Load += new System.EventHandler(this.Report__Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EmployerBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.EmployerTableAdapter EmployerTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource ClientBindingSource;
        private DataSet2 DataSet2;
        private DataSet2TableAdapters.ClientTableAdapter ClientTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.BindingSource ProductBindingSource;
        private DataSet3 DataSet3;
        private DataSet3TableAdapters.ProductTableAdapter ProductTableAdapter;
        private System.Windows.Forms.BindingSource InvoiceBindingSource;
        private DataSet4 DataSet4;
        private DataSet4TableAdapters.InvoiceTableAdapter InvoiceTableAdapter;
    }
}