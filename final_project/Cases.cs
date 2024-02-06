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
    public partial class Cases : Form
    {
        public Cases()
        {
            InitializeComponent();
        }

        private void Cases_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'policedbDataSet12.police' table. You can move, or remove it, as needed.
            this.policeTableAdapter.Fill(this.policedbDataSet12.police);
            // TODO: This line of code loads data into the 'policedbDataSet11.criminals' table. You can move, or remove it, as needed.
            this.criminalsTableAdapter1.Fill(this.policedbDataSet11.criminals);
            // TODO: This line of code loads data into the 'policedbDataSet10.criminals' table. You can move, or remove it, as needed.
            this.criminalsTableAdapter.Fill(this.policedbDataSet10.criminals);
            // TODO: This line of code loads data into the 'policedbDataSet.cases' table. You can move, or remove it, as needed.
            this.casesTableAdapter.Fill(this.policedbDataSet.cases);

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

            Login a = new Login();
            a.Show();
        }

        private void clickofficer(object sender, EventArgs e)
        {
            Close();
            Officer a = new Officer();
            a.Show();
        }

        private void clickcrime(object sender, EventArgs e)
        {
            Close();
            Criminals a = new Criminals();
            a.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void statisticclick(object sender, EventArgs e)
        {
            Close();
            Admin a = new Admin();
            a.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source =Eyakem;initial catalog = policedb ; integrated security = true;");
            con.Open();
            String s1 = cmbcid.SelectedItem.ToString();
            String s2 = cmbpid.SelectedItem.ToString(); 
            SqlCommand cmd = new SqlCommand("Add_case", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@type", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@detail", txtdetail.Text);
            cmd.Parameters.AddWithValue("@date", date.Value );
            cmd.Parameters.AddWithValue("@place", txtplace.Text);
            cmd.Parameters.AddWithValue("@cid", Convert.ToInt32(cmbcid.SelectedValue));
            cmd.Parameters.AddWithValue("@pid", Convert.ToInt32(cmbpid.SelectedValue));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registered Successfully");
            this.casesTableAdapter.Fill(this.policedbDataSet.cases);
            con.Close();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source = Eyakem;initial catalog = policedb ; integrated security = true;");
            con.Open();
            if (cmbsearch.SelectedIndex.Equals(0))
            {
                SqlCommand cmd = new SqlCommand("select * from cases where case_id like '" + txtsearch.Text + "%' ", con);
                SqlDataAdapter d = new SqlDataAdapter(cmd);
                DataTable t = new DataTable();
                d.Fill(t);
                dataGridView1.DataSource = t;
                cmd.ExecuteNonQuery();

            }
            else if (cmbsearch.SelectedIndex.Equals(1))
            {
                SqlCommand cmd = new SqlCommand("select * from cases where CaseType like '" + txtsearch.Text + "%' ", con);
                SqlDataAdapter d = new SqlDataAdapter(cmd);
                DataTable t = new DataTable();
                d.Fill(t);
                dataGridView1.DataSource = t;
                cmd.ExecuteNonQuery();
            }
            else if (cmbsearch.SelectedIndex.Equals(2))
            {
                SqlCommand cmd = new SqlCommand("select * from cases where CaseDetail like '" + txtsearch.Text + "%' ", con);
                SqlDataAdapter d = new SqlDataAdapter(cmd);
                DataTable t = new DataTable();
                d.Fill(t);
                dataGridView1.DataSource = t;
                cmd.ExecuteNonQuery();
            }
            else if (cmbsearch.SelectedIndex.Equals(3))
            {
                SqlCommand cmd = new SqlCommand("select * from cases where CaseDate like '" + txtsearch.Text + "%' ", con);
                SqlDataAdapter d = new SqlDataAdapter(cmd);
                DataTable t = new DataTable();
                d.Fill(t);
                dataGridView1.DataSource = t;
                cmd.ExecuteNonQuery();
            }
            else if (cmbsearch.SelectedIndex.Equals(4))
            {
                SqlCommand cmd = new SqlCommand("select * from cases where Caseplace like '" + txtsearch.Text + "%' ", con);
                SqlDataAdapter d = new SqlDataAdapter(cmd);
                DataTable t = new DataTable();
                d.Fill(t);
                dataGridView1.DataSource = t;
                cmd.ExecuteNonQuery();
            }
            
            else if (cmbsearch.SelectedIndex.Equals(5))
            {
                SqlCommand cmd = new SqlCommand("select * from cases where criminal_id like '" + txtsearch.Text + "%' ", con);
                SqlDataAdapter d = new SqlDataAdapter(cmd);
                DataTable t = new DataTable();
                d.Fill(t);
                dataGridView1.DataSource = t;
                cmd.ExecuteNonQuery();
            }
            else if (cmbsearch.SelectedIndex.Equals(6))
            {
                SqlCommand cmd = new SqlCommand("select * from cases where police_id like '" + txtsearch.Text + "%' ", con);
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
