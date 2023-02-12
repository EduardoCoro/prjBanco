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
    public partial class Frm_Saque_Notas : Form
    {
        public Frm_Saque_Notas()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Saque_Notas_Load(object sender, EventArgs e)
        {
            int saque = 0, nt100 = 0, nt50 = 0, nt20 = 0, nt10 = 0, nt5 = 0;


            Lblnt10.Text = "";
            Lblnt100.Text = "";
            Lblnt20.Text = "";
            Lblnt5.Text = "";
            Lblnt50.Text = "";
            pcnt05.Visible = false;
            pcnt10.Visible = false;
            pcnt100.Visible = false;
            pcnt20.Visible = false;
            pcnt50.Visible = false;

            saque = VariaveisGlobais.Varsaque;






            if (saque >= 100)
            {
                nt100 = saque / 100;
                saque = saque - 100 * nt100;


            }
            if (saque >= 50)
            {
                nt50 = saque / 50;
                saque = saque - 50 * nt50;
            }
            if (saque >= 20)
            {
                nt20 = saque / 20;
                saque = saque - 20 * nt20;
            }

            if (saque >= 10)
            {
                nt10 = saque / 10;
                saque = saque - 10 * nt10;
            }
            if (saque >= 5)
            {
                nt5 = saque / 5;
                saque = saque - 5 * nt5;
            }
            if (nt100 > 0)
            {
                Lblnt100.Text = "Notas de 100: " + nt100 + " Nota(as)";
                pcnt100.Visible = true;
            }
            if (nt50 > 0)
            {
                Lblnt50.Text = "Notas de 50: " + nt50 + " Nota(as)";
                pcnt50.Visible = true;
            }
            if (nt20 > 0)
            {
                Lblnt20.Text = "Notas de 20: " + nt20 + " Nota(as)";
                pcnt20.Visible = true;
            }
            if (nt10 > 0)
            {
                Lblnt10.Text = "Notas de 10: " + nt10 + " Nota(as)";
                pcnt10.Visible = true;
            }
            if (nt5 > 0)
            {
                Lblnt5.Text = "Notas de 5: " + nt5 + " Nota(as)";
                pcnt05.Visible = true;
            }
            timer1.Start();
            timer1.Interval = 7000;
        }
    }
}
