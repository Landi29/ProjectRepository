using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckLinkTrustworthinessLibrary;
using WebArticleURLToText;
using System.Net;

namespace GUIprototype
{
    public partial class CheckText : Form
    {
        public string weblink;
        public NewsPage ArticleText;
        public CheckText()
        {
            InitializeComponent();
            
        }


        private void URLbox_TextChanged(object sender, EventArgs e)
        {


        }

        private void CheckLink_Click(object sender, EventArgs e)
        {

            weblink = URLbox.Text;
            CheckLinkTrustworthiness link = new CheckLinkTrustworthiness();

            try
            {
                link.IsLinkValid(URLbox.Text);
                
            }

            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message);
            }

            if (link.CheckLink(URLbox.Text))
            {
                this.Hide();
                // Create instance of form CheckLinkResult and pass the current CheckText as a parameter to the constructer.
                CheckLinkResult CheckLinkResult = new CheckLinkResult(this);
                CheckLinkResult.Show();
                
            }

            else
            {
                try
                {
                    NewsPage Article = new NewsPage(weblink);
                    ArticleText = Article;
                    ChooseTagForm TagsForm = new ChooseTagForm(this);
                    this.Hide();
                    TagsForm.Show();
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

                catch (ArgumentException Argument)
                {


                    if (DialogResult.OK == MessageBox.Show(Argument.Message))
                    {
                        this.Hide();
                        Form1 StartForm = new Form1();
                        StartForm.Show();
                    }
                }

                catch (KeyNotFoundException)
                {
                    if (DialogResult.OK == MessageBox.Show("The article that has been linked to cannot be extracted. Please check the README file and try again."))
                    {
                        Form1 StartForm = new Form1();
                        this.Hide();
                        StartForm.Show();
                    }
                }

            }

        }

        private void CheckText_Load(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChooseALinkOrFileForm().Show();
            this.Hide();
        }
    }
}
