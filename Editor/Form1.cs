using Editor.Core;
using System.ComponentModel;
using System.Drawing.Text;
using System.Reflection;

namespace Editor
{
    public partial class Form1 : Form
    {
        ProjectModel? projectModel;

        ImageFileManagerForm? imageFileManagerForm;
        bool imageFileManagerFormIsVisible;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ProjectModel? Project
        {
            get => projectModel;
            set
            {
                projectModel = value;

                if (projectModel == null)
                {
                    ResetFormContent();
                }
                else
                {
                    EnableFormContent();
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            ResetFormContent();
        }

        private void ResetFormContent()
        {
            MainTabPanel.Enabled = false;
            MainTabPanel.Visible = false;
        }

        private void EnableFormContent()
        {
            MainTabPanel.Enabled = true;
            MainTabPanel.Visible = true;
        }

        private void OpenImageWindowButton_Click(object sender, EventArgs e)
        {
            if (imageFileManagerForm == null || imageFileManagerForm.IsDisposed)
            {
                imageFileManagerForm = CreateImageFileManagerForm();
            }

            if (imageFileManagerFormIsVisible)
            {
                imageFileManagerForm.Focus();
            }
            else
            {
                imageFileManagerForm.Show();
            }
        }

        private ImageFileManagerForm CreateImageFileManagerForm()
        {
            var form = new ImageFileManagerForm();
            form.FormClosed += (object? sender, FormClosedEventArgs e) => { imageFileManagerFormIsVisible = false; };
            return form;
        }

        private void NewProjectMenuItem_Click(object sender, EventArgs e)
        {
            var form = new NewProjectForm();
            form.StartPosition = FormStartPosition.CenterParent;

            var dialog = form.ShowDialog(this);
        }

        private void AddCharacterButton_Click(object sender, EventArgs e)
        {

        }

        private void OpenProjectMenuItem_Click(object sender, EventArgs e)
        {
            var fileManager = new OpenFileManager();
            var file = fileManager.OpenProject();

            if (file != null) 
            {                
                this.Project = Pipeline.Read<ProjectModel>(file);
            }
        }
    }
}
