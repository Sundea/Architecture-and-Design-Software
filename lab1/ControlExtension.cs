
using System.Drawing;
using System.Windows.Forms;

namespace CustomExtension
{
    public static class ControlExnsion
    {
        public static bool canMoveToPoint(this Control control, Point point)
        {
            bool result = false;

            if (point.X >= 0 && point.Y >= 0)
            {
                var parentSize = control.Parent.Size;
                var pointRight = point.X + control.Size.Width;
                var pointBottom = point.Y + control.Size.Height;

                if (pointRight <= parentSize.Width && pointBottom <= parentSize.Height)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}