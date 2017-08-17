namespace GUIprototype
{
    partial class TextSimilarityResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextSimilarityResult));
            this.ResultIsFalseLabel = new System.Windows.Forms.Label();
            this.AddArticleQuestion = new System.Windows.Forms.Label();
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.ResultIsTrueLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotificationLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultIsFalseLabel
            // 
            this.ResultIsFalseLabel.AutoSize = true;
            this.ResultIsFalseLabel.BackColor = System.Drawing.Color.Transparent;
            this.ResultIsFalseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultIsFalseLabel.ForeColor = System.Drawing.Color.White;
            this.ResultIsFalseLabel.Location = new System.Drawing.Point(120, 79);
            this.ResultIsFalseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResultIsFalseLabel.Name = "ResultIsFalseLabel";
            this.ResultIsFalseLabel.Size = new System.Drawing.Size(418, 33);
            this.ResultIsFalseLabel.TabIndex = 0;
            this.ResultIsFalseLabel.Text = "Result of similarity (midlertidig)";
            // 
            // AddArticleQuestion
            // 
            this.AddArticleQuestion.AutoSize = true;
            this.AddArticleQuestion.BackColor = System.Drawing.Color.Transparent;
            this.AddArticleQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddArticleQuestion.ForeColor = System.Drawing.Color.White;
            this.AddArticleQuestion.Location = new System.Drawing.Point(180, 263);
            this.AddArticleQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddArticleQuestion.Name = "AddArticleQuestion";
            this.AddArticleQuestion.Size = new System.Drawing.Size(622, 33);
            this.AddArticleQuestion.TabIndex = 1;
            this.AddArticleQuestion.Text = "Do you want to add the article to the database?";
            this.AddArticleQuestion.Click += new System.EventHandler(this.AddArticleQuestion_Click);
            // 
            // YesButton
            // 
            this.YesButton.BackColor = System.Drawing.Color.Black;
            this.YesButton.ForeColor = System.Drawing.Color.White;
            this.YesButton.Location = new System.Drawing.Point(198, 360);
            this.YesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(186, 87);
            this.YesButton.TabIndex = 2;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = false;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.BackColor = System.Drawing.Color.Black;
            this.NoButton.ForeColor = System.Drawing.Color.White;
            this.NoButton.Location = new System.Drawing.Point(608, 360);
            this.NoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(186, 87);
            this.NoButton.TabIndex = 3;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = false;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // ResultIsTrueLabel
            // 
            this.ResultIsTrueLabel.AutoSize = true;
            this.ResultIsTrueLabel.BackColor = System.Drawing.Color.Transparent;
            this.ResultIsTrueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultIsTrueLabel.ForeColor = System.Drawing.Color.White;
            this.ResultIsTrueLabel.Location = new System.Drawing.Point(120, 154);
            this.ResultIsTrueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResultIsTrueLabel.Name = "ResultIsTrueLabel";
            this.ResultIsTrueLabel.Size = new System.Drawing.Size(93, 33);
            this.ResultIsTrueLabel.TabIndex = 4;
            this.ResultIsTrueLabel.Text = "label1";
            this.ResultIsTrueLabel.Click += new System.EventHandler(this.ResultIsTrueLabel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 40);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(76, 36);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // NotificationLabel
            // 
            this.NotificationLabel.AutoSize = true;
            this.NotificationLabel.BackColor = System.Drawing.Color.Transparent;
            this.NotificationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationLabel.ForeColor = System.Drawing.Color.Red;
            this.NotificationLabel.Location = new System.Drawing.Point(318, 531);
            this.NotificationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NotificationLabel.Name = "NotificationLabel";
            this.NotificationLabel.Size = new System.Drawing.Size(0, 33);
            this.NotificationLabel.TabIndex = 6;
            // 
            // TextSimilarityResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1012, 685);
            this.Controls.Add(this.NotificationLabel);
            this.Controls.Add(this.ResultIsTrueLabel);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.AddArticleQuestion);
            this.Controls.Add(this.ResultIsFalseLabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TextSimilarityResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "!News";
            this.Load += new System.EventHandler(this.TextSimilarityResult_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResultIsFalseLabel;
        private System.Windows.Forms.Label AddArticleQuestion;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Label ResultIsTrueLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label NotificationLabel;
    }
}