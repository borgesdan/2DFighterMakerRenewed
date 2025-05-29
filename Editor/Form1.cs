using Editor.Core;
using System.Drawing;

namespace Editor
{
    public partial class Form1 : Form
    {
        ImageFileManagerForm form;

        public Form1()
        {
            InitializeComponent();
            form = CreateForm();
        }

        private void Form_SelectedImageChanged(object? sender, Bitmap e)
        {
            if (e != null)
            {
                pictureBox1.Image = e;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (form.IsDisposed)
            {
                form = CreateForm();
            }

            form.Show(this);            
        }

        private ImageFileManagerForm CreateForm()
        {
            var f = new ImageFileManagerForm();
            f.ForwardSelectedImageButtonClick += Form_SelectedImageChanged;
            return f;
        }
    }
}
