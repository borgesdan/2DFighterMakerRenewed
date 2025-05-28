using Editor.Core;

namespace Editor
{
    public partial class ImageFileManagerForm : Form
    {
        PictureBoxSelectionRectangleHandler selectionRectangle;

        public ImageFileManagerForm()
        {
            InitializeComponent();

            selectionRectangle = new PictureBoxSelectionRectangleHandler(pictureBox1);
        }

        private void openImageButton_Click(object sender, EventArgs e)
        {
            using FileManager fileManager = new FileManager();
            var image = fileManager.OpenImage();

            pictureBox1.Load(image!);
            
        }
    }
}
