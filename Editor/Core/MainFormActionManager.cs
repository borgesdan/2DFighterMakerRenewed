using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.Core
{
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
            {
                imageFileManagerForm = new ImageFileManagerForm();
                imageFileManagerForm.Shown += (object? sender, EventArgs e) => imageFileManagerIsOpen = true;
                imageFileManagerForm.FormClosed += (object? sender, FormClosedEventArgs e) => imageFileManagerIsOpen = false;
            }

            if (imageFileManagerIsOpen)
                imageFileManagerForm.Focus();
            else
                imageFileManagerForm.Show(Form1.Instance);

            return imageFileManagerForm;
        }
    }
}
