namespace prjBanco
{
    partial class Frm_Extrato_geral
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BANCODataSet = new prjBanco.BANCODataSet();
            this.Exibição_extrato_GeralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Exibição_extrato_GeralTableAdapter = new prjBanco.BANCODataSetTableAdapters.Exibição_extrato_GeralTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BANCODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exibição_extrato_GeralBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Exibição_extrato_GeralBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "prjBanco.Extrato_Geral.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(923, 512);
            this.reportViewer1.TabIndex = 0;
            // 
            // BANCODataSet
            // 
            this.BANCODataSet.DataSetName = "BANCODataSet";
            this.BANCODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Exibição_extrato_GeralBindingSource
            // 
            this.Exibição_extrato_GeralBindingSource.DataMember = "Exibição_extrato Geral";
            this.Exibição_extrato_GeralBindingSource.DataSource = this.BANCODataSet;
            // 
            // Exibição_extrato_GeralTableAdapter
            // 
            this.Exibição_extrato_GeralTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Extrato_geral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 524);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Extrato_geral";
            this.Text = "Frm_Extrato_geral";
            this.Load += new System.EventHandler(this.Frm_Extrato_geral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BANCODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exibição_extrato_GeralBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Exibição_extrato_GeralBindingSource;
        private BANCODataSet BANCODataSet;
        private BANCODataSetTableAdapters.Exibição_extrato_GeralTableAdapter Exibição_extrato_GeralTableAdapter;
    }
}