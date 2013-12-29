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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Contestant player1 = new Contestant(name_txt.Text); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void start_button_Click(object sender, EventArgs e)
        {            
            this.Hide();            
            Form f2 = new Form2(name_txt.Text);
            f2.ShowDialog();

        }

        private void highscores_but_Click(object sender, EventArgs e)
        {
            this.Hide();            
            Form f3 = new Form3();            
            f3.ShowDialog();
            this.Close();
        }

       /****************************************************/
        	


        /*****************************************************/

        private void clear_highscore_but_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=KARL-PC;Initial Catalog=TestDB2;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("TRUNCATE TABLE highscores_default", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            MessageBox.Show("Contents of Table Have been deleted");
        }        
    }
}
