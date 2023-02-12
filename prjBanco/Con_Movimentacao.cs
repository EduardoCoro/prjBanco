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
    public partial class Con_Movimentacao : Form
    {
        public Con_Movimentacao()
        {
            InitializeComponent();
        }

        private void Con_Movimentacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bANCODataSet.consulta_movimentacao' table. You can move, or remove it, as needed.
            this.consulta_movimentacaoTableAdapter.Fill(this.bANCODataSet.consulta_movimentacao);
            this.CancelButton = button1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                consulta_movimentacaoBindingSource.Filter="CLI_NOME LIKE '" + txt_name.Text + "%'";
            }
            catch (Exception)
            {

                consulta_movimentacaoBindingSource.RemoveFilter(); 
            }
        }

        private void txt_num_TextChanged(object sender, EventArgs e)
        {
            try
            {
                consulta_movimentacaoBindingSource.Filter = "CONTA_NUMERO = " + txt_num.Text;
            }
            catch (Exception)
            {

                consulta_movimentacaoBindingSource.RemoveFilter();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
