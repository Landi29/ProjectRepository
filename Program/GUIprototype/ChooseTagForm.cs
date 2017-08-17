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
using System.Net;
using WebArticleURLToText;
using PathMakerToDatabase;

namespace GUIprototype
{
    public partial class ChooseTagForm : Form
    {
        public CheckLinkResult Pastform;
        public ChooseALinkOrFileForm OtherPastForm;
        public CheckText ThirdPastForm;
        public List<string> NewsArticleText; 
        
        // Constructor for parsing a CheckLinkResult form.
        public ChooseTagForm(CheckLinkResult pastform)
        {
            InitializeComponent();
            Pastform = pastform;

            NewsTagsBox.CheckOnClick = true;
            // Loads the resent tags to an arrat and adds them to the NewsTagsBox.
            var FindPath = new PathToDatabase();
            string PathToTags = FindPath.PathToArticleDatabase;
            string[] Tags = (from dir in Directory.GetDirectories(PathToTags) select Path.GetFileNameWithoutExtension(dir)).ToArray();

            NewsTagsBox.Items.AddRange(Tags);
            NewsArticleText = pastform.ArticleText.BodyText;
        }

        // Constructer for parsing a ChooseALinkOrFileForm.
        public ChooseTagForm(ChooseALinkOrFileForm otherPastform)
        {
            InitializeComponent();
            OtherPastForm = otherPastform;

            NewsTagsBox.CheckOnClick = true;

            var FindPath = new PathToDatabase();
            string PathToTags = FindPath.PathToArticleDatabase;
            string[] Tags = (from dir in Directory.GetDirectories(PathToTags) select Path.GetFileNameWithoutExtension(dir)).ToArray();

            NewsTagsBox.Items.AddRange(Tags);
            NewsArticleText = otherPastform.NewsArticle;
        }

        // Constructer for entering a CheckText form. 
        public ChooseTagForm(CheckText pastform)
        {
            InitializeComponent();
            ThirdPastForm = pastform;

            NewsTagsBox.CheckOnClick = true;

            var FindPath = new PathToDatabase();
            string PathToTags = FindPath.PathToArticleDatabase;

            
            string[] Tags = (from dir in Directory.GetDirectories(PathToTags) select Path.GetFileNameWithoutExtension(dir)).ToArray();
            

            NewsTagsBox.Items.AddRange(Tags);

            NewsArticleText = pastform.ArticleText.BodyText;

            
        }

        private void NewsTagsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChooseTagForm_Load(object sender, EventArgs e)
        {
           
        }

        // ContinueButton.click event handler.
        private void continueButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TextSimilarityForm Textsimilarity = new TextSimilarityForm(this);
            Textsimilarity.Show();
            
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
