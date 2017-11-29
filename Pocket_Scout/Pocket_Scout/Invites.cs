using System;
using System.Collections.Generic;
using System.Text;

namespace Pocket_Scout
{
    class Invites
    {
        //the username that invited said person
        public string Username { get; set; }

        //the property on the group manager that will show the buttons or not
        public bool IsVisible { get; set; }
    }
}
