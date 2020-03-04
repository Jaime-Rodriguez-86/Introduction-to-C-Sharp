namespace InternetAccess
{
    partial class internetForm
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
            this.servicesButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // servicesButton
            // 
            this.servicesButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.servicesButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.servicesButton.Location = new System.Drawing.Point(275, 188);
            this.servicesButton.Name = "servicesButton";
            this.servicesButton.Size = new System.Drawing.Size(249, 151);
            this.servicesButton.TabIndex = 0;
            this.servicesButton.Text = "Click To Begin";
            this.servicesButton.UseVisualStyleBackColor = false;
            this.servicesButton.Click += new System.EventHandler(this.servicesButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.Blue;
            this.headerLabel.Location = new System.Drawing.Point(76, 50);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(680, 64);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "\"The Best\" Internet Service";
            // 
            // internetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.servicesButton);
            this.Name = "internetForm";
            this.Text = "\"The Best\" Internet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button servicesButton;
        private System.Windows.Forms.Label headerLabel;
    }
}

