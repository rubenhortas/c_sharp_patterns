﻿using System;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton _instance;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }

        public void SayHelloWorld()
        {
            Console.WriteLine("Hello world!");
        }
    }
}
