namespace курсовик
{
    partial class ChildForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextCutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextPasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextSelectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextAlignLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextAlignCenterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextAlignRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextTextColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.boldButton = new System.Windows.Forms.ToolStripButton();
            this.italicButton = new System.Windows.Forms.ToolStripButton();
            this.underlineButton = new System.Windows.Forms.ToolStripButton();
            this.strikeoutButton = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Location = new System.Drawing.Point(0, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 422);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextCutToolStripMenuItem,
            this.contextCopyToolStripMenuItem,
            this.contextPasteToolStripMenuItem,
            this.contextSelectAllToolStripMenuItem,
            this.contextAlignLeftToolStripMenuItem,
            this.contextAlignCenterToolStripMenuItem,
            this.contextAlignRightToolStripMenuItem,
            this.contextFontToolStripMenuItem,
            this.contextTextColorToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 202);
            // 
            // contextCutToolStripMenuItem
            // 
            this.contextCutToolStripMenuItem.Name = "contextCutToolStripMenuItem";
            this.contextCutToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.contextCutToolStripMenuItem.Text = "Cut";
            this.contextCutToolStripMenuItem.Click += new System.EventHandler(this.contextCutToolStripMenuItem_Click);
            // 
            // contextCopyToolStripMenuItem
            // 
            this.contextCopyToolStripMenuItem.Name = "contextCopyToolStripMenuItem";
            this.contextCopyToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.contextCopyToolStripMenuItem.Text = "Copy";
            this.contextCopyToolStripMenuItem.Click += new System.EventHandler(this.contextCopyToolStripMenuItem_Click);
            // 
            // contextPasteToolStripMenuItem
            // 
            this.contextPasteToolStripMenuItem.Name = "contextPasteToolStripMenuItem";
            this.contextPasteToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.contextPasteToolStripMenuItem.Text = "Paste";
            this.contextPasteToolStripMenuItem.Click += new System.EventHandler(this.contextPasteToolStripMenuItem_Click);
            // 
            // contextSelectAllToolStripMenuItem
            // 
            this.contextSelectAllToolStripMenuItem.Name = "contextSelectAllToolStripMenuItem";
            this.contextSelectAllToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.contextSelectAllToolStripMenuItem.Text = "Select All";
            this.contextSelectAllToolStripMenuItem.Click += new System.EventHandler(this.contextSelectAllToolStripMenuItem_Click);
            // 
            // contextAlignLeftToolStripMenuItem
            // 
            this.contextAlignLeftToolStripMenuItem.Name = "contextAlignLeftToolStripMenuItem";
            this.contextAlignLeftToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.contextAlignLeftToolStripMenuItem.Text = "Align Left";
            this.contextAlignLeftToolStripMenuItem.Click += new System.EventHandler(this.contextAlignLeftToolStripMenuItem_Click);
            // 
            // contextAlignCenterToolStripMenuItem
            // 
            this.contextAlignCenterToolStripMenuItem.Name = "contextAlignCenterToolStripMenuItem";
            this.contextAlignCenterToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.contextAlignCenterToolStripMenuItem.Text = "Align Center";
            this.contextAlignCenterToolStripMenuItem.Click += new System.EventHandler(this.contextAlignCenterToolStripMenuItem_Click);
            // 
            // contextAlignRightToolStripMenuItem
            // 
            this.contextAlignRightToolStripMenuItem.Name = "contextAlignRightToolStripMenuItem";
            this.contextAlignRightToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.contextAlignRightToolStripMenuItem.Text = "Align Right";
            this.contextAlignRightToolStripMenuItem.Click += new System.EventHandler(this.contextAlignRightToolStripMenuItem_Click);
            // 
            // contextFontToolStripMenuItem
            // 
            this.contextFontToolStripMenuItem.Name = "contextFontToolStripMenuItem";
            this.contextFontToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.contextFontToolStripMenuItem.Text = "Font";
            this.contextFontToolStripMenuItem.Click += new System.EventHandler(this.contextFontToolStripMenuItem_Click);
            // 
            // contextTextColorToolStripMenuItem
            // 
            this.contextTextColorToolStripMenuItem.Name = "contextTextColorToolStripMenuItem";
            this.contextTextColorToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.contextTextColorToolStripMenuItem.Text = "Text Color";
            this.contextTextColorToolStripMenuItem.Click += new System.EventHandler(this.contextTextColorToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldButton,
            this.italicButton,
            this.underlineButton,
            this.strikeoutButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // boldButton
            // 
            this.boldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldButton.Image = ((System.Drawing.Image)(resources.GetObject("boldButton.Image")));
            this.boldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(23, 22);
            this.boldButton.Text = "toolStripButton1";
            this.boldButton.Click += new System.EventHandler(this.boldButton_Click);
            // 
            // italicButton
            // 
            this.italicButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicButton.Image = ((System.Drawing.Image)(resources.GetObject("italicButton.Image")));
            this.italicButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicButton.Name = "italicButton";
            this.italicButton.Size = new System.Drawing.Size(23, 22);
            this.italicButton.Text = "toolStripButton2";
            this.italicButton.Click += new System.EventHandler(this.italicButton_Click);
            // 
            // underlineButton
            // 
            this.underlineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underlineButton.Image = ((System.Drawing.Image)(resources.GetObject("underlineButton.Image")));
            this.underlineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineButton.Name = "underlineButton";
            this.underlineButton.Size = new System.Drawing.Size(23, 22);
            this.underlineButton.Text = "toolStripButton3";
            this.underlineButton.Click += new System.EventHandler(this.underlineButton_Click);
            // 
            // strikeoutButton
            // 
            this.strikeoutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.strikeoutButton.Image = ((System.Drawing.Image)(resources.GetObject("strikeoutButton.Image")));
            this.strikeoutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strikeoutButton.Name = "strikeoutButton";
            this.strikeoutButton.Size = new System.Drawing.Size(23, 22);
            this.strikeoutButton.Text = "toolStripButton4";
            this.strikeoutButton.Click += new System.EventHandler(this.strikeoutButton_Click);
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "ChildForm";
            this.Text = "ChildForm";
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.RichTextBox RichTextBox1
        {
            get { return richTextBox1; }
            set { richTextBox1 = value; }
        }
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextCutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextPasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextSelectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextAlignLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextAlignCenterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextAlignRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextTextColorToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton boldButton;
        private System.Windows.Forms.ToolStripButton italicButton;
        private System.Windows.Forms.ToolStripButton underlineButton;
        private System.Windows.Forms.ToolStripButton strikeoutButton;
    }
}