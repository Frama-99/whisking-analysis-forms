namespace WhiskingAnalysis
{
    partial class GrabberDlg
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
            if(disposing && (components != null))
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
            this.label1 = new System.Windows.Forms.Label();
            this.GrabberList = new System.Windows.Forms.ListBox();
            this.LaunchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose your Grabber (If you don\'t have a grabber ready, choose \"Norpix Virtual Gr" +
                "abber\") :";
            // 
            // GrabberList
            // 
            this.GrabberList.FormattingEnabled = true;
            this.GrabberList.Location = new System.Drawing.Point(12, 45);
            this.GrabberList.Name = "GrabberList";
            this.GrabberList.Size = new System.Drawing.Size(268, 186);
            this.GrabberList.TabIndex = 1;
            // 
            // LaunchButton
            // 
            this.LaunchButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.LaunchButton.Location = new System.Drawing.Point(205, 237);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(75, 23);
            this.LaunchButton.TabIndex = 2;
            this.LaunchButton.Text = "Launch !";
            this.LaunchButton.UseVisualStyleBackColor = true;
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // GrabberDlg
            // 
            this.AcceptButton = this.LaunchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.LaunchButton);
            this.Controls.Add(this.GrabberList);
            this.Controls.Add(this.label1);
            this.Name = "GrabberDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GrabberDlg";
            this.Load += new System.EventHandler(this.GrabberDlg_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox GrabberList;
        private System.Windows.Forms.Button LaunchButton;
    }
}