using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAFrame.ImageProcess
{
    internal abstract class LogicalNode:AFBaseNode
    {
        public LogicalNode LogicalStartNode { get; set; } = null;
        public LogicalNode LogicalEndNode { get; set; } = null;

    }
}
