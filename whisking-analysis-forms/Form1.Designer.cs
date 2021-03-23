
namespace whisking_analysis_forms
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
            this.leftRightSplitter = new System.Windows.Forms.SplitContainer();
            this.leftTopBotSplitter = new System.Windows.Forms.SplitContainer();
            this.rightTopBotSplitter = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.leftRightSplitter)).BeginInit();
            this.leftRightSplitter.Panel1.SuspendLayout();
            this.leftRightSplitter.Panel2.SuspendLayout();
            this.leftRightSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftTopBotSplitter)).BeginInit();
            this.leftTopBotSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightTopBotSplitter)).BeginInit();
            this.rightTopBotSplitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftRightSplitter
            // 
            this.leftRightSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftRightSplitter.Location = new System.Drawing.Point(0, 0);
            this.leftRightSplitter.Name = "leftRightSplitter";
            // 
            // leftRightSplitter.Panel1
            // 
            this.leftRightSplitter.Panel1.Controls.Add(this.leftTopBotSplitter);
            // 
            // leftRightSplitter.Panel2
            // 
            this.leftRightSplitter.Panel2.Controls.Add(this.rightTopBotSplitter);
            this.leftRightSplitter.Size = new System.Drawing.Size(784, 561);
            this.leftRightSplitter.SplitterDistance = 400;
            this.leftRightSplitter.TabIndex = 0;
            // 
            // leftTopBotSplitter
            // 
            this.leftTopBotSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftTopBotSplitter.Location = new System.Drawing.Point(0, 0);
            this.leftTopBotSplitter.Name = "leftTopBotSplitter";
            this.leftTopBotSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // leftTopBotSplitter.Panel1
            // 
            this.leftTopBotSplitter.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.leftTopBotSplitter.Size = new System.Drawing.Size(400, 561);
            this.leftTopBotSplitter.SplitterDistance = 300;
            this.leftTopBotSplitter.TabIndex = 0;
            // 
            // rightTopBotSplitter
            // 
            this.rightTopBotSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightTopBotSplitter.Location = new System.Drawing.Point(0, 0);
            this.rightTopBotSplitter.Name = "rightTopBotSplitter";
            this.rightTopBotSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.rightTopBotSplitter.Size = new System.Drawing.Size(380, 561);
            this.rightTopBotSplitter.SplitterDistance = 300;
            this.rightTopBotSplitter.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.leftRightSplitter);
            this.Name = "Form1";
            this.Text = "Whisking Analysis";
            this.leftRightSplitter.Panel1.ResumeLayout(false);
            this.leftRightSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftRightSplitter)).EndInit();
            this.leftRightSplitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftTopBotSplitter)).EndInit();
            this.leftTopBotSplitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rightTopBotSplitter)).EndInit();
            this.rightTopBotSplitter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer leftRightSplitter;
        private System.Windows.Forms.SplitContainer leftTopBotSplitter;
        private System.Windows.Forms.SplitContainer rightTopBotSplitter;
    }
}

