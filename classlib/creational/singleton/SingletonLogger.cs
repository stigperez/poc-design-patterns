using System;

namespace classlib.creational.singleton
{
    public class SingletonLogger
    {
        private bool? _loggingIsSuccessful;
        private static Lazy<SingletonLogger> singletonLoggerInstance => new Lazy<SingletonLogger>(() => new SingletonLogger());
        public static SingletonLogger SingletonLoggerInstance { get => singletonLoggerInstance.Value; }

        private SingletonLogger()
        {
            // this will set the success of logging to true, but only if the constructor is called one time
            _loggingIsSuccessful = _loggingIsSuccessful.HasValue ? false : true;
        }

        public bool Log(string message)
        {
            return _loggingIsSuccessful.Value;
        }
    }
}