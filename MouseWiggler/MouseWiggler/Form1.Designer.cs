namespace MouseWiggler
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
            this.WiggleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WiggleButton
            // 
            this.WiggleButton.Location = new System.Drawing.Point(234, 152);
            this.WiggleButton.Name = "WiggleButton";
            this.WiggleButton.Size = new System.Drawing.Size(257, 102);
            this.WiggleButton.TabIndex = 0;
            this.WiggleButton.Text = "Wiggle";
            this.WiggleButton.UseVisualStyleBackColor = true;
            this.WiggleButton.Click += new System.EventHandler(this.Wiggle_ClickAsync);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WiggleButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WiggleButton;
    }
}

