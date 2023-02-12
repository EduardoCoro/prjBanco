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
    public partial class Frm_Extrato_geral : Form
    {
        public Frm_Extrato_geral()
        {
            InitializeComponent();
        }

        private void Frm_Extrato_geral_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BANCODataSet.Exibição_extrato_Geral' table. You can move, or remove it, as needed.
            this.Exibição_extrato_GeralTableAdapter.Fill(this.BANCODataSet.Exibição_extrato_Geral);

            this.reportViewer1.RefreshReport();
        }
    }
}
