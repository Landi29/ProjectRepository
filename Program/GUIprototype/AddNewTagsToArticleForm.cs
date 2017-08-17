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
    public partial class AddNewTagsToArticleForm : Form
    {
        List<string> Article;
        string Filename;
        string TrueOrFalse;
        AddArticleUserChoice PastForm;

        public AddNewTagsToArticleForm(List<string> Article, string Filename, string TrueOrFalse,AddArticleUserChoice PastForm)
        {
            InitializeComponent();
            this.Article = Article;
            this.Filename = Filename;
            this.TrueOrFalse = TrueOrFalse;
            this.PastForm = PastForm;
        }

        private void AddTagsToArticleButton_Click(object sender, EventArgs e)
        {

            List<string> Tags = new List<string>();
            Tags.Add(AddTagsBox.Text);
            
            // Adds the new tag to the article. 
            AddOrRemoveArticle AddNewTagToArticle = new AddOrRemoveArticle(Article, Filename);
            AddNewTagToArticle.AddArticle("NewTag", TrueOrFalse, Tags);

            this.Close();
            PastForm.Show();
        }

        private void AddTagsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddNewTagsToArticleForm_Load(object sender, EventArgs e)
        {

        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
