using System;
using System.Windows.Forms;

namespace lab2
{
    public partial class MDIContainer : Form
    {
        public MDIContainer()
        {
            InitializeComponent();
        }

        private void newFile_Click(object sender, EventArgs e)
        {
            DocumentForm mdiChild = new DocumentForm();
            mdiChild.MdiParent = this;
            mdiChild.Show();
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                DocumentForm active = (DocumentForm)this.ActiveMdiChild;
                active.saveFile();
            }
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "C:\\Users\\admin\\Documents";
            openFileDialog.Filter = "Rich Text File|*.rtf";
            openFileDialog.DefaultExt = "*.rtf";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DocumentForm mdiChild = new DocumentForm(openFileDialog.FileName);
                    mdiChild.MdiParent = this;
                    mdiChild.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
