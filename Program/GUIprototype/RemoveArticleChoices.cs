﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChangeDatabase;

namespace GUIprototype
{
    public partial class RemoveArticleChoices : Form
    {
        public RemoveArticleChoices(AddOrRemoveArticle RemoveArticle)
        {
            InitializeComponent();
            this.RemoveArticle = RemoveArticle;
        }

        AddOrRemoveArticle RemoveArticle;
        private void RemoveArticleChoices_Load(object sender, EventArgs e)
        {

        }


        private void DatabaseButton_Click(object sender, EventArgs e)
        {
            // Removing the article from the entire database and returning to Form1.
            RemoveArticle.RemoveArticleFromDatabase();
            if (DialogResult.OK == MessageBox.Show("Article has been removed"))
            {
                this.Hide();
                Form1 FirstForm = new Form1();
                FirstForm.Show();
            }

        }

        private void TagButton_Click(object sender, EventArgs e)
        {
            // Create form for entering tag. 
            SelectTagForArticle TagForArticleForm = new SelectTagForArticle(RemoveArticle);
            this.Hide();
            TagForArticleForm.Show();

        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
