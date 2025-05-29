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
        public event EventHandler<Bitmap>? ForwardSelectedImageButtonClick;
        /// <summary>
        /// Evento quando o usuário clica no botão de aceitar o recorte da imagem.
        /// A seleção deve ser processada como uma imagem a ser adicionada anterior a outra em uma animação.
        /// </summary>
        public event EventHandler<Bitmap>? BackwardSelectedImageButtonClick;
        /// <summary>
        /// Evento quando o usuário clica no botão de aceitar o recorte da imagem.
        /// A seleção deve ser processada como uma imagem que substituirá outra em uma animação.
        /// </summary>
        public event EventHandler<Bitmap>? ReplaceSelectedImageButtonClick;

        public ImageFileManagerForm()
        {
            InitializeComponent();

            SelectionRectangle = new PictureBoxSelectionRectangleHandler(pictureBox1);
        }

        private void ImageFileDialogButton_Click(object sender, EventArgs e)
        {
            using FileManager fileManager = new FileManager();
            var image = fileManager.OpenImage();

            if (image != null)
                pictureBox1.Load(image!);
        }

        private void ForwardSelectedImageButton_Click(object sender, EventArgs e)
        {
            var bmp = SelectionRectangle.GetSelectedBitmap();

            if (bmp != null)
            {
                ForwardSelectedImageButtonClick?.Invoke(sender, bmp);
            }
        }

        private void BackwardSelectedImageButton_Click(object sender, EventArgs e)
        {
            var bmp = SelectionRectangle.GetSelectedBitmap();

            if (bmp != null)
            {
                BackwardSelectedImageButtonClick?.Invoke(sender, bmp);
            }
        }

        private void ReplaceSelectedImageButton_Click(object sender, EventArgs e)
        {
            var bmp = SelectionRectangle.GetSelectedBitmap();

            if (bmp != null)
            {
                ReplaceSelectedImageButtonClick?.Invoke(sender, bmp);
            }
        }
    }
}
