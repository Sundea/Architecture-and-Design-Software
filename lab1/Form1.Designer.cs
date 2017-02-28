namespace lab1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UpArrow = new System.Windows.Forms.Button();
            this.DownArrow = new System.Windows.Forms.Button();
            this.LeftArrow = new System.Windows.Forms.Button();
            this.RightArrow = new System.Windows.Forms.Button();
            this.ButtonToMove = new System.Windows.Forms.Button();
            this.ButtonAreaPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RearangeMenu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DiagonalUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.StepUpDown = new System.Windows.Forms.NumericUpDown();
            this.notificationCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ControlsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonAreaPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagonalUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpArrow
            // 
            this.UpArrow.AccessibleName = "UpArrow";
            this.UpArrow.Location = new System.Drawing.Point(41, 19);
            this.UpArrow.Name = "UpArrow";
            this.UpArrow.Size = new System.Drawing.Size(75, 23);
            this.UpArrow.TabIndex = 0;
            this.UpArrow.Text = "↑";
            this.UpArrow.UseVisualStyleBackColor = true;
            this.UpArrow.Click += new System.EventHandler(this.upArrowClick);
            // 
            // DownArrow
            // 
            this.DownArrow.Location = new System.Drawing.Point(41, 77);
            this.DownArrow.Name = "DownArrow";
            this.DownArrow.Size = new System.Drawing.Size(75, 23);
            this.DownArrow.TabIndex = 1;
            this.DownArrow.Text = "↓";
            this.DownArrow.UseVisualStyleBackColor = true;
            this.DownArrow.Click += new System.EventHandler(this.downArrowClick);
            // 
            // LeftArrow
            // 
            this.LeftArrow.Location = new System.Drawing.Point(0, 48);
            this.LeftArrow.Name = "LeftArrow";
            this.LeftArrow.Size = new System.Drawing.Size(75, 23);
            this.LeftArrow.TabIndex = 2;
            this.LeftArrow.Text = "←";
            this.LeftArrow.UseVisualStyleBackColor = true;
            this.LeftArrow.Click += new System.EventHandler(this.leftArrowClick);
            // 
            // RightArrow
            // 
            this.RightArrow.Location = new System.Drawing.Point(89, 48);
            this.RightArrow.Name = "RightArrow";
            this.RightArrow.Size = new System.Drawing.Size(75, 23);
            this.RightArrow.TabIndex = 3;
            this.RightArrow.Text = "→";
            this.RightArrow.UseVisualStyleBackColor = true;
            this.RightArrow.Click += new System.EventHandler(this.rightArrowClick);
            // 
            // ButtonToMove
            // 
            this.ButtonToMove.Location = new System.Drawing.Point(108, 127);
            this.ButtonToMove.Name = "ButtonToMove";
            this.ButtonToMove.Size = new System.Drawing.Size(75, 23);
            this.ButtonToMove.TabIndex = 1;
            this.ButtonToMove.Text = "button1";
            this.ButtonToMove.UseVisualStyleBackColor = true;
            this.ButtonToMove.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClick);
            // 
            // ButtonAreaPanel
            // 
            this.ButtonAreaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAreaPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ButtonAreaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtonAreaPanel.Controls.Add(this.ButtonToMove);
            this.ButtonAreaPanel.Location = new System.Drawing.Point(197, 12);
            this.ButtonAreaPanel.Name = "ButtonAreaPanel";
            this.ButtonAreaPanel.Size = new System.Drawing.Size(277, 349);
            this.ButtonAreaPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RearangeMenu);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.DiagonalUpDown);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.StepUpDown);
            this.panel1.Controls.Add(this.notificationCheckBox);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 297);
            this.panel1.TabIndex = 3;
            // 
            // RearangeMenu
            // 
            this.RearangeMenu.Location = new System.Drawing.Point(41, 265);
            this.RearangeMenu.Name = "RearangeMenu";
            this.RearangeMenu.Size = new System.Drawing.Size(75, 23);
            this.RearangeMenu.TabIndex = 12;
            this.RearangeMenu.Text = "Rearange Menu";
            this.RearangeMenu.UseVisualStyleBackColor = true;
            this.RearangeMenu.Click += new System.EventHandler(this.rearangeMenuOrder);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "PerformClick";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.performMenuClick);
            // 
            // DiagonalUpDown
            // 
            this.DiagonalUpDown.Location = new System.Drawing.Point(89, 148);
            this.DiagonalUpDown.Name = "DiagonalUpDown";
            this.DiagonalUpDown.Size = new System.Drawing.Size(60, 20);
            this.DiagonalUpDown.TabIndex = 10;
            this.DiagonalUpDown.ValueChanged += new System.EventHandler(this.changeArea);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = " Крок";
            // 
            // StepUpDown
            // 
            this.StepUpDown.Location = new System.Drawing.Point(89, 174);
            this.StepUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StepUpDown.Name = "StepUpDown";
            this.StepUpDown.Size = new System.Drawing.Size(60, 20);
            this.StepUpDown.TabIndex = 8;
            this.StepUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // notificationCheckBox
            // 
            this.notificationCheckBox.AutoSize = true;
            this.notificationCheckBox.Location = new System.Drawing.Point(6, 106);
            this.notificationCheckBox.Name = "notificationCheckBox";
            this.notificationCheckBox.Size = new System.Drawing.Size(120, 17);
            this.notificationCheckBox.TabIndex = 7;
            this.notificationCheckBox.Text = "Enable Notifications";
            this.notificationCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RightArrow);
            this.groupBox1.Controls.Add(this.UpArrow);
            this.groupBox1.Controls.Add(this.LeftArrow);
            this.groupBox1.Controls.Add(this.DownArrow);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = " Діагональ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ControlsMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(496, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ControlsMenuItem
            // 
            this.ControlsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.ControlsMenuItem.Name = "ControlsMenuItem";
            this.ControlsMenuItem.Size = new System.Drawing.Size(64, 20);
            this.ControlsMenuItem.Text = "&Controls";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItem1.Text = "&Up";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.upArrowClick);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItem2.Text = "D&own";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.downArrowClick);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.toolStripMenuItem3.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItem3.Text = "&Left";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.leftArrowClick);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.toolStripMenuItem4.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItem4.Text = "&Right";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.rightArrowClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 373);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonAreaPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ButtonAreaPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagonalUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RightArrow;
        private System.Windows.Forms.Button LeftArrow;
        private System.Windows.Forms.Button DownArrow;
        private System.Windows.Forms.Button UpArrow;
        private System.Windows.Forms.Button ButtonToMove;
        private System.Windows.Forms.Panel ButtonAreaPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox notificationCheckBox;
        private System.Windows.Forms.NumericUpDown StepUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown DiagonalUpDown;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ControlsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RearangeMenu;
    }
}

