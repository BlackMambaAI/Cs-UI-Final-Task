using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIFinalTask
{
    internal class Notification
    {
        public required string SenderUsername { get; set; }
        public required string ReceiverUsername { get; set; }
        public required string NotificationText { get; set; }
        public DateTime Timestamp { get; set; }
        public bool Starred { get; set; }

    }
}
