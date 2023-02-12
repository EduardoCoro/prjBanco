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
    public partial class Frm_Rel_Cliente : Form
    {
        public Frm_Rel_Cliente()
        {
            InitializeComponent();
        }

        private void Frm_Rel_Cliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BANCODataSet.Cliente' table. You can move, or remove it, as needed.
            this.ClienteTableAdapter.Fill(this.BANCODataSet.Cliente);

            this.reportViewer1.RefreshReport();
        }

        private void Frm_Rel_Cliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        
       
    }
}
