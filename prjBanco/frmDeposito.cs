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
    public partial class frmDeposito : Form
    {
        public frmDeposito()
        {
            InitializeComponent();
        }

        private void movimentacaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movimentacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCODataSet);

        }

        private void frmDeposito_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bANCODataSet.Movimentacao' table. You can move, or remove it, as needed.
            this.movimentacaoTableAdapter.Fill(this.bANCODataSet.Movimentacao);
            this.AcceptButton = btnDeposit;
            this.CancelButton = btnsair;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cod, depo;

            cod = int.Parse(txt_cod_depo.Text);
            depo = int.Parse(txtdeposit.Text);

            movimentacaoTableAdapter.Iserrir_mov_saque_depo("Depósito", "D", cod, depo, DateTime.Now);
            movimentacaoTableAdapter.Movimentacao_deposito("Depósito", "D", cod, depo, DateTime.Now);
            MessageBox.Show("Depósito Efetuado", "Banco Central", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
