namespace GUIprototype
{
    partial class CreateDateAndFileNameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateDateAndFileNameForm));
            this.label1 = new System.Windows.Forms.Label();
            this.FilenameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DayOfMonthBox = new System.Windows.Forms.TextBox();
            this.MonthOfYearBox = new System.Windows.Forms.TextBox();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddFileButton = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(220, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter a name and date for the file.";
            // 
            // FilenameBox
            // 
            this.FilenameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilenameBox.Location = new System.Drawing.Point(91, 260);
            this.FilenameBox.Name = "FilenameBox";
            this.FilenameBox.Size = new System.Drawing.Size(167, 40);
            this.FilenameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(85, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filename";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DayOfMonthBox
            // 
            this.DayOfMonthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayOfMonthBox.Location = new System.Drawing.Point(303, 260);
            this.DayOfMonthBox.Name = "DayOfMonthBox";
            this.DayOfMonthBox.Size = new System.Drawing.Size(167, 40);
            this.DayOfMonthBox.TabIndex = 3;
            // 
            // MonthOfYearBox
            // 
            this.MonthOfYearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthOfYearBox.Location = new System.Drawing.Point(504, 260);
            this.MonthOfYearBox.Name = "MonthOfYearBox";
            this.MonthOfYearBox.Size = new System.Drawing.Size(167, 40);
            this.MonthOfYearBox.TabIndex = 4;
            // 
            // YearBox
            // 
            this.YearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearBox.Location = new System.Drawing.Point(716, 260);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(167, 40);
            this.YearBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(297, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Day (dd)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(498, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Month (mm)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(718, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 33);
            this.label5.TabIndex = 8;
            this.label5.Text = "Year (yyyy)";
            // 
            // AddFileButton
            // 
            this.AddFileButton.BackColor = System.Drawing.Color.Black;
            this.AddFileButton.ForeColor = System.Drawing.Color.White;
            this.AddFileButton.Location = new System.Drawing.Point(405, 396);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(186, 86);
            this.AddFileButton.TabIndex = 9;
            this.AddFileButton.Text = "Add file";
            this.AddFileButton.UseVisualStyleBackColor = false;
            this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1013, 40);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToMenuToolStripMenuItem
            // 
            this.backToMenuToolStripMenuItem.Name = "backToMenuToolStripMenuItem";
            this.backToMenuToolStripMenuItem.Size = new System.Drawing.Size(178, 36);
            this.backToMenuToolStripMenuItem.Text = "Back To Menu";
            this.backToMenuToolStripMenuItem.Click += new System.EventHandler(this.backToMenuToolStripMenuItem_Click);
            // 
            // CreateDateAndFileNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1013, 684);
            this.Controls.Add(this.AddFileButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.MonthOfYearBox);
            this.Controls.Add(this.DayOfMonthBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FilenameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CreateDateAndFileNameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "!News";
            this.Load += new System.EventHandler(this.CreateDateAndFileNameForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilenameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DayOfMonthBox;
        private System.Windows.Forms.TextBox MonthOfYearBox;
        private System.Windows.Forms.TextBox YearBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddFileButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToMenuToolStripMenuItem;
    }
}