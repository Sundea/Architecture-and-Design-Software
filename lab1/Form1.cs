using System;
using System.Drawing;
using System.Windows.Forms;
using CustomExtension;
namespace lab1
{
    public partial class Form1 : Form
    {
        private int Step
        {
            get
            {
                return Decimal.ToInt32(StepUpDown.Value);
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    StepUpDown.Value = value;
                }
            }
        }
        private ContextMenu buttonAreaContextMenu;
        private Size StartSize { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.StartSize = this.Size;
            this.buttonAreaContextMenu = new ContextMenu();
            this.buttonAreaContextMenu.MenuItems.Add(new MenuItem("Up", upArrowClick));
            this.buttonAreaContextMenu.MenuItems.Add(new MenuItem("Down", downArrowClick));
            this.buttonAreaContextMenu.MenuItems.Add(new MenuItem("Left", leftArrowClick));
            this.buttonAreaContextMenu.MenuItems.Add(new MenuItem("Right", rightArrowClick));
            this.ButtonAreaPanel.ContextMenu = buttonAreaContextMenu;
        }


        private void moveSpecialButtonTo(int x, int y)
        {
            var point = new Point(x, y);

            if (ButtonToMove.canMoveToPoint(point))
            {
                this.ButtonToMove.Location = point;
            } 
            else if (notificationCheckBox.Checked)
            {
                const string message = "Error";
                const string caption = "Wrong coordinates";
                MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
        }

        private void upArrowClick(object sender, EventArgs e)
        {
            moveSpecialButtonTo(ButtonToMove.Left, ButtonToMove.Top - Step);
        }

        private void downArrowClick(object sender, EventArgs e)
        {
            moveSpecialButtonTo(ButtonToMove.Left, ButtonToMove.Top + Step);
        }

        private void leftArrowClick(object sender, EventArgs e)
        {
            moveSpecialButtonTo(ButtonToMove.Left - Step, ButtonToMove.Top);
        }

        private void rightArrowClick(object sender, EventArgs e)
        {
            moveSpecialButtonTo(ButtonToMove.Left + Step, ButtonToMove.Top);
        }

        private void numericKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar));
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool result = true;

            switch (keyData)
            {
                case Keys.Up: moveSpecialButtonTo(ButtonToMove.Left, ButtonToMove.Top - Step); break;
                case Keys.Down: moveSpecialButtonTo(ButtonToMove.Left, ButtonToMove.Top + Step); break;
                case Keys.Right: moveSpecialButtonTo(ButtonToMove.Left + Step, ButtonToMove.Top); break;
                case Keys.Left: moveSpecialButtonTo(ButtonToMove.Left - Step, ButtonToMove.Top); break;
                default: result = base.ProcessCmdKey(ref msg, keyData); break;
            }

            return result;
        }

        private void mouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.buttonAreaContextMenu.Show((Control)sender, e.Location);
            }
        }

        private void performMenuClick(object sender, EventArgs e)
        {
            buttonAreaContextMenu.MenuItems[0].PerformClick();
        }

        private void rearangeMenuOrder(object sender, EventArgs e)
        {
            var firstItem = buttonAreaContextMenu.MenuItems[0];
            buttonAreaContextMenu.MenuItems.RemoveAt(0);
            buttonAreaContextMenu.MenuItems.Add(firstItem);
        }

        private void changeArea(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;
            var value = Decimal.ToInt32(numeric.Value);
            this.Size = new Size(this.StartSize.Width + value, this.StartSize.Height + value);
        }
    }
}
