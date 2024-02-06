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
    public partial class Officer : Form
    {
        public Officer()
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-5IQJSKJ;initial catalog = policedb ; integrated security = true;");
            con.Open();
            InitializeComponent();
        }

        private void Officer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'policedbDataSet.police' table. You can move, or remove it, as needed.
            this.policeTableAdapter.Fill(this.policedbDataSet.police);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Close();
            Cases a = new Cases();
            a.Show();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            Close();
            Criminals a = new Criminals();
            a.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-5IQJSKJ;initial catalog = policedb ; integrated security = true;");
            con.Open();

            SqlCommand cmd = new SqlCommand("Edit_Officer", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usernew", txtuser.Text);
            cmd.Parameters.AddWithValue("@fname", txtfname.Text);
            cmd.Parameters.AddWithValue("@lname", txtlname.Text);
            cmd.Parameters.AddWithValue("@id", Int32.Parse(idlabel.Text));
            cmd.Parameters.AddWithValue("@pass", txtpass.Text);



            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully");
            this.policeTableAdapter.Fill(this.policedbDataSet.police);

            con.Close();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-5IQJSKJ;initial catalog = policedb ; integrated security = true;");
            con.Open();
            
            SqlCommand cmd = new SqlCommand("insert_police", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fname", txtfname.Text);
            cmd.Parameters.AddWithValue("@lname", txtlname.Text);
            cmd.Parameters.AddWithValue("@user", txtuser.Text);
            cmd.Parameters.AddWithValue("@pass", txtpass.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Registered Successfully");
            this.policeTableAdapter.Fill(this.policedbDataSet.police);
            
            con.Close();
          
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-5IQJSKJ;initial catalog = policedb ; integrated security = true;");
            con.Open();

            SqlCommand cmd = new SqlCommand("Remove_officer", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", txtuser.Text);
           

            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted Successfully");
            this.policeTableAdapter.Fill(this.policedbDataSet.police);

            con.Close();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtfname.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtlname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtuser.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtpass.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            idlabel.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-5IQJSKJ;initial catalog = policedb ; integrated security = true;");
            con.Open();
            if (cmbsearch.SelectedIndex.Equals(0))
            {
                SqlCommand cmd = new SqlCommand("select * from police where First_name like '" + txtsearch.Text + "%' ", con);
                SqlDataAdapter d = new SqlDataAdapter(cmd);
                DataTable t = new DataTable();
                d.Fill(t);
                dataGridView1.DataSource = t;
                cmd.ExecuteNonQuery();

            }
            else if (cmbsearch.SelectedIndex.Equals(1))
            {
                SqlCommand cmd = new SqlCommand("select * from police where Last_Name like '" + txtsearch.Text + "%' ", con);
                SqlDataAdapter d = new SqlDataAdapter(cmd);
                DataTable t = new DataTable();
                d.Fill(t);
                dataGridView1.DataSource = t;
                cmd.ExecuteNonQuery();
            }
            else if (cmbsearch.SelectedIndex.Equals(2))
            {
                SqlCommand cmd = new SqlCommand("select * from police where username like '" + txtsearch.Text + "%' ", con);
                SqlDataAdapter d = new SqlDataAdapter(cmd);
                DataTable t = new DataTable();
                d.Fill(t);
                dataGridView1.DataSource = t;
                cmd.ExecuteNonQuery();
            }
            else if (cmbsearch.SelectedIndex.Equals(3))
            {
                SqlCommand cmd = new SqlCommand("select * from police where police_id like '" + txtsearch.Text + "%' ", con);
                SqlDataAdapter d = new SqlDataAdapter(cmd);
                DataTable t = new DataTable();
                d.Fill(t);
                dataGridView1.DataSource = t;
                cmd.ExecuteNonQuery();
            }
            else if (cmbsearch.SelectedIndex.Equals(4))
            {
                SqlCommand cmd = new SqlCommand("select * from  police where passwd like '" + txtsearch.Text + "%' ", con);
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
