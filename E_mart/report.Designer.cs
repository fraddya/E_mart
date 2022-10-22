
namespace E_mart
{
    partial class report
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
            this.ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client = new E_mart.client();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClientTableAdapter = new E_mart.clientTableAdapters.ClientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientBindingSource
            // 
            this.ClientBindingSource.DataMember = "Client";
            this.ClientBindingSource.DataSource = this.client;
            // 
            // client
            // 
            this.client.DataSetName = "client";
            this.client.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer2
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ClientBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "E_mart.client.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(58, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1002, 541);
            this.reportViewer2.TabIndex = 0;
            // 
            // ClientTableAdapter
            // 
            this.ClientTableAdapter.ClearBeforeFill = true;
            // 
            // report
            // 
            this.ClientSize = new System.Drawing.Size(1484, 595);
            this.Controls.Add(this.reportViewer2);
            this.Name = "report";
            this.Load += new System.EventHandler(this.report_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProductBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.ProductTableAdapter ProductTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource ClientBindingSource;
        private client client;
        private clientTableAdapters.ClientTableAdapter ClientTableAdapter;
    }
}