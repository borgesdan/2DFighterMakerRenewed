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
            CharTabPage = new TabPage();
            splitContainer1 = new SplitContainer();
            CharTabPanel = new TabControl();
            AnimationTabPage = new TabPage();
            tabPage2 = new TabPage();
            splitContainer2 = new SplitContainer();
            toolStrip1 = new ToolStrip();
            OpenImageWindowButton = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            MainToolMenu.SuspendLayout();
            MainTabPanel.SuspendLayout();
            CharTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            CharTabPanel.SuspendLayout();
            AnimationTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.SuspendLayout();
            toolStrip1.SuspendLayout();
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
            MainTabPanel.Controls.Add(CharTabPage);
            MainTabPanel.Dock = DockStyle.Fill;
            MainTabPanel.Location = new Point(0, 25);
            MainTabPanel.Name = "MainTabPanel";
            MainTabPanel.SelectedIndex = 0;
            MainTabPanel.Size = new Size(1280, 673);
            MainTabPanel.TabIndex = 1;
            // 
            // ConfigTabPage
            // 
            ConfigTabPage.Location = new Point(4, 24);
            ConfigTabPage.Name = "ConfigTabPage";
            ConfigTabPage.Padding = new Padding(3);
            ConfigTabPage.Size = new Size(1272, 645);
            ConfigTabPage.TabIndex = 0;
            ConfigTabPage.Text = "Configurações";
            ConfigTabPage.UseVisualStyleBackColor = true;
            // 
            // CharTabPage
            // 
            CharTabPage.Controls.Add(splitContainer1);
            CharTabPage.Location = new Point(4, 24);
            CharTabPage.Name = "CharTabPage";
            CharTabPage.Padding = new Padding(3);
            CharTabPage.Size = new Size(1272, 645);
            CharTabPage.TabIndex = 1;
            CharTabPage.Text = "Personagens";
            CharTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(CharTabPanel);
            splitContainer1.Size = new Size(1266, 639);
            splitContainer1.SplitterDistance = 194;
            splitContainer1.TabIndex = 0;
            // 
            // CharTabPanel
            // 
            CharTabPanel.Controls.Add(AnimationTabPage);
            CharTabPanel.Controls.Add(tabPage2);
            CharTabPanel.Dock = DockStyle.Fill;
            CharTabPanel.Location = new Point(0, 0);
            CharTabPanel.Name = "CharTabPanel";
            CharTabPanel.SelectedIndex = 0;
            CharTabPanel.Size = new Size(1068, 639);
            CharTabPanel.TabIndex = 0;
            // 
            // AnimationTabPage
            // 
            AnimationTabPage.Controls.Add(splitContainer2);
            AnimationTabPage.Location = new Point(4, 24);
            AnimationTabPage.Name = "AnimationTabPage";
            AnimationTabPage.Padding = new Padding(3);
            AnimationTabPage.Size = new Size(1060, 611);
            AnimationTabPage.TabIndex = 0;
            AnimationTabPage.Text = "Animações";
            AnimationTabPage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 72);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(toolStrip1);
            splitContainer2.Size = new Size(1054, 605);
            splitContainer2.SplitterDistance = 257;
            splitContainer2.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { OpenImageWindowButton, toolStripButton2, toolStripButton3, toolStripButton4 });
            toolStrip1.Location = new Point(0, 580);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(257, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // OpenImageWindowButton
            // 
            OpenImageWindowButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            OpenImageWindowButton.Image = (Image)resources.GetObject("OpenImageWindowButton.Image");
            OpenImageWindowButton.ImageTransparentColor = Color.Magenta;
            OpenImageWindowButton.Name = "OpenImageWindowButton";
            OpenImageWindowButton.Size = new Size(23, 22);
            OpenImageWindowButton.Text = "Abrir";
            OpenImageWindowButton.Click += OpenImageWindowButton_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 22);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(23, 22);
            toolStripButton4.Text = "toolStripButton4";
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
            CharTabPage.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            CharTabPanel.ResumeLayout(false);
            AnimationTabPage.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        private TabPage CharTabPage;
        private SplitContainer splitContainer1;
        private TabControl CharTabPanel;
        private TabPage AnimationTabPage;
        private TabPage tabPage2;
        private SplitContainer splitContainer2;
        private ToolStrip toolStrip1;
        private ToolStripButton OpenImageWindowButton;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
    }
}
