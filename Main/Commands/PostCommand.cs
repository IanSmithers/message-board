namespace Main.Commands;

using Main.Data;

public class PostCommand : ICommand
{
    public void Execute(CommandData commandData, Store dataStore)
    {
        dataStore.AddMessage(
            commandData.Author,
            commandData.Project,
            commandData.Message
        );
    }
}