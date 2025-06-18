using System;

namespace Lab2.Patterns.Singleton
{
    public class Singleton
    {
        private static Singleton? _instance;
        private static readonly object _lock = new object();

        public string Data { get; set; }

        private Singleton()
        {
            Data = "Singleton data";
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}