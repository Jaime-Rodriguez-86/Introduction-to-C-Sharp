namespace GuessANumber
{
    partial class guessForm
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.hintLabel = new System.Windows.Forms.Label();
            this.radioButtonOne = new System.Windows.Forms.RadioButton();
            this.radioButtonTwo = new System.Windows.Forms.RadioButton();
            this.radioButtonThree = new System.Windows.Forms.RadioButton();
            this.radioButtonFour = new System.Windows.Forms.RadioButton();
            this.radioButtonFive = new System.Windows.Forms.RadioButton();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hintLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hintLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hintLabel.Location = new System.Drawing.Point(278, 414);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(161, 27);
            this.hintLabel.TabIndex = 0;
            this.hintLabel.Text = "Hover for a hint";
            this.hintLabel.MouseLeave += new System.EventHandler(this.hintLabel_MouseLeave);
            this.hintLabel.MouseHover += new System.EventHandler(this.hintLabel_MouseHover);
            // 
            // radioButtonOne
            // 
            this.radioButtonOne.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.radioButtonOne.AutoSize = true;
            this.radioButtonOne.Location = new System.Drawing.Point(51, 224);
            this.radioButtonOne.Name = "radioButtonOne";
            this.radioButtonOne.Size = new System.Drawing.Size(55, 29);
            this.radioButtonOne.TabIndex = 1;
            this.radioButtonOne.Text = "1";
            this.radioButtonOne.UseVisualStyleBackColor = true;
            this.radioButtonOne.CheckedChanged += new System.EventHandler(this.radioButtonOne_CheckedChanged);
            // 
            // radioButtonTwo
            // 
            this.radioButtonTwo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.radioButtonTwo.AutoSize = true;
            this.radioButtonTwo.Location = new System.Drawing.Point(187, 348);
            this.radioButtonTwo.Name = "radioButtonTwo";
            this.radioButtonTwo.Size = new System.Drawing.Size(55, 29);
            this.radioButtonTwo.TabIndex = 2;
            this.radioButtonTwo.Text = "2";
            this.radioButtonTwo.UseVisualStyleBackColor = true;
            this.radioButtonTwo.CheckedChanged += new System.EventHandler(this.radioButtonTwo_CheckedChanged);
            // 
            // radioButtonThree
            // 
            this.radioButtonThree.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.radioButtonThree.AutoSize = true;
            this.radioButtonThree.Location = new System.Drawing.Point(343, 224);
            this.radioButtonThree.Name = "radioButtonThree";
            this.radioButtonThree.Size = new System.Drawing.Size(55, 29);
            this.radioButtonThree.TabIndex = 3;
            this.radioButtonThree.Text = "3";
            this.radioButtonThree.UseVisualStyleBackColor = true;
            this.radioButtonThree.CheckedChanged += new System.EventHandler(this.radioButtonThree_CheckedChanged);
            // 
            // radioButtonFour
            // 
            this.radioButtonFour.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.radioButtonFour.AutoSize = true;
            this.radioButtonFour.Location = new System.Drawing.Point(483, 348);
            this.radioButtonFour.Name = "radioButtonFour";
            this.radioButtonFour.Size = new System.Drawing.Size(55, 29);
            this.radioButtonFour.TabIndex = 4;
            this.radioButtonFour.Text = "4";
            this.radioButtonFour.UseVisualStyleBackColor = true;
            this.radioButtonFour.CheckedChanged += new System.EventHandler(this.radioButtonFour_CheckedChanged);
            // 
            // radioButtonFive
            // 
            this.radioButtonFive.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.radioButtonFive.AutoSize = true;
            this.radioButtonFive.Location = new System.Drawing.Point(635, 224);
            this.radioButtonFive.Name = "radioButtonFive";
            this.radioButtonFive.Size = new System.Drawing.Size(55, 29);
            this.radioButtonFive.TabIndex = 5;
            this.radioButtonFive.Text = "5";
            this.radioButtonFive.UseVisualStyleBackColor = true;
            this.radioButtonFive.CheckedChanged += new System.EventHandler(this.radioButtonFive_CheckedChanged);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(12, 15);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(308, 42);
            this.infoLabel.TabIndex = 6;
            this.infoLabel.Text = "Guess a number";
            // 
            // guessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.radioButtonFive);
            this.Controls.Add(this.radioButtonFour);
            this.Controls.Add(this.radioButtonThree);
            this.Controls.Add(this.radioButtonTwo);
            this.Controls.Add(this.radioButtonOne);
            this.Controls.Add(this.hintLabel);
            this.Name = "guessForm";
            this.Text = "Guessing Game";
            this.Load += new System.EventHandler(this.guessForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label hintLabel;
        private System.Windows.Forms.RadioButton radioButtonOne;
        private System.Windows.Forms.RadioButton radioButtonTwo;
        private System.Windows.Forms.RadioButton radioButtonThree;
        private System.Windows.Forms.RadioButton radioButtonFour;
        private System.Windows.Forms.RadioButton radioButtonFive;
        private System.Windows.Forms.Label infoLabel;
    }
}

