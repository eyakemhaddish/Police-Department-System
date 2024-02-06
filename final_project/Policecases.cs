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
    public partial class Policecases : Form
    {
        SqlConnection con = new SqlConnection("data source = Eyakem;initial catalog = policedb ; integrated security = true;");
        public Policecases()
        {
            InitializeComponent();
        }

        private void Policecases_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'policedbDataSet5.cases' table. You can move, or remove it, as needed.
            this.casesTableAdapter.Fill(this.policedbDataSet5.cases);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            cmbtype.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtdetail.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            date.Text    = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtplace.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            cmbcid.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            cmbpid.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void cmbtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtplace_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdetail_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbcid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbpid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Click(object sender, EventArgs e)
        {
            Close();
           Policecriminal a = new Policecriminal();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Login a = new Login();
            a.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Close();
            Police a = new Police();    
            a.Show();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("data source = Eyakem;initial catalog = policedb ; integrated security = true;");
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
