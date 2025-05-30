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
            
            var svgDoc = SvgManager.NewDocument("solid\\magnifying-glass.svg");

            button1.Image = svgDoc.Draw(SvgManager.EditorDefaultWidth, SvgManager.EditorDefaultHeight);
        }
    }
}
