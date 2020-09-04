﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Helpers
{
    public static class ObjectFactory
    {
        public static T Get<T>(params object[] args)
        {
            return (T)Activator.CreateInstance(typeof(T), args);
        }
    }
}
