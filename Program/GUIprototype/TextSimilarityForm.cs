using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebArticleURLToText;
using JaccardSimilarityLibrary;
using CompareTexts;



namespace GUIprototype
{
    public partial class TextSimilarityForm : Form
    {

        
        public ChooseTagForm Pastform;

        private string[] CheckedTagsCollection;
        public CompareTextUsingCosineSimilarity compareTextCosine; 
        public CompareTextUsingJaccardSimilarity compareTextJaccard;
        public string trueOrFalse = "True";
        

        public TextSimilarityForm(ChooseTagForm pastform)
        {
            InitializeComponent();

            // Setting the instance of chooseTagForm equel to the parameter that is passed in the constructer. 
            Pastform = pastform;

            List<string> CheckedTags = new List<string>();

            foreach (var item in pastform.NewsTagsBox.CheckedItems)
            {
                CheckedTags.Add(item.ToString());
            }

            CheckedTagsCollection = CheckedTags.ToArray();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextSimilarityForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        // Event handler method for checking the news article by using the different textsimilarity methods. 
        private void CheckButton_Click(object sender, EventArgs e)
        {
            if ((string)comboBox1.SelectedItem == "Jaccard similarity.")
            {
                List<string> text = Pastform.NewsArticleText;

                compareTextJaccard = new CompareTextUsingJaccardSimilarity(text, CheckedTagsCollection);

                if (compareTextJaccard.FalseArticlesSimilarity > compareTextJaccard.TrueArticlesSimilarity)
                    trueOrFalse = "False";
                else
                    trueOrFalse = "True";
            }
            else if ((string)comboBox1.SelectedItem == "Cosine similarity.")
            {
                List<string> text = Pastform.NewsArticleText;

                compareTextCosine = new CompareTextUsingCosineSimilarity(text, CheckedTagsCollection);

                if (compareTextCosine.FalseArticlesSimilarity > compareTextCosine.TrueArticlesSimilarity)
                    trueOrFalse = "False";
                else
                    trueOrFalse = "True";
            }
            else
            {
                List<string> text = Pastform.NewsArticleText;

                compareTextJaccard = new CompareTextUsingJaccardSimilarity(text, CheckedTagsCollection);

                compareTextCosine = new CompareTextUsingCosineSimilarity(text, CheckedTagsCollection);

                if (compareTextJaccard.FalseArticlesSimilarity > compareTextJaccard.TrueArticlesSimilarity)
                    trueOrFalse = "False";

                if (compareTextCosine.FalseArticlesSimilarity > compareTextCosine.TrueArticlesSimilarity)
                    trueOrFalse = "False";
            }

            TextSimilarityResult SimilarityResult = new TextSimilarityResult(this);
            this.Hide();
            SimilarityResult.Show();

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pastform.Show();
        }
    }
}
