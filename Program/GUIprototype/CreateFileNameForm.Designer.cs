namespace GUIprototype
{
    partial class CreateFileNameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateFileNameForm));
            this.label1 = new System.Windows.Forms.Label();
            this.FileNameBox = new System.Windows.Forms.TextBox();
            this.CreateFileButton = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(296, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter a name for the file.";
            // 
            // FileNameBox
            // 
            this.FileNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileNameBox.Location = new System.Drawing.Point(302, 230);
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.Size = new System.Drawing.Size(421, 40);
            this.FileNameBox.TabIndex = 1;
            this.FileNameBox.TextChanged += new System.EventHandler(this.FileNameBox_TextChanged);
            // 
            // CreateFileButton
            // 
            this.CreateFileButton.BackColor = System.Drawing.Color.Black;
            this.CreateFileButton.ForeColor = System.Drawing.Color.White;
            this.CreateFileButton.Location = new System.Drawing.Point(411, 385);
            this.CreateFileButton.Name = "CreateFileButton";
            this.CreateFileButton.Size = new System.Drawing.Size(186, 86);
            this.CreateFileButton.TabIndex = 2;
            this.CreateFileButton.Text = "Add filename";
            this.CreateFileButton.UseVisualStyleBackColor = false;
            this.CreateFileButton.Click += new System.EventHandler(this.CreateFileButton_Click);
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
            this.backToolStripMenuItem.Size = new System.Drawing.Size(178, 36);
            this.backToolStripMenuItem.Text = "Back To Menu";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // CreateFileNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1013, 684);
            this.Controls.Add(this.CreateFileButton);
            this.Controls.Add(this.FileNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CreateFileNameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "!News";
            this.Load += new System.EventHandler(this.CreateFileNameForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileNameBox;
        private System.Windows.Forms.Button CreateFileButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}