using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace FlashGame1
{
    public partial class Form2 : Form
    {
        int answer_counter = 10;
        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        int question_answer;
        int num_questions = 5;
        Contestant player1;  
  
        public Form2(string name)
        {
            InitializeComponent();                   
            myTimer.Tick += new EventHandler(OnTimedEvent);
            // Set the Interval to 1 second.
            myTimer.Interval = 1000;            
            player1 = new Contestant(name);            
            MessageBox.Show("Okay " + player1.name + " Let's get ready to play");            
            Generate_question();            
            this.ActiveControl = answer_box;
            answer_box.Focus();
            myTimer.Start();            
        }

        void tb_KeyDown(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                process_answer();
            }
        }

        private void submit_answer_Click(object sender, EventArgs e)
        {
            process_answer();          
        }
        public void OnTimedEvent(object source, EventArgs e)
        {
            if (answer_counter > 0)
            {
                answer_counter--;            
            }
            else if (answer_counter == 0)
            {
                answer_counter = 10;
                myTimer.Stop();
                MessageBox.Show("Sorry you ran out of time to answer the question");

                if (QuestionsRemaining())
                {
                    SetUpNextQuestion();
                }
                else
                    Game_CleanUp();
            }
            answer_timer_lab.Text = Convert.ToString(answer_counter);
            
        }
        public void Generate_question()
        {            
            int arg1, arg2;
            Random random = new Random();
            arg1 = random.Next(1, 20); 
            arg2 = random.Next(1, 20);
            argument1_label.Text = Convert.ToString(arg1);
            argument2_label.Text = Convert.ToString(arg2);
            operator_label.Text = "+";
            question_answer = arg1 + arg2;
        }
        public bool QuestionsRemaining()
        {
            if (num_questions > 0)
                return true;
            else
                return false;
        }
        public void Game_CleanUp()
        {
            MessageBox.Show("Thanks For playing "+player1.name+"! You scored " +player1.highscore + " points");
            Save_User(player1.name, player1.highscore);
            Display_Scores();            
            Application.Exit();
        }
        public void SetUpNextQuestion()
        {
            num_questions--;
            answer_counter = 10;
            answer_box.Text = "";            
            Generate_question();
            answer_box.Focus();
            myTimer.Start();
        }
        public void process_answer()
        {
            int submitted_answer;         

            if (myTimer.Enabled)
            {
                myTimer.Stop();
                 
                try
                {
                    submitted_answer = Convert.ToInt32(answer_box.Text);                                              
           
                    if (submitted_answer == question_answer)
                    {
                        MessageBox.Show("You Guessed RIGHT! Answer was " + question_answer);
                        player1.highscore += Convert.ToInt32(answer_timer_lab.Text);
                    }
                    else
                        MessageBox.Show("You Guessed WRONG! Answer was " + question_answer);

                }
                catch 
                {
                    MessageBox.Show("That's Wrong! Answer must be in a number format");
                }   

                if (QuestionsRemaining())
                {
                    SetUpNextQuestion();
                }
                else
                    Game_CleanUp();
            }  
        }
        public void Save_User(string name, int high_score)
        {          
            SqlConnection con = new SqlConnection("Data Source=KARL-PC;Initial Catalog=TestDB2;Integrated Security=True");
            string insert = "INSERT INTO highscores_default (name, score) values('" + name + "','" + high_score +"') ";
            con.Open();
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Display_Scores()
        {
            this.Hide();
            Form f3 = new Form3();
            f3.ShowDialog();
            this.Close();
        }        
    }

    public class Contestant
    {
        public int highscore;
        public string name;
   
        public Contestant(string name1)
        {
            name = name1;
            highscore = 0;
        }       
    }
}
