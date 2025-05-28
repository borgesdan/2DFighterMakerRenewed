namespace Editor.Core
{
    /// <summary>
    /// Classe para gerenciamento de arquivos.
    /// </summary>
    internal class FileManager : IDisposable
    {
        static readonly string ImageExtensions =
            "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tif;*.tiff|" +
            "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
            "PNG (*.png)|*.png|" +
            "Bitmap (*.bmp)|*.bmp|" +
            "GIF (*.gif)|*.gif|" +
            "TIFF (*.tif;*.tiff)|*.tif;*.tiff|" +
            "Todos os Arquivos|*.*";

        readonly OpenFileDialog openFileDialog;
        bool disposed = false;

        public FileManager()
        {
            openFileDialog = new OpenFileDialog
            {
                RestoreDirectory = true,
                Multiselect = false,
                FilterIndex = 1
            };
        }        

        /// <summary>Abre uma janela para selecionar um arquivo de imagem e o retorna com um Stream.</summary>
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

        public void Dispose()
        {
            if (disposed) return;

            disposed = true;

            openFileDialog.Dispose();
        }
    }
}
