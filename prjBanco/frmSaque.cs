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
    public partial class frmSaque : Form
    {
        public frmSaque()
        {
            InitializeComponent();
        }

       

        private void btok_Click(object sender, EventArgs e)
        {
            try
            {
                int cod=int.Parse(txt_cod.Text),saque=0;

                
                saque = int.Parse(txt_saque.Text);
                VariaveisGlobais.Varsaque = saque;

                movimentacaoTableAdapter.Iserrir_mov_saque_depo("Saque", "S", cod, VariaveisGlobais.Varsaque, DateTime.Now);
                movimentacaoTableAdapter.Movimentacao_saque("Saque", "S", cod, VariaveisGlobais.Varsaque, DateTime.Now);
                if (MessageBox.Show("Processando - 'Contando Notas...'","Banco Central",MessageBoxButtons.OK,MessageBoxIcon.Exclamation)==DialogResult.OK)
                {
                    Frm_Saque_Notas nota = new Frm_Saque_Notas();
                    nota.ShowDialog();
                }
            }
            catch (Exception error)
            {

                MessageBox.Show("Erro :" + error.Message, "Banco Central - Por Favor preencha os campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void movimentacaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movimentacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCODataSet);

        }

        private void frmSaque_Load(object sender, EventArgs e)
        {
           
            this.AcceptButton = btnok;
            this.CancelButton = Btnsair;
        }

        private void Btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

