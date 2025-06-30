using Editor.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor.Components
{
    public partial class FighterAnimationEditor : UserControl
    {
        private ImageList imageList = new ImageList();

        public FighterAnimationEditor()
        {
            InitializeComponent();

            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.VerticalScroll.Enabled = false;

            iconListView.Scrollable = false;
            iconListView.GridLines = true;
            iconListView.BackColor = panel1.BackColor;
            iconListView.BorderStyle = BorderStyle.None;
        }

        public void AttachEvents(ImageFileManagerForm form)
        {
            form.SelectFrameEvent += (object? sender, AddFrameEventArgs e) => AddFrame(e.SelectedFrame, e.Position);
        }

        public void AddFrame(Bitmap frame, AddFramePositionType position)
        {
            imageList.Images.Add(frame);            

            var item = new ListViewItem();
            item.ImageIndex = imageList.Images.Count - 1;
                        
            iconListView.View = View.Tile;
            iconListView.LargeImageList = imageList;
            iconListView.GroupImageList = imageList;
            iconListView.SmallImageList = imageList;
            iconListView.StateImageList = imageList;
            iconListView.TileSize = new Size(40,40);
            iconListView.Items.Add(item);

            if (iconListView.TileSize.Width * iconListView.Items.Count > iconListView.Width)
                iconListView.Width += iconListView.Width / 3;
        }        
    }
}
