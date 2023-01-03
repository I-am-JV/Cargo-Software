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
    public partial class trans_details : Form
    {
        public trans_details()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trans_details_Load(object sender, EventArgs e)
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

            //con.Open();
            //SqlCommand cmd1 = new SqlCommand("select * from cust_details where c_name='"+textBox2.Text+"'", con);
            //SqlDataReader rdr1 = cmd1.ExecuteReader();
            //if (rdr1.Read())
            //{
            //    label3.Text = rdr1["c_id"].ToString();
            //}

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=JV;integrated security=true;initial catalog=cargo_mgmt;");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select * from cust_details where c_name='" + textBox2.Text + "'", con);
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            if (rdr1.Read())
            {
                label3.Text = rdr1[1].ToString();
                textBox1.Text = rdr1["bill_nop"].ToString();
                textBox13.Text = rdr1["r_city"].ToString();

            }
        }

        String rt = null;
        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("data source=JV;integrated security=true;initial catalog=cargo_mgmt;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into trans_details(c_id,bill_no,c_name,type_of_goods,goods_code,goods_qty,mode_of_transfer,trans_no,trans_status,goods_cost,date_of_sending,date_of_delivery,service_charge,advance,bal,Received_Place) values('" + label13.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox3.Text + "','" + rt + "','" + comboBox2.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','"+ textBox13.Text +"')", con);
            cmd.ExecuteNonQuery();
            textBox1.Text = " ";
            textBox10.Text = " ";
            textBox11.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text=" ";
            textBox7.Text = " ";
            textBox8.Text = " ";
            textBox9.Text = " ";
            textBox12.Text=" ";
            textBox13.Text = " ";
            comboBox2.Text = " ";
            label13.Text = " ";





        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox11.Text = (double.Parse(textBox6.Text)).ToString();
            }
            catch (Exception ex)
            {
 
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox11.Text = (double.Parse(textBox6.Text) + double.Parse(textBox9.Text)).ToString();
            }

            catch (Exception ex)
            { 
            }
            }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox11.Text = (double.Parse(textBox6.Text) + double.Parse(textBox9.Text) - double.Parse(textBox10.Text)).ToString();
            }
            catch (Exception ex)
            {
 
            }
            }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
          
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

          
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Air Line")
            {
                rt = "Air Line No :" + textBox12.Text;
            }
            else if (comboBox3.Text == "Truck")
            {
                rt = "Truck No :" + textBox12.Text;
            }
            else if (comboBox3.Text == "Two wheeler")
            {
                rt = " Two wheeler No :" + textBox12.Text;
            }
        }
    }
    }
