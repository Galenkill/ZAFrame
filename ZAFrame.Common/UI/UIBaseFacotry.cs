using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ZAFrame.Common.UI
{
    public static class UIBaseFacotry
    {
        const string DLLPATTERN = "ZAFrame.*.dll";
        private static Dictionary<UI_UCBaseAttribute, Type> uiTypeDic = null;
        public static Dictionary<UI_UCBaseAttribute, Type> UITypeDic
        {
            get
            {
                if(uiTypeDic == null)
                {
                    var assm = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).GetFiles(DLLPATTERN).Select(u => Assembly.LoadFrom(u.FullName)).ToList();
                    assm.AddRange(AppDomain.CurrentDomain.GetAssemblies());
                    assm = assm.Distinct().ToList();
                    uiTypeDic = assm.SelectMany(a => a.GetTypes())
                               .Where(t =>
                               {
                                   if (t.GetCustomAttributes(typeof(UI_UCBaseAttribute), true).Any())
                                   {
                                       var attr = t.GetCustomAttribute<UI_UCBaseAttribute>();
                                       return attr != null;
                                   }
                                   else
                                   {
                                       return false;
                                   }
                               }).ToDictionary(t => t.GetCustomAttribute<UI_UCBaseAttribute>(), t => t);
                }
                return uiTypeDic;
            }
        }
    }
}
