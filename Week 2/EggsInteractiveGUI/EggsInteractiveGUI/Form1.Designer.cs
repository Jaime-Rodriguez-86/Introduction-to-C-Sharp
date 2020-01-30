namespace EggsInteractiveGUI
{
    partial class eggsInteractiveForm
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
            this.chickenOneLabel = new System.Windows.Forms.Label();
            this.chickenTwoLabel = new System.Windows.Forms.Label();
            this.chickenThreeLabel = new System.Windows.Forms.Label();
            this.chickenFourLabel = new System.Windows.Forms.Label();
            this.chickenFiveLabel = new System.Windows.Forms.Label();
            this.eggsInputOne = new System.Windows.Forms.TextBox();
            this.eggsInputTwo = new System.Windows.Forms.TextBox();
            this.eggsInputThree = new System.Windows.Forms.TextBox();
            this.eggsInputFour = new System.Windows.Forms.TextBox();
            this.eggsInputFive = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.totalEggsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chickenOneLabel
            // 
            this.chickenOneLabel.AutoSize = true;
            this.chickenOneLabel.Location = new System.Drawing.Point(67, 40);
            this.chickenOneLabel.Name = "chickenOneLabel";
            this.chickenOneLabel.Size = new System.Drawing.Size(108, 25);
            this.chickenOneLabel.TabIndex = 0;
            this.chickenOneLabel.Text = "Chicken 1";
            // 
            // chickenTwoLabel
            // 
            this.chickenTwoLabel.AutoSize = true;
            this.chickenTwoLabel.Location = new System.Drawing.Point(67, 90);
            this.chickenTwoLabel.Name = "chickenTwoLabel";
            this.chickenTwoLabel.Size = new System.Drawing.Size(108, 25);
            this.chickenTwoLabel.TabIndex = 1;
            this.chickenTwoLabel.Text = "Chicken 2";
            // 
            // chickenThreeLabel
            // 
            this.chickenThreeLabel.AutoSize = true;
            this.chickenThreeLabel.Location = new System.Drawing.Point(67, 142);
            this.chickenThreeLabel.Name = "chickenThreeLabel";
            this.chickenThreeLabel.Size = new System.Drawing.Size(108, 25);
            this.chickenThreeLabel.TabIndex = 2;
            this.chickenThreeLabel.Text = "Chicken 3";
            // 
            // chickenFourLabel
            // 
            this.chickenFourLabel.AutoSize = true;
            this.chickenFourLabel.Location = new System.Drawing.Point(67, 192);
            this.chickenFourLabel.Name = "chickenFourLabel";
            this.chickenFourLabel.Size = new System.Drawing.Size(108, 25);
            this.chickenFourLabel.TabIndex = 3;
            this.chickenFourLabel.Text = "Chicken 4";
            // 
            // chickenFiveLabel
            // 
            this.chickenFiveLabel.AutoSize = true;
            this.chickenFiveLabel.Location = new System.Drawing.Point(67, 242);
            this.chickenFiveLabel.Name = "chickenFiveLabel";
            this.chickenFiveLabel.Size = new System.Drawing.Size(108, 25);
            this.chickenFiveLabel.TabIndex = 4;
            this.chickenFiveLabel.Text = "Chicken 5";
            // 
            // eggsInputOne
            // 
            this.eggsInputOne.Location = new System.Drawing.Point(201, 40);
            this.eggsInputOne.Name = "eggsInputOne";
            this.eggsInputOne.Size = new System.Drawing.Size(100, 31);
            this.eggsInputOne.TabIndex = 5;
            // 
            // eggsInputTwo
            // 
            this.eggsInputTwo.Location = new System.Drawing.Point(201, 90);
            this.eggsInputTwo.Name = "eggsInputTwo";
            this.eggsInputTwo.Size = new System.Drawing.Size(100, 31);
            this.eggsInputTwo.TabIndex = 6;
            // 
            // eggsInputThree
            // 
            this.eggsInputThree.Location = new System.Drawing.Point(201, 142);
            this.eggsInputThree.Name = "eggsInputThree";
            this.eggsInputThree.Size = new System.Drawing.Size(100, 31);
            this.eggsInputThree.TabIndex = 7;
            // 
            // eggsInputFour
            // 
            this.eggsInputFour.Location = new System.Drawing.Point(201, 192);
            this.eggsInputFour.Name = "eggsInputFour";
            this.eggsInputFour.Size = new System.Drawing.Size(100, 31);
            this.eggsInputFour.TabIndex = 8;
            // 
            // eggsInputFive
            // 
            this.eggsInputFive.Location = new System.Drawing.Point(201, 242);
            this.eggsInputFive.Name = "eggsInputFive";
            this.eggsInputFive.Size = new System.Drawing.Size(100, 31);
            this.eggsInputFive.TabIndex = 9;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(477, 106);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(205, 111);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate Number\r\nof Dozens and Eggs";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // totalEggsLabel
            // 
            this.totalEggsLabel.AutoSize = true;
            this.totalEggsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalEggsLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.totalEggsLabel.Location = new System.Drawing.Point(12, 322);
            this.totalEggsLabel.Name = "totalEggsLabel";
            this.totalEggsLabel.Size = new System.Drawing.Size(292, 102);
            this.totalEggsLabel.TabIndex = 11;
            this.totalEggsLabel.Text = "Your eggs \r\ncalculate to...\r\n";
            // 
            // eggsInteractiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 482);
            this.Controls.Add(this.totalEggsLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.eggsInputFive);
            this.Controls.Add(this.eggsInputFour);
            this.Controls.Add(this.eggsInputThree);
            this.Controls.Add(this.eggsInputTwo);
            this.Controls.Add(this.eggsInputOne);
            this.Controls.Add(this.chickenFiveLabel);
            this.Controls.Add(this.chickenFourLabel);
            this.Controls.Add(this.chickenThreeLabel);
            this.Controls.Add(this.chickenTwoLabel);
            this.Controls.Add(this.chickenOneLabel);
            this.Name = "eggsInteractiveForm";
            this.Text = "Eggs Interactive Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chickenOneLabel;
        private System.Windows.Forms.Label chickenTwoLabel;
        private System.Windows.Forms.Label chickenThreeLabel;
        private System.Windows.Forms.Label chickenFourLabel;
        private System.Windows.Forms.Label chickenFiveLabel;
        private System.Windows.Forms.TextBox eggsInputOne;
        private System.Windows.Forms.TextBox eggsInputTwo;
        private System.Windows.Forms.TextBox eggsInputThree;
        private System.Windows.Forms.TextBox eggsInputFour;
        private System.Windows.Forms.TextBox eggsInputFive;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label totalEggsLabel;
    }
}

