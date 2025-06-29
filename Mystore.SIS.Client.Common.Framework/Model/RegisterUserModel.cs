using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystore.SIS.Client.Common.Framework.Model
{
    public class RegisterUserModel : NotifyPropertyChangeBase
    {
        private string _email;
        private string _password;
        private string _confirmPassword;
        private string _userName;

        public string Email
        {
            get { return _email; }
            set {
                _email = value;
                OnPropertyChanged();
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }
        public string ConfirmPassword
        {
            get { return _confirmPassword; }
            set
            {
                _confirmPassword = value;
                OnPropertyChanged();
            }
        }
        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
        }

    }
}
