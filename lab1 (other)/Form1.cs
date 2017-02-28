using System;
using System.Windows.Forms;

namespace lab1__other_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void colorPickerStripClick(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.ShowDialog();
            if (textEditor.SelectedText != String.Empty)
            {
                textEditor.SelectionColor = dialog.Color;
            }
        }

        private void saveFileButtonClick(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "*.rtf";
            saveDialog.Filter = "Rich text file|*.rtf";
            saveDialog.Title = "Save File";

            if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK 
                && saveDialog.FileName != String.Empty)
            {
                textEditor.SaveFile(saveDialog.FileName, RichTextBoxStreamType.RichText);
                this.Text = saveDialog.FileName;
            }
        }

        private void newTextFileClick(object sender, EventArgs e)
        {
            if (textEditor.Text != String.Empty)
            {
                const string message = "Current File not empty";
                const string caption = "Save It?";
                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNoCancel);
                if (result == System.Windows.Forms.DialogResult.No)
                {
                    textEditor.Text = "";
                }
                else if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.DefaultExt = "*.rtf";
                    saveDialog.Filter = "Rich text file|*.rtf";
                    saveDialog.Title = "Save File";

                    if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK
                        && saveDialog.FileName != String.Empty)
                    {
                        textEditor.SaveFile(saveDialog.FileName, RichTextBoxStreamType.RichText);
                        textEditor.Text = "";
                    }
                }
            }
        }
    }
}
