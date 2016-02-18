using System.Diagnostics;

namespace Study.EventLog {
    class Program {
        static void Main(string[] args) {
        }

        public void WriteToEventLog(string message, EventLogEntryType eventLogEntryType) {
            System.Diagnostics.EventLog eventLog = new System.Diagnostics.EventLog {
                Source = "MySource",
                EnableRaisingEvents = true
            };
            eventLog.WriteEntry(message, eventLogEntryType);
        }
    }
}
