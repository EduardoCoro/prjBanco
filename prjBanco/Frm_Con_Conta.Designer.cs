namespace prjBanco
{
    partial class Frm_Con_Conta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsair = new System.Windows.Forms.Button();
            this.view_Conta_ClienteDataGridView = new System.Windows.Forms.DataGridView();
            this.CLI_SALARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.txt_num_conta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_Conta_ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bANCODataSet = new prjBanco.BANCODataSet();
            this.view_Conta_ClienteTableAdapter = new prjBanco.BANCODataSetTableAdapters.View_Conta_ClienteTableAdapter();
            this.tableAdapterManager = new prjBanco.BANCODataSetTableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_Conta_ClienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Conta_ClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANCODataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Controls.Add(this.btnsair);
            this.groupBox1.Controls.Add(this.view_Conta_ClienteDataGridView);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 415);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultando a Conta do Cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.Red;
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.ForeColor = System.Drawing.SystemColors.Control;
            this.btnsair.Location = new System.Drawing.Point(347, 371);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(99, 33);
            this.btnsair.TabIndex = 7;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.button1_Click);
            // 
            // view_Conta_ClienteDataGridView
            // 
            this.view_Conta_ClienteDataGridView.AllowUserToAddRows = false;
            this.view_Conta_ClienteDataGridView.AllowUserToDeleteRows = false;
            this.view_Conta_ClienteDataGridView.AutoGenerateColumns = false;
            this.view_Conta_ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_Conta_ClienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.CLI_SALARIO});
            this.view_Conta_ClienteDataGridView.DataSource = this.view_Conta_ClienteBindingSource;
            this.view_Conta_ClienteDataGridView.Location = new System.Drawing.Point(45, 19);
            this.view_Conta_ClienteDataGridView.Name = "view_Conta_ClienteDataGridView";
            this.view_Conta_ClienteDataGridView.ReadOnly = true;
            this.view_Conta_ClienteDataGridView.Size = new System.Drawing.Size(721, 346);
            this.view_Conta_ClienteDataGridView.TabIndex = 0;
            // 
            // CLI_SALARIO
            // 
            this.CLI_SALARIO.DataPropertyName = "CLI_SALARIO";
            this.CLI_SALARIO.HeaderText = "CLI_SALARIO";
            this.CLI_SALARIO.Name = "CLI_SALARIO";
            this.CLI_SALARIO.ReadOnly = true;
            // 
            // txt_cod
            // 
            this.txt_cod.Location = new System.Drawing.Point(174, 123);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(100, 20);
            this.txt_cod.TabIndex = 3;
            this.txt_cod.TextChanged += new System.EventHandler(this.txt_cod_TextChanged);
            this.txt_cod.Leave += new System.EventHandler(this.txt_cod_Leave);
            // 
            // txt_num_conta
            // 
            this.txt_num_conta.Location = new System.Drawing.Point(559, 124);
            this.txt_num_conta.Name = "txt_num_conta";
            this.txt_num_conta.Size = new System.Drawing.Size(100, 20);
            this.txt_num_conta.TabIndex = 4;
            this.txt_num_conta.TextChanged += new System.EventHandler(this.txt_num_conta_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome do Cliente :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Número da Conta :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Use as caixa para a consulta!";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(0, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(821, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Consulta               Conta                Cliente";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CONTA_CLIENTE";
            this.dataGridViewTextBoxColumn7.HeaderText = "CONTA_CLIENTE";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CLI_NOME";
            this.dataGridViewTextBoxColumn3.HeaderText = "CLI_NOME";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CONTA_ABERTURA";
            this.dataGridViewTextBoxColumn6.HeaderText = "CONTA_ABERTURA";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CONTA_FECHAMENTO";
            this.dataGridViewTextBoxColumn5.HeaderText = "CONTA_FECHAMENTO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // view_Conta_ClienteBindingSource
            // 
            this.view_Conta_ClienteBindingSource.DataMember = "View_Conta-Cliente";
            this.view_Conta_ClienteBindingSource.DataSource = this.bANCODataSet;
            // 
            // bANCODataSet
            // 
            this.bANCODataSet.DataSetName = "BANCODataSet";
            this.bANCODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_Conta_ClienteTableAdapter
            // 
            this.view_Conta_ClienteTableAdapter.ClearBeforeFill = true;
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
            // Frm_Con_Conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(819, 610);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_num_conta);
            this.Controls.Add(this.txt_cod);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Con_Conta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco Central - Consulta da Conta";
            this.Load += new System.EventHandler(this.Frm_Con_Conta_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_Conta_ClienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Conta_ClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANCODataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BANCODataSet bANCODataSet;
        private System.Windows.Forms.BindingSource view_Conta_ClienteBindingSource;
        private BANCODataSetTableAdapters.View_Conta_ClienteTableAdapter view_Conta_ClienteTableAdapter;
        private BANCODataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.TextBox txt_num_conta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView view_Conta_ClienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLI_SALARIO;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}