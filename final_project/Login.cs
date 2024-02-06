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

    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("data source = Eyakem;initial catalog = policedb ; integrated security = true;");
       // SqlConnection con = new SqlConnection("data source = Eyakem;initial catalog = policedb ; integrated security = true;");
        
        public Login()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            

            if (comboBox2.SelectedIndex == 0)
            {

                //cmd.CommandText = parameterStatment.getQuery();

                //con.Open();

                SqlCommand cmd = new SqlCommand("admin_check", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", txtId.Text);
                cmd.Parameters.AddWithValue("@passwd", txtPass.Text);
                var returnParameter = cmd.Parameters.Add("@return", SqlDbType.VarChar);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteNonQuery();
                var result = returnParameter.Value;
                con.Close();
                if (result.Equals(1))
                {


                    string Name;
                    Name = txtId.Text;
                    Admin a = new Admin();

                    a.Show();
                    this.Hide();

                   

                }
                else if (result.Equals(0))
                    MessageBox.Show("Incorrect Username or Password");



            }
            else if (comboBox2.SelectedIndex == 1)
            {
           //     con.Open();
                SqlCommand cmd = new SqlCommand("police_check", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", txtId.Text);
                cmd.Parameters.AddWithValue("@passwd", txtPass.Text);
                var returnParameter = cmd.Parameters.Add("@return", SqlDbType.VarChar);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteNonQuery();
                var result = returnParameter.Value;
                con.Close();
                if (result.Equals(1))
                {
                    string Name;
                    Name=txtId.Text;  
                   
                    Police a = new Police();
                    a.Show();
                    this.Hide();

                }
                else if (result.Equals(0))
                    MessageBox.Show("Incorrect Username or Password");


            }
            else if (comboBox2.SelectedIndex == -1)

            { MessageBox.Show("Please select a role"); }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {  


            Application.Exit();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
                panel1.BackColor = Color.Red;

            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
                panel1.BackColor = Color.Blue;

        }
    }
    }

