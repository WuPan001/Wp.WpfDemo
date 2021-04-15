using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wp.WpfDemo.UIL.TestPrism.Interfaces
{
    internal interface IAppCmds
    {
        CompositeCommand GetCurrentAllTimeCommand { get; }
    }
}