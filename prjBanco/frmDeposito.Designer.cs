namespace prjBanco
{
    partial class frmDeposito
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
            System.Windows.Forms.Label mOV_NUMEROLabel;
            System.Windows.Forms.Label mOV_VALORLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeposito));
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.bANCODataSet = new prjBanco.BANCODataSet();
            this.movimentacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movimentacaoTableAdapter = new prjBanco.BANCODataSetTableAdapters.MovimentacaoTableAdapter();
            this.tableAdapterManager = new prjBanco.BANCODataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cod_depo = new System.Windows.Forms.TextBox();
            this.txtdeposit = new System.Windows.Forms.TextBox();
            mOV_NUMEROLabel = new System.Windows.Forms.Label();
            mOV_VALORLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bANCODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentacaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mOV_NUMEROLabel
            // 
            mOV_NUMEROLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            mOV_NUMEROLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mOV_NUMEROLabel.Location = new System.Drawing.Point(39, 66);
            mOV_NUMEROLabel.Name = "mOV_NUMEROLabel";
            mOV_NUMEROLabel.Size = new System.Drawing.Size(168, 31);
            mOV_NUMEROLabel.TabIndex = 23;
            mOV_NUMEROLabel.Text = "Código da Conta:";
            mOV_NUMEROLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mOV_VALORLabel
            // 
            mOV_VALORLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            mOV_VALORLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mOV_VALORLabel.Location = new System.Drawing.Point(53, 124);
            mOV_VALORLabel.Name = "mOV_VALORLabel";
            mOV_VALORLabel.Size = new System.Drawing.Size(125, 46);
            mOV_VALORLabel.TabIndex = 24;
            mOV_VALORLabel.Text = "Depositar :";
            mOV_VALORLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Location = new System.Drawing.Point(146, 207);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(116, 52);
            this.btnDeposit.TabIndex = 0;
            this.btnDeposit.Text = "OK";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.Snow;
            this.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsair.Location = new System.Drawing.Point(12, 241);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(46, 31);
            this.btnsair.TabIndex = 2;
            this.btnsair.Text = "Exit";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 49);
            this.label1.TabIndex = 26;
            this.label1.Text = "Deposita o Seu Dinheiro!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_cod_depo
            // 
            this.txt_cod_depo.Location = new System.Drawing.Point(254, 77);
            this.txt_cod_depo.Name = "txt_cod_depo";
            this.txt_cod_depo.Size = new System.Drawing.Size(100, 20);
            this.txt_cod_depo.TabIndex = 27;
            // 
            // txtdeposit
            // 
            this.txtdeposit.Location = new System.Drawing.Point(237, 139);
            this.txtdeposit.Name = "txtdeposit";
            this.txtdeposit.Size = new System.Drawing.Size(100, 20);
            this.txtdeposit.TabIndex = 28;
            // 
            // frmDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prjBanco.Properties.Resources.download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 284);
            this.Controls.Add(this.txtdeposit);
            this.Controls.Add(this.txt_cod_depo);
            this.Controls.Add(this.label1);
            this.Controls.Add(mOV_VALORLabel);
            this.Controls.Add(mOV_NUMEROLabel);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnDeposit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDeposito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco Central - Depósito ";
            this.Load += new System.EventHandler(this.frmDeposito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bANCODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentacaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnsair;
        private BANCODataSet bANCODataSet;
        private System.Windows.Forms.BindingSource movimentacaoBindingSource;
        private BANCODataSetTableAdapters.MovimentacaoTableAdapter movimentacaoTableAdapter;
        private BANCODataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cod_depo;
        private System.Windows.Forms.TextBox txtdeposit;
    }
}