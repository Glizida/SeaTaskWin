using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Microsoft.EntityFrameworkCore;
using SeaTaskWin.ModelDataBase;
using SeaTaskWin.CustomUserControl;


namespace SeaTaskWin.ViewModel
{
    class ViewModelLogin : ViewModelBase
    {

        //-----------------------------------------------------------------------------//


    
        //-----------------------------------------------------------------------------//


        private string _username;
        public string Username
        {
            get { return _username; }
            set 
            { 
                _username = value;
            }
        }

        private RelayCommand _registrationCommand;

        public RelayCommand RegistrationCommand
        {
            get {
                return _registrationCommand ??
                    (
                        _registrationCommand = new RelayCommand(obj =>
                        {

                        }
                        )
                     );
                }
        }


        private RelayCommand _authorizatiConommand;
        public RelayCommand AuthorizationCommand
        { 
            get
            {
                return _authorizatiConommand ??
                    (
                        _authorizatiConommand = new RelayCommand(obj =>
                        {
                            try
                            {
                                using (master_bdContext db = new master_bdContext())
                                {
                                    var users = db.Loginusers.ToList();
                                    foreach (Loginuser u in users)
                                    {
                                        MessageBox.Show($"{u.Id}.{u.Login} - {u.Password}");
                                    }
                                   
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        )
                    );
            }
        }

    }
}
