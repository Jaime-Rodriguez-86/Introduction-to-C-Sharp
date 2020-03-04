namespace FiveColors
{
    partial class colorForm
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
            this.redButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.orangeButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.statementLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.redButton.Location = new System.Drawing.Point(27, 334);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(125, 70);
            this.redButton.TabIndex = 0;
            this.redButton.Text = "Red";
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.Location = new System.Drawing.Point(171, 334);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(125, 70);
            this.blueButton.TabIndex = 1;
            this.blueButton.Text = "Blue";
            this.blueButton.UseVisualStyleBackColor = true;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.Location = new System.Drawing.Point(325, 334);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(125, 70);
            this.greenButton.TabIndex = 2;
            this.greenButton.Text = "Green";
            this.greenButton.UseVisualStyleBackColor = true;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // orangeButton
            // 
            this.orangeButton.Location = new System.Drawing.Point(481, 334);
            this.orangeButton.Name = "orangeButton";
            this.orangeButton.Size = new System.Drawing.Size(125, 70);
            this.orangeButton.TabIndex = 3;
            this.orangeButton.Text = "Orange";
            this.orangeButton.UseVisualStyleBackColor = true;
            this.orangeButton.Click += new System.EventHandler(this.orangeButton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.Location = new System.Drawing.Point(637, 334);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(125, 70);
            this.yellowButton.TabIndex = 4;
            this.yellowButton.Text = "Yellow";
            this.yellowButton.UseVisualStyleBackColor = true;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // statementLabel
            // 
            this.statementLabel.AutoSize = true;
            this.statementLabel.Location = new System.Drawing.Point(267, 268);
            this.statementLabel.Name = "statementLabel";
            this.statementLabel.Size = new System.Drawing.Size(249, 25);
            this.statementLabel.TabIndex = 5;
            this.statementLabel.Text = "CHOOSE YOUR COLOR";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(107, 22);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(612, 135);
            this.headerLabel.TabIndex = 6;
            this.headerLabel.Text = "Color Happy";
            // 
            // colorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.statementLabel);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.orangeButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.redButton);
            this.Name = "colorForm";
            this.Text = "Color Chooser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button orangeButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Label statementLabel;
        private System.Windows.Forms.Label headerLabel;
    }
}

