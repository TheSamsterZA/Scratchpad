namespace OverrideButtonImageDemo
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
            this.customButton = new OverrideButtonImageDemo.CustomButton();
            this.SuspendLayout();
            // 
            // customButton
            // 
            this.customButton.Image = global::OverrideButtonImageDemo.MyResources.SadFace;
            this.customButton.Location = new System.Drawing.Point(12, 12);
            this.customButton.Name = "customButton";
            this.customButton.Size = new System.Drawing.Size(39, 32);
            this.customButton.TabIndex = 0;
            this.customButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 176);
            this.Controls.Add(this.customButton);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomButton customButton;
    }
}

