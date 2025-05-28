using Editor.Core;
using System.ComponentModel;

namespace Editor
{
    public partial class ImageFileManagerForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PictureBoxSelectionRectangleHandler SelectionRectangle { get; set; }

        public ImageFileManagerForm()
        {
            InitializeComponent();

            SelectionRectangle = new PictureBoxSelectionRectangleHandler(pictureBox1);
        }

        private void openImageButton_Click(object sender, EventArgs e)
        {
            using FileManager fileManager = new FileManager();
            var image = fileManager.OpenImage();

            pictureBox1.Load(image!);
            
        }
    }
}
