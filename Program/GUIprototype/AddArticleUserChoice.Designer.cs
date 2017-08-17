namespace GUIprototype
{
    partial class AddArticleUserChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddArticleUserChoice));
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentTagButton = new System.Windows.Forms.Button();
            this.NewTagButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(184, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(618, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do you want to add the article to a current tag?\r\n               A New tag? Or ar" +
    "e you done?";
            // 
            // CurrentTagButton
            // 
            this.CurrentTagButton.BackColor = System.Drawing.Color.Black;
            this.CurrentTagButton.ForeColor = System.Drawing.Color.White;
            this.CurrentTagButton.Location = new System.Drawing.Point(117, 317);
            this.CurrentTagButton.Name = "CurrentTagButton";
            this.CurrentTagButton.Size = new System.Drawing.Size(186, 86);
            this.CurrentTagButton.TabIndex = 1;
            this.CurrentTagButton.Text = "Current Tag";
            this.CurrentTagButton.UseVisualStyleBackColor = false;
            this.CurrentTagButton.Click += new System.EventHandler(this.CurrentTagButton_Click);
            // 
            // NewTagButton
            // 
            this.NewTagButton.BackColor = System.Drawing.Color.Black;
            this.NewTagButton.ForeColor = System.Drawing.Color.White;
            this.NewTagButton.Location = new System.Drawing.Point(387, 317);
            this.NewTagButton.Name = "NewTagButton";
            this.NewTagButton.Size = new System.Drawing.Size(186, 86);
            this.NewTagButton.TabIndex = 2;
            this.NewTagButton.Text = "New Tag";
            this.NewTagButton.UseVisualStyleBackColor = false;
            this.NewTagButton.Click += new System.EventHandler(this.NewTagButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.Black;
            this.DoneButton.ForeColor = System.Drawing.Color.White;
            this.DoneButton.Location = new System.Drawing.Point(667, 317);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(186, 86);
            this.DoneButton.TabIndex = 3;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // AddArticleUserChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1013, 684);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.NewTagButton);
            this.Controls.Add(this.CurrentTagButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddArticleUserChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "!News";
            this.Load += new System.EventHandler(this.AddArticleUserChoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CurrentTagButton;
        private System.Windows.Forms.Button NewTagButton;
        private System.Windows.Forms.Button DoneButton;
    }
}