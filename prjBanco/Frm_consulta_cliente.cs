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
    public partial class Frm_consulta_cliente : Form
    {
        public Frm_consulta_cliente()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCODataSet);

        }

        private void Frm_consulta_cliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bANCODataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.bANCODataSet.Cliente);
            this.CancelButton = btn_exit;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                clienteBindingSource.Filter = "CLI_NOME LIKE '" + txt_name.Text + "%'";
            }
            catch (Exception)
            {
                
               clienteBindingSource.RemoveFilter();
            }
        }

        private void txt_num_TextChanged(object sender, EventArgs e)
        {
            try
            {
                clienteBindingSource.Filter = "CLI_COD = " + txt_num.Text;
            }
            catch (Exception)
            {
                
                clienteBindingSource.RemoveFilter();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Utiliza os campos para a busca da consulta!","Banco Central - Informa",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
