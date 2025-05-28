using Editor.Core;

namespace Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImageFileManagerForm form = new ImageFileManagerForm();
            form.ShowDialog();
        }
    }
}
