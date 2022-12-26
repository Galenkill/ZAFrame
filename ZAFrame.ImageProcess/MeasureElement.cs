using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;
namespace ZAFrame.ImageProcess
{
    public abstract class ImageProcessElementBase : IDisposable
    {
        #region 变量
        public MeasureBaseType MeasureType { get; set; }
        public List<Point2f> Points { get; set; } = null;
        #endregion

        #region Base
        public ImageProcessElementBase()
        {

        }
        #endregion

        #region 释放

        private bool disposedValue;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: 释放托管状态(托管对象)
                    Points.Clear();
                }

                // TODO: 释放未托管的资源(未托管的对象)并重写终结器
                // TODO: 将大型字段设置为 null
                disposedValue = true;
            }
        }

        // // TODO: 仅当“Dispose(bool disposing)”拥有用于释放未托管资源的代码时才替代终结器
        // ~ImageProcessElementBase()
        // {
        //     // 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    public class ImageProcess_Point : ImageProcessElementBase
    {

    }
    public class ImageProcess_Arc : ImageProcessElementBase
    {
        public ZAAngle StartAngle { get; set; } = ZAAngle.Zero;
        public ZAAngle EndAngle { get; set; }= ZAAngle.Zero;
        //public ImageProcess_Arc
    }
    public class ImageProcess_Circle : ImageProcessElementBase
    {

    }
    public class ImageProcess_Line : ImageProcessElementBase
    {

    }

    public class ImageProcess_Contour : ImageProcessElementBase
    {

    }
}
