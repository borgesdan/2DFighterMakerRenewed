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
            abrirToolStripMenuItem = new ToolStripMenuItem();
            OpenProjectMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            fighterAnimationEditor1 = new Editor.Components.FighterAnimationEditor();
            MainToolMenu.SuspendLayout();
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
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, abrirToolStripMenuItem });
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
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpenProjectMenuItem });
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(103, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            // 
            // OpenProjectMenuItem
            // 
            OpenProjectMenuItem.Name = "OpenProjectMenuItem";
            OpenProjectMenuItem.Size = new Size(112, 22);
            OpenProjectMenuItem.Text = "Projeto";
            OpenProjectMenuItem.Click += OpenProjectMenuItem_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Bottom;
            button1.Location = new Point(0, 675);
            button1.Name = "button1";
            button1.Size = new Size(1280, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // fighterAnimationEditor1
            // 
            fighterAnimationEditor1.Dock = DockStyle.Fill;
            fighterAnimationEditor1.Location = new Point(0, 25);
            fighterAnimationEditor1.Name = "fighterAnimationEditor1";
            fighterAnimationEditor1.Size = new Size(1280, 650);
            fighterAnimationEditor1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 698);
            Controls.Add(fighterAnimationEditor1);
            Controls.Add(button1);
            Controls.Add(MainToolMenu);
            Name = "Form1";
            Text = "Form1";
            MainToolMenu.ResumeLayout(false);
            MainToolMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip MainToolMenu;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem NewProjectMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem OpenProjectMenuItem;
        private Button button1;
        private Components.FighterAnimationEditor fighterAnimationEditor1;
    }
}
