using Editor.Models;
using System.ComponentModel;
using System.Drawing.Text;
using System.Reflection;

namespace Editor
{
    public partial class Form1 : Form
    {
        public static Form1 Instance { get; private set; } = null!;

        ProjectModel? projectModel;
        ImageFileManagerForm? imageFileManagerForm;
        bool imageFileManagerFormIsVisible;

        /// <summary>
        /// Respons�vel por gerenciar as a��es gerais da janela principal.
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
            }
        }

        public Form1()
        {
            if (Instance != null)
                throw new InvalidOperationException($"J� existe uma inst�ncia de {nameof(Form1)} em execu��o.");

            Instance = this;
            FormActionManager = new MainFormActionManager();


            InitializeComponent();
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

        private void OpenProjectMenuItem_Click(object sender, EventArgs e)
        {
            var fileManager = new OpenFileManager();
            var file = fileManager.OpenProject();

            if (file != null)
            {
                this.CurrentProject = Pipeline.Read<ProjectModel>(file);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = FormActionManager.ShowImageFileManagerForm();
            fighterAnimationEditor1.AttachEvents(form);
        }
    }    
}
