using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wp.WpfDemo.Model.Enums
{
    /// <summary>
    /// 用户权限
    /// </summary>
    public enum EUserAuthority
    {
        /// <summary>
        /// 管理员
        /// </summary>
        [Description("管理员")]
        Admin,

        /// <summary>
        /// 普通用户
        /// </summary>
        [Description("普通用户")]
        Normal,

        /// <summary>
        /// 临时用户
        /// </summary>
        [Description("临时用户")]
        Temp,
    }
}