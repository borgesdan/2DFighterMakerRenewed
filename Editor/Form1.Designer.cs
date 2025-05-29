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
            tabPage2 = new TabPage();
            MainToolMenu.SuspendLayout();
            MainTabPanel.SuspendLayout();
            FighterEditorPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            CharTabPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainToolMenu
            // 
            MainToolMenu.Items.AddRange(new ToolStripItem[] { toolStripSplitButton1 });
            MainToolMenu.Location = new Point(0, 0);
            MainToolMenu.Name = "MainToolMenu";
            MainToolMenu.Size = new Size(998, 25);
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
            MainTabPanel.Size = new Size(998, 593);
            MainTabPanel.TabIndex = 1;
            // 
            // ConfigTabPage
            // 
            ConfigTabPage.Location = new Point(4, 24);
            ConfigTabPage.Name = "ConfigTabPage";
            ConfigTabPage.Padding = new Padding(3);
            ConfigTabPage.Size = new Size(792, 397);
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
            FighterEditorPage.Size = new Size(990, 565);
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
            splitContainer1.Size = new Size(984, 559);
            splitContainer1.SplitterDistance = 328;
            splitContainer1.TabIndex = 0;
            // 
            // CharsListView
            // 
            CharsListView.Dock = DockStyle.Fill;
            CharsListView.Location = new Point(0, 0);
            CharsListView.Name = "CharsListView";
            CharsListView.Size = new Size(328, 559);
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
            CharTabPanel.Size = new Size(652, 559);
            CharTabPanel.TabIndex = 0;
            // 
            // AnimationTabPage
            // 
            AnimationTabPage.Location = new Point(4, 24);
            AnimationTabPage.Name = "AnimationTabPage";
            AnimationTabPage.Padding = new Padding(3);
            AnimationTabPage.Size = new Size(644, 531);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 618);
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
    }
}
