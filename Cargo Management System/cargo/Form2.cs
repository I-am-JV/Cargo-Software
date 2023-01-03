using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cargo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void customerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cust_details cd = new cust_details();
            cd.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trans_details td = new trans_details();
            td.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trans_details_del_ tdd = new trans_details_del_();
            tdd.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trans_details_view_ tdv = new trans_details_view_();
            tdv.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trans_detais_edit_ tde = new trans_detais_edit_();
            tde.Show();
        }

        private void enquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enquiry enq = new enquiry();
            enq.Show();
        }

        private void billingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bill_report br = new bill_report();
            br.Show();
        }
    }
}
