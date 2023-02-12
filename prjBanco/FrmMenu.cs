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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void saqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaque form = new frmSaque();
            form.ShowDialog();
        }

        private void depositoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeposito form = new frmDeposito();
            form.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente form = new Cliente();
            form.ShowDialog();            
        }

        private void contaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConta conta = new frmConta();
            conta.ShowDialog();        
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Rel_Cliente form = new Frm_Rel_Cliente();
            form.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Logado Com Sucesso", "Banco Central - Informa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void esconderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void contasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_REL_CONTA form = new Frm_REL_CONTA();
            form.ShowDialog();
        }

        private void extratoGeralToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Con_Conta consulta = new Frm_Con_Conta();
            consulta.ShowDialog();
        }

        private void movimentaçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Con_Movimentacao movi = new Con_Movimentacao();
            movi.ShowDialog();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void contaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Frm_consulta_cliente concli = new Frm_consulta_cliente();
            concli.ShowDialog();
        }
    }
}
