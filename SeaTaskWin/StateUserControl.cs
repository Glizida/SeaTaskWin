using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SeaTaskWin
{
    public enum State
    {
        Unsecured,
        SignedIn,
        Registration
    }

    public abstract class StateUserControl
    {

        protected UserControl currentStateUserControl;
        public StateUserControl()
        {
            CurrentStateCurrentState = new CustomUserControl.Login();
        }

        public UserControl CurrentStateCurrentState
        {
            get { return currentStateUserControl; }
            set { currentStateUserControl = value; }
        }

        public abstract void SetState(UserControl NewUserControl);
    }

    public class Unsecured : StateUserControl
    {
        public override void SetState(UserControl NewUserControl)
        {
            CurrentStateCurrentState = Login
        }
    }
}
