namespace NumberTest
{
    partial class NumberTestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.display_button = new System.Windows.Forms.Button();
            this.textInputBox1 = new System.Windows.Forms.TextBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.results_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // display_button
            // 
            this.display_button.Location = new System.Drawing.Point(26, 278);
            this.display_button.Name = "display_button";
            this.display_button.Size = new System.Drawing.Size(100, 23);
            this.display_button.TabIndex = 2;
            this.display_button.Text = "Display/Refresh";
            this.display_button.UseVisualStyleBackColor = true;
            this.display_button.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // textInputBox1
            // 
            this.textInputBox1.Location = new System.Drawing.Point(26, 19);
            this.textInputBox1.Name = "textInputBox1";
            this.textInputBox1.Size = new System.Drawing.Size(100, 20);
            this.textInputBox1.TabIndex = 0;
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(132, 16);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(75, 23);
            this.submit_button.TabIndex = 1;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(26, 68);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(254, 199);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter input here";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(189, 278);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(91, 23);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // results_label
            // 
            this.results_label.AutoSize = true;
            this.results_label.Location = new System.Drawing.Point(26, 49);
            this.results_label.Name = "results_label";
            this.results_label.Size = new System.Drawing.Size(42, 13);
            this.results_label.TabIndex = 6;
            this.results_label.Text = "Results";
            // 
            // NumberTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 322);
            this.Controls.Add(this.results_label);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.display_button);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.textInputBox1);
            this.Name = "NumberTestForm";
            this.Text = "Enter Numbers To Display in Ascending Order";
            this.Load += new System.EventHandler(this.NumberTestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textInputBox1;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button display_button;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label results_label;
    }
}

