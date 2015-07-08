
using SKYPE4COMLib;

namespace skype_flooder_gui
{
    class SkypeFriends
    {
        public User SUser;

        public override string ToString()
        {
            return SUser.FullName.Trim().Length > 0 ? SUser.FullName : SUser.Handle;
            //return s_user.FullName;
        } 
    }
}
