namespace Calculator
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
            this.result = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.opration_add = new System.Windows.Forms.Button();
            this.opration_sub = new System.Windows.Forms.Button();
            this.opration_div = new System.Windows.Forms.Button();
            this.opration_mult = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.operation_back = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.operation_equal = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.Dock = System.Windows.Forms.DockStyle.Top;
            this.result.Location = new System.Drawing.Point(0, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(413, 20);
            this.result.TabIndex = 0;
            this.result.Text = "0";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.result.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.opration_add);
            this.flowLayoutPanel1.Controls.Add(this.opration_sub);
            this.flowLayoutPanel1.Controls.Add(this.opration_div);
            this.flowLayoutPanel1.Controls.Add(this.opration_mult);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(308, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(105, 255);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // opration_add
            // 
            this.opration_add.Location = new System.Drawing.Point(3, 3);
            this.opration_add.Name = "opration_add";
            this.opration_add.Size = new System.Drawing.Size(97, 45);
            this.opration_add.TabIndex = 9;
            this.opration_add.Text = "+";
            this.opration_add.UseVisualStyleBackColor = true;
            this.opration_add.Click += new System.EventHandler(this.btnOperation_Add_Click);
            // 
            // opration_sub
            // 
            this.opration_sub.Location = new System.Drawing.Point(3, 54);
            this.opration_sub.Name = "opration_sub";
            this.opration_sub.Size = new System.Drawing.Size(97, 45);
            this.opration_sub.TabIndex = 10;
            this.opration_sub.Text = "-";
            this.opration_sub.UseVisualStyleBackColor = true;
            this.opration_sub.Click += new System.EventHandler(this.opration_sub1);
            // 
            // opration_div
            // 
            this.opration_div.Location = new System.Drawing.Point(3, 105);
            this.opration_div.Name = "opration_div";
            this.opration_div.Size = new System.Drawing.Size(97, 45);
            this.opration_div.TabIndex = 11;
            this.opration_div.Text = "/";
            this.opration_div.UseVisualStyleBackColor = true;
            this.opration_div.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // opration_mult
            // 
            this.opration_mult.Location = new System.Drawing.Point(3, 156);
            this.opration_mult.Name = "opration_mult";
            this.opration_mult.Size = new System.Drawing.Size(97, 38);
            this.opration_mult.TabIndex = 12;
            this.opration_mult.Text = "*";
            this.opration_mult.UseVisualStyleBackColor = true;
            this.opration_mult.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btn3);
            this.flowLayoutPanel2.Controls.Add(this.btn6);
            this.flowLayoutPanel2.Controls.Add(this.btn9);
            this.flowLayoutPanel2.Controls.Add(this.button19);
            this.flowLayoutPanel2.Controls.Add(this.operation_back);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(203, 20);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(105, 255);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(3, 3);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(97, 45);
            this.btn3.TabIndex = 7;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNum_3_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(3, 54);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(97, 45);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(3, 105);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(97, 45);
            this.btn9.TabIndex = 12;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.button16_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(3, 156);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(102, 38);
            this.button19.TabIndex = 13;
            this.button19.Text = "c";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // operation_back
            // 
            this.operation_back.Location = new System.Drawing.Point(3, 200);
            this.operation_back.Name = "operation_back";
            this.operation_back.Size = new System.Drawing.Size(102, 43);
            this.operation_back.TabIndex = 14;
            this.operation_back.Text = "backspace";
            this.operation_back.UseVisualStyleBackColor = true;
            this.operation_back.Click += new System.EventHandler(this.btn_backspace);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btn2);
            this.flowLayoutPanel3.Controls.Add(this.btn5);
            this.flowLayoutPanel3.Controls.Add(this.btn8);
            this.flowLayoutPanel3.Controls.Add(this.btn0);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(98, 20);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(105, 255);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(3, 3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(97, 45);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNum_2_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(3, 54);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(97, 45);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(3, 105);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(97, 45);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.button15_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(3, 156);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(97, 38);
            this.btn0.TabIndex = 8;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.button18_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(0, 24);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(97, 44);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNum_1_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(0, 74);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(97, 45);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(0, 125);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(97, 45);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.button7_Click);
            // 
            // operation_equal
            // 
            this.operation_equal.Location = new System.Drawing.Point(0, 176);
            this.operation_equal.Name = "operation_equal";
            this.operation_equal.Size = new System.Drawing.Size(97, 38);
            this.operation_equal.TabIndex = 8;
            this.operation_equal.Text = "=";
            this.operation_equal.UseVisualStyleBackColor = true;
            this.operation_equal.Click += new System.EventHandler(this.btnOperation_Equals_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(413, 275);
            this.Controls.Add(this.operation_equal);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.result);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnOperation_Add;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnNum_6;
        private System.Windows.Forms.Button btnNum_3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnNum_5;
        private System.Windows.Forms.Button btnNum_2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNum_4;
        private System.Windows.Forms.Button btnNum_1;
        private System.Windows.Forms.Button btnOperation_Equals;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNum_9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnNum_8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnNum_7;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button opration_add;
        private System.Windows.Forms.Button opration_sub;
        private System.Windows.Forms.Button opration_div;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button opration_mult;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button operation_equal;
        private System.Windows.Forms.Button operation_back;
    }
}

