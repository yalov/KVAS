﻿using System;
using UnityEngine;

namespace USKAM
{
    public static class Logging
    {
        private static string PREFIX = "<color=green>USKAM:</color> ";

        public static void Log<T>(T msg)
        {
            Debug.Log(PREFIX + DateTime.Now.ToString("hh:mm:ss.f ") + msg.ToString());
        }

        public static void Log(string msg, params object[] arg)
        {
            Debug.Log(PREFIX + DateTime.Now.ToString("hh:mm:ss.f ") + String.Format(msg, arg));
        }
    }
}
