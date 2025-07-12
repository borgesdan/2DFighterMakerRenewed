using Editor.Models;
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
        /// </summary>
        public event EventHandler<AddFrameEventArgs>? SelectFrameEvent;

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
        
        private void InvokeFrameEventArgs(object sender, AddFramePositionType position)
        {
            var bmp = SelectionRectangle.GetSelectedBitmap();

            if (bmp != null)
            {
                var args = new AddFrameEventArgs
                {
                    SelectedFrame = bmp,
                    ImagePath = pictureBox1.Tag as string ?? throw new NullReferenceException(),
                    Position = AddFramePositionType.End,
                };
                SelectFrameEvent?.Invoke(sender, args);
            }
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
            => InvokeFrameEventArgs(sender, AddFramePositionType.End);

        private void BackwardSelectedImageButton_Click(object sender, EventArgs e) 
            => InvokeFrameEventArgs(sender, AddFramePositionType.Begin);

        private void ReplaceSelectedImageButton_Click(object sender, EventArgs e) 
            => InvokeFrameEventArgs(sender, AddFramePositionType.Replace);
    }    
}
