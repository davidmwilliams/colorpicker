using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color_Picker
{
    public class StateManager
    {
        public enum States
        {
            Normal,
            Abnormal,
            NotAuthorized
        }

        public static States State { get; set; }
    }
}
