using System;
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
    public partial class AddArticleUserChoice : Form
    {

        List<string> Article;
        string Filename;
        string TrueOrFalse;

        public AddArticleUserChoice(List<string> Article, string Filename, string TrueOrFalse)
        {
            InitializeComponent();
            this.Article = Article;
            this.Filename = Filename;
            this.TrueOrFalse = TrueOrFalse;
        }

     

        private void DoneButton_Click(object sender, EventArgs e)
        {
            // Add the article to the all articles tag.
            AddOrRemoveArticle FinishAddArticle = new AddOrRemoveArticle(Article, Filename);
            FinishAddArticle.FinishAddArticle(TrueOrFalse);

            // Show a message box with information. Go back to form 1. 
            if(DialogResult.OK == MessageBox.Show("The article was added to the all articles tag. Press OK to return to homescreen"))
            {
                Form1 StartForm = new Form1();
                this.Close();
                StartForm.Show();
            }
        }

        private void CurrentTagButton_Click(object sender, EventArgs e)
        {
            AddArticleToTags AddToTags = new AddArticleToTags(Article,Filename,TrueOrFalse,this);
            this.Hide();
            AddToTags.Show();
        }

        private void AddArticleUserChoice_Load(object sender, EventArgs e)
        {

        }

        private void NewTagButton_Click(object sender, EventArgs e)
        {
            // Creates new instance of the AddNewTagsToArticleForm.
            // This allows the user to add new tags that describes the text and also adds the tags to the database. 
            this.Hide();
            AddNewTagsToArticleForm AddNewTags = new AddNewTagsToArticleForm(Article, Filename, TrueOrFalse,this);
            AddNewTags.Show();
        }

        private void backToManuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
