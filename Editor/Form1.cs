using Editor.Core;
using System.ComponentModel;
using System.Drawing.Text;
using System.Reflection;

namespace Editor
{
    public partial class Form1 : Form
    {
        public Form1 Instance { get; private set; } = null!;

        ProjectModel? projectModel;
        ImageFileManagerForm? imageFileManagerForm;
        bool imageFileManagerFormIsVisible;

        /// <summary>
        /// Responsável por gerenciar as ações gerais da janela principal.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MainFormActionManager FormActionManager { get; private set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ProjectModel? CurrentProject
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
            if (Instance != null)
                throw new InvalidOperationException($"Já existe uma instância de {nameof(Form1)} em execução.");

            Instance = this;
            FormActionManager = new MainFormActionManager();


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
            var form = new AddNewItemForm();
            form.ShowDialog();
        }

        private void OpenProjectMenuItem_Click(object sender, EventArgs e)
        {
            var fileManager = new OpenFileManager();
            var file = fileManager.OpenProject();

            if (file != null)
            {
                this.CurrentProject = Pipeline.Read<ProjectModel>(file);
            }
        }

        private void OpenImageWindowButton_Click_1(object sender, EventArgs e)
        {
            var form = new ImageFileManagerForm();
            form.Show();
        }
    }

    /// <summary>
    /// Classe responsável por gerenciar as ações gerais da janela principal.
    /// </summary>
    public class MainFormActionManager
    {
        private ImageFileManagerForm? imageFileManagerForm;
        private bool imageFileManagerIsOpen = false;        

        public ImageFileManagerForm ShowImageFileManagerForm()
        {
            if (imageFileManagerForm == null || imageFileManagerForm.IsDisposed)
                imageFileManagerForm = new ImageFileManagerForm();

            if (imageFileManagerIsOpen)
                imageFileManagerForm.Focus();
            else
                imageFileManagerForm.Show();

            return imageFileManagerForm;
        }
    }
}
