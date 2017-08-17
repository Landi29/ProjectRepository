using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ChangeDatabase;
using PathMakerToDatabase;

namespace GUIprototype
{
    public partial class AddArticleToTags : Form
    {

        List<string> Article;
        string Filename;
        string TrueOrFalse;
        AddArticleUserChoice PastForm;

        public AddArticleToTags(List<string> Article, string Filename, string TrueOrFalse,AddArticleUserChoice PastForm)
        {
            InitializeComponent();
            this.Article = Article;
            this.Filename = Filename;
            this.TrueOrFalse = TrueOrFalse;
            this.PastForm = PastForm;

            ChooseTagsBox.CheckOnClick = true;
            var FindPath = new PathToDatabase();
            string PathToTags = FindPath.PathToArticleDatabase;
            string[] Tags = (from dir in Directory.GetDirectories(PathToTags) select Path.GetFileNameWithoutExtension(dir)).ToArray();

            ChooseTagsBox.Items.AddRange(Tags);

        }


        private void AddArticleToTags_Load(object sender, EventArgs e)
        {

        }

        private void ChooseTagsMessage_Click(object sender, EventArgs e)
        {

        }

        private void ChooseTagsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddArticleButton_Click(object sender, EventArgs e)
        {
            List<string> CheckedTags = new List<string>();

            foreach (var item in ChooseTagsBox.CheckedItems)
            {
                CheckedTags.Add(item.ToString());
            }

            // Adds the article and its filename to the database.
            AddOrRemoveArticle AddArticleToTags = new AddOrRemoveArticle(Article, Filename);
            AddArticleToTags.AddArticle("CurrentTag", TrueOrFalse, CheckedTags);

            this.Close();
            PastForm.Show();
        }

        private void backToMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
