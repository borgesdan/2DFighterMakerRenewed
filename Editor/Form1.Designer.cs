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
            NewProjectMenuItem = new ToolStripMenuItem();
            MainTabPanel = new TabControl();
            ConfigTabPage = new TabPage();
            CharTabPage = new TabPage();
            splitContainer1 = new SplitContainer();
            listView1 = new ListView();
            toolStrip3 = new ToolStrip();
            AddCharacterButton = new ToolStripButton();
            CharTabPanel = new TabControl();
            AnimationTabPage = new TabPage();
            splitContainer2 = new SplitContainer();
            toolStrip2 = new ToolStrip();
            OpenImageWindowButton = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            toolStripComboBox1 = new ToolStripComboBox();
            toolStripButton1 = new ToolStripButton();
            tabPage2 = new TabPage();
            MainToolMenu.SuspendLayout();
            MainTabPanel.SuspendLayout();
            CharTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            toolStrip3.SuspendLayout();
            CharTabPanel.SuspendLayout();
            AnimationTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.SuspendLayout();
            toolStrip2.SuspendLayout();
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
            novoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewProjectMenuItem });
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(103, 22);
            novoToolStripMenuItem.Text = "Novo";
            // 
            // NewProjectMenuItem
            // 
            NewProjectMenuItem.Name = "NewProjectMenuItem";
            NewProjectMenuItem.Size = new Size(112, 22);
            NewProjectMenuItem.Text = "Projeto";
            NewProjectMenuItem.Click += NewProjectMenuItem_Click;
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
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listView1);
            splitContainer1.Panel1.Controls.Add(toolStrip3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(CharTabPanel);
            splitContainer1.Size = new Size(1266, 639);
            splitContainer1.SplitterDistance = 194;
            splitContainer1.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(0, 25);
            listView1.Name = "listView1";
            listView1.Size = new Size(194, 614);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // toolStrip3
            // 
            toolStrip3.Items.AddRange(new ToolStripItem[] { AddCharacterButton });
            toolStrip3.Location = new Point(0, 0);
            toolStrip3.Name = "toolStrip3";
            toolStrip3.Size = new Size(194, 25);
            toolStrip3.TabIndex = 0;
            toolStrip3.Text = "toolStrip3";
            // 
            // AddCharacterButton
            // 
            AddCharacterButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            AddCharacterButton.Image = (Image)resources.GetObject("AddCharacterButton.Image");
            AddCharacterButton.ImageTransparentColor = Color.Magenta;
            AddCharacterButton.Name = "AddCharacterButton";
            AddCharacterButton.Size = new Size(33, 22);
            AddCharacterButton.Text = "Add";
            AddCharacterButton.Click += AddCharacterButton_Click;
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
            AnimationTabPage.Controls.Add(toolStrip1);
            AnimationTabPage.Location = new Point(4, 24);
            AnimationTabPage.Name = "AnimationTabPage";
            AnimationTabPage.Padding = new Padding(3);
            AnimationTabPage.Size = new Size(1060, 611);
            AnimationTabPage.TabIndex = 0;
            AnimationTabPage.Text = "Animações";
            AnimationTabPage.UseVisualStyleBackColor = true;
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
            splitContainer2.Size = new Size(1054, 580);
            splitContainer2.SplitterDistance = 257;
            splitContainer2.TabIndex = 1;
            // 
            // toolStrip2
            // 
            toolStrip2.Dock = DockStyle.Bottom;
            toolStrip2.Items.AddRange(new ToolStripItem[] { OpenImageWindowButton, toolStripButton2, toolStripButton3, toolStripButton4 });
            toolStrip2.Location = new Point(0, 555);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(257, 25);
            toolStrip2.TabIndex = 0;
            toolStrip2.Text = "toolStrip2";
            // 
            // OpenImageWindowButton
            // 
            OpenImageWindowButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            OpenImageWindowButton.Image = (Image)resources.GetObject("OpenImageWindowButton.Image");
            OpenImageWindowButton.ImageTransparentColor = Color.Magenta;
            OpenImageWindowButton.Name = "OpenImageWindowButton";
            OpenImageWindowButton.Size = new Size(37, 22);
            OpenImageWindowButton.Text = "Abrir";
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
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripComboBox1, toolStripButton1 });
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1054, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 25);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1060, 611);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
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
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            toolStrip3.ResumeLayout(false);
            toolStrip3.PerformLayout();
            CharTabPanel.ResumeLayout(false);
            AnimationTabPage.ResumeLayout(false);
            AnimationTabPage.PerformLayout();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip MainToolMenu;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem NewProjectMenuItem;
        private TabControl MainTabPanel;
        private TabPage ConfigTabPage;
        private TabPage CharTabPage;
        private SplitContainer splitContainer1;
        private TabControl CharTabPanel;
        private TabPage AnimationTabPage;
        private TabPage tabPage2;
        private SplitContainer splitContainer2;
        private ToolStrip toolStrip2;
        private ToolStripButton OpenImageWindowButton;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStrip toolStrip1;
        private ToolStrip toolStrip3;
        private ToolStripButton AddCharacterButton;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripButton toolStripButton1;
        private ListView listView1;
    }
}
