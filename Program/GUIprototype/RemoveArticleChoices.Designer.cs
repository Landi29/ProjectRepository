namespace GUIprototype
{
    partial class RemoveArticleChoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveArticleChoices));
            this.label1 = new System.Windows.Forms.Label();
            this.DatabaseButton = new System.Windows.Forms.Button();
            this.TagButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Would you like to remove the article\r\nfrom the entire database or from a specific" +
    " tag?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DatabaseButton
            // 
            this.DatabaseButton.BackColor = System.Drawing.Color.Black;
            this.DatabaseButton.ForeColor = System.Drawing.Color.White;
            this.DatabaseButton.Location = new System.Drawing.Point(94, 189);
            this.DatabaseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DatabaseButton.Name = "DatabaseButton";
            this.DatabaseButton.Size = new System.Drawing.Size(93, 45);
            this.DatabaseButton.TabIndex = 1;
            this.DatabaseButton.Text = "Database";
            this.DatabaseButton.UseVisualStyleBackColor = false;
            this.DatabaseButton.Click += new System.EventHandler(this.DatabaseButton_Click);
            // 
            // TagButton
            // 
            this.TagButton.BackColor = System.Drawing.Color.Black;
            this.TagButton.ForeColor = System.Drawing.Color.White;
            this.TagButton.Location = new System.Drawing.Point(312, 189);
            this.TagButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TagButton.Name = "TagButton";
            this.TagButton.Size = new System.Drawing.Size(93, 45);
            this.TagButton.TabIndex = 2;
            this.TagButton.Text = "Tag";
            this.TagButton.UseVisualStyleBackColor = false;
            this.TagButton.Click += new System.EventHandler(this.TagButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(506, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToMenuToolStripMenuItem
            // 
            this.backToMenuToolStripMenuItem.Name = "backToMenuToolStripMenuItem";
            this.backToMenuToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.backToMenuToolStripMenuItem.Text = "Back To Menu";
            this.backToMenuToolStripMenuItem.Click += new System.EventHandler(this.backToMenuToolStripMenuItem_Click);
            // 
            // RemoveArticleChoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(506, 356);
            this.Controls.Add(this.TagButton);
            this.Controls.Add(this.DatabaseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RemoveArticleChoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "!News";
            this.Load += new System.EventHandler(this.RemoveArticleChoices_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DatabaseButton;
        private System.Windows.Forms.Button TagButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToMenuToolStripMenuItem;
    }
}