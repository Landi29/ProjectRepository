namespace GUIprototype
{
    partial class AddNewTagsToArticleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewTagsToArticleForm));
            this.InformationMessage = new System.Windows.Forms.Label();
            this.AddTagsToArticleButton = new System.Windows.Forms.Button();
            this.AddTagsBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InformationMessage
            // 
            this.InformationMessage.AutoSize = true;
            this.InformationMessage.BackColor = System.Drawing.Color.Transparent;
            this.InformationMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformationMessage.ForeColor = System.Drawing.Color.White;
            this.InformationMessage.Location = new System.Drawing.Point(165, 114);
            this.InformationMessage.Name = "InformationMessage";
            this.InformationMessage.Size = new System.Drawing.Size(672, 33);
            this.InformationMessage.TabIndex = 0;
            this.InformationMessage.Text = "Please write the tags you want to add to the article.";
            // 
            // AddTagsToArticleButton
            // 
            this.AddTagsToArticleButton.BackColor = System.Drawing.Color.Black;
            this.AddTagsToArticleButton.ForeColor = System.Drawing.Color.White;
            this.AddTagsToArticleButton.Location = new System.Drawing.Point(411, 396);
            this.AddTagsToArticleButton.Name = "AddTagsToArticleButton";
            this.AddTagsToArticleButton.Size = new System.Drawing.Size(186, 86);
            this.AddTagsToArticleButton.TabIndex = 1;
            this.AddTagsToArticleButton.Text = "Add";
            this.AddTagsToArticleButton.UseVisualStyleBackColor = false;
            this.AddTagsToArticleButton.Click += new System.EventHandler(this.AddTagsToArticleButton_Click);
            // 
            // AddTagsBox
            // 
            this.AddTagsBox.Location = new System.Drawing.Point(332, 226);
            this.AddTagsBox.Name = "AddTagsBox";
            this.AddTagsBox.Size = new System.Drawing.Size(332, 31);
            this.AddTagsBox.TabIndex = 2;
            this.AddTagsBox.TextChanged += new System.EventHandler(this.AddTagsBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1013, 40);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToMenuToolStripMenuItem
            // 
            this.backToMenuToolStripMenuItem.Name = "backToMenuToolStripMenuItem";
            this.backToMenuToolStripMenuItem.Size = new System.Drawing.Size(178, 36);
            this.backToMenuToolStripMenuItem.Text = "Back To Menu";
            this.backToMenuToolStripMenuItem.Click += new System.EventHandler(this.backToMenuToolStripMenuItem_Click);
            // 
            // AddNewTagsToArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1013, 684);
            this.Controls.Add(this.AddTagsBox);
            this.Controls.Add(this.AddTagsToArticleButton);
            this.Controls.Add(this.InformationMessage);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddNewTagsToArticleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "!News";
            this.Load += new System.EventHandler(this.AddNewTagsToArticleForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InformationMessage;
        private System.Windows.Forms.Button AddTagsToArticleButton;
        private System.Windows.Forms.TextBox AddTagsBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToMenuToolStripMenuItem;
    }
}