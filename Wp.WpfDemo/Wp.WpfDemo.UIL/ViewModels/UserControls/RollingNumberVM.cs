using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-------------------------------------------------------------------------
 * 版权所有：
 * 作者：
 * 联系方式：
 * CLR Version :4.0.30319.42000
 * 创建时间： 2021/4/20 15:34:16
 * 版本号：v1.0
 * 本类主要用途描述：
 *******************************************************************
 * Copyright @ Administrator 2021. All rights reserved.
 *******************************************************************
 *  -------------------------------------------------------------------------*/

namespace Wp.WpfDemo.UIL.ViewModels.UserControls
{
    public class RollingNumberVM : ViewModelBase
    {
        #region 事件

        //

        #endregion 事件

        #region 字段、属性

        private int _nextNum;

        public int NextNum
        {
            get { return _nextNum; }
            set { _nextNum = value; RaisePropertyChanged(); }
        }

        private int _currentNum;

        public int CurrentNum
        {
            get { return _currentNum; }
            set
            {
                PrveNum = value - 1;
                _currentNum = value;
                NextNum = value + 1;
                RaisePropertyChanged();
            }
        }

        private int _prveNum;

        public int PrveNum
        {
            get { return _prveNum; }
            set { _prveNum = value; RaisePropertyChanged(); }
        }

        #region 命令

        //

        #endregion 命令

        #endregion 字段、属性

        #region 方法

        //

        #endregion 方法
    }
}