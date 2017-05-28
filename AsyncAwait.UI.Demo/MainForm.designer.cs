namespace AsyncAwait.UI.Demo
{
    partial class MainForm
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
            this.lblFeedback = new System.Windows.Forms.Label();
            this.btnClickMe = new System.Windows.Forms.Button();
            this.lblFeedbackAsync = new System.Windows.Forms.Label();
            this.btnMessage = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(35, 50);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(61, 13);
            this.lblFeedback.TabIndex = 0;
            this.lblFeedback.Text = "(Feedback)";
            // 
            // btnClickMe
            // 
            this.btnClickMe.Location = new System.Drawing.Point(35, 132);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(75, 23);
            this.btnClickMe.TabIndex = 1;
            this.btnClickMe.Text = "Click Me";
            this.btnClickMe.UseVisualStyleBackColor = true;
            this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
            // 
            // lblFeedbackAsync
            // 
            this.lblFeedbackAsync.AutoSize = true;
            this.lblFeedbackAsync.Location = new System.Drawing.Point(35, 91);
            this.lblFeedbackAsync.Name = "lblFeedbackAsync";
            this.lblFeedbackAsync.Size = new System.Drawing.Size(93, 13);
            this.lblFeedbackAsync.TabIndex = 2;
            this.lblFeedbackAsync.Text = "(Feedback Async)";
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(218, 132);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(90, 23);
            this.btnMessage.TabIndex = 3;
            this.btnMessage.Text = "Show Message";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(215, 50);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(56, 13);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "(Message)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 195);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.lblFeedbackAsync);
            this.Controls.Add(this.btnClickMe);
            this.Controls.Add(this.lblFeedback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task-based Async/Await Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.Label lblFeedbackAsync;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Label lblMessage;
    }
}

