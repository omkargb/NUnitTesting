using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestPrograms
{
    public class NLog
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public void LogDebug( string message)
        {
            logger.Debug(" Debug : " +message);
        }

        public void LogError(string message)
        {
            logger.Error(" Error : " +message);
        }

        public void LogInfo(string message)
        {
            logger.Info(" Info :" +message);
        }
        public void LogWarn(string message)
        {
            logger.Warn(" Warn : " +message);
        }
    }
}
