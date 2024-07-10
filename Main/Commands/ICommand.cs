namespace Main.Commands;

using Main.Data;

public interface ICommand
{
    public void Execute(CommandData commandData, Store dataStore);
}
