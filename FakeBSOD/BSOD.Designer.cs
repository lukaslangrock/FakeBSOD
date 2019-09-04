namespace FakeBSOD
{
    partial class BSOD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BSOD));
            this.BSOD_Text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BSOD_Text
            // 
            this.BSOD_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BSOD_Text.BackColor = System.Drawing.Color.Transparent;
            this.BSOD_Text.Font = new System.Drawing.Font("Courier New", 15.75F);
            this.BSOD_Text.ForeColor = System.Drawing.Color.White;
            this.BSOD_Text.Location = new System.Drawing.Point(12, 9);
            this.BSOD_Text.Name = "BSOD_Text";
            this.BSOD_Text.Size = new System.Drawing.Size(376, 382);
            this.BSOD_Text.TabIndex = 0;
            this.BSOD_Text.Text = "BSOD_Text";
            // 
            // BSOD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.BSOD_Text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BSOD";
            this.ShowInTaskbar = false;
            this.Text = "BSOD";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BSOD_FormClosing);
            this.Load += new System.EventHandler(this.BSOD_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label BSOD_Text;
    }
}