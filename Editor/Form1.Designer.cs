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
            FighterEditorPage = new TabPage();
            splitContainer1 = new SplitContainer();
            CharsListView = new ListView();
            CharTabPanel = new TabControl();
            AnimationTabPage = new TabPage();
            toolStrip1 = new ToolStrip();
            toolStripTextBox1 = new ToolStripTextBox();
            tabPage2 = new TabPage();
            splitContainer2 = new SplitContainer();
            toolStrip2 = new ToolStrip();
            OpenImageDialogButton = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            MainToolMenu.SuspendLayout();
            MainTabPanel.SuspendLayout();
            FighterEditorPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            CharTabPanel.SuspendLayout();
            AnimationTabPage.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.SuspendLayout();
            toolStrip2.SuspendLayout();
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
            MainTabPanel.Controls.Add(FighterEditorPage);
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
            ConfigTabPage.Size = new Size(990, 565);
            ConfigTabPage.TabIndex = 0;
            ConfigTabPage.Text = "Configurações";
            ConfigTabPage.UseVisualStyleBackColor = true;
            // 
            // FighterEditorPage
            // 
            FighterEditorPage.Controls.Add(splitContainer1);
            FighterEditorPage.Location = new Point(4, 24);
            FighterEditorPage.Name = "FighterEditorPage";
            FighterEditorPage.Padding = new Padding(3);
            FighterEditorPage.Size = new Size(1272, 645);
            FighterEditorPage.TabIndex = 1;
            FighterEditorPage.Text = "Personagens";
            FighterEditorPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(CharsListView);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(CharTabPanel);
            splitContainer1.Size = new Size(1266, 639);
            splitContainer1.SplitterDistance = 422;
            splitContainer1.TabIndex = 0;
            // 
            // CharsListView
            // 
            CharsListView.Dock = DockStyle.Fill;
            CharsListView.Location = new Point(0, 0);
            CharsListView.Name = "CharsListView";
            CharsListView.Size = new Size(422, 639);
            CharsListView.TabIndex = 0;
            CharsListView.UseCompatibleStateImageBehavior = false;
            // 
            // CharTabPanel
            // 
            CharTabPanel.Controls.Add(AnimationTabPage);
            CharTabPanel.Controls.Add(tabPage2);
            CharTabPanel.Dock = DockStyle.Fill;
            CharTabPanel.Location = new Point(0, 0);
            CharTabPanel.Name = "CharTabPanel";
            CharTabPanel.SelectedIndex = 0;
            CharTabPanel.Size = new Size(840, 639);
            CharTabPanel.TabIndex = 0;
            // 
            // AnimationTabPage
            // 
            AnimationTabPage.Controls.Add(splitContainer2);
            AnimationTabPage.Controls.Add(toolStrip1);
            AnimationTabPage.Location = new Point(4, 24);
            AnimationTabPage.Name = "AnimationTabPage";
            AnimationTabPage.Padding = new Padding(3);
            AnimationTabPage.Size = new Size(832, 611);
            AnimationTabPage.TabIndex = 0;
            AnimationTabPage.Text = "Animações";
            AnimationTabPage.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox1 });
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(826, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(265, 25);
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(644, 531);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 28);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(toolStrip2);
            splitContainer2.Size = new Size(826, 580);
            splitContainer2.SplitterDistance = 206;
            splitContainer2.TabIndex = 1;
            // 
            // toolStrip2
            // 
            toolStrip2.Dock = DockStyle.Bottom;
            toolStrip2.Items.AddRange(new ToolStripItem[] { OpenImageDialogButton, toolStripButton2, toolStripButton3, toolStripButton4 });
            toolStrip2.Location = new Point(0, 555);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(206, 25);
            toolStrip2.TabIndex = 0;
            toolStrip2.Text = "toolStrip2";
            // 
            // OpenImageDialogButton
            // 
            OpenImageDialogButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            OpenImageDialogButton.Image = (Image)resources.GetObject("OpenImageDialogButton.Image");
            OpenImageDialogButton.ImageTransparentColor = Color.Magenta;
            OpenImageDialogButton.Name = "OpenImageDialogButton";
            OpenImageDialogButton.Size = new Size(40, 22);
            OpenImageDialogButton.Text = "Open";
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
            FighterEditorPage.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            CharTabPanel.ResumeLayout(false);
            AnimationTabPage.ResumeLayout(false);
            AnimationTabPage.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
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
        private TabPage FighterEditorPage;
        private SplitContainer splitContainer1;
        private ListView CharsListView;
        private TabControl CharTabPanel;
        private TabPage AnimationTabPage;
        private TabPage tabPage2;
        private ToolStrip toolStrip1;
        private ToolStripTextBox toolStripTextBox1;
        private SplitContainer splitContainer2;
        private ToolStrip toolStrip2;
        private ToolStripButton OpenImageDialogButton;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
    }
}
