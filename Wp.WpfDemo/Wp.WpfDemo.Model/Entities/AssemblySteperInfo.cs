using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wp.WpfDemo.Model.Enums;

namespace Wp.WpfDemo.Model.Entities
{
    public class AssemblySteperInfo : ViewModelBase
    {
        #region 事件

        //

        #endregion 事件

        #region 属性、字段

        private EAssemblyStatus _status;

        /// <summary>
        /// 当组装状态
        /// </summary>
        public EAssemblyStatus Status { get { return _status; } set { _status = value; RaisePropertyChanged(); } }

        private string _rfid;

        /// <summary>
        /// 托盘RFID编号
        /// </summary>
        public string RFID { get { return _rfid; } set { _rfid = value; RaisePropertyChanged(); } }

        private ObservableCollection<AssemblySteperItemInfo> _steperItemInfo = new ObservableCollection<AssemblySteperItemInfo>();

        /// <summary>
        /// 组装详细信息
        /// </summary>
        public ObservableCollection<AssemblySteperItemInfo> SteperItemInfo { get { return _steperItemInfo; } set { _steperItemInfo = value; RaisePropertyChanged(); } }

        private bool _isExpand;

        /// <summary>
        /// 标识Expander是否打开
        /// </summary>
        public bool IsExpand { get { return _isExpand; } set { _isExpand = value; RaisePropertyChanged(); } }

        #region 命令

        //

        #endregion 命令

        #endregion 属性、字段

        #region 方法

        //

        #endregion 方法
    }
}