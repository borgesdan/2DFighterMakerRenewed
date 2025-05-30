namespace Editor
{
    partial class NewProjectForm
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
            MainTabPanel = new TabControl();
            GetStartedPage = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox1 = new TextBox();
            SearchRecentsButton = new Button();
            NewProjectButton = new Button();
            NewProjectPage = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            label4 = new Label();
            label5 = new Label();
            EmptyProjectButton = new Button();
            ConfigPage = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            ProjectNameTextBox = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            DirectoryListBox = new ComboBox();
            OpenDirectoryDialogButton = new Button();
            FinishButton = new Button();
            MainTabPanel.SuspendLayout();
            GetStartedPage.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            NewProjectPage.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ConfigPage.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabPanel
            // 
            MainTabPanel.Controls.Add(GetStartedPage);
            MainTabPanel.Controls.Add(NewProjectPage);
            MainTabPanel.Controls.Add(ConfigPage);
            MainTabPanel.Dock = DockStyle.Fill;
            MainTabPanel.Location = new Point(0, 0);
            MainTabPanel.Name = "MainTabPanel";
            MainTabPanel.SelectedIndex = 0;
            MainTabPanel.Size = new Size(760, 675);
            MainTabPanel.TabIndex = 0;
            // 
            // GetStartedPage
            // 
            GetStartedPage.Controls.Add(tableLayoutPanel1);
            GetStartedPage.Location = new Point(4, 24);
            GetStartedPage.Name = "GetStartedPage";
            GetStartedPage.Padding = new Padding(3);
            GetStartedPage.Size = new Size(752, 647);
            GetStartedPage.TabIndex = 0;
            GetStartedPage.Text = "Início";
            GetStartedPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Controls.Add(NewProjectButton, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(746, 641);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(367, 64);
            label1.TabIndex = 0;
            label1.Text = "2D Fighter Maker R";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 65);
            label2.Margin = new Padding(3, 1, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(367, 35);
            label2.TabIndex = 1;
            label2.Text = "Abrir Recentes";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(376, 65);
            label3.Margin = new Padding(3, 1, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(367, 35);
            label3.TabIndex = 2;
            label3.Text = "Comece por aqui";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 535);
            panel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanel2.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(SearchRecentsButton, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(367, 36);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(325, 23);
            textBox1.TabIndex = 0;
            // 
            // SearchRecentsButton
            // 
            SearchRecentsButton.Location = new Point(334, 3);
            SearchRecentsButton.Name = "SearchRecentsButton";
            SearchRecentsButton.Size = new Size(30, 23);
            SearchRecentsButton.TabIndex = 1;
            SearchRecentsButton.UseVisualStyleBackColor = true;
            // 
            // NewProjectButton
            // 
            NewProjectButton.Dock = DockStyle.Top;
            NewProjectButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            NewProjectButton.ImageAlign = ContentAlignment.MiddleLeft;
            NewProjectButton.Location = new Point(376, 103);
            NewProjectButton.Name = "NewProjectButton";
            NewProjectButton.Size = new Size(367, 64);
            NewProjectButton.TabIndex = 4;
            NewProjectButton.Text = "Criar Novo Projeto";
            NewProjectButton.TextAlign = ContentAlignment.MiddleLeft;
            NewProjectButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            NewProjectButton.UseVisualStyleBackColor = true;
            // 
            // NewProjectPage
            // 
            NewProjectPage.Controls.Add(tableLayoutPanel3);
            NewProjectPage.Location = new Point(4, 24);
            NewProjectPage.Name = "NewProjectPage";
            NewProjectPage.Padding = new Padding(3);
            NewProjectPage.Size = new Size(752, 647);
            NewProjectPage.TabIndex = 1;
            NewProjectPage.Text = "Projeto";
            NewProjectPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.02439F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.97561F));
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
            tableLayoutPanel3.Controls.Add(label5, 0, 1);
            tableLayoutPanel3.Controls.Add(EmptyProjectButton, 1, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(746, 641);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label4.Location = new Point(3, 0);
            label4.Margin = new Padding(3, 0, 3, 2);
            label4.Name = "label4";
            label4.Size = new Size(285, 62);
            label4.TabIndex = 0;
            label4.Text = "Criar Novo Projeto";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(3, 65);
            label5.Margin = new Padding(3, 1, 3, 1);
            label5.Name = "label5";
            label5.Size = new Size(285, 30);
            label5.TabIndex = 1;
            label5.Text = "Templates Recentes";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EmptyProjectButton
            // 
            EmptyProjectButton.Dock = DockStyle.Top;
            EmptyProjectButton.Font = new Font("Segoe UI", 12F);
            EmptyProjectButton.ImageAlign = ContentAlignment.MiddleLeft;
            EmptyProjectButton.Location = new Point(294, 99);
            EmptyProjectButton.Name = "EmptyProjectButton";
            EmptyProjectButton.Size = new Size(449, 64);
            EmptyProjectButton.TabIndex = 2;
            EmptyProjectButton.Text = "Projeto Vazio";
            EmptyProjectButton.TextAlign = ContentAlignment.MiddleLeft;
            EmptyProjectButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            EmptyProjectButton.UseVisualStyleBackColor = true;
            // 
            // ConfigPage
            // 
            ConfigPage.Controls.Add(tableLayoutPanel4);
            ConfigPage.Location = new Point(4, 24);
            ConfigPage.Name = "ConfigPage";
            ConfigPage.Padding = new Padding(3);
            ConfigPage.Size = new Size(752, 647);
            ConfigPage.TabIndex = 2;
            ConfigPage.Text = "Configurações";
            ConfigPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(label8, 0, 3);
            tableLayoutPanel4.Controls.Add(label6, 0, 0);
            tableLayoutPanel4.Controls.Add(label7, 0, 1);
            tableLayoutPanel4.Controls.Add(ProjectNameTextBox, 0, 2);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 4);
            tableLayoutPanel4.Controls.Add(FinishButton, 0, 5);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 6;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel4.Size = new Size(746, 641);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(3, 129);
            label8.Margin = new Padding(3, 1, 3, 1);
            label8.Name = "label8";
            label8.Size = new Size(740, 30);
            label8.TabIndex = 3;
            label8.Text = "Localização";
            label8.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 1);
            label6.Margin = new Padding(3, 1, 3, 1);
            label6.Name = "label6";
            label6.Size = new Size(740, 62);
            label6.TabIndex = 0;
            label6.Text = "Configure Seu Projeto";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(3, 65);
            label7.Margin = new Padding(3, 1, 3, 1);
            label7.Name = "label7";
            label7.Size = new Size(740, 30);
            label7.TabIndex = 1;
            label7.Text = "Nome do Projeto";
            label7.TextAlign = ContentAlignment.BottomLeft;
            // 
            // ProjectNameTextBox
            // 
            ProjectNameTextBox.Dock = DockStyle.Fill;
            ProjectNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProjectNameTextBox.Location = new Point(3, 97);
            ProjectNameTextBox.Margin = new Padding(3, 1, 3, 1);
            ProjectNameTextBox.Name = "ProjectNameTextBox";
            ProjectNameTextBox.Size = new Size(740, 29);
            ProjectNameTextBox.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 88.19206F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.8079376F));
            tableLayoutPanel5.Controls.Add(DirectoryListBox, 0, 0);
            tableLayoutPanel5.Controls.Add(OpenDirectoryDialogButton, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 163);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.Size = new Size(740, 26);
            tableLayoutPanel5.TabIndex = 4;
            // 
            // DirectoryListBox
            // 
            DirectoryListBox.Dock = DockStyle.Fill;
            DirectoryListBox.FormattingEnabled = true;
            DirectoryListBox.Location = new Point(3, 0);
            DirectoryListBox.Margin = new Padding(3, 0, 3, 0);
            DirectoryListBox.Name = "DirectoryListBox";
            DirectoryListBox.Size = new Size(646, 23);
            DirectoryListBox.TabIndex = 0;
            // 
            // OpenDirectoryDialogButton
            // 
            OpenDirectoryDialogButton.Dock = DockStyle.Fill;
            OpenDirectoryDialogButton.Location = new Point(655, 0);
            OpenDirectoryDialogButton.Margin = new Padding(3, 0, 3, 0);
            OpenDirectoryDialogButton.Name = "OpenDirectoryDialogButton";
            OpenDirectoryDialogButton.Size = new Size(82, 26);
            OpenDirectoryDialogButton.TabIndex = 1;
            OpenDirectoryDialogButton.UseVisualStyleBackColor = true;
            OpenDirectoryDialogButton.Click += OpenDirectoryDialogButton_Click;
            // 
            // FinishButton
            // 
            FinishButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            FinishButton.Location = new Point(486, 608);
            FinishButton.Margin = new Padding(0, 3, 10, 10);
            FinishButton.Name = "FinishButton";
            FinishButton.Size = new Size(250, 23);
            FinishButton.TabIndex = 5;
            FinishButton.Text = "Finalizar";
            FinishButton.UseVisualStyleBackColor = true;
            FinishButton.Click += FinishButton_Click;
            // 
            // NewProjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 675);
            Controls.Add(MainTabPanel);
            Name = "NewProjectForm";
            ShowIcon = false;
            MainTabPanel.ResumeLayout(false);
            GetStartedPage.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            NewProjectPage.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ConfigPage.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainTabPanel;
        private TabPage GetStartedPage;
        private TableLayoutPanel tableLayoutPanel1;
        private TabPage NewProjectPage;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox1;
        private Button SearchRecentsButton;
        private Button NewProjectButton;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label4;
        private Label label5;
        private Button EmptyProjectButton;
        private TabPage ConfigPage;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label6;
        private Label label7;
        private TextBox ProjectNameTextBox;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel5;
        private ComboBox DirectoryListBox;
        private Button OpenDirectoryDialogButton;
        private Button FinishButton;
    }
}