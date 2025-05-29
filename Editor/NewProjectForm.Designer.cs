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
            textBox1 = new TextBox();
            CreateProjectButton = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(434, 23);
            textBox1.TabIndex = 0;
            // 
            // CreateProjectButton
            // 
            CreateProjectButton.Dock = DockStyle.Fill;
            CreateProjectButton.Location = new Point(0, 23);
            CreateProjectButton.Name = "CreateProjectButton";
            CreateProjectButton.Size = new Size(434, 41);
            CreateProjectButton.TabIndex = 1;
            CreateProjectButton.Text = "Criar";
            CreateProjectButton.UseVisualStyleBackColor = true;
            // 
            // NewProjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 64);
            Controls.Add(CreateProjectButton);
            Controls.Add(textBox1);
            Name = "NewProjectForm";
            Text = "NewProjectForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button CreateProjectButton;
    }
}