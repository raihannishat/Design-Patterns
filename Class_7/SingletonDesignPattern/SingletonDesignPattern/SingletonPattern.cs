using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern
{
    public class SingletonPattern
    {
        private volatile static SingletonPattern instance;
        private static readonly object _look = new object();

        private SingletonPattern() { }

        public static SingletonPattern GetSingletonPattern()
        {
            if (instance == null)
            {
                lock(_look)
                {
                    if (instance == null)
                    {
                        instance = new SingletonPattern();
                    }
                }
            }

            return instance;
        }
    }
}
