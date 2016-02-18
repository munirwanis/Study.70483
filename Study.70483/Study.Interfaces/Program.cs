using System;

namespace Study.Interfaces {
    class Program {
        static void Main(string[] args) {
            var starter = new UserStart();
            ((IHome)starter).Start();
            ((IOffice)starter).Start();
        }
    }

    class UserStart : IHome, IOffice {
        void IHome.Start() {
            throw new NotImplementedException();
        }

        void IOffice.Start() {
            throw new NotImplementedException();
        }
    }

    interface IHome {
        void Start();
    }

    interface IOffice {
        void Start();
    }
}
