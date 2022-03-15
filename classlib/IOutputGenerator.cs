namespace classlib
{
    public interface IOutputGenerator
    {
        string GetOutput();
        string GetOutput(string parameter);
    }
}