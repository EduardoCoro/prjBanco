using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjBanco
{
    public partial class frmConta : Form
    {
        public frmConta()
        {
            InitializeComponent();
        }

        private void cONTABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void frmConta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bANCODataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.bANCODataSet.Cliente);
            // TODO: This line of code loads data into the 'bANCODataSet.CONTA' table. You can move, or remove it, as needed.
            this.cONTATableAdapter.Fill(this.bANCODataSet.CONTA);
            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            cONTA_ABERTURAMaskedTextBox.Text = DateTime.Now.ToShortDateString();
          
            

            
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.cONTABindingSource.EndEdit();
                cONTATableAdapter.Update(bANCODataSet.CONTA);
                //this.tableAdapterManager.UpdateAll(this.bANCODataSet);
                MessageBox.Show("Registro Salvo", "Banco Central - Informa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBox1.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar o registro" + ex.Message, "Banco Central", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            groupBox1.Enabled = false;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("confirma exclusão do registro atual", "BancoSystem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cONTABindingSource.RemoveCurrent();
                    cONTATableAdapter.Update(bANCODataSet);
                    groupBox1.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("registro não pode ser excluído " + ex.Message);
                this.cONTATableAdapter.Fill(this.bANCODataSet.CONTA);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            clienteBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
