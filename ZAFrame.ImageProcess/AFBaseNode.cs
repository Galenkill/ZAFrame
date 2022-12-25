using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAFrame.ImageProcess
{
    interface INode
    {
        void Run();
        void Execute();
    }
    internal abstract class AFBaseNode: INode
    {
        #region 属性
        public string ID { get; set; }=Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Description { get; set; }

        AFBaseNode PreNode { get; set; } = null;
        AFBaseNode NextNode { get; set; } = null;

        #endregion

        #region 
        public  AFBaseNode(){}
        public AFBaseNode(string name,string description):this(name,description,null,null)
        {
           
        }
        public AFBaseNode(string name, string description, AFBaseNode nextnode):this(name, description,null,nextnode)
        {
        }
        public AFBaseNode(string name,string description,AFBaseNode prenode,AFBaseNode nextnode)
        {
            Name = name;
            Description = description;
            if(prenode!=null)
                PreNode = prenode;
            if(nextnode!=null)
                NextNode = nextnode;
        }
        #endregion
        public virtual void Run()
        {
            Console.WriteLine("Run");
        }
        public virtual void Execute()
        {
            if (NextNode != null)
                NextNode.Execute();
            else
                Console.WriteLine("Process End!");
        }

        #region 逻辑控制
        #endregion
    }
}
