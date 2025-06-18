using System;

namespace Lab3.Patterns.Proxy
{
    // Proxy
    public class Proxy : ISubject
    {
        private RealSubject _realSubject;
        private bool _isAuthorized;

        public Proxy(RealSubject realSubject, bool isAuthorized)
        {
            _realSubject = realSubject;
            _isAuthorized = isAuthorized;
        }

        public string Request()
        {
            if (CheckAccess())
            {
                return $"Proxy: Authorized. {_realSubject.Request()}";
            }
            else
            {
                return "Proxy: Access denied.";
            }
        }

        private bool CheckAccess()
        {
            return _isAuthorized;
        }
    }
}