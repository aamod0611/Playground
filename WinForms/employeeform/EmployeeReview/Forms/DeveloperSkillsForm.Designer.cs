namespace EmployeeReview.Forms
{
    partial class DeveloperSkillsForm
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
            this.btnNext = new System.Windows.Forms.Button();
            this.lblDevSkillName = new System.Windows.Forms.Label();
            this.rbUnsatisfactory = new System.Windows.Forms.RadioButton();
            this.rbNeedsImprovement = new System.Windows.Forms.RadioButton();
            this.rbMeetsExpectations = new System.Windows.Forms.RadioButton();
            this.rbAboveExpectations = new System.Windows.Forms.RadioButton();
            this.rbOutstanding = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(12, 251);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(230, 37);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblDevSkillName
            // 
            this.lblDevSkillName.AutoSize = true;
            this.lblDevSkillName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevSkillName.Location = new System.Drawing.Point(12, 9);
            this.lblDevSkillName.Name = "lblDevSkillName";
            this.lblDevSkillName.Size = new System.Drawing.Size(0, 20);
            this.lblDevSkillName.TabIndex = 16;
            // 
            // rbUnsatisfactory
            // 
            this.rbUnsatisfactory.AutoSize = true;
            this.rbUnsatisfactory.Location = new System.Drawing.Point(55, 206);
            this.rbUnsatisfactory.Name = "rbUnsatisfactory";
            this.rbUnsatisfactory.Size = new System.Drawing.Size(92, 17);
            this.rbUnsatisfactory.TabIndex = 14;
            this.rbUnsatisfactory.TabStop = true;
            this.rbUnsatisfactory.Text = "Unsatisfactory";
            this.rbUnsatisfactory.UseVisualStyleBackColor = true;
            // 
            // rbNeedsImprovement
            // 
            this.rbNeedsImprovement.AutoSize = true;
            this.rbNeedsImprovement.Location = new System.Drawing.Point(55, 167);
            this.rbNeedsImprovement.Name = "rbNeedsImprovement";
            this.rbNeedsImprovement.Size = new System.Drawing.Size(120, 17);
            this.rbNeedsImprovement.TabIndex = 13;
            this.rbNeedsImprovement.TabStop = true;
            this.rbNeedsImprovement.Text = "Needs Improvement";
            this.rbNeedsImprovement.UseVisualStyleBackColor = true;
            // 
            // rbMeetsExpectations
            // 
            this.rbMeetsExpectations.AutoSize = true;
            this.rbMeetsExpectations.Location = new System.Drawing.Point(55, 130);
            this.rbMeetsExpectations.Name = "rbMeetsExpectations";
            this.rbMeetsExpectations.Size = new System.Drawing.Size(118, 17);
            this.rbMeetsExpectations.TabIndex = 12;
            this.rbMeetsExpectations.TabStop = true;
            this.rbMeetsExpectations.Text = "Meets Expectations";
            this.rbMeetsExpectations.UseVisualStyleBackColor = true;
            // 
            // rbAboveExpectations
            // 
            this.rbAboveExpectations.AutoSize = true;
            this.rbAboveExpectations.Location = new System.Drawing.Point(55, 91);
            this.rbAboveExpectations.Name = "rbAboveExpectations";
            this.rbAboveExpectations.Size = new System.Drawing.Size(120, 17);
            this.rbAboveExpectations.TabIndex = 11;
            this.rbAboveExpectations.TabStop = true;
            this.rbAboveExpectations.Text = "Above Expectations";
            this.rbAboveExpectations.UseVisualStyleBackColor = true;
            // 
            // rbOutstanding
            // 
            this.rbOutstanding.AutoSize = true;
            this.rbOutstanding.Location = new System.Drawing.Point(55, 57);
            this.rbOutstanding.Name = "rbOutstanding";
            this.rbOutstanding.Size = new System.Drawing.Size(82, 17);
            this.rbOutstanding.TabIndex = 10;
            this.rbOutstanding.TabStop = true;
            this.rbOutstanding.Text = "Outstanding";
            this.rbOutstanding.UseVisualStyleBackColor = true;
            this.rbOutstanding.CheckedChanged += new System.EventHandler(this.rbOutstanding_CheckedChanged);
            // 
            // DeveloperSkillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 307);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblDevSkillName);
            this.Controls.Add(this.rbUnsatisfactory);
            this.Controls.Add(this.rbNeedsImprovement);
            this.Controls.Add(this.rbMeetsExpectations);
            this.Controls.Add(this.rbAboveExpectations);
            this.Controls.Add(this.rbOutstanding);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeveloperSkillsForm";
            this.Text = "DeveloperSkills";
            this.Load += new System.EventHandler(this.DeveloperSkills_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblDevSkillName;
        private System.Windows.Forms.RadioButton rbUnsatisfactory;
        private System.Windows.Forms.RadioButton rbNeedsImprovement;
        private System.Windows.Forms.RadioButton rbMeetsExpectations;
        private System.Windows.Forms.RadioButton rbAboveExpectations;
        private System.Windows.Forms.RadioButton rbOutstanding;
    }
}