using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wp.WpfDemo.Model.Enums
{
    /// <summary>
    /// 装配状态
    /// </summary>
    public enum EAssemblyStatus
    {
        [Description("完成配盘")]
        CompleteMatching,

        [Description("完成装配")]
        CompleteAssembly,

        [Description("完成预装")]
        CompletePreAssembly,

        [Description("取消配盘")]
        CancelMatching,

        [Description("取消装配")]
        CancelAssembly,

        [Description("取消预装")]
        CancelPreAssembly,

        [Description("暂停配盘")]
        PauseMatching,

        [Description("暂停装配")]
        PauseAssembly,

        [Description("暂停预装")]
        PausePreAssembly,

        [Description("等待配盘")]
        WaittingMatching,

        [Description("等待装配")]
        WaittingAssembly,

        [Description("等待预装")]
        WaittingPerAssembly,

        [Description("配盘中")]
        Matching,

        [Description("组装中")]
        Assembling,

        [Description("预装中")]
        PreAssembling,

        [Description("入库中")]
        Storing,

        [Description("在库")]
        Stored,

        [Description("出库中")]
        Delivering,

        [Description("已出库")]
        Delivered,
    }
}