using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.Net_Button_WebChall.Models
{
    public class ButtonModel
    {
        public ButtonModel(int state)
        {
            State = state;
        }

        public int State { get; set; }
    }
}