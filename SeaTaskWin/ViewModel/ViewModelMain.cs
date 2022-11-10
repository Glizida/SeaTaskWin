using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

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

        
    }
}
