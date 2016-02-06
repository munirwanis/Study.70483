using System;
using System.Diagnostics;
using System.Threading;

namespace Study.ExceptionHandling {
    class Program {

        private static Stopwatch _execTimer = new Stopwatch();

        public static void Delay(int delay) => Thread.Sleep(delay);

        public static void LogLongExec(string msg) {
            if (_execTimer.Elapsed.Seconds >= 5) {
                throw new Exception($"Execution is too long > {msg} > {_execTimer.Elapsed.TotalMilliseconds}");
            }
        }

        static void Main(string[] args) {
            _execTimer.Start();

            try {
                Delay(10);
                LogLongExec("Delay(10)");
                Delay(5000);
                LogLongExec("Delay(5000)");
            } catch (Exception ex) {
                using (
                    XmlWriterTraceListener log1 =
                        new XmlWriterTraceListener($@"C:\Users\{Environment.UserName}\Pictures\Error.log")) {
                    log1.TraceEvent(new TraceEventCache(), ex.Message, TraceEventType.Error, ex.HResult);
                    log1.Flush();
                }
            }
        }
    }
}
