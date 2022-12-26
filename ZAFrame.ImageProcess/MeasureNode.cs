using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAFrame.ImageProcess
{
    interface IImageProcessNode
    {
        ImageProcessElementBase[] Calculate(Mat mat, Mat matrix, params ImageProcessElementBase[] processelements);
        ImageProcessElementBase[] PreProcess(Mat mat, Mat matrix, params ImageProcessElementBase[] processelements);
        ImageProcessElementBase[] OnProcess(Mat mat, Mat matrix, params ImageProcessElementBase[] processelements);
        ImageProcessElementBase[] PostProcess(Mat mat, Mat matrix, params ImageProcessElementBase[] processelements);
    }
    public abstract class ImageProcessNode : AFBaseNode,IImageProcessNode
    {
        //For Display Calculated Mat with DrawElements
        public Action<Mat> OnUpdateCalculatedMat;
        public Action<ImageProcessElementBase[]> OnUpdateDisplayElement;
        public override void Execute()
        {
            base.Execute();
        }
        public virtual ImageProcessElementBase[] Calculate(Mat mat, Mat matrix, params ImageProcessElementBase[] processelements)
        {
            // ProProcess
            var preelements = PreProcess(mat, matrix, processelements);

            //Process
            var onprocesselements = OnProcess(mat, matrix, preelements);

            //PostProcess
            var postprocesselements = PostProcess(mat, matrix, onprocesselements);

            var dispmat = GenerateCalculatedMat(mat, postprocesselements);

            OnUpdateCalculatedMat?.BeginInvoke(dispmat, null, null);

            OnUpdateDisplayElement?.BeginInvoke(postprocesselements, null, null);

            return postprocesselements;
        }

        public abstract ImageProcessElementBase[] PreProcess(Mat mat, Mat matrix, params ImageProcessElementBase[] processelements);
        public abstract ImageProcessElementBase[] OnProcess(Mat mat, Mat matrix, params ImageProcessElementBase[] processelements);
        public abstract ImageProcessElementBase[] PostProcess(Mat mat, Mat matrix, params ImageProcessElementBase[] processelements);
        public abstract Mat GenerateCalculatedMat(Mat mat, params ImageProcessElementBase[] elements);
    }

    public class MeasureNode : ImageProcessNode
    {
        public override Mat GenerateCalculatedMat(Mat mat, params ImageProcessElementBase[] elements)
        {
            throw new NotImplementedException();
        }

        public override ImageProcessElementBase[] OnProcess(Mat mat, Mat matrix, params ImageProcessElementBase[] processelements)
        {
            throw new NotImplementedException();
        }

        public override ImageProcessElementBase[] PostProcess(Mat mat, Mat matrix, params ImageProcessElementBase[] processelements)
        {
            throw new NotImplementedException();
        }

        public override ImageProcessElementBase[] PreProcess(Mat mat, Mat matrix, params ImageProcessElementBase[] processelements)
        {
            throw new NotImplementedException();
        }
    }

    public class ConstructNode : ImageProcessNode
    {
        public override Mat GenerateCalculatedMat(Mat mat, params ImageProcessElementBase[] elements)
        {
            throw new NotImplementedException();
        }

        public override ImageProcessElementBase[] OnProcess(Mat mat, Mat matrix, params ImageProcessElementBase[] processelements)
        {
            throw new NotImplementedException();
        }

        public override ImageProcessElementBase[] PostProcess(Mat mat, Mat matrix, params ImageProcessElementBase[] processelements)
        {
            throw new NotImplementedException();
        }

        public override ImageProcessElementBase[] PreProcess(Mat mat, Mat matrix, params ImageProcessElementBase[] processelements)
        {
            throw new NotImplementedException();
        }
    }

    public class EvaluateNode : ImageProcessNode
    {
        public override Mat GenerateCalculatedMat(Mat mat, params ImageProcessElementBase[] elements)
        {
            throw new NotImplementedException();
        }

        public override ImageProcessElementBase[] OnProcess(Mat mat, Mat matrix, params ImageProcessElementBase[] processelements)
        {
            throw new NotImplementedException();
        }

        public override ImageProcessElementBase[] PostProcess(Mat mat, Mat matrix, params ImageProcessElementBase[] processelements)
        {
            throw new NotImplementedException();
        }

        public override ImageProcessElementBase[] PreProcess(Mat mat, Mat matrix, params ImageProcessElementBase[] processelements)
        {
            throw new NotImplementedException();
        }
    }
}
