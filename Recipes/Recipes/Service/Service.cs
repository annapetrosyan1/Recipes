﻿using System;
namespace Recipes
{
    public static class Service<T>
    {
        private static T _instance;

        public static void RegisterService(T instance)
        {
            if (_instance != null)
                new Exception("Service already exist");
            _instance = instance;
        }

        public static T GetService()
        {
            if (_instance == null)
                new Exception("No service!");
            return _instance;
        }
    }
}
