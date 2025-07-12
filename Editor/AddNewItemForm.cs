using Editor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class AddNewItemForm : Form
    {
        public AddNewItemForm()
        {
            InitializeComponent();

            var imageList = new ImageList();
            var icon = SvgManager.LoadBitmap("solid\\address-book", 150, 150);

            imageList.Images.Add(icon);

            ItemsList.LargeImageList = imageList;
            ItemsList.SmallImageList = imageList;
            ItemsList.StateImageList = imageList;

            ItemsList.Items.Add(new ListViewItem
            {
                ImageIndex = 0,
                Text = "Personagem",
                Tag = null
            });            
        }
    }
}
