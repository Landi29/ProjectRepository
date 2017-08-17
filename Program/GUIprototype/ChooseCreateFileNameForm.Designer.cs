namespace GUIprototype
{
    partial class ChooseCreateFileNameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseCreateFileNameForm));
            this.label1 = new System.Windows.Forms.Label();
            this.AddDateButton = new System.Windows.Forms.Button();
            this.CurrentDateButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do you want to add the date of the article, or use the current date?";
            // 
            // AddDateButton
            // 
            this.AddDateButton.BackColor = System.Drawing.Color.Black;
            this.AddDateButton.ForeColor = System.Drawing.Color.White;
            this.AddDateButton.Location = new System.Drawing.Point(338, 171);
            this.AddDateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddDateButton.Name = "AddDateButton";
            this.AddDateButton.Size = new System.Drawing.Size(95, 47);
            this.AddDateButton.TabIndex = 1;
            this.AddDateButton.Text = "Add date and filename";
            this.AddDateButton.UseVisualStyleBackColor = false;
            this.AddDateButton.Click += new System.EventHandler(this.AddDateButton_Click);
            // 
            // CurrentDateButton
            // 
            this.CurrentDateButton.BackColor = System.Drawing.Color.Black;
            this.CurrentDateButton.ForeColor = System.Drawing.Color.White;
            this.CurrentDateButton.Location = new System.Drawing.Point(86, 171);
            this.CurrentDateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CurrentDateButton.Name = "CurrentDateButton";
            this.CurrentDateButton.Size = new System.Drawing.Size(95, 47);
            this.CurrentDateButton.TabIndex = 2;
            this.CurrentDateButton.Text = "Add filename with current date";
            this.CurrentDateButton.UseVisualStyleBackColor = false;
            this.CurrentDateButton.Click += new System.EventHandler(this.CurrentDateButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(506, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.backToolStripMenuItem.Text = " Back to URL Window";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // ChooseCreateFileNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(506, 356);
            this.Controls.Add(this.CurrentDateButton);
            this.Controls.Add(this.AddDateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChooseCreateFileNameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "!News";
            this.Load += new System.EventHandler(this.ChooseCreateFileNameForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddDateButton;
        private System.Windows.Forms.Button CurrentDateButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}