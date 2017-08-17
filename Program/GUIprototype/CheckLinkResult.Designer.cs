namespace GUIprototype
{
    partial class CheckLinkResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckLinkResult));
            this.Messagelabel = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.previousForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Messagelabel
            // 
            this.Messagelabel.AutoSize = true;
            this.Messagelabel.BackColor = System.Drawing.Color.Transparent;
            this.Messagelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Messagelabel.ForeColor = System.Drawing.Color.White;
            this.Messagelabel.Location = new System.Drawing.Point(102, 60);
            this.Messagelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Messagelabel.Name = "Messagelabel";
            this.Messagelabel.Size = new System.Drawing.Size(308, 36);
            this.Messagelabel.TabIndex = 0;
            this.Messagelabel.Text = "The link does not lead to a trustworthy site.\r\nDo you want to continue by extract" +
    "ing the file?";
            this.Messagelabel.Click += new System.EventHandler(this.Messagelabel_Click);
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.Black;
            this.continueButton.ForeColor = System.Drawing.Color.White;
            this.continueButton.Location = new System.Drawing.Point(298, 192);
            this.continueButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(93, 45);
            this.continueButton.TabIndex = 1;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // previousForm
            // 
            this.previousForm.BackColor = System.Drawing.Color.Black;
            this.previousForm.ForeColor = System.Drawing.Color.White;
            this.previousForm.Location = new System.Drawing.Point(105, 192);
            this.previousForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.previousForm.Name = "previousForm";
            this.previousForm.Size = new System.Drawing.Size(93, 45);
            this.previousForm.TabIndex = 3;
            this.previousForm.Text = "Back";
            this.previousForm.UseVisualStyleBackColor = false;
            this.previousForm.Click += new System.EventHandler(this.previousForm_Click);
            // 
            // CheckLinkResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(506, 356);
            this.Controls.Add(this.previousForm);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.Messagelabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CheckLinkResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "!News";
            this.Load += new System.EventHandler(this.CheckLinkResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Messagelabel;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button previousForm;
    }
}