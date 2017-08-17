using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIprototype
{
    public partial class ChooseCreateFileNameForm : Form
    {
        List<string> Article;
        string TrueOrFalse;

        public ChooseCreateFileNameForm(List<string> Article, string TrueOrFalse)
        {
            this.Article = Article;
            this.TrueOrFalse = TrueOrFalse;
            InitializeComponent();
        }

        // Event handler for the AddDateButton.click event. 
        // Creates a new instance of the CreateDateAndFileNameForm and show it to the user. 
        private void AddDateButton_Click(object sender, EventArgs e)
        {
            CreateDateAndFileNameForm CreateDateAndFile = new CreateDateAndFileNameForm(Article, TrueOrFalse, this);
            this.Hide();
            CreateDateAndFile.Show();
        }
        
        // Event handler for the CurrentDateButton.click event. 
        // Creates a new instance of the CreateFileNameForm and show it to the user. 
        private void CurrentDateButton_Click(object sender, EventArgs e)
        {
            CreateFileNameForm CreateFile = new CreateFileNameForm(Article, TrueOrFalse);
            this.Hide();
            CreateFile.Show();
        }

        private void ChooseCreateFileNameForm_Load(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CheckText().Show();
            this.Hide();
        }
    }
}
