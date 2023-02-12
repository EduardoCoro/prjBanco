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
    public partial class Frm_Con_Conta : Form
    {
        public Frm_Con_Conta()
        {
            InitializeComponent();
        }

        private void Frm_Con_Conta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bANCODataSet._View_Conta_Cliente' table. You can move, or remove it, as needed.
            this.view_Conta_ClienteTableAdapter.Fill(this.bANCODataSet._View_Conta_Cliente);
            this.CancelButton = btnsair;
        }

        private void txt_cod_TextChanged(object sender, EventArgs e)
        {
            view_Conta_ClienteBindingSource.Filter = "CLI_NOME LIKE '" + txt_cod.Text + "%'";
        }

        private void txt_num_conta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                view_Conta_ClienteBindingSource.Filter = "CONTA_NUMERO = " + txt_num_conta.Text;
            }
            catch (Exception)
            {

                view_Conta_ClienteBindingSource.RemoveFilter();
            }
        }

        private void txt_cod_Leave(object sender, EventArgs e)
        {
            view_Conta_ClienteBindingSource.RemoveFilter();
            txt_num_conta.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
