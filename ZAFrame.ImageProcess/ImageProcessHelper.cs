using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAFrame.ImageProcess
{
    internal class ImageProcessHelper
    {
        
    }

    public struct ZAAngle
    {
        public double Angle { get; set; }
        public double Angle_PI
        {
            get
            {
                return OpenCvSharp.Cv2.PI * (Angle / 180f);
            }
        }
        public static ZAAngle Zero 
        {
            get 
            {
                ZAAngle angle = new ZAAngle();
                angle.Angle = 0;
                return angle;
            } 
        }

    }
}
