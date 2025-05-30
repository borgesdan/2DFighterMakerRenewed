using Svg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.Core
{
    public class SvgManager
    {
        public static readonly string EditorDefaultPath = "Content\\Svgs";
        public static readonly int EditorDefaultWidth = 12;
        public static readonly int EditorDefaultHeight = 12;

        public SvgManager() { }

        public static SvgDocument NewDocument(string svgDocument)
        {
            string path = Path.Combine(EditorDefaultPath, svgDocument);
            return SvgDocument.Open(path);
        }
    }
}
