using Editor.Core;
using System.ComponentModel;

namespace Editor
{
    public partial class NewProjectForm : Form
    {
        public event EventHandler<CreateProjectEventArgs>? CreateButtonClick;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ProjectModel? ProjectModel { get; private set; }

        public NewProjectForm()
        {
            InitializeComponent();
        }

        private void CreateProjectButton_Click(object sender, EventArgs e)
        {
            ProjectModel = new ProjectModel()
            {
                Name = NameTextBox.Text
            };

            var args = new CreateProjectEventArgs
            {
                ProjectModel = this.ProjectModel,
            };

            CreateButtonClick?.Invoke(sender, args);

            DialogResult = DialogResult.OK;
        }
    }    

    public class CreateProjectEventArgs : EventArgs
    {
        public ProjectModel? ProjectModel { get; set; }        
    }
}
