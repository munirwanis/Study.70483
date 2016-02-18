using System;
using System.Collections.Generic;

namespace Study.DoWorkObjectTypes {
    class Program {
        static void Main(string[] args) {
            Queue<Worker> queue = new Queue<Worker>();
            queue.Enqueue(new Worker());
            Worker worker = new Worker();
            worker.Run();
            Console.ReadKey();
        }
    }

    public class ItemBase { }
    public class Widget : ItemBase { }

    class Worker {
        void DoWork(object obj) {
            Console.WriteLine("In DoWork(object)");
        }

        void DoWork(Widget widget) {
            Console.WriteLine("In DoWork(Widget)");
        }

        void DoWork(ItemBase itemBase) {
            Console.WriteLine("In DoWork(ItemBase)");
        }

        public void Run() {
            object o = new Widget();
            DoWork((Widget)o);
        }
    }
}
