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
    public partial class cust_details : Form
    {
        public cust_details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=JV;integrated security=true;initial catalog=cargo_mgmt;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into cust_details(c_name,c_id,c_address,c_city,c_pincode,c_ph_no,r_name,r_id,r_address,r_city,r_pincode,r_ph_no) values('" + textBox2.Text + "','" + textBox12.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox11.Text + "','" + textBox13.Text + "','" + textBox10.Text + "','" + textBox9.Text + "','" + textBox8.Text + "','" + textBox7.Text + "')", con);
            cmd.ExecuteNonQuery();
            textBox1.Text = " ";
            textBox10.Text = " ";
            textBox11.Text = " ";
            textBox12.Text = " ";
            textBox13.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";
            textBox8.Text = " ";
            textBox9.Text = " ";
            textBox2.Focus();
        }

        private void cust_details_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=JV;integrated security=true;initial catalog=cargo_mgmt;");
            con.Open();
            SqlCommand com = new SqlCommand("select count(*) from cust_details", con);
            //con.Open();
            int count = Convert.ToInt16 (com.ExecuteScalar()) + 1;
            textBox1.Text=("0"+count);
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
