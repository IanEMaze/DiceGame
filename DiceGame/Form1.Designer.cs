namespace DiceGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.diceRollOne = new System.Windows.Forms.PictureBox();
            this.diceRollTwo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.playerOneTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.playerOneButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.playerTwoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.playerTwoButton = new System.Windows.Forms.Button();
            this.rollValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diceRollOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceRollTwo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(356, 146);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(86, 38);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Game";
            this.startButton.UseMnemonic = false;
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(113, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "This game will simulate dice rolls. The first player to get to 50 points wins!";
            // 
            // diceRollOne
            // 
            this.diceRollOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.diceRollOne.Image = global::DiceGame.Properties.Resources._6Die;
            this.diceRollOne.Location = new System.Drawing.Point(284, 294);
            this.diceRollOne.Name = "diceRollOne";
            this.diceRollOne.Size = new System.Drawing.Size(103, 106);
            this.diceRollOne.TabIndex = 2;
            this.diceRollOne.TabStop = false;
            // 
            // diceRollTwo
            // 
            this.diceRollTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.diceRollTwo.Image = global::DiceGame.Properties.Resources._6Die;
            this.diceRollTwo.Location = new System.Drawing.Point(406, 294);
            this.diceRollTwo.Name = "diceRollTwo";
            this.diceRollTwo.Size = new System.Drawing.Size(101, 106);
            this.diceRollTwo.TabIndex = 3;
            this.diceRollTwo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.playerOneTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.playerOneButton);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 205);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player One";
            // 
            // playerOneTextBox
            // 
            this.playerOneTextBox.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneTextBox.Location = new System.Drawing.Point(105, 138);
            this.playerOneTextBox.Name = "playerOneTextBox";
            this.playerOneTextBox.ReadOnly = true;
            this.playerOneTextBox.Size = new System.Drawing.Size(154, 33);
            this.playerOneTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Score:";
            // 
            // playerOneButton
            // 
            this.playerOneButton.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.playerOneButton.Location = new System.Drawing.Point(16, 58);
            this.playerOneButton.Name = "playerOneButton";
            this.playerOneButton.Size = new System.Drawing.Size(105, 49);
            this.playerOneButton.TabIndex = 0;
            this.playerOneButton.Text = "Press to Roll!";
            this.playerOneButton.UseVisualStyleBackColor = true;
            this.playerOneButton.Click += new System.EventHandler(this.playerOneButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.playerTwoTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.playerTwoButton);
            this.groupBox2.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(484, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 205);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player Two";
            // 
            // playerTwoTextBox
            // 
            this.playerTwoTextBox.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoTextBox.Location = new System.Drawing.Point(133, 139);
            this.playerTwoTextBox.Name = "playerTwoTextBox";
            this.playerTwoTextBox.ReadOnly = true;
            this.playerTwoTextBox.Size = new System.Drawing.Size(154, 33);
            this.playerTwoTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Score:";
            // 
            // playerTwoButton
            // 
            this.playerTwoButton.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.playerTwoButton.Location = new System.Drawing.Point(24, 58);
            this.playerTwoButton.Name = "playerTwoButton";
            this.playerTwoButton.Size = new System.Drawing.Size(105, 49);
            this.playerTwoButton.TabIndex = 1;
            this.playerTwoButton.Text = "Press to Roll!";
            this.playerTwoButton.UseVisualStyleBackColor = true;
            this.playerTwoButton.Click += new System.EventHandler(this.playerTwoButton_Click);
            // 
            // rollValueLabel
            // 
            this.rollValueLabel.AutoSize = true;
            this.rollValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.rollValueLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollValueLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rollValueLabel.Location = new System.Drawing.Point(299, 424);
            this.rollValueLabel.Name = "rollValueLabel";
            this.rollValueLabel.Size = new System.Drawing.Size(110, 20);
            this.rollValueLabel.TabIndex = 6;
            this.rollValueLabel.Text = "Dice Roll Value: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.rollValueLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.diceRollTwo);
            this.Controls.Add(this.diceRollOne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dice Roll Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diceRollOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceRollTwo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox diceRollOne;
        private System.Windows.Forms.PictureBox diceRollTwo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox playerOneTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button playerOneButton;
        private System.Windows.Forms.TextBox playerTwoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button playerTwoButton;
        private System.Windows.Forms.Label rollValueLabel;
    }
}

