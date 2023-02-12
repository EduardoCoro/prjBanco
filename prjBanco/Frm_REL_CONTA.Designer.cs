namespace prjBanco
{
    partial class Frm_REL_CONTA
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
            this.BANCODataSet = new prjBanco.BANCODataSet();
            this.View_Conta_ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_Conta_ClienteTableAdapter = new prjBanco.BANCODataSetTableAdapters.View_Conta_ClienteTableAdapter();
            this.tableAdapterManager = new prjBanco.BANCODataSetTableAdapters.TableAdapterManager();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.BANCODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_Conta_ClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BANCODataSet
            // 
            this.BANCODataSet.DataSetName = "BANCODataSet";
            this.BANCODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_Conta_ClienteBindingSource
            // 
            this.View_Conta_ClienteBindingSource.DataMember = "View_Conta-Cliente";
            this.View_Conta_ClienteBindingSource.DataSource = this.BANCODataSet;
            // 
            // View_Conta_ClienteTableAdapter
            // 
            this.View_Conta_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CONTATableAdapter = null;
            this.tableAdapterManager.MovimentacaoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjBanco.BANCODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.View_Conta_ClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "prjBanco.Rel_Conta-Cliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(689, 394);
            this.reportViewer1.TabIndex = 0;
            // 
            // Frm_REL_CONTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 406);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_REL_CONTA";
            this.Text = "Frm_REL_CONTA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_REL_CONTA_FormClosing);
            this.Load += new System.EventHandler(this.Frm_REL_CONTA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BANCODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_Conta_ClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource View_Conta_ClienteBindingSource;
        private BANCODataSet BANCODataSet;
        private BANCODataSetTableAdapters.View_Conta_ClienteTableAdapter View_Conta_ClienteTableAdapter;
        private BANCODataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}