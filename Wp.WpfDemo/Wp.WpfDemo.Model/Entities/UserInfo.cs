using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wp.WpfDemo.Model.Enums;

namespace Wp.WpfDemo.Model.Entities
{
    public class UserInfo : ViewModelBase
    {
        public int Id { get; set; }
        private string _userName;

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get { return _userName; } set { _userName = value; RaisePropertyChanged(); } }

        private string _pwd;

        /// <summary>
        /// 用户密码
        /// </summary>
        public string PWD { get { return _pwd; } set { _pwd = value; RaisePropertyChanged(); } }

        public EUserAuthority? _authority;

        /// <summary>
        /// 用户权限
        /// </summary>
        public EUserAuthority? Authority { get { return _authority; } set { _authority = value; RaisePropertyChanged(); } }
    }
}