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
    public partial class trans_detais_edit_ : Form
    {
        public trans_detais_edit_()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=JV;integrated security=true;initial catalog=cargo_mgmt;");
            con.Open();
            SqlCommand cmd = new SqlCommand("update trans_details set c_id='"+label13.Text+"', c_name='" + textBox2.Text + "',type_of_goods='" + textBox3.Text + "',goods_code='" + textBox4.Text + "',goods_qty='" + textBox5.Text + "',trans_no='" + textBox13.Text + "',trans_status='" + comboBox2.Text + "',goods_cost='" + textBox6.Text + "',date_of_sending='" + textBox7.Text + "',date_of_delivery='" + textBox8.Text + "',service_charge='" + textBox9.Text + "',advance='" + textBox10.Text + "',bal='" + textBox11.Text + "' where c_name='" + textBox2.Text + "'", con);
            cmd.ExecuteNonQuery();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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
                textBox13.Text = rdr1["trans_no"].ToString();
                comboBox2.Text = rdr1["trans_status"].ToString();
                textBox6.Text = rdr1["goods_cost"].ToString();
                textBox7.Text = rdr1["date_of_sending"].ToString();
                textBox8.Text = rdr1["date_of_delivery"].ToString();
                textBox9.Text = rdr1["service_charge"].ToString();
                textBox10.Text = rdr1["advance"].ToString();
                textBox11.Text = rdr1["bal"].ToString();
                textBox12.Text = rdr1["mode_of_transfer"].ToString();
            }
        }

        private void trans_detais_edit__Load(object sender, EventArgs e)
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
