using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace final_project
{
    public partial class Criminals : Form
    {
        SqlConnection con = new SqlConnection("data source = Eyakem;initial catalog = policedb ; integrated security = true;");
        public Criminals()
        {
            InitializeComponent();
        }

        private void Criminals_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'policedbDataSet7.criminals' table. You can move, or remove it, as needed.
            this.criminalsTableAdapter3.Fill(this.policedbDataSet7.criminals);
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Login a = new Login();
            a.Show();
             
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Close();
            Admin a = new Admin();
            a.Show();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Close();
            Officer a = new Officer();
            a.Show();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            Close();
            Cases a = new Cases();
            a.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("data source = Eyakem;initial catalog = policedb ; integrated security = true;");
            con.Open();

            SqlCommand cmd = new SqlCommand("Edit_Criminal", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id",Int32.Parse(idlabel.Text));
            cmd.Parameters.AddWithValue("@name", txtname.Text);
            cmd.Parameters.AddWithValue("@add", txtadd.Text);
            cmd.Parameters.AddWithValue("@type", comboBox1.SelectedItem.ToString());



            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully");

            this.criminalsTableAdapter3.Fill(this.policedbDataSet7.criminals);
            con.Close();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("data source = Eyakem;initial catalog = policedb ; integrated security = true;");
            con.Open();

            SqlCommand cmd = new SqlCommand("Add_criminal", con);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@name", txtname.Text);
            cmd.Parameters.AddWithValue("@add", txtadd.Text);
            cmd.Parameters.AddWithValue("@type", comboBox1.SelectedItem.ToString());

            cmd.ExecuteNonQuery();
            MessageBox.Show("Registered Successfully");
            this.criminalsTableAdapter3.Fill(this.policedbDataSet7.criminals);

            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            idlabel.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtadd.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox1.SelectedItem = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            



        }

        private void delbtn_Click(object sender, EventArgs e)
        {
           // SqlConnection con = new SqlConnection("data source = Eyakem;initial catalog = policedb ; integrated security = true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Remove_criminal", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", Int32.Parse(idlabel.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted Successfully");
            this.criminalsTableAdapter3.Fill(this.policedbDataSet7.criminals);

            
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("data source = Eyakem;initial catalog = policedb ; integrated security = true;");
            con.Open();
            if (cmbsearch.SelectedIndex.Equals(0))
            {
                SqlCommand cmd = new SqlCommand("select * from criminals where criminal_id like '"+txtsearch.Text+"%' ",con);
                SqlDataAdapter d = new SqlDataAdapter(cmd);
                DataTable t = new DataTable();
                d.Fill(t);
                dataGridView1.DataSource = t;
                cmd.ExecuteNonQuery();

            }
            else if (cmbsearch.SelectedIndex.Equals(1))
            {
                SqlCommand cmd = new SqlCommand("select * from criminals where Name like '" + txtsearch.Text + "%' ", con);
                SqlDataAdapter d = new SqlDataAdapter(cmd);
                DataTable t = new DataTable();
                d.Fill(t);
                dataGridView1.DataSource = t;
                cmd.ExecuteNonQuery();
            }
            else if (cmbsearch.SelectedIndex.Equals(2))
            {
                SqlCommand cmd = new SqlCommand("select * from criminals where criminal_address like '" + txtsearch.Text + "%' ", con);
                SqlDataAdapter d = new SqlDataAdapter(cmd);
                DataTable t = new DataTable();
                d.Fill(t);
                dataGridView1.DataSource = t;
                cmd.ExecuteNonQuery();
            }
            else if (cmbsearch.SelectedIndex.Equals(3))
            {
                SqlCommand cmd = new SqlCommand("select * from criminals where crime_type like '" + txtsearch.Text + "%' ", con);
                SqlDataAdapter d = new SqlDataAdapter(cmd);
                DataTable t = new DataTable();
                d.Fill(t);
                dataGridView1.DataSource = t;
                cmd.ExecuteNonQuery();
            }
            else if (cmbsearch.SelectedIndex.Equals(-1))
                MessageBox.Show("Please Choose Search Type");
            con.Close();
        }
    }
}
