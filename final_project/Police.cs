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
    public partial class Police : Form
    {
        public Police()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void criminallabel_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Close();
            Policecases a = new Policecases();
            a.Show();
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

        private void Police_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source = Eyakem ;initial catalog = policedb ; integrated security = true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Count_cases", con);
            cmd.CommandType = CommandType.StoredProcedure;
            var returnParameter = cmd.Parameters.Add("@number", SqlDbType.VarChar);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            var result = returnParameter.Value;
            caselabel.Text = result.ToString();
            SqlCommand cmd1 = new SqlCommand("Count_criminal", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            var returnParameter1 = cmd1.Parameters.Add("@number", SqlDbType.VarChar);
            returnParameter1.Direction = ParameterDirection.ReturnValue;
            cmd1.ExecuteNonQuery();
            var result1 = returnParameter1.Value;
            criminallabel.Text = result1.ToString();
            SqlCommand cmd2 = new SqlCommand("Count_officer", con);
            cmd2.CommandType = CommandType.StoredProcedure;
            var returnParameter2 = cmd2.Parameters.Add("@number", SqlDbType.VarChar);
            returnParameter2.Direction = ParameterDirection.ReturnValue;
            cmd2.ExecuteNonQuery();
            var result2 = returnParameter2.Value;
            officerlabel.Text = result2.ToString();
            con.Close();

            label6.Text = "WELCEOME OFFICER " + Name;

        }
    }
}
