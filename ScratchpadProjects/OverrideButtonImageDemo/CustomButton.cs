using System.Windows.Forms;

namespace OverrideButtonImageDemo
{
    public class CustomButton : Button
    {
        public override void Refresh()
        {
            Image = MyResources.HappyFace;
        }
        
    }
}
