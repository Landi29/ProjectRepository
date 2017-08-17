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

namespace GUIprototype
{
    public partial class ChooseALinkOrFileForm : Form
    {
        public List<string> NewsArticle;
        public string articleName;
        public ChooseALinkOrFileForm()
        {
            InitializeComponent();
        }

        // Event handler for the WebLinkButton.
        private void WebLinkButton_Click(object sender, EventArgs e)
        {
            CheckText WebLink = new CheckText();
            this.Hide();
            WebLink.Show();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            // Sets the filter of the OpenFileDialog to allow .txt files. 
            openFileDialog1.Filter = "Text Files (.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Sets the path of the file and reads the file into a list of strings. 
                string path = openFileDialog1.FileName;
                NewsArticle = (File.ReadAllLines(path)).ToList();
                
                ChooseTagForm ChooseTags = new ChooseTagForm(this);
                this.Hide();
                ChooseTags.Show();  
            }
        }

        private void ChooseALinkOrFileForm_Load(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
