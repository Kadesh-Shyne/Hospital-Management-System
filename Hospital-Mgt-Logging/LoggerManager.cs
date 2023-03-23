using Hospital_Mgt_Application.Contracts;


namespace Hospital_Mgt_Logging
{
    public class LoggerManager : ILoggerManager
    {
        private static ILoggerManager logger = LoggerManager.GetCurrentClassLogger();
        public void LogDebug(string message)
        {
         logger.LogDebug(message);
        }

        public void LogError(string message)
        {
         logger.LogError(message);
        }

        public void LogInfo(string message)
        {
         logger.LogInfo(message);
        }

        public void LogWarn(string message)
        {
          logger.LogWarn(message);
        }
    }
}
