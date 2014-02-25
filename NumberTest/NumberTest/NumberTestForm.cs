using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace NumberTest
{
    public partial class NumberTestForm : Form
    {
        ArrayList myAL = new ArrayList();
        static bool sortflag = false;
        const int MAX_VALUE = 0x7FFF;
                
        public NumberTestForm()
        {
            InitializeComponent();
        }
        /* SubmitButton_Click 
         * 
         * Method to process input from the user          
         * Called from the Submit button to add data to the list        
         */
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Process_Input();
            textInputBox1.Focus();
        }

        /* method Process_Input
         * 
         * Validates and then adds number to list
         */ 
        private void Process_Input()
        {
                int userValue;
                short newNum;

                if(int.TryParse(textInputBox1.Text, out userValue))
                {
                 // We have the value successfully, range check then add to arraylist
                    if(RangeCheck(userValue))
                    {
                        newNum = (short)userValue;
                        textInputBox1.Text = "";
                        AddToList(newNum);
                    }
                }
                else
                {
                 // We don't have the users value.
                 MessageBox.Show("Please enter an integer into the text box.");
                }
        }
        private bool RangeCheck(int value)
        {
            if(value < short.MinValue)
            {
                MessageBox.Show("Number is less than minimum value -32768 (0x8000)");
                return false;
            }
            else if (value > MAX_VALUE)
            {
                MessageBox.Show("Number is greater than maximum value 32767 (0x7FFF)");
                return false;
            }
            else
                return true;
        }
        private void AddToList(short Val)
        {
            myAL.Add(Val);
            /* With an additional entry placd at the end
             * we can't say that is list sorted so reset flag
             */ 
            sortflag = false;
            /* Confirms to the user what value is submitted */
            label1.Text = "Last Submitted: " + Val + "";            
        }
        /* DisplayButton_Click 
         * 
         * method to Called from the Display/Refresh button 
         * 
         */
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            DisplayValues();
            textInputBox1.Focus();
        }
        /* method DisplayValues
         * 
         * Primary function for displaying values
         * Calls methods to sort and display number lists
         */ 
        private void DisplayValues()
        {
            if (myAL.Count != 0)
            {
                /* If it's not sorted new entries have been added
                 * sort the list and refresh the ListView
                 */ 
                if (!sortflag)
                {
                    myAL.Sort();
                    sortflag = true;
                    PrintToListView();
                }
            }
            else
            {
                MessageBox.Show("Number List is Empty. Nothing to display");
            }
        }
        /* method: PrintToListView
         * 
         * Traverses through the array list 
         * to display to the user 
         */
        private void PrintToListView()
        {           
            listView1.Items.Clear();
            foreach (short elem in myAL)
            {
                listView1.Items.Add(new ListViewItem(elem.ToString()));                
            }           
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            /* Clear the list and the output screen */
            myAL.Clear();
            listView1.Items.Clear();
            /* reset sortflag and return the info label to default */
            sortflag = true;
            label1.Text = "Enter Input Here";
        }

        private void NumberTestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
