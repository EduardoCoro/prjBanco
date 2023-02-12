namespace prjBanco
{
    partial class Cliente
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
            System.Windows.Forms.Label cLI_CODLabel;
            System.Windows.Forms.Label cLI_NOMELabel;
            System.Windows.Forms.Label cLI_TELEFONELabel;
            System.Windows.Forms.Label cLI_NASCLabel;
            System.Windows.Forms.Label cLI_SALARIOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.bANCODataSet = new prjBanco.BANCODataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new prjBanco.BANCODataSetTableAdapters.ClienteTableAdapter();
            this.tableAdapterManager = new prjBanco.BANCODataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cLI_NASCMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cLI_CODTextBox = new System.Windows.Forms.TextBox();
            this.cLI_NOMETextBox = new System.Windows.Forms.TextBox();
            this.cLI_TELEFONEMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cLI_SALARIOTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            cLI_CODLabel = new System.Windows.Forms.Label();
            cLI_NOMELabel = new System.Windows.Forms.Label();
            cLI_TELEFONELabel = new System.Windows.Forms.Label();
            cLI_NASCLabel = new System.Windows.Forms.Label();
            cLI_SALARIOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bANCODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cLI_CODLabel
            // 
            cLI_CODLabel.AutoSize = true;
            cLI_CODLabel.Location = new System.Drawing.Point(45, 48);
            cLI_CODLabel.Name = "cLI_CODLabel";
            cLI_CODLabel.Size = new System.Drawing.Size(121, 16);
            cLI_CODLabel.TabIndex = 11;
            cLI_CODLabel.Text = "Código do Cliente :";
            // 
            // cLI_NOMELabel
            // 
            cLI_NOMELabel.AutoSize = true;
            cLI_NOMELabel.Location = new System.Drawing.Point(52, 95);
            cLI_NOMELabel.Name = "cLI_NOMELabel";
            cLI_NOMELabel.Size = new System.Drawing.Size(114, 16);
            cLI_NOMELabel.TabIndex = 13;
            cLI_NOMELabel.Text = "Nome do Cliente: ";
            // 
            // cLI_TELEFONELabel
            // 
            cLI_TELEFONELabel.AutoSize = true;
            cLI_TELEFONELabel.Location = new System.Drawing.Point(98, 138);
            cLI_TELEFONELabel.Name = "cLI_TELEFONELabel";
            cLI_TELEFONELabel.Size = new System.Drawing.Size(68, 16);
            cLI_TELEFONELabel.TabIndex = 15;
            cLI_TELEFONELabel.Text = "Telefone :";
            // 
            // cLI_NASCLabel
            // 
            cLI_NASCLabel.AutoSize = true;
            cLI_NASCLabel.Location = new System.Drawing.Point(80, 183);
            cLI_NASCLabel.Name = "cLI_NASCLabel";
            cLI_NASCLabel.Size = new System.Drawing.Size(86, 16);
            cLI_NASCLabel.TabIndex = 17;
            cLI_NASCLabel.Text = "Nascimento :";
            // 
            // cLI_SALARIOLabel
            // 
            cLI_SALARIOLabel.AutoSize = true;
            cLI_SALARIOLabel.Location = new System.Drawing.Point(98, 224);
            cLI_SALARIOLabel.Name = "cLI_SALARIOLabel";
            cLI_SALARIOLabel.Size = new System.Drawing.Size(57, 16);
            cLI_SALARIOLabel.TabIndex = 19;
            cLI_SALARIOLabel.Text = "Salário :";
            // 
            // bANCODataSet
            // 
            this.bANCODataSet.DataSetName = "BANCODataSet";
            this.bANCODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.bANCODataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.CONTATableAdapter = null;
            this.tableAdapterManager.MovimentacaoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjBanco.BANCODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.cLI_NASCMaskedTextBox);
            this.groupBox1.Controls.Add(cLI_CODLabel);
            this.groupBox1.Controls.Add(this.cLI_CODTextBox);
            this.groupBox1.Controls.Add(cLI_NOMELabel);
            this.groupBox1.Controls.Add(this.cLI_NOMETextBox);
            this.groupBox1.Controls.Add(cLI_TELEFONELabel);
            this.groupBox1.Controls.Add(this.cLI_TELEFONEMaskedTextBox);
            this.groupBox1.Controls.Add(cLI_NASCLabel);
            this.groupBox1.Controls.Add(cLI_SALARIOLabel);
            this.groupBox1.Controls.Add(this.cLI_SALARIOTextBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(73, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 258);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cadastramento do Cliente";
            // 
            // cLI_NASCMaskedTextBox
            // 
            this.cLI_NASCMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CLI_NASC", true));
            this.cLI_NASCMaskedTextBox.Location = new System.Drawing.Point(172, 177);
            this.cLI_NASCMaskedTextBox.Mask = "00/00/0000";
            this.cLI_NASCMaskedTextBox.Name = "cLI_NASCMaskedTextBox";
            this.cLI_NASCMaskedTextBox.Size = new System.Drawing.Size(99, 22);
            this.cLI_NASCMaskedTextBox.TabIndex = 21;
            this.cLI_NASCMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // cLI_CODTextBox
            // 
            this.cLI_CODTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CLI_COD", true));
            this.cLI_CODTextBox.Enabled = false;
            this.cLI_CODTextBox.Location = new System.Drawing.Point(172, 42);
            this.cLI_CODTextBox.Name = "cLI_CODTextBox";
            this.cLI_CODTextBox.Size = new System.Drawing.Size(63, 22);
            this.cLI_CODTextBox.TabIndex = 12;
            // 
            // cLI_NOMETextBox
            // 
            this.cLI_NOMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CLI_NOME", true));
            this.cLI_NOMETextBox.Location = new System.Drawing.Point(172, 89);
            this.cLI_NOMETextBox.Name = "cLI_NOMETextBox";
            this.cLI_NOMETextBox.Size = new System.Drawing.Size(249, 22);
            this.cLI_NOMETextBox.TabIndex = 14;
            // 
            // cLI_TELEFONEMaskedTextBox
            // 
            this.cLI_TELEFONEMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CLI_TELEFONE", true));
            this.cLI_TELEFONEMaskedTextBox.Location = new System.Drawing.Point(172, 132);
            this.cLI_TELEFONEMaskedTextBox.Mask = "(99) 0000-0000";
            this.cLI_TELEFONEMaskedTextBox.Name = "cLI_TELEFONEMaskedTextBox";
            this.cLI_TELEFONEMaskedTextBox.Size = new System.Drawing.Size(200, 22);
            this.cLI_TELEFONEMaskedTextBox.TabIndex = 16;
            // 
            // cLI_SALARIOTextBox
            // 
            this.cLI_SALARIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CLI_SALARIO", true));
            this.cLI_SALARIOTextBox.Location = new System.Drawing.Point(172, 218);
            this.cLI_SALARIOTextBox.Name = "cLI_SALARIOTextBox";
            this.cLI_SALARIOTextBox.Size = new System.Drawing.Size(99, 22);
            this.cLI_SALARIOTextBox.TabIndex = 20;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.clienteBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolbtnSalvar,
            this.toolStripButton1,
            this.toolStripButton2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(618, 25);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click_2);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click_2);
            // 
            // toolbtnSalvar
            // 
            this.toolbtnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnSalvar.Image")));
            this.toolbtnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnSalvar.Name = "toolbtnSalvar";
            this.toolbtnSalvar.Size = new System.Drawing.Size(23, 22);
            this.toolbtnSalvar.Text = "toolStripButton1";
            this.toolbtnSalvar.Click += new System.EventHandler(this.toolbtnSalvar_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prjBanco.Properties.Resources.wal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(618, 379);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco Central - Cadastro de Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bANCODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BANCODataSet bANCODataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private BANCODataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private BANCODataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cLI_CODTextBox;
        private System.Windows.Forms.TextBox cLI_NOMETextBox;
        private System.Windows.Forms.TextBox cLI_SALARIOTextBox;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton toolbtnSalvar;
        private System.Windows.Forms.MaskedTextBox cLI_NASCMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cLI_TELEFONEMaskedTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}