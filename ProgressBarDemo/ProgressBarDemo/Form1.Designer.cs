namespace ProgressBarDemo
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
            this.StartButton = new System.Windows.Forms.Button();
            this.UpdateProgress = new System.Windows.Forms.ProgressBar();
            this.UpdateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(109, 159);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(175, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "StartButton";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // UpdateProgress
            // 
            this.UpdateProgress.Location = new System.Drawing.Point(109, 74);
            this.UpdateProgress.Name = "UpdateProgress";
            this.UpdateProgress.Size = new System.Drawing.Size(232, 23);
            this.UpdateProgress.TabIndex = 1;
            // 
            // UpdateLabel
            // 
            this.UpdateLabel.Location = new System.Drawing.Point(453, 83);
            this.UpdateLabel.Name = "UpdateLabel";
            this.UpdateLabel.Size = new System.Drawing.Size(100, 13);
            this.UpdateLabel.TabIndex = 2;
            this.UpdateLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateLabel);
            this.Controls.Add(this.UpdateProgress);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ProgressBar UpdateProgress;
        private System.Windows.Forms.Label UpdateLabel;
    }
}

