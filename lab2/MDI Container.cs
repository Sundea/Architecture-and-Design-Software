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


    }
}
