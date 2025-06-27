using Editor.Core;
using System.ComponentModel;

namespace Editor
{
    public partial class ImageFileManagerForm : Form
    {
        /// <summary>Obtém o manipulador do retângulo de seleção da imagem.</summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PictureBoxSelectionRectangleHandler SelectionRectangle { get; private set; }

        /// <summary>
        /// Evento quando o usuário clica no botão de aceitar o recorte da imagem.
        /// A seleção deve ser processada como uma imagem a ser adicionada posterior a outra em uma animação.
        /// </summary>
        public event EventHandler<ImageFileManagerEventArgs>? ForwardButtonClick;
        /// <summary>
        /// Evento quando o usuário clica no botão de aceitar o recorte da imagem.
        /// A seleção deve ser processada como uma imagem a ser adicionada anterior a outra em uma animação.
        /// </summary>
        public event EventHandler<ImageFileManagerEventArgs>? BackwardButtonClick;
        /// <summary>
        /// Evento quando o usuário clica no botão de aceitar o recorte da imagem.
        /// A seleção deve ser processada como uma imagem que substituirá outra em uma animação.
        /// </summary>
        public event EventHandler<ImageFileManagerEventArgs>? ReplaceButtonClick;

        public ImageFileManagerForm()
        {
            InitializeComponent();

            SelectionRectangle = new PictureBoxSelectionRectangleHandler(pictureBox1);
            OpenImageButton.Image = SvgManager.LoadBitmap("solid/folder");

            OpenImageButton.Image = SvgManager.SolidIcon.Folder;
            BackwardSelectedImageButton.Image = SvgManager.SolidIcon.ArrowLeft;
            ReplaceSelectedImageButton.Image = SvgManager.SolidIcon.ArrowDown;
            ForwardSelectedImageButton.Image = SvgManager.SolidIcon.ArrowRight;

            OpenImageButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BackwardSelectedImageButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ReplaceSelectedImageButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ForwardSelectedImageButton.DisplayStyle = ToolStripItemDisplayStyle.Image;            
        }

        private void OpenImageButton_Click(object sender, EventArgs e)
        {
            using var fileManager = new OpenFileManager();
            var image = fileManager.OpenImage();

            if (image != null)
            {
                SelectionRectangle.Reset();
                pictureBox1.Tag = image;
                pictureBox1.Load(image!);
            }                
        }

        private void ForwardSelectedImageButton_Click(object sender, EventArgs e)
        {
            var bmp = SelectionRectangle.GetSelectedBitmap();

            if (bmp != null)
            {
                var args = new ImageFileManagerEventArgs
                {
                    SelectedFrame = bmp,
                    ImagePath = pictureBox1.Tag as string ?? throw new NullReferenceException(),
                };
                ForwardButtonClick?.Invoke(sender, args);
            }
        }

        private void BackwardSelectedImageButton_Click(object sender, EventArgs e)
        {
            var bmp = SelectionRectangle.GetSelectedBitmap();

            if (bmp != null)
            {
                var args = new ImageFileManagerEventArgs
                {
                    SelectedFrame = bmp,
                    ImagePath = pictureBox1.Tag as string ?? throw new NullReferenceException()
                };
                BackwardButtonClick?.Invoke(sender, args);
            }
        }

        private void ReplaceSelectedImageButton_Click(object sender, EventArgs e)
        {
            var bmp = SelectionRectangle.GetSelectedBitmap();

            if (bmp != null)
            {
                var args = new ImageFileManagerEventArgs
                {
                    SelectedFrame = bmp,
                    ImagePath = pictureBox1.Tag as string ?? throw new NullReferenceException()
                };
                ReplaceButtonClick?.Invoke(sender, args);
            }
        }
    }

    public class ImageFileManagerEventArgs : EventArgs
    {
        public Bitmap SelectedFrame { get; set; } = null!;
        public string ImagePath { get; set; } = null!;
    }
}
