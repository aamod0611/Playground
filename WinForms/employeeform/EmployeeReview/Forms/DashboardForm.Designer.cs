namespace EmployeeReview.Forms
{
    partial class DashboardForm
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
            this.components = new System.ComponentModel.Container();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDevSkills = new System.Windows.Forms.Button();
            this.btnTechSkills = new System.Windows.Forms.Button();
            this.btnViewSummary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDevSkills
            // 
            this.btnDevSkills.Location = new System.Drawing.Point(48, 38);
            this.btnDevSkills.Name = "btnDevSkills";
            this.btnDevSkills.Size = new System.Drawing.Size(162, 44);
            this.btnDevSkills.TabIndex = 0;
            this.btnDevSkills.Text = "Dev Skills";
            this.btnDevSkills.UseVisualStyleBackColor = true;
            this.btnDevSkills.Click += new System.EventHandler(this.btnDevSkills_Click);
            // 
            // btnTechSkills
            // 
            this.btnTechSkills.Location = new System.Drawing.Point(48, 103);
            this.btnTechSkills.Name = "btnTechSkills";
            this.btnTechSkills.Size = new System.Drawing.Size(162, 44);
            this.btnTechSkills.TabIndex = 1;
            this.btnTechSkills.Text = "Tech Skills";
            this.btnTechSkills.UseVisualStyleBackColor = true;
            this.btnTechSkills.Click += new System.EventHandler(this.btnTechSkills_Click);
            // 
            // btnViewSummary
            // 
            this.btnViewSummary.Location = new System.Drawing.Point(48, 170);
            this.btnViewSummary.Name = "btnViewSummary";
            this.btnViewSummary.Size = new System.Drawing.Size(162, 44);
            this.btnViewSummary.TabIndex = 2;
            this.btnViewSummary.Text = "View Summary";
            this.btnViewSummary.UseVisualStyleBackColor = true;
            this.btnViewSummary.Visible = false;
            this.btnViewSummary.Click += new System.EventHandler(this.btnViewSummary_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 272);
            this.Controls.Add(this.btnViewSummary);
            this.Controls.Add(this.btnTechSkills);
            this.Controls.Add(this.btnDevSkills);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DashboardForm";
            this.Text = "Dashboard Form";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.Button btnDevSkills;
        private System.Windows.Forms.Button btnTechSkills;
        private System.Windows.Forms.Button btnViewSummary;
    }
}

