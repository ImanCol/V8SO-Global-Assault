using System;
using System.Diagnostics;
using System.IO;
using UnityEngine;
using Debug = UnityEngine.Debug;

//Para Debugging
namespace V2UnityDiscordIntercept
{
    internal static class Logger
    {
        public static void Log(string message)
        {
            var method = new StackFrame(1).GetMethod();
            string msg = $"[{DateTime.UtcNow}] - {method.DeclaringType}.{method.Name} - {message}\r\n";
            LogToFile(msg);
        }

        private static void LogToFile(string message)
        {
#if UNITY_ANDROID
            Debug.LogWarning(string.Format(message));
#elif UNITY_SWITCH
            Debug.LogWarning(string.Format(message));
#elif UNITY_STANDALONE_WIN || UNITY_EDITOR_WIN
            Directory.CreateDirectory("Logs");
            File.AppendAllText($"Logs/{Plugin.Username}.txt", message);
#endif
        }
    }
}
