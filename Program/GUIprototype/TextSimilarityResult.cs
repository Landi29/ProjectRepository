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
    public partial class TextSimilarityResult : Form
    {
        TextSimilarityForm Pastform;
        DisplayTextSimilarityResult DisplayResult = new DisplayTextSimilarityResult();

        public TextSimilarityResult(TextSimilarityForm pastForm)
        {
            InitializeComponent();
            Pastform = pastForm;

            // Checks if both similarity methods were chosen and calls the resulting method from the DisplayTextSimilarityResult class. 
            if (pastForm.compareTextJaccard != null && pastForm.compareTextCosine != null)
            {
                ResultIsFalseLabel.Text = DisplayResult.BothSimilaritymethods(pastForm.compareTextJaccard.FalseArticlesSimilarity, 
                                          pastForm.compareTextJaccard.TrueArticlesSimilarity, pastForm.compareTextCosine.FalseArticlesSimilarity, 
                                          pastForm.compareTextCosine.TrueArticlesSimilarity); 

                ResultIsTrueLabel.Text = "";
            }
            // Checks if jaccard similarity was chosen and calls the resulting methods from the class. 
            else if(pastForm.compareTextJaccard != null)
            {
                DisplayResult.JaccardSimilaritymethod(pastForm.compareTextJaccard.FalseArticlesSimilarity, pastForm.compareTextJaccard.TrueArticlesSimilarity);

                ResultIsFalseLabel.Text = $"The greatest similarity with false texts is: {DisplayResult.resultIsFalse}";

                if (DisplayResult.resultIsFalse == "Almost identical")
                    NotificationLabel.Text = "The article is Fake News";
                    

                ResultIsTrueLabel.Text = $"The greatest similarity with true texts is: {DisplayResult.resultIsTrue}";
            }

            //Cosine similarity was chosen and the correct methods are called. 
            else
            {
                DisplayResult.CosineSimilaritymethod(pastForm.compareTextCosine.FalseArticlesSimilarity, pastForm.compareTextCosine.TrueArticlesSimilarity);

                ResultIsFalseLabel.Text = $"The greatest similarity with false texts is: {DisplayResult.resultIsFalse}";

                if (DisplayResult.resultIsFalse == "Almost identical")
                    NotificationLabel.Text = "The article is Fake News";

                ResultIsTrueLabel.Text = $"The greatest similarity with true texts is: { DisplayResult.resultIsTrue}";
            }
   
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            // Create new form.
            ChooseCreateFileNameForm ChooseOption = new ChooseCreateFileNameForm(Pastform.Pastform.NewsArticleText, Pastform.trueOrFalse);
            this.Hide();
            ChooseOption.Show();

        }

        private void TextSimilarityResult_Load(object sender, EventArgs e)
        {

        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            Form1 StartForm = new Form1();
            this.Close();
            StartForm.Show();
        }

       

        private void AddArticleQuestion_Click(object sender, EventArgs e)
        {

        }

        private void ResultIsTrueLabel_Click(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pastform.Show();
            this.Hide();
            
        }
    }
}
