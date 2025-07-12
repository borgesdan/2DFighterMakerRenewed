namespace Editor.Models
{
    /// <summary>Classe responsável por gerenciar a seleção de retângulos para um PictureBox por meio de eventos.</summary>
    public class PictureBoxSelectionRectangleHandler
    {
        readonly PictureBox pictureBox;
        Point selectionStart;
        Rectangle selectionRect;
        bool isSelecting = false;
        bool repainting = false;

        public PictureBoxSelectionRectangleHandler(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            pictureBox.MouseDown += MouseDown;
            pictureBox.MouseMove += MouseMove;
            pictureBox.MouseUp += MouseUp;
            pictureBox.Paint += Paint;
        }

        public void Reset()
        {
            isSelecting = false;
            repainting = false;
            pictureBox.Invalidate();
        }

        private void MouseDown(object? sender, MouseEventArgs e)
        {
            isSelecting = true;
            selectionStart = e.Location;
            selectionRect = new Rectangle(e.Location, Size.Empty);
            pictureBox.Invalidate();
        }

        private void MouseMove(object? sender, MouseEventArgs e)
        {
            if (isSelecting)
            {
                var x = Math.Min(e.X, selectionStart.X);
                var y = Math.Min(e.Y, selectionStart.Y);
                var width = Math.Abs(e.X - selectionStart.X);
                var height = Math.Abs(e.Y - selectionStart.Y);

                selectionRect = new Rectangle(x, y, width, height);
                pictureBox.Invalidate();
            }
        }

        private void MouseUp(object? sender, MouseEventArgs e)
        {
            isSelecting = false;            

            if (IsValidRectangle(selectionRect) && pictureBox.Image is Bitmap bmp)
            {
                selectionRect = AdjustSelection(bmp, selectionRect);
                repainting = true;
            }
            else
            {
                repainting = false;
            }

            pictureBox.Invalidate();
        }

        private void Paint(object? sender, PaintEventArgs e)
        {
            if(selectionRect != Rectangle.Empty && (isSelecting || repainting))
            {
                using var pen = new Pen(Color.Black, 2);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawRectangle(pen, selectionRect);
            }
        }        

        /// <summary>Obtém o bitmap da seleção da imagem.</summary>
        public Bitmap? GetSelectedBitmap()
        {
            if(selectionRect.Width == 0 || selectionRect.Height == 0)
                return null;

            var bmp = SliceBitmap(pictureBox.Image as Bitmap, selectionRect);

            return bmp;
        }

        /// <summary>Verifica se é um retângulo válido.</summary>
        private static bool IsValidRectangle(Rectangle rec)
        {
            return !rec.IsEmpty && rec.Width > 0 && rec.Height > 0;
        }

        /// <summary>
        /// Ajusta automaticamente o retângulo de seleção para "encaixar" perfeitamente na imagem.
        /// </summary>
        private static Rectangle AdjustSelection(Bitmap source, Rectangle selection)
        {
            ArgumentNullException.ThrowIfNull(source, nameof(source));       
            
            if(!IsValidRectangle(selection))
                throw new ArgumentException("O retângulo não pode ser vazio ou ter a altura ou largura menores ou iguais a zero.", nameof(selection));

            var minX = selection.Width;
            var minY = selection.Height;
            var maxX = 0;
            var maxY = 0;
            bool finded = false;

            try
            {
                using var slice = SliceBitmap(source, selection) ?? throw new NullReferenceException("Não foi possível realizar o recorte da imagem.");

                var magenta = Color.Magenta;

                for (int y = 0; y < slice.Height; y++)
                {
                    for (int x = 0; x < slice.Width; x++)
                    {
                        var pixel = slice.GetPixel(x, y);

                        if (pixel.A > 0 && pixel.R != magenta.R && pixel.G != magenta.G && pixel.B != magenta.B)
                        {
                            finded = true;
                            if (x < minX) minX = x;
                            if (y < minY) minY = y;
                            if (x > maxX) maxX = x;
                            if (y > maxY) maxY = y;
                        }
                    }
                }

                if (!finded)
                    return Rectangle.Empty;

                return new Rectangle(
                    selection.X + minX,
                    selection.Y + minY,
                    (maxX - minX + 1),
                    (maxY - minY + 1));
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Ocorreu um erro ao tentar redimensionar o retângulo. Veja as exceções internas para mais detalhes.", ex);
            }            
        }

        private static Bitmap? SliceBitmap(Bitmap? source, Rectangle sourceRectangle)
        {
            if(source == null) 
                return null;

            var bmp = new Bitmap(sourceRectangle.Width, sourceRectangle.Height);

            using var g = Graphics.FromImage(bmp);
            g.DrawImage(source, new Rectangle(0, 0, sourceRectangle.Width, sourceRectangle.Height), sourceRectangle, GraphicsUnit.Pixel);

            return bmp;
        }
    }
}
