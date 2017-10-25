using System;
using System.Collections.Generic;
using System.Text;

namespace Pocket_Scout
{
    class Message
    {
        public string MessageText { get; set; }
        public string UserSent { get; set; }
        public string Time { get; set; }
        //tells if the last message was sent by the same person //used to determine if we need to turn off name on message
        public bool NotSameUser { get; set; }
        //just the color of the message
        public string colorMessage { get; set; }
        //either start or end for the alignment between user and others in messages
        public string alignment { get; set; }
    }
}
