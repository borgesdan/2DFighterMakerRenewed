using Svg;

namespace Editor.Core
{
    public class SvgManager
    {
        public static readonly string EditorDefaultPath = "Content\\Svgs";
        public static Dictionary<string, Bitmap> loadedBitmaps = [];

        public SvgManager() { }

        public static SvgDocument NewDocument(string svgDocument)
        {
            string path = Path.Combine(EditorDefaultPath, svgDocument + ".svg");
            return SvgDocument.Open(path);
        }

        public static Bitmap NewBitmap(string svgDocument, int width = 12, int height = 12) 
        {
            ArgumentNullException.ThrowIfNull(svgDocument, nameof(svgDocument));

            if(loadedBitmaps.TryGetValue(svgDocument, out var bitmap))
            {
                return bitmap;
            }

            string path = Path.Combine(EditorDefaultPath, svgDocument + ".svg");
            var document = SvgDocument.Open(path);

            var docBmp = document.Draw(width, height);

            loadedBitmaps.Add(svgDocument, docBmp);

            return docBmp;
        }
    }
}
