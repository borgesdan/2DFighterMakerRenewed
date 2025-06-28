namespace Editor.Core
{
    public enum AddFramePositionType
    {
        Begin, 
        End,
        Replace
    }

    public class AddFrameEventArgs : EventArgs
    {
        public AddFramePositionType Position { get; set; }
        public Bitmap SelectedFrame { get; set; } = null!;
        public string ImagePath { get; set; } = null!;
    }
}
