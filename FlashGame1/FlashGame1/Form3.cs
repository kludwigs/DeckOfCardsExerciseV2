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

namespace FlashGame1
{
    public partial class Form3 : Form
    {        
        public Form3()
        {
            InitializeComponent();
            Display_HighScores();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void Display_HighScores()
        {
            DataTable myTable = new DataTable();            
            DataRow myNewRow = myTable.NewRow();
            int count = 1;
            
            myTable.Columns.Add("Rank", typeof(int));
            myTable.Columns.Add("Name", typeof(string));
            myTable.Columns.Add("Score", typeof(string));

            SqlConnection con = new SqlConnection("Data Source=KARL-PC;Initial Catalog=TestDB2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM highscores_default ORDER BY score DESC", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
 
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                if (count <= 10)
                {
                    myNewRow = myTable.NewRow();
                    myNewRow["Rank"] = count++;
                    myNewRow["Name"] = dr["name"].ToString();
                    myNewRow["Score"] = dr["score"].ToString();
                    myTable.Rows.Add(myNewRow);
                }
            }
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = new BindingSource(myTable, null);
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();            
            Form f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
    }

}
