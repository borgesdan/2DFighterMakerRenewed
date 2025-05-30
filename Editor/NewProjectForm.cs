using Editor.Core;
using Svg;
using System.ComponentModel;
using System.Windows.Forms;

namespace Editor
{
    public partial class NewProjectForm : Form
    {
        public NewProjectForm()
        {
            InitializeComponent();

            SearchRecentsButton.Image = SvgManager.NewBitmap("solid\\magnifying-glass");
            NewProjectButton.Image = SvgManager.NewBitmap("solid\\file-signature", 32, 32);
            EmptyProjectButton.Image = SvgManager.NewBitmap("solid\\file", 32, 32);
            OpenDirectoryDialogButton.Image = SvgManager.NewBitmap("solid\\folder-open", 12, 12);

            FinishButton.Enabled = false;

            ProjectNameTextBox.LostFocus += FinishButtonEnabledEvent;
            DirectoryListBox.SelectedIndexChanged += FinishButtonEnabledEvent;
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

            string path = Path.Combine(directory, projectName + ".fmbr");

            if (File.Exists(path))
            {
                MessageBox.Show("Já existe um projeto de mesmo nome no caminho específicado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                File.Create(path);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch(Exception ex)
            {
                var message = String.Format("Não foi possível criar o arquivo de projeto. Exceção: {}", ex.Message);
                MessageBox.Show(message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
