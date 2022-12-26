using Newtonsoft.Json;
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
    public abstract class AFBaseNode: INode
    {
        public event Action<string> OnException;
        #region 属性
        public string ID { get; set; }=Guid.NewGuid().ToString();
        public string NodeName { get; set; }
        public string Description { get; set; }
        public string PreNodeID { get; set; }
        public string NextNodeID { get; set; }

        [JsonIgnore]
        AFBaseNode PreNode { get; set; } = null;
        [JsonIgnore]
        AFBaseNode NextNode { get; set; } = null;

        #endregion

        #region 构造函数
        public  AFBaseNode(){}
        public AFBaseNode(string name,string description):this(name,description,null,null)
        {
           
        }
        public AFBaseNode(string name, string description, AFBaseNode nextnode):this(name, description,null,nextnode)
        {
        }
        public AFBaseNode(string name,string description,AFBaseNode prenode,AFBaseNode nextnode)
        {
            NodeName = name;
            Description = description;
            if (prenode != null)
            {
                PreNode = prenode;
                PreNodeID = prenode.ID;
            }
            if (nextnode != null)
            {
                NextNode = nextnode;
                NextNodeID = nextnode.ID;
            }
        }
        #endregion
        public virtual void Run()
        {
            Execute();
            if (NextNode != null)
                NextNode.Run();
            else
                Console.WriteLine("Process End!");
            Console.WriteLine("Run");
        }
        public virtual void Execute()
        {
            
           
        }
        //public virtual void Execute_OneStep()
        //{

        //}
        #region 逻辑控制
        #endregion
    }
}
