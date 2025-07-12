using Editor.Models;
using System.ComponentModel;
using System.Text.Json;

namespace Editor
{
    public partial class NewProjectForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ProjectModel? Model { get; set; }

        public NewProjectForm()
        {
            InitializeComponent();

            SearchRecentsButton.Image = SvgManager.LoadBitmap("solid\\magnifying-glass");
            NewProjectButton.Image = SvgManager.LoadBitmap("solid\\file-signature", 32, 32);
            EmptyProjectButton.Image = SvgManager.LoadBitmap("solid\\file", 32, 32);
            OpenDirectoryDialogButton.Image = SvgManager.LoadBitmap("solid\\folder-open", 12, 12);

            ProjectNameTextBox.LostFocus += FinishButtonEnabledEvent;
            DirectoryListBox.SelectedIndexChanged += FinishButtonEnabledEvent;

            SetDefaultState();
        }

        private void SetDefaultState()
        {
            FinishButton.Enabled = false;

            MainTabPanel.TabPages.Clear();
            MainTabPanel.TabPages.Add(GetStartedPage);
        }

        private void FinishButtonEnabledEvent(object? sender, EventArgs e)
            => FinishButton.Enabled = !string.IsNullOrWhiteSpace(ProjectNameTextBox.Text) && DirectoryListBox.SelectedIndex != -1;

        private void OpenDirectoryDialogButton_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                DirectoryListBox.Items.Add(dialog.SelectedPath);
                var dirCount = DirectoryListBox.Items.Count;

                DirectoryListBox.SelectedIndex = dirCount - 1;
            }
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            var projectName = ProjectNameTextBox.Text;
            var directory = DirectoryListBox.Items[DirectoryListBox.SelectedIndex] as string;

            if (string.IsNullOrWhiteSpace(directory) || string.IsNullOrWhiteSpace(projectName))
            {
                MessageBox.Show("Erro ao processar o formulário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string finalDirectory = Path.Combine(directory, projectName);
            string path = Path.Combine(finalDirectory, projectName + ProjectModel.FileExtension);

            if (File.Exists(path))
            {
                MessageBox.Show("Já existe um projeto de mesmo nome no caminho específicado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {   
                Model = new ProjectModel
                {
                    FileName = path,
                    Name = projectName,
                };

                Pipeline.Write(path, Model);

                DialogResult = DialogResult.OK;

                Close();
            }
            catch (Exception ex)
            {
                var message = string.Format("Não foi possível criar o arquivo de projeto. Exceção: {0}", ex.Message);
                MessageBox.Show(message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewProjectButton_Click(object sender, EventArgs e)
        {
            MainTabPanel.TabPages.Clear();
            MainTabPanel.TabPages.Add(NewProjectPage);
        }

        private void NewProjectBackButton_Click(object sender, EventArgs e)
        {
            MainTabPanel.TabPages.Clear();
            MainTabPanel.TabPages.Add(GetStartedPage);
        }

        private void EmptyProjectButton_Click(object sender, EventArgs e)
        {
            MainTabPanel.TabPages.Clear();
            MainTabPanel.TabPages.Add(ConfigPage);
        }
    }
}
