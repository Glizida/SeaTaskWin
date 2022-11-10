using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using SeaTaskWin.CustomUserControl;

namespace SeaTaskWin.ViewModel
{
    class ViewModelMain : ViewModelBase
    {
        private UserControl _content;

        internal void SetNewContent(UserControl _content)
        {
            ContentWindow = _content;
        }

        public UserControl ContentWindow
        {
            get { return _content; }
            set
            {
                _content = value;
                OnPropertyChanged("ContentWindow");
            }
        }

        private RelayCommand _loadFirst;
        public RelayCommand LoadFirst
        {
            get
            {
                return _loadFirst ??
                    (
                        _loadFirst = new RelayCommand(obj =>
                        {
                            UserControl userControl = new CustomUserControl.Login();
                            SetNewContent(userControl);
                        }
                        )
                     );
            }
        }
    }
}
