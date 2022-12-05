using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAFrame.Common.UI
{
    public class UI_UCBaseAttribute : Attribute
    {
        public string UICode { get; set; }
        public string UIName { get; set; }
        public UI_UCBaseAttribute(string menucode, string menuname)
        {
            UICode = menucode;
            UIName = menuname;
        }
    }

}

