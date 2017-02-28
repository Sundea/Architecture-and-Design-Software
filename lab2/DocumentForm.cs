using System;
using System.IO;
using System.Windows.Forms;

namespace lab2
{
    public partial class DocumentForm : Form
    {
        private bool FileWasCreated { get; set; } 
        private string path { get; set; }

        public DocumentForm()
        {
            InitializeComponent();
            this.FileWasCreated = false;
        }

        public DocumentForm(string path):this()
        {
            this.textEditor.LoadFile(path);
            this.path = path;
            this.Text = Path.GetFileNameWithoutExtension(path);
            this.FileWasCreated = true;
        }

        public void saveFile()
        {
            if (this.FileWasCreated)
            {
                resaveFile(path);
            } 
            else
            {
                createFileAndSave();
            }
        }

        public void createFileAndSave()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "*.rtf";
            saveDialog.Filter = "Rich text file|*.rtf";
            saveDialog.Title = "Save File";
            saveDialog.FileName = this.Text;

            if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK
                && saveDialog.FileName != String.Empty)
            {
                this.resaveFile(saveDialog.FileName);
                this.FileWasCreated = true;
                this.Text = Path.GetFileNameWithoutExtension(saveDialog.FileName);
            }
        }

        public void resaveFile(string fileName)
        {
            textEditor.SaveFile(fileName, RichTextBoxStreamType.RichText);
        }
    }
}
