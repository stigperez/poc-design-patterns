namespace classlib.behavioral.command
{
    public interface ICommand
    {
        CommandResult ExecuteCommand();
        CommandResult UndoCommand();
    }
}