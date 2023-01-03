using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace cargo
{
    public partial class trans_details_view_ : Form
    {
        public trans_details_view_()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("data source=JV;integrated security=true;initial catalog=cargo_mgmt;");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select * from trans_details where c_name='" + textBox2.Text + "'", con);
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            if (rdr1.Read())
            {
                label3.Text = rdr1["c_id"].ToString();
                textBox1.Text = rdr1["bill_no"].ToString();
                textBox3.Text = rdr1["type_of_goods"].ToString();
                textBox4.Text = rdr1["goods_code"].ToString();
                textBox5.Text = rdr1["goods_qty"].ToString();
                textBox12.Text = rdr1["trans_no"].ToString();
                textBox13.Text = rdr1["trans_status"].ToString();
                textBox6.Text = rdr1["goods_cost"].ToString();
                textBox7.Text = rdr1["date_of_sending"].ToString();
                textBox8.Text = rdr1["date_of_delivery"].ToString();
                textBox9.Text = rdr1["service_charge"].ToString();
                textBox10.Text = rdr1["advance"].ToString();
                textBox11.Text = rdr1["bal"].ToString();
            }
        }

        private void trans_details_view__Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=JV;integrated security=true;initial catalog=cargo_mgmt;");
            con.Open();
            AutoCompleteStringCollection nc = new AutoCompleteStringCollection();
            SqlCommand cmd = new SqlCommand("select * from cust_details", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                nc.Add(rdr[1].ToString());
            }
            textBox2.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox2.AutoCompleteCustomSource = nc;
            rdr.Close();
            rdr.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
