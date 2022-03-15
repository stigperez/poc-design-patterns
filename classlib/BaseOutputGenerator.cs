namespace classlib
{
    public abstract class BaseOutputGenerator : IOutputGenerator
    {
        public abstract string GetOutput();

        public virtual string GetOutput(string parameter)
        {
            return GetOutput();
        }
    }
}