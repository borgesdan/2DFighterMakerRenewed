namespace Editor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MainToolMenu = new ToolStrip();
            toolStripSplitButton1 = new ToolStripSplitButton();
            novoToolStripMenuItem = new ToolStripMenuItem();
            projetoToolStripMenuItem = new ToolStripMenuItem();
            MainTabPanel = new TabControl();
            ConfigTabPage = new TabPage();
            splitContainer1 = new SplitContainer();
            MainToolMenu.SuspendLayout();
            MainTabPanel.SuspendLayout();
            ConfigTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // MainToolMenu
            // 
            MainToolMenu.Items.AddRange(new ToolStripItem[] { toolStripSplitButton1 });
            MainToolMenu.Location = new Point(0, 0);
            MainToolMenu.Name = "MainToolMenu";
            MainToolMenu.Size = new Size(1280, 25);
            MainToolMenu.TabIndex = 0;
            MainToolMenu.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem });
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(65, 22);
            toolStripSplitButton1.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { projetoToolStripMenuItem });
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(103, 22);
            novoToolStripMenuItem.Text = "Novo";
            // 
            // projetoToolStripMenuItem
            // 
            projetoToolStripMenuItem.Name = "projetoToolStripMenuItem";
            projetoToolStripMenuItem.Size = new Size(112, 22);
            projetoToolStripMenuItem.Text = "Projeto";
            // 
            // MainTabPanel
            // 
            MainTabPanel.Controls.Add(ConfigTabPage);
            MainTabPanel.Dock = DockStyle.Fill;
            MainTabPanel.Location = new Point(0, 25);
            MainTabPanel.Name = "MainTabPanel";
            MainTabPanel.SelectedIndex = 0;
            MainTabPanel.Size = new Size(1280, 673);
            MainTabPanel.TabIndex = 1;
            // 
            // ConfigTabPage
            // 
            ConfigTabPage.Controls.Add(splitContainer1);
            ConfigTabPage.Location = new Point(4, 24);
            ConfigTabPage.Name = "ConfigTabPage";
            ConfigTabPage.Padding = new Padding(3);
            ConfigTabPage.Size = new Size(1272, 645);
            ConfigTabPage.TabIndex = 0;
            ConfigTabPage.Text = "Configurações";
            ConfigTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Size = new Size(1266, 639);
            splitContainer1.SplitterDistance = 147;
            splitContainer1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 698);
            Controls.Add(MainTabPanel);
            Controls.Add(MainToolMenu);
            Name = "Form1";
            Text = "Form1";
            MainToolMenu.ResumeLayout(false);
            MainToolMenu.PerformLayout();
            MainTabPanel.ResumeLayout(false);
            ConfigTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip MainToolMenu;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem projetoToolStripMenuItem;
        private TabControl MainTabPanel;
        private TabPage ConfigTabPage;
        private SplitContainer splitContainer1;
    }
}
