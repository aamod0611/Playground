namespace EmployeeReview1.Forms
{
    partial class TechnicalSkillsForm
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
            this.rb_Expert = new System.Windows.Forms.RadioButton();
            this.rb_proficient = new System.Windows.Forms.RadioButton();
            this.rb_Intermediate = new System.Windows.Forms.RadioButton();
            this.rb_beginner = new System.Windows.Forms.RadioButton();
            this.btn_next = new System.Windows.Forms.Button();
            this.lbltechSkillName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rb_Expert
            // 
            this.rb_Expert.AutoSize = true;
            this.rb_Expert.Checked = true;
            this.rb_Expert.Location = new System.Drawing.Point(77, 41);
            this.rb_Expert.Name = "rb_Expert";
            this.rb_Expert.Size = new System.Drawing.Size(55, 17);
            this.rb_Expert.TabIndex = 0;
            this.rb_Expert.TabStop = true;
            this.rb_Expert.Text = "Expert";
            this.rb_Expert.UseVisualStyleBackColor = true;
            this.rb_Expert.CheckedChanged += new System.EventHandler(this.rb_Expert_CheckedChanged);
            // 
            // rb_proficient
            // 
            this.rb_proficient.AutoSize = true;
            this.rb_proficient.Location = new System.Drawing.Point(77, 77);
            this.rb_proficient.Name = "rb_proficient";
            this.rb_proficient.Size = new System.Drawing.Size(69, 17);
            this.rb_proficient.TabIndex = 1;
            this.rb_proficient.Text = "Proficient";
            this.rb_proficient.UseVisualStyleBackColor = true;
            this.rb_proficient.CheckedChanged += new System.EventHandler(this.rb_proficient_CheckedChanged);
            // 
            // rb_Intermediate
            // 
            this.rb_Intermediate.AutoSize = true;
            this.rb_Intermediate.Location = new System.Drawing.Point(77, 112);
            this.rb_Intermediate.Name = "rb_Intermediate";
            this.rb_Intermediate.Size = new System.Drawing.Size(83, 17);
            this.rb_Intermediate.TabIndex = 2;
            this.rb_Intermediate.Text = "Intermediate";
            this.rb_Intermediate.UseVisualStyleBackColor = true;
            this.rb_Intermediate.CheckedChanged += new System.EventHandler(this.rb_Intermediate_CheckedChanged);
            // 
            // rb_beginner
            // 
            this.rb_beginner.AutoSize = true;
            this.rb_beginner.Location = new System.Drawing.Point(77, 147);
            this.rb_beginner.Name = "rb_beginner";
            this.rb_beginner.Size = new System.Drawing.Size(67, 17);
            this.rb_beginner.TabIndex = 3;
            this.rb_beginner.Text = "Beginner";
            this.rb_beginner.UseVisualStyleBackColor = true;
            this.rb_beginner.CheckedChanged += new System.EventHandler(this.rb_beginner_CheckedChanged);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(12, 203);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(248, 37);
            this.btn_next.TabIndex = 4;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lbltechSkillName
            // 
            this.lbltechSkillName.AutoSize = true;
            this.lbltechSkillName.Location = new System.Drawing.Point(13, 13);
            this.lbltechSkillName.Name = "lbltechSkillName";
            this.lbltechSkillName.Size = new System.Drawing.Size(0, 13);
            this.lbltechSkillName.TabIndex = 5;
            // 
            // TechnicalSkillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 261);
            this.Controls.Add(this.lbltechSkillName);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.rb_beginner);
            this.Controls.Add(this.rb_Intermediate);
            this.Controls.Add(this.rb_proficient);
            this.Controls.Add(this.rb_Expert);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TechnicalSkillsForm";
            this.Text = "C#";
            this.Load += new System.EventHandler(this.TechnicalSkillsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_Expert;
        private System.Windows.Forms.RadioButton rb_proficient;
        private System.Windows.Forms.RadioButton rb_Intermediate;
        private System.Windows.Forms.RadioButton rb_beginner;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label lbltechSkillName;
    }
}