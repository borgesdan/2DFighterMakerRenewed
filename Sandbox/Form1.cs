
namespace Sandbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            panel1.Controls.Add(new UserControl1());

            base.OnLoad(e);
        }
    }
}
