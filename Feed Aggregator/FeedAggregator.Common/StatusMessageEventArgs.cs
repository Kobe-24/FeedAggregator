using System;
using System.Diagnostics;

namespace FeedAggregator.Common
{
    public class StatusMessageEventArgs : EventArgs
    {
        public EventLogEntryType MessageType { get; set; }
        public string Message { get; set; }

        public StatusMessageEventArgs(string message, EventLogEntryType messageType = EventLogEntryType.Information)
        {
            Message = message;
            MessageType = messageType;
        }
    }
}
