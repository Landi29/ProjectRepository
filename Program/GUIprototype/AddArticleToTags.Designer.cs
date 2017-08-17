namespace GUIprototype
{
    partial class AddArticleToTags
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddArticleToTags));
            this.ChooseTagsBox = new System.Windows.Forms.CheckedListBox();
            this.AddArticleButton = new System.Windows.Forms.Button();
            this.ChooseTagsMessage = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChooseTagsBox
            // 
            this.ChooseTagsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseTagsBox.FormattingEnabled = true;
            this.ChooseTagsBox.Location = new System.Drawing.Point(133, 159);
            this.ChooseTagsBox.Name = "ChooseTagsBox";
            this.ChooseTagsBox.Size = new System.Drawing.Size(458, 459);
            this.ChooseTagsBox.TabIndex = 0;
            this.ChooseTagsBox.SelectedIndexChanged += new System.EventHandler(this.ChooseTagsBox_SelectedIndexChanged);
            // 
            // AddArticleButton
            // 
            this.AddArticleButton.BackColor = System.Drawing.Color.Black;
            this.AddArticleButton.ForeColor = System.Drawing.Color.White;
            this.AddArticleButton.Location = new System.Drawing.Point(743, 532);
            this.AddArticleButton.Name = "AddArticleButton";
            this.AddArticleButton.Size = new System.Drawing.Size(186, 86);
            this.AddArticleButton.TabIndex = 1;
            this.AddArticleButton.Text = "Add";
            this.AddArticleButton.UseVisualStyleBackColor = false;
            this.AddArticleButton.Click += new System.EventHandler(this.AddArticleButton_Click);
            // 
            // ChooseTagsMessage
            // 
            this.ChooseTagsMessage.AutoSize = true;
            this.ChooseTagsMessage.BackColor = System.Drawing.Color.Transparent;
            this.ChooseTagsMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseTagsMessage.ForeColor = System.Drawing.Color.White;
            this.ChooseTagsMessage.Location = new System.Drawing.Point(127, 82);
            this.ChooseTagsMessage.Name = "ChooseTagsMessage";
            this.ChooseTagsMessage.Size = new System.Drawing.Size(449, 33);
            this.ChooseTagsMessage.TabIndex = 2;
            this.ChooseTagsMessage.Text = "Choose the tags to add the article";
            this.ChooseTagsMessage.Click += new System.EventHandler(this.ChooseTagsMessage_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToMainToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1013, 40);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToMainToolStripMenuItem
            // 
            this.backToMainToolStripMenuItem.Name = "backToMainToolStripMenuItem";
            this.backToMainToolStripMenuItem.Size = new System.Drawing.Size(169, 36);
            this.backToMainToolStripMenuItem.Text = "Back To Main";
            this.backToMainToolStripMenuItem.Click += new System.EventHandler(this.backToMainToolStripMenuItem_Click);
            // 
            // AddArticleToTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1013, 684);
            this.Controls.Add(this.ChooseTagsMessage);
            this.Controls.Add(this.AddArticleButton);
            this.Controls.Add(this.ChooseTagsBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddArticleToTags";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "!News";
            this.Load += new System.EventHandler(this.AddArticleToTags_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ChooseTagsBox;
        private System.Windows.Forms.Button AddArticleButton;
        private System.Windows.Forms.Label ChooseTagsMessage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToMainToolStripMenuItem;
    }
}