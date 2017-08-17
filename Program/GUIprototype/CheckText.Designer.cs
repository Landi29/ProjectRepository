namespace GUIprototype
{
    partial class CheckText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckText));
            this.CheckLink = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.URLbox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckLink
            // 
            this.CheckLink.BackColor = System.Drawing.Color.Black;
            this.CheckLink.ForeColor = System.Drawing.Color.White;
            this.CheckLink.Location = new System.Drawing.Point(400, 369);
            this.CheckLink.Name = "CheckLink";
            this.CheckLink.Size = new System.Drawing.Size(186, 86);
            this.CheckLink.TabIndex = 0;
            this.CheckLink.Text = "Check Link";
            this.CheckLink.UseVisualStyleBackColor = false;
            this.CheckLink.Click += new System.EventHandler(this.CheckLink_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(296, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter an URL to check";
            // 
            // URLbox
            // 
            this.URLbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLbox.Location = new System.Drawing.Point(161, 274);
            this.URLbox.Name = "URLbox";
            this.URLbox.Size = new System.Drawing.Size(680, 40);
            this.URLbox.TabIndex = 2;
            this.URLbox.TextChanged += new System.EventHandler(this.URLbox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1013, 40);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(76, 36);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // CheckText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1013, 648);
            this.Controls.Add(this.URLbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckLink);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CheckText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "!News";
            this.Load += new System.EventHandler(this.CheckText_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckLink;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox URLbox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}