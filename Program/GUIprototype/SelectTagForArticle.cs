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
    public partial class SelectTagForArticle : Form
    {
        AddOrRemoveArticle RemoveArticle;

        public SelectTagForArticle(AddOrRemoveArticle RemoveArticle)
        {
            InitializeComponent();

            // The box must load the resent tags from the database folder. 
            ChooseTagsBox.CheckOnClick = true;
            PathToDatabase FindPath = new PathToDatabase();
            string PathToTags = FindPath.PathToArticleDatabase;
            string[] Tags = (from dir in Directory.GetDirectories(PathToTags) select Path.GetFileNameWithoutExtension(dir)).ToArray();

            ChooseTagsBox.Items.AddRange(Tags);

            this.RemoveArticle = RemoveArticle; 
            
        }
 
         
        private void ChooseTagsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectTagForArticle_Load(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            // Creating a list of strings that contains the checked tags. 
            List<string> CheckedTags = new List<string>();

            foreach (var item in ChooseTagsBox.CheckedItems)
            {
                CheckedTags.Add(item.ToString());
            }

            // Removing the article from the selected tags. 
            foreach (string Tag in CheckedTags)
            {
                RemoveArticle.RemoveArticleFromTag(Tag);
            }

            if(DialogResult.OK ==  MessageBox.Show("The article has been removed from the tag folders"))
            {
                Form1 StartForm = new Form1();
                this.Close();
                StartForm.Show();
            }

        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
