namespace Editor.Core
{
    /// <summary>
    /// Classe para gerenciamento de abertura arquivos.
    /// </summary>
    internal class OpenFileManager : IDisposable
    {
        static readonly string ImageExtensions =
            "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tif;*.tiff|" +
            "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
            "PNG (*.png)|*.png|" +
            "Bitmap (*.bmp)|*.bmp|" +
            "GIF (*.gif)|*.gif|" +
            "TIFF (*.tif;*.tiff)|*.tif;*.tiff|" +
            "Todos os Arquivos|*.*";

        static readonly string ProjectExtensions =
            string.Format("Arquivos de Projeto|*{0}|", ProjectModel.FileExtension) +
            string.Format("FMBR (*{0})|*{1}|", ProjectModel.FileExtension, ProjectModel.FileExtension) +
            "Todos os Arquivos|*.*";

        readonly OpenFileDialog openFileDialog;
        bool disposed = false;

        public OpenFileManager()
        {
            openFileDialog = new OpenFileDialog
            {
                RestoreDirectory = true,
                Multiselect = false,
                FilterIndex = 1
            };
        }        

        /// <summary>Abre uma janela para selecionar um arquivo de imagem.</summary>
        public string? OpenImage()
        {
            openFileDialog.Filter = ImageExtensions;
            openFileDialog.Title = "Selecione uma imagem";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }

            return null;
        }

        public string? OpenProject()
        {
            openFileDialog.Filter = ProjectExtensions;
            openFileDialog.Title = "Selecione um arquivo de projeto.";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }

            return null;
        }

        public void Dispose()
        {
            if (disposed) return;

            disposed = true;

            openFileDialog.Dispose();
        }
    }
}
