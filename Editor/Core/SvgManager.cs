using Svg;

namespace Editor.Core
{
    public class SvgManager
    {
        public static readonly string EditorDefaultPath = "Content\\Svgs";
        public static readonly Dictionary<string, Bitmap> loadedBitmaps = [];

        public SvgManager() { }        

        public static Bitmap LoadSolidBitmap(string svgDocument, int width = 12, int height = 12)
        {
            ArgumentNullException.ThrowIfNull(svgDocument, nameof(svgDocument));

            string path = Path.Combine("solid/", svgDocument);
            var bmp = OpenBitmap(path, width, height);

            return bmp;
        }

        public static Bitmap LoadBitmap(string svgDocument, int width = 12, int height = 12) 
        {
            ArgumentNullException.ThrowIfNull(svgDocument, nameof(svgDocument));
            var bmp = OpenBitmap(svgDocument, width, height);            

            return bmp;
        }

        private static Bitmap OpenBitmap(string svgDocument, int width = 12, int height = 12)
        {
            if (loadedBitmaps.TryGetValue(svgDocument, out var bitmap))
                return bitmap;

            string path = Path.Combine(EditorDefaultPath, svgDocument + ".svg");

            var document = SvgDocument.Open(path);
            var docBmp = document.Draw(width, height);

            loadedBitmaps.Add(svgDocument, docBmp);

            return docBmp;
        }

        public static class Solid
        {
            public static Bitmap ArrowDown => SvgManager.LoadSolidBitmap("arrow-down");
            public static Bitmap ArrowLeft => SvgManager.LoadSolidBitmap("arrow-left");
            public static Bitmap ArrowRight => SvgManager.LoadSolidBitmap("arrow-right");
            public static Bitmap Folder => SvgManager.LoadSolidBitmap("folder");
        }
    }
}
