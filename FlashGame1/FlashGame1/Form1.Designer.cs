namespace FlashGame1
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
            this.start_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.highscores_but = new System.Windows.Forms.Button();
            this.clear_highscore_but = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(41, 105);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(201, 20);
            this.name_txt.TabIndex = 0;
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(251, 278);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(118, 56);
            this.start_button.TabIndex = 1;
            this.start_button.Text = "Start Game!";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Your Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // highscores_but
            // 
            this.highscores_but.Location = new System.Drawing.Point(128, 278);
            this.highscores_but.Name = "highscores_but";
            this.highscores_but.Size = new System.Drawing.Size(117, 56);
            this.highscores_but.TabIndex = 7;
            this.highscores_but.Text = "Show High Scores";
            this.highscores_but.UseVisualStyleBackColor = true;
            this.highscores_but.Click += new System.EventHandler(this.highscores_but_Click);
            // 
            // clear_highscore_but
            // 
            this.clear_highscore_but.Location = new System.Drawing.Point(20, 277);
            this.clear_highscore_but.Name = "clear_highscore_but";
            this.clear_highscore_but.Size = new System.Drawing.Size(102, 57);
            this.clear_highscore_but.TabIndex = 8;
            this.clear_highscore_but.Text = "Clear High Scores";
            this.clear_highscore_but.UseVisualStyleBackColor = true;
            this.clear_highscore_but.Click += new System.EventHandler(this.clear_highscore_but_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(94, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Welcome to Math Flash!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 386);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clear_highscore_but);
            this.Controls.Add(this.highscores_but);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.name_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button highscores_but;
        private System.Windows.Forms.Button clear_highscore_but;
        private System.Windows.Forms.Label label2;
    }
}

