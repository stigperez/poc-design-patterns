using System.Collections.Generic;
using System.Linq;

namespace classlib.creational.singleton
{
    public class SingletonOutputGenerator : BaseOutputGenerator
    {
        public override string GetOutput()
        {
            var logger = SingletonLogger.SingletonLoggerInstance;
            var loggingResults = new List<bool>(2);
            for(int i = 0; i < loggingResults.Capacity; i++)
            {
                loggingResults.Add(logger.Log("Log this"));
            }
            bool allLoggingsAreSuccessful = loggingResults.All(candidate => candidate);
            return $"Logging successful: {allLoggingsAreSuccessful}";
        }
    }
}