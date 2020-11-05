namespace VisualSoftwareSystem
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DrawingOutput = new System.Windows.Forms.PictureBox();
            this.CommandLineTextBox = new System.Windows.Forms.TextBox();
            this.CommandLineRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ErrorMessageBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1253, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // DrawingOutput
            // 
            this.DrawingOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DrawingOutput.Location = new System.Drawing.Point(286, 41);
            this.DrawingOutput.Name = "DrawingOutput";
            this.DrawingOutput.Size = new System.Drawing.Size(941, 315);
            this.DrawingOutput.TabIndex = 1;
            this.DrawingOutput.TabStop = false;
            this.DrawingOutput.Click += new System.EventHandler(this.pictureBox1_Click);
            this.DrawingOutput.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingOutput_Paint);
            // 
            // CommandLineTextBox
            // 
            this.CommandLineTextBox.Location = new System.Drawing.Point(24, 375);
            this.CommandLineTextBox.Name = "CommandLineTextBox";
            this.CommandLineTextBox.Size = new System.Drawing.Size(231, 22);
            this.CommandLineTextBox.TabIndex = 2;
            this.CommandLineTextBox.TextChanged += new System.EventHandler(this.commandLine_TextChanged);
            this.CommandLineTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.commandLine_KeyDown);
            // 
            // CommandLineRichTextBox
            // 
            this.CommandLineRichTextBox.Location = new System.Drawing.Point(24, 41);
            this.CommandLineRichTextBox.Name = "CommandLineRichTextBox";
            this.CommandLineRichTextBox.Size = new System.Drawing.Size(231, 315);
            this.CommandLineRichTextBox.TabIndex = 3;
            this.CommandLineRichTextBox.Text = "";
            this.CommandLineRichTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.CommandLineRichTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            // 
            // ErrorMessageBox
            // 
            this.ErrorMessageBox.BackColor = System.Drawing.SystemColors.Info;
            this.ErrorMessageBox.Location = new System.Drawing.Point(286, 375);
            this.ErrorMessageBox.Multiline = true;
            this.ErrorMessageBox.Name = "ErrorMessageBox";
            this.ErrorMessageBox.Size = new System.Drawing.Size(941, 63);
            this.ErrorMessageBox.TabIndex = 4;
            this.ErrorMessageBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ErrorMessageBox_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 450);
            this.Controls.Add(this.ErrorMessageBox);
            this.Controls.Add(this.CommandLineRichTextBox);
            this.Controls.Add(this.CommandLineTextBox);
            this.Controls.Add(this.DrawingOutput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Visual Software System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox DrawingOutput;
        private System.Windows.Forms.TextBox CommandLineTextBox;
        private System.Windows.Forms.RichTextBox CommandLineRichTextBox;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TextBox ErrorMessageBox;
    }
}

