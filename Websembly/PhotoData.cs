//Created a PhotoData Class

using System;

namespace SurfaceApplication1
{
    public class PhotoData
    {
        public string Source { get; private set; }
        public string Caption { get; private set; }
        public bool CanDrop { get; private set; }

      
        public PhotoData(string source, string caption, bool CanDrop)
        {
            this.Source = source;
            this.Caption = caption;
            this.CanDrop = CanDrop;
           
            
        }
        public string returnCaption()
        {

            return Caption;
        }
    }

}
