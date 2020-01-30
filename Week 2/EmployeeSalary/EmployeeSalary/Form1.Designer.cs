namespace EmployeeSalary
{
    partial class EmployeeSalaryForm
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
            this.inputLabel = new System.Windows.Forms.Label();
            this.currentSalaryTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.futureSalaryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.BackColor = System.Drawing.SystemColors.Info;
            this.inputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inputLabel.Location = new System.Drawing.Point(217, 46);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(325, 27);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Enter Your Current Salary Below\r\n";
            // 
            // currentSalaryTextBox
            // 
            this.currentSalaryTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.currentSalaryTextBox.Location = new System.Drawing.Point(283, 90);
            this.currentSalaryTextBox.Name = "currentSalaryTextBox";
            this.currentSalaryTextBox.Size = new System.Drawing.Size(200, 31);
            this.currentSalaryTextBox.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.submitButton.Location = new System.Drawing.Point(237, 244);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(293, 76);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Click To See Your\r\nFuture Salary";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // futureSalaryLabel
            // 
            this.futureSalaryLabel.AutoSize = true;
            this.futureSalaryLabel.Location = new System.Drawing.Point(232, 342);
            this.futureSalaryLabel.Name = "futureSalaryLabel";
            this.futureSalaryLabel.Size = new System.Drawing.Size(0, 25);
            this.futureSalaryLabel.TabIndex = 3;
            // 
            // EmployeeSalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.futureSalaryLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.currentSalaryTextBox);
            this.Controls.Add(this.inputLabel);
            this.Name = "EmployeeSalaryForm";
            this.Text = "Employee Salary Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox currentSalaryTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label futureSalaryLabel;
    }
}

