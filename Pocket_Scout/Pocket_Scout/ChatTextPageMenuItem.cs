using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocket_Scout
{

    public class ChatTextPageMenuItem
    {
        public ChatTextPageMenuItem()
        {
            TargetType = typeof(ChatTextPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}