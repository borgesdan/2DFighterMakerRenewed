using Editor.Core;
using Svg;
using System.ComponentModel;
using System.Windows.Forms;

namespace Editor
{
    public partial class NewProjectForm : Form
    {
        public NewProjectForm()
        {
            InitializeComponent();
            
            string svgFilePath = "C:\\Users\\Borges\\Downloads\\fontawesome-free-6.7.2-desktop\\svgs\\solid\\magnifying-glass.svg";             
            var svgDoc = SvgDocument.Open(svgFilePath);


            button1.Image = svgDoc.Draw(12,12);
        }
    }
}
