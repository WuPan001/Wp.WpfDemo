using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace Wp.WpfDemo.Model.Entities.Assembly
{
    public class AssemblySteperItemInfo : ViewModelBase
    {
        #region 属性、字段

        private string _firstLevelTitle;

        /// <summary>
        /// 一级标题
        /// </summary>
        public string FirstLevelTitle { get { return _firstLevelTitle; } set { _firstLevelTitle = value; RaisePropertyChanged(); } }

        private string _secondLevelTitle;

        /// <summary>
        /// 二级标题
        /// </summary>
        public string SecondLevelTitle { get { return _secondLevelTitle; } set { _secondLevelTitle = value; RaisePropertyChanged(); } }

        private string _dividerContext = "详细信息";

        /// <summary>
        /// 分隔条标题
        /// </summary>
        public string DividerContext { get { return _dividerContext; } set { _dividerContext = value; RaisePropertyChanged(); } }

        private ObservableCollection<string> _details = new ObservableCollection<string>();

        /// <summary>
        /// 详细信息
        /// </summary>
        public ObservableCollection<string> Details { get { return _details; } set { _details = value; RaisePropertyChanged(); } }

        #endregion 属性、字段
    }
}