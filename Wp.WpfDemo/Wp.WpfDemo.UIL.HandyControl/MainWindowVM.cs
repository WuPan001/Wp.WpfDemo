using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wp.WpfDemo.UIL.HandyControl
{
    internal class MainWindowVM
    {
        public string ImgPath { get; set; }
        public Dictionary<string, string> Dic { get; set; } = new Dictionary<string, string>() { { "123", "123" }, { "qwe", "qwe" }, { "asd", "asd" }, };
    }
}