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
    public partial class CreateFileNameForm : Form
    {
        List<string> Article;
        string TrueOrFalse;

        public CreateFileNameForm(List<string> Article, string TrueOrFalse)
        {
            this.Article = Article;
            this.TrueOrFalse = TrueOrFalse;
            InitializeComponent();
        }

        private void CreateFileButton_Click(object sender, EventArgs e)
        {
            // Creates new instance of the CreateArticleFileName class. 
            CreateArticleFileName CreateFileName = new CreateArticleFileName(FileNameBox.Text, DateTime.Now);

            // Shows a messagebox with information and checks if the user has pressed the ok button.
            // When the button is pressed, an instance of the AddArticleUserChoise form is created and showed to the user.  
           if(DialogResult.OK == MessageBox.Show("The filename has been created"))
            {
                AddArticleUserChoice AddArticle = new AddArticleUserChoice(Article, CreateFileName.ArticleName, TrueOrFalse);
                this.Hide();
                AddArticle.Show();
            }
        }

        private void CreateFileNameForm_Load(object sender, EventArgs e)
        {
            
        }

        private void FileNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
