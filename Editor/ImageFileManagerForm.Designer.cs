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
            openImageButton = new ToolStripButton();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            toolMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toolMenu
            // 
            toolMenu.Items.AddRange(new ToolStripItem[] { openImageButton });
            toolMenu.Location = new Point(0, 0);
            toolMenu.Name = "toolMenu";
            toolMenu.Size = new Size(800, 25);
            toolMenu.TabIndex = 0;
            toolMenu.Text = "toolStrip1";
            // 
            // openImageButton
            // 
            openImageButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openImageButton.Image = (Image)resources.GetObject("openImageButton.Image");
            openImageButton.ImageTransparentColor = Color.Magenta;
            openImageButton.Name = "openImageButton";
            openImageButton.Size = new Size(23, 22);
            openImageButton.Text = "toolStripButton1";
            openImageButton.Click += openImageButton_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
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
        private ToolStripButton openImageButton;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}