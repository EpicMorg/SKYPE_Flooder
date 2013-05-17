using System;
using System.Collections.Generic;
using System.Text;
using SKYPE4COMLib;

namespace skype_flooder_gui
{
    class skype_friends
    {
        public User s_user;

        public override string ToString()
        {
            return s_user.FullName.Trim().Length > 0 ? s_user.FullName : s_user.Handle;
            //return s_user.FullName;
        } 
    }
}
