namespace FlashGame1
{
    partial class Form2
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
            this.argument1_label = new System.Windows.Forms.Label();
            this.argument2_label = new System.Windows.Forms.Label();
            this.submit_answer = new System.Windows.Forms.Button();
            this.answer_box = new System.Windows.Forms.TextBox();
            this.operator_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.answer_timer_lab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // argument1_label
            // 
            this.argument1_label.AutoSize = true;
            this.argument1_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.argument1_label.Location = new System.Drawing.Point(91, 51);
            this.argument1_label.Name = "argument1_label";
            this.argument1_label.Size = new System.Drawing.Size(18, 20);
            this.argument1_label.TabIndex = 0;
            this.argument1_label.Text = "?";
            // 
            // argument2_label
            // 
            this.argument2_label.AutoSize = true;
            this.argument2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.argument2_label.Location = new System.Drawing.Point(91, 126);
            this.argument2_label.Name = "argument2_label";
            this.argument2_label.Size = new System.Drawing.Size(18, 20);
            this.argument2_label.TabIndex = 1;
            this.argument2_label.Text = "?";
            // 
            // submit_answer
            // 
            this.submit_answer.Location = new System.Drawing.Point(208, 167);
            this.submit_answer.Name = "submit_answer";
            this.submit_answer.Size = new System.Drawing.Size(75, 51);
            this.submit_answer.TabIndex = 2;
            this.submit_answer.Text = "Submit";
            this.submit_answer.UseVisualStyleBackColor = true;
            this.submit_answer.Click += new System.EventHandler(this.submit_answer_Click);
            // 
            // answer_box
            // 
            this.answer_box.Location = new System.Drawing.Point(65, 183);
            this.answer_box.Name = "answer_box";
            this.answer_box.Size = new System.Drawing.Size(100, 20);
            this.answer_box.TabIndex = 3;            
            this.answer_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyDown);
            // 
            // operator_label
            // 
            this.operator_label.AutoSize = true;
            this.operator_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operator_label.Location = new System.Drawing.Point(23, 126);
            this.operator_label.Name = "operator_label";
            this.operator_label.Size = new System.Drawing.Size(18, 20);
            this.operator_label.TabIndex = 4;
            this.operator_label.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "=";
            // 
            // answer_timer_lab
            // 
            this.answer_timer_lab.AutoSize = true;
            this.answer_timer_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer_timer_lab.Location = new System.Drawing.Point(232, 9);
            this.answer_timer_lab.Name = "answer_timer_lab";
            this.answer_timer_lab.Size = new System.Drawing.Size(27, 20);
            this.answer_timer_lab.TabIndex = 6;
            this.answer_timer_lab.Text = "10";            
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 339);
            this.Controls.Add(this.answer_timer_lab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.operator_label);
            this.Controls.Add(this.answer_box);
            this.Controls.Add(this.submit_answer);
            this.Controls.Add(this.argument2_label);
            this.Controls.Add(this.argument1_label);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label argument1_label;
        private System.Windows.Forms.Label argument2_label;
        private System.Windows.Forms.Button submit_answer;
        private System.Windows.Forms.TextBox answer_box;
        private System.Windows.Forms.Label operator_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label answer_timer_lab;
    }
}