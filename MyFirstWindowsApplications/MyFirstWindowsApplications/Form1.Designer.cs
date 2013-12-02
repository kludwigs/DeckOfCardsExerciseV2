namespace MyFirstWindowsApplications
{
    partial class Form1
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
            this.name_txt = new System.Windows.Forms.TextBox();
            this.Customer1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.doStuff = new System.Windows.Forms.Button();
            this.age_txt = new System.Windows.Forms.TextBox();
            this.agetxt = new System.Windows.Forms.Label();
            this.button_del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(118, 23);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(100, 20);
            this.name_txt.TabIndex = 1;
            // 
            // Customer1
            // 
            this.Customer1.AutoSize = true;
            this.Customer1.Location = new System.Drawing.Point(30, 23);
            this.Customer1.Name = "Customer1";
            this.Customer1.Size = new System.Drawing.Size(82, 13);
            this.Customer1.TabIndex = 4;
            this.Customer1.Text = "Customer Name";
            this.Customer1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // doStuff
            // 
            this.doStuff.Location = new System.Drawing.Point(66, 414);
            this.doStuff.Name = "doStuff";
            this.doStuff.Size = new System.Drawing.Size(247, 23);
            this.doStuff.TabIndex = 20;
            this.doStuff.Text = "Show All";
            this.doStuff.UseVisualStyleBackColor = true;
            this.doStuff.Click += new System.EventHandler(this.button2_Click);
            // 
            // age_txt
            // 
            this.age_txt.Location = new System.Drawing.Point(118, 49);
            this.age_txt.Name = "age_txt";
            this.age_txt.Size = new System.Drawing.Size(100, 20);
            this.age_txt.TabIndex = 21;
            // 
            // agetxt
            // 
            this.agetxt.AutoSize = true;
            this.agetxt.Location = new System.Drawing.Point(30, 52);
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(26, 13);
            this.agetxt.TabIndex = 22;
            this.agetxt.Text = "Age";
            this.agetxt.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(66, 352);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(247, 25);
            this.button_del.TabIndex = 23;
            this.button_del.Text = "Delete All";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 445);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.agetxt);
            this.Controls.Add(this.age_txt);
            this.Controls.Add(this.doStuff);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Customer1);
            this.Controls.Add(this.name_txt);
            this.Name = "Form1";
            this.Text = "Customer Data Entry Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label Customer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button doStuff;
        private System.Windows.Forms.TextBox age_txt;
        private System.Windows.Forms.Label agetxt;
        private System.Windows.Forms.Button button_del;
    }
}

