using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JaccardSimilarityLibrary;
using ChangeDatabase;
using System.IO;
using PathMakerToDatabase;

namespace GUIprototype
{
    public partial class Form1 : Form
    {

        public string ArticleName;
        public Form1()
        {
            InitializeComponent();
        }

        public CheckText CheckText = new CheckText();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // The following is code for severeal button click event handlers. 
        private void checkText_Click(object sender, EventArgs e)
        {
            ChooseALinkOrFileForm ChooseLinkOrFile = new ChooseALinkOrFileForm();
            this.Hide();
            ChooseLinkOrFile.Show();
        }

        
        private void UpdateDatabase_Click(object sender, EventArgs e)
        {
            // This will update the database automatically. 
            AutomaticRemoveFromDatabase UpdateDatabase = new AutomaticRemoveFromDatabase();

            UpdateDatabase.FindOutdatedFolder();
            MessageBox.Show("Update of database has been performed");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            // Creating new instance of the PathToDatabase class to set the initial directory of the instance of the OpenFileDialog class. 
            PathToDatabase Path = new PathToDatabase();
            openFileDialog1.InitialDirectory = Path.PathToArticleDatabase;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Save the name of the article.
                ArticleName = openFileDialog1.SafeFileName;
                // Creating new instance of class to remove article. 
                ChangeDatabase.AddOrRemoveArticle RemoveArticle = new ChangeDatabase.AddOrRemoveArticle(ArticleName);
                
                // Instantiating and showing new form. 
                RemoveArticleChoices RemoveArticleForm = new RemoveArticleChoices(RemoveArticle);

                this.Hide();

                RemoveArticleForm.Show();
             
            }
                
        }

        private void CloseProgramButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
