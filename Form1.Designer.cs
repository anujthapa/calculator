namespace calculator
{
    partial class frm_Calculator
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
            this.btn_seven = new System.Windows.Forms.Button();
            this.btn_eight = new System.Windows.Forms.Button();
            this.btn_nine = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_onoff = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_six = new System.Windows.Forms.Button();
            this.btn_five = new System.Windows.Forms.Button();
            this.btn_four = new System.Windows.Forms.Button();
            this.btn_equals = new System.Windows.Forms.Button();
            this.btn_substraction = new System.Windows.Forms.Button();
            this.btn_three = new System.Windows.Forms.Button();
            this.btn_two = new System.Windows.Forms.Button();
            this.btn_one = new System.Windows.Forms.Button();
            this.btn_sum = new System.Windows.Forms.Button();
            this.btn_point = new System.Windows.Forms.Button();
            this.btn_zero = new System.Windows.Forms.Button();
            this.txtbox_display = new System.Windows.Forms.TextBox();
            this.lbl_process = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_seven
            // 
            this.btn_seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seven.Location = new System.Drawing.Point(17, 117);
            this.btn_seven.Name = "btn_seven";
            this.btn_seven.Size = new System.Drawing.Size(45, 45);
            this.btn_seven.TabIndex = 0;
            this.btn_seven.Text = "7";
            this.btn_seven.UseVisualStyleBackColor = true;
            this.btn_seven.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_eight
            // 
            this.btn_eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eight.Location = new System.Drawing.Point(80, 117);
            this.btn_eight.Name = "btn_eight";
            this.btn_eight.Size = new System.Drawing.Size(45, 45);
            this.btn_eight.TabIndex = 1;
            this.btn_eight.Text = "8";
            this.btn_eight.UseVisualStyleBackColor = true;
            this.btn_eight.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_nine
            // 
            this.btn_nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nine.Location = new System.Drawing.Point(144, 117);
            this.btn_nine.Name = "btn_nine";
            this.btn_nine.Size = new System.Drawing.Size(45, 45);
            this.btn_nine.TabIndex = 2;
            this.btn_nine.Text = "9";
            this.btn_nine.UseVisualStyleBackColor = true;
            this.btn_nine.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_divide
            // 
            this.btn_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_divide.Location = new System.Drawing.Point(205, 117);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(45, 45);
            this.btn_divide.TabIndex = 3;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.operator_Click);
            // 
            // btn_onoff
            // 
            this.btn_onoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_onoff.Location = new System.Drawing.Point(266, 117);
            this.btn_onoff.Name = "btn_onoff";
            this.btn_onoff.Size = new System.Drawing.Size(45, 45);
            this.btn_onoff.TabIndex = 4;
            this.btn_onoff.Text = "CE";
            this.btn_onoff.UseVisualStyleBackColor = true;
            this.btn_onoff.Click += new System.EventHandler(this.btn_onoff_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(266, 180);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(45, 45);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "c";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiply.Location = new System.Drawing.Point(205, 180);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(45, 45);
            this.btn_multiply.TabIndex = 8;
            this.btn_multiply.Text = "*";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.operator_Click);
            // 
            // btn_six
            // 
            this.btn_six.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_six.Location = new System.Drawing.Point(144, 180);
            this.btn_six.Name = "btn_six";
            this.btn_six.Size = new System.Drawing.Size(45, 45);
            this.btn_six.TabIndex = 7;
            this.btn_six.Text = "6";
            this.btn_six.UseVisualStyleBackColor = true;
            this.btn_six.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_five
            // 
            this.btn_five.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_five.Location = new System.Drawing.Point(80, 180);
            this.btn_five.Name = "btn_five";
            this.btn_five.Size = new System.Drawing.Size(45, 45);
            this.btn_five.TabIndex = 6;
            this.btn_five.Text = "5";
            this.btn_five.UseVisualStyleBackColor = true;
            this.btn_five.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_four
            // 
            this.btn_four.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_four.Location = new System.Drawing.Point(17, 180);
            this.btn_four.Name = "btn_four";
            this.btn_four.Size = new System.Drawing.Size(45, 45);
            this.btn_four.TabIndex = 5;
            this.btn_four.Text = "4";
            this.btn_four.UseVisualStyleBackColor = true;
            this.btn_four.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_equals
            // 
            this.btn_equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_equals.Location = new System.Drawing.Point(266, 242);
            this.btn_equals.Name = "btn_equals";
            this.btn_equals.Size = new System.Drawing.Size(45, 106);
            this.btn_equals.TabIndex = 14;
            this.btn_equals.Text = "=";
            this.btn_equals.UseVisualStyleBackColor = true;
            this.btn_equals.Click += new System.EventHandler(this.btn_equals_Click);
            // 
            // btn_substraction
            // 
            this.btn_substraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_substraction.Location = new System.Drawing.Point(205, 242);
            this.btn_substraction.Name = "btn_substraction";
            this.btn_substraction.Size = new System.Drawing.Size(45, 45);
            this.btn_substraction.TabIndex = 13;
            this.btn_substraction.Text = "-";
            this.btn_substraction.UseVisualStyleBackColor = true;
            this.btn_substraction.Click += new System.EventHandler(this.operator_Click);
            // 
            // btn_three
            // 
            this.btn_three.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_three.Location = new System.Drawing.Point(144, 242);
            this.btn_three.Name = "btn_three";
            this.btn_three.Size = new System.Drawing.Size(45, 45);
            this.btn_three.TabIndex = 12;
            this.btn_three.Text = "3";
            this.btn_three.UseVisualStyleBackColor = true;
            this.btn_three.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_two
            // 
            this.btn_two.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_two.Location = new System.Drawing.Point(80, 242);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(45, 45);
            this.btn_two.TabIndex = 11;
            this.btn_two.Text = "2";
            this.btn_two.UseVisualStyleBackColor = true;
            this.btn_two.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_one
            // 
            this.btn_one.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_one.Location = new System.Drawing.Point(17, 242);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(45, 45);
            this.btn_one.TabIndex = 10;
            this.btn_one.Text = "1";
            this.btn_one.UseVisualStyleBackColor = true;
            this.btn_one.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_sum
            // 
            this.btn_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sum.Location = new System.Drawing.Point(205, 303);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(45, 45);
            this.btn_sum.TabIndex = 18;
            this.btn_sum.Text = "+";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.operator_Click);
            // 
            // btn_point
            // 
            this.btn_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_point.Location = new System.Drawing.Point(144, 303);
            this.btn_point.Name = "btn_point";
            this.btn_point.Size = new System.Drawing.Size(45, 45);
            this.btn_point.TabIndex = 17;
            this.btn_point.Text = ".";
            this.btn_point.UseVisualStyleBackColor = true;
            this.btn_point.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_zero
            // 
            this.btn_zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zero.Location = new System.Drawing.Point(17, 303);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(108, 45);
            this.btn_zero.TabIndex = 15;
            this.btn_zero.Text = "0";
            this.btn_zero.UseVisualStyleBackColor = true;
            this.btn_zero.Click += new System.EventHandler(this.btn_click);
            // 
            // txtbox_display
            // 
            this.txtbox_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_display.Location = new System.Drawing.Point(17, 64);
            this.txtbox_display.Name = "txtbox_display";
            this.txtbox_display.Size = new System.Drawing.Size(292, 38);
            this.txtbox_display.TabIndex = 19;
            this.txtbox_display.Text = "0";
            this.txtbox_display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_process
            // 
            this.lbl_process.AutoSize = true;
            this.lbl_process.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_process.Location = new System.Drawing.Point(12, 29);
            this.lbl_process.Name = "lbl_process";
            this.lbl_process.Size = new System.Drawing.Size(0, 32);
            this.lbl_process.TabIndex = 20;
            // 
            // frm_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 366);
            this.Controls.Add(this.lbl_process);
            this.Controls.Add(this.txtbox_display);
            this.Controls.Add(this.btn_sum);
            this.Controls.Add(this.btn_point);
            this.Controls.Add(this.btn_zero);
            this.Controls.Add(this.btn_equals);
            this.Controls.Add(this.btn_substraction);
            this.Controls.Add(this.btn_three);
            this.Controls.Add(this.btn_two);
            this.Controls.Add(this.btn_one);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_six);
            this.Controls.Add(this.btn_five);
            this.Controls.Add(this.btn_four);
            this.Controls.Add(this.btn_onoff);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_nine);
            this.Controls.Add(this.btn_eight);
            this.Controls.Add(this.btn_seven);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_seven;
        private System.Windows.Forms.Button btn_eight;
        private System.Windows.Forms.Button btn_nine;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_onoff;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_six;
        private System.Windows.Forms.Button btn_five;
        private System.Windows.Forms.Button btn_four;
        private System.Windows.Forms.Button btn_equals;
        private System.Windows.Forms.Button btn_substraction;
        private System.Windows.Forms.Button btn_three;
        private System.Windows.Forms.Button btn_two;
        private System.Windows.Forms.Button btn_one;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Button btn_point;
        private System.Windows.Forms.Button btn_zero;
        private System.Windows.Forms.TextBox txtbox_display;
        private System.Windows.Forms.Label lbl_process;
    }
}

