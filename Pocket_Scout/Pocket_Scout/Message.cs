﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pocket_Scout
{
    class Message
    {
        public string MessageText { get; set; }
        public string UserSent { get; set; }
        public string Time { get; set; }
        public bool NotSameUser { get; set; }
        public string colorMessage { get; set; }
        public string alignment { get; set; }
    }
}
