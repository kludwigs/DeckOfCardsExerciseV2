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

namespace MyFirstWindowsApplications
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello " + name_txt.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = this.name_txt.Text;
            string age = this.age_txt.Text;

            MessageBox.Show("Name and Age entered: " + name + ", " + age + " " ); 

            SqlConnection con = new SqlConnection("Data Source=KARL-PC;Initial Catalog=TestDB1;Integrated Security=True");
            string insert = "INSERT INTO employee_Table (employee_name, employee_age) values('" + this.name_txt.Text + "','" + this.age_txt.Text + "') ";
            con.Open();
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=KARL-PC;Initial Catalog=TestDB1;Integrated Security=True");
            int row_count = 0;            
            int read_age = 0;
           // MessageBox.Show("sql is connected");

            SqlCommand cmd = new SqlCommand("SELECT * FROM employee_Table", con);
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                row_count++;
                MyFunction(dr["employee_ID"].ToString(), dr["employee_Name"].ToString());
                read_age += Convert.ToInt32(dr["employee_age"]);
            }
            if (row_count> 0)
            {
                MessageBox.Show("we counted " + row_count + " rows from our data base");
                MessageBox.Show("Average age is " + read_age / row_count);
            }
            con.Close();
        }
        public static void MyFunction(string Id, string Name)
        {
           MessageBox.Show("Employee (" + Id + ") has name " +Name);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=KARL-PC;Initial Catalog=TestDB1;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("TRUNCATE TABLE employee_Table", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            MessageBox.Show("Contents of Table Have been deleted");
        }
    }
}
