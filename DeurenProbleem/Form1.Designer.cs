namespace DeurenProbleem
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
            this.GewonnenCounterLabel = new System.Windows.Forms.Label();
            this.verlorenCounterLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioSwitch = new System.Windows.Forms.RadioButton();
            this.radioStay = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GewonnenCounterLabel
            // 
            this.GewonnenCounterLabel.AutoSize = true;
            this.GewonnenCounterLabel.Location = new System.Drawing.Point(12, 163);
            this.GewonnenCounterLabel.Name = "GewonnenCounterLabel";
            this.GewonnenCounterLabel.Size = new System.Drawing.Size(16, 13);
            this.GewonnenCounterLabel.TabIndex = 0;
            this.GewonnenCounterLabel.Text = "...";
            // 
            // verlorenCounterLabel
            // 
            this.verlorenCounterLabel.AutoSize = true;
            this.verlorenCounterLabel.Location = new System.Drawing.Point(12, 138);
            this.verlorenCounterLabel.Name = "verlorenCounterLabel";
            this.verlorenCounterLabel.Size = new System.Drawing.Size(16, 13);
            this.verlorenCounterLabel.TabIndex = 1;
            this.verlorenCounterLabel.Text = "...";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(52, 94);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(52, 68);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioStay);
            this.groupBox1.Controls.Add(this.radioSwitch);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 50);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Switch or stay";
            // 
            // radioSwitch
            // 
            this.radioSwitch.AutoSize = true;
            this.radioSwitch.Location = new System.Drawing.Point(6, 27);
            this.radioSwitch.Name = "radioSwitch";
            this.radioSwitch.Size = new System.Drawing.Size(55, 17);
            this.radioSwitch.TabIndex = 5;
            this.radioSwitch.TabStop = true;
            this.radioSwitch.Text = "switch";
            this.radioSwitch.UseVisualStyleBackColor = true;
            // 
            // radioStay
            // 
            this.radioStay.AutoSize = true;
            this.radioStay.Location = new System.Drawing.Point(88, 27);
            this.radioStay.Name = "radioStay";
            this.radioStay.Size = new System.Drawing.Size(44, 17);
            this.radioStay.TabIndex = 6;
            this.radioStay.TabStop = true;
            this.radioStay.Text = "stay";
            this.radioStay.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 193);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.verlorenCounterLabel);
            this.Controls.Add(this.GewonnenCounterLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GewonnenCounterLabel;
        private System.Windows.Forms.Label verlorenCounterLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioStay;
        private System.Windows.Forms.RadioButton radioSwitch;
    }
}

