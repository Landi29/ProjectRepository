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
using System.Net;

namespace GUIprototype
{
    public partial class CheckLinkResult : Form
    {
        // Declaring an instance of the checkText form. 
        private CheckText pastForm;
        public NewsPage ArticleText;

        public CheckLinkResult(CheckText pastForm)
        {
            InitializeComponent();
            // Setting the instance of checkText equel to the parameter that is passed in the constructer. 
            this.pastForm = pastForm;
        }


        private void Messagelabel_Click(object sender, EventArgs e)
        {

        }

        private void CheckLinkResult_Load(object sender, EventArgs e)
        {

        }

        

        private void continueButton_Click(object sender, EventArgs e)
        {
            // Creates a new instance of the NewsPage class and ChooseTagForm form. 
            try
            {
                NewsPage article = new NewsPage(pastForm.URLbox.Text);
                ArticleText = article;
                ChooseTagForm ChooseTags = new ChooseTagForm(this);
                this.Hide();
                ChooseTags.Show();

            }

            catch (WebException)
            {

                if (DialogResult.OK == MessageBox.Show("The text from the article could not be extracted. Please make sure that the link refers to an article."))
                {
                    this.Hide();
                    Form1 StartForm = new Form1();
                    StartForm.Show();
                }
            }

            catch(ArgumentException Argument)
            {
              
                if (DialogResult.OK == MessageBox.Show(Argument.Message))
                {
                    this.Hide();
                    Form1 StartForm = new Form1();
                    StartForm.Show();
                }
            }

            catch(KeyNotFoundException)
            {
                if(DialogResult.OK == MessageBox.Show("The article that has been linked to cannot be extracted. Please check the README file and try again."))
                {
                    Form1 StartForm = new Form1();
                    this.Hide();
                    StartForm.Show();
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void previousForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            pastForm.URLbox.Clear();
            pastForm.Show();

        }
    }
}
