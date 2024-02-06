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
    public partial class Policecriminal : Form
    {
        SqlConnection con = new SqlConnection("data source = Eyakem;initial catalog = policedb ; integrated security = true;");
        public Policecriminal()
        {
            InitializeComponent();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Close();
            Police a = new Police();
            a.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Close();
            Policecases a = new Policecases();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Login a = new Login();
            a.Show();

        }

        private void Policecriminal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'policedbDataSet7.criminals' table. You can move, or remove it, as needed.
            this.criminalsTableAdapter.Fill(this.policedbDataSet7.criminals);

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

            txtname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtadd.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            idlabel.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
           
            con.Open();

            SqlCommand cmd = new SqlCommand("Edit_Criminal", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", Int32.Parse(idlabel.Text));
            cmd.Parameters.AddWithValue("@name", txtname.Text);
            cmd.Parameters.AddWithValue("@add", txtadd.Text);
            cmd.Parameters.AddWithValue("@type", comboBox1.SelectedItem.ToString());



            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully");

            this.criminalsTableAdapter.Fill(this.policedbDataSet7.criminals);
            con.Close();
        }

        private void addbtn_Click(object sender, EventArgs e)
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
            this.criminalsTableAdapter.Fill(this.policedbDataSet7.criminals);

            con.Close();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("data source = Eyakem;initial catalog = policedb ; integrated security = true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Remove_criminal", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", Int32.Parse(idlabel.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted Successfully");
            this.criminalsTableAdapter.Fill(this.policedbDataSet7.criminals);


            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            //SqlConnection con = new SqlConnection("data source = Eyakem;initial catalog = policedb ; integrated security = true;");
            con.Open();
            if (cmbsearch.SelectedIndex.Equals(0))
            {
                SqlCommand cmd = new SqlCommand("select * from criminals where criminal_id like '" + txtsearch.Text + "%' ", con);
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
