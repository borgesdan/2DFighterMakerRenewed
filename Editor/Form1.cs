namespace Editor
{
    public partial class Form1 : Form
    {
        ImageFileManagerForm imageFileManagerForm;
        bool imageFileManagerFormIsVisible;

        public Form1()
        {
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
    }
}
