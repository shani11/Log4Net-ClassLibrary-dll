using log4net;
using log4net.Config;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Log4Net_Logging
{
    public static class LogFourNet
    {
        // Define a static logger variable so that it references the
        private static readonly ILog Log = LogManager.GetLogger(typeof(LogFourNet));

        public static void SetUp(Assembly a, string configFile, [CallerFilePath] string caller = "")
        {
            var logRepository = LogManager.GetRepository(a);
            XmlConfigurator.Configure(logRepository, new FileInfo(configFile));
            Log.Info("Log4net is configured for " + Path.GetFileNameWithoutExtension(caller));

        }

        public static void Info(object currentObj, string msg, [CallerLineNumber] int lineNumber = 0,
            [CallerFilePath] string caller = "", [CallerMemberName] string memberName = "")
        {

            Log.Info("[" + currentObj.GetType().Namespace + "." +
                     Path.GetFileNameWithoutExtension(caller) + "." + memberName + ":" + lineNumber + "] - " + msg);

        }

        public static void Debug(object currentObj, string msg, [CallerLineNumber] int lineNumber = 0,
            [CallerFilePath] string caller = "", [CallerMemberName] string memberName = "")
        {
            Log.Debug("[" + currentObj.GetType().Namespace + "." +
                      Path.GetFileNameWithoutExtension(caller) + "." + memberName + ":" + lineNumber + "] - " + msg);
        }

        public static void Error(object currentObj, string msg, [CallerLineNumber] int lineNumber = 0,
            [CallerFilePath] string caller = "", [CallerMemberName] string memberName = "")
        {
            Log.Error("[" + currentObj.GetType().Namespace + "." +
                      Path.GetFileNameWithoutExtension(caller) + "." + memberName + ":" + lineNumber + "] - " + msg);
        }
    }
}
