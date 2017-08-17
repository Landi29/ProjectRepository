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
    public partial class CreateDateAndFileNameForm : Form
    {
        List<string> Article;
        string TrueOrFalse;
        ChooseCreateFileNameForm PastForm;

        public CreateDateAndFileNameForm(List<string> Article, string TrueOrFalse, ChooseCreateFileNameForm PastForm)
        {
            this.Article = Article;
            this.TrueOrFalse = TrueOrFalse;
            this.PastForm = PastForm;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                CreateArticleFileName CreateFileName = new CreateArticleFileName(FilenameBox.Text, DayOfMonthBox.Text, MonthOfYearBox.Text, YearBox.Text);

                // Shows a messagebox with information to the user and waits for confirmation. 
                if (DialogResult.OK == MessageBox.Show("The filename has been created"))
                {
                    AddArticleUserChoice AddArticle = new AddArticleUserChoice(Article, CreateFileName.ArticleName, TrueOrFalse);
                    this.Hide();
                    AddArticle.Show();
                }
            }

            catch(InvalidDateException exception)
            {
                if (DialogResult.OK == MessageBox.Show(exception.Message))
                {
                    this.Close();
                    PastForm.Show();
                }

            }
        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void CreateDateAndFileNameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
