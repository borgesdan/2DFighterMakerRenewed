namespace Editor
{
    partial class ImageFileManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageFileManagerForm));
            toolMenu = new ToolStrip();
            OpenImageButton = new ToolStripButton();
            BackwardSelectedImageButton = new ToolStripButton();
            ReplaceSelectedImageButton = new ToolStripButton();
            ForwardSelectedImageButton = new ToolStripButton();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            toolMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toolMenu
            // 
            toolMenu.Items.AddRange(new ToolStripItem[] { OpenImageButton, BackwardSelectedImageButton, ReplaceSelectedImageButton, ForwardSelectedImageButton });
            toolMenu.Location = new Point(0, 0);
            toolMenu.Name = "toolMenu";
            toolMenu.Size = new Size(800, 25);
            toolMenu.TabIndex = 0;
            toolMenu.Text = "toolStrip1";
            // 
            // OpenImageButton
            // 
            OpenImageButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            OpenImageButton.Image = (Image)resources.GetObject("OpenImageButton.Image");
            OpenImageButton.ImageTransparentColor = Color.Magenta;
            OpenImageButton.Name = "OpenImageButton";
            OpenImageButton.Size = new Size(37, 22);
            OpenImageButton.Text = "Abrir";
            OpenImageButton.Click += OpenImageButton_Click;
            // 
            // BackwardSelectedImageButton
            // 
            BackwardSelectedImageButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            BackwardSelectedImageButton.Image = (Image)resources.GetObject("BackwardSelectedImageButton.Image");
            BackwardSelectedImageButton.ImageTransparentColor = Color.Magenta;
            BackwardSelectedImageButton.Name = "BackwardSelectedImageButton";
            BackwardSelectedImageButton.Size = new Size(41, 22);
            BackwardSelectedImageButton.Text = "Antes";
            BackwardSelectedImageButton.Click += BackwardSelectedImageButton_Click;
            // 
            // ReplaceSelectedImageButton
            // 
            ReplaceSelectedImageButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ReplaceSelectedImageButton.Image = (Image)resources.GetObject("ReplaceSelectedImageButton.Image");
            ReplaceSelectedImageButton.ImageTransparentColor = Color.Magenta;
            ReplaceSelectedImageButton.Name = "ReplaceSelectedImageButton";
            ReplaceSelectedImageButton.Size = new Size(61, 22);
            ReplaceSelectedImageButton.Text = "Substituir";
            ReplaceSelectedImageButton.Click += ReplaceSelectedImageButton_Click;
            // 
            // ForwardSelectedImageButton
            // 
            ForwardSelectedImageButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ForwardSelectedImageButton.Image = (Image)resources.GetObject("ForwardSelectedImageButton.Image");
            ForwardSelectedImageButton.ImageTransparentColor = Color.Magenta;
            ForwardSelectedImageButton.Name = "ForwardSelectedImageButton";
            ForwardSelectedImageButton.Size = new Size(47, 22);
            ForwardSelectedImageButton.Text = "Depois";
            ForwardSelectedImageButton.Click += ForwardSelectedImageButton_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 425);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ImageFileManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(toolMenu);
            Name = "ImageFileManagerForm";
            Text = "Gerenciar Imagem";
            toolMenu.ResumeLayout(false);
            toolMenu.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolMenu;
        private ToolStripButton OpenImageButton;
        private Panel panel1;
        private PictureBox pictureBox1;
        private ToolStripButton ForwardSelectedImageButton;
        private ToolStripButton ReplaceSelectedImageButton;
        private ToolStripButton BackwardSelectedImageButton;
    }
}