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
    public partial class Frm_REL_CONTA : Form
    {
        public Frm_REL_CONTA()
        {
            InitializeComponent();
        }

        private void Frm_REL_CONTA_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BANCODataSet.View_Conta_Cliente' table. You can move, or remove it, as needed.
            this.View_Conta_ClienteTableAdapter.Fill(this.BANCODataSet._View_Conta_Cliente);


            this.reportViewer1.RefreshReport();
        }

        private void Frm_REL_CONTA_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
