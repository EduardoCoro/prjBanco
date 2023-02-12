namespace prjBanco
{
    partial class frmSaque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaque));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_saque = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.bANCODataSet = new prjBanco.BANCODataSet();
            this.movimentacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movimentacaoTableAdapter = new prjBanco.BANCODataSetTableAdapters.MovimentacaoTableAdapter();
            this.tableAdapterManager = new prjBanco.BANCODataSetTableAdapters.TableAdapterManager();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btnsair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bANCODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentacaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txt_saque
            // 
            resources.ApplyResources(this.txt_saque, "txt_saque");
            this.txt_saque.Name = "txt_saque";
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.btnok, "btnok");
            this.btnok.Name = "btnok";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btok_Click);
            // 
            // bANCODataSet
            // 
            this.bANCODataSet.DataSetName = "BANCODataSet";
            this.bANCODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movimentacaoBindingSource
            // 
            this.movimentacaoBindingSource.DataMember = "Movimentacao";
            this.movimentacaoBindingSource.DataSource = this.bANCODataSet;
            // 
            // movimentacaoTableAdapter
            // 
            this.movimentacaoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.CONTATableAdapter = null;
            this.tableAdapterManager.MovimentacaoTableAdapter = this.movimentacaoTableAdapter;
            this.tableAdapterManager.UpdateOrder = prjBanco.BANCODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txt_cod
            // 
            resources.ApplyResources(this.txt_cod, "txt_cod");
            this.txt_cod.Name = "txt_cod";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // Btnsair
            // 
            this.Btnsair.BackColor = System.Drawing.Color.Crimson;
            resources.ApplyResources(this.Btnsair, "Btnsair");
            this.Btnsair.Name = "Btnsair";
            this.Btnsair.UseVisualStyleBackColor = false;
            this.Btnsair.Click += new System.EventHandler(this.Btnsair_Click);
            // 
            // frmSaque
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prjBanco.Properties.Resources._535;
            this.Controls.Add(this.Btnsair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_cod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txt_saque);
            this.Controls.Add(this.label1);
            this.Name = "frmSaque";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.frmSaque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bANCODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentacaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_saque;
        private System.Windows.Forms.Button btnok;
        private BANCODataSet bANCODataSet;
        private System.Windows.Forms.BindingSource movimentacaoBindingSource;
        private BANCODataSetTableAdapters.MovimentacaoTableAdapter movimentacaoTableAdapter;
        private BANCODataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btnsair;
    }
}