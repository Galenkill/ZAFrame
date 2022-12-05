using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;
namespace ZAFrame.ImageProcess
{
    public class MeasureFactory
    {
        #region 变量
        public MeasureModel Model { get; set; }

        #endregion
    }

    public class MeasureModel
    {
        //测量元素颜色
        public Scalar MeasuredElementColor = new Scalar(255, 0, 0);

        //构造元素颜色
        public Scalar ConstructElementColor = new Scalar(0, 255, 0);

        //Evaluate元素颜色
        public Scalar EvaluateElementColor = new Scalar(0, 0, 255);
    }
    public enum MeasureBaseType
    {
        Line, Circle, Point, Contour, None
    }
    public enum ConstructElementType
    {
        Line, Point, Circle, None
    }
    public enum EvaluateElementType
    {
        Distance, Angle, None
    }
}
