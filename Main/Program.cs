namespace Main;

using Main.Commands;
using Main.Data;

public class Program
{
    static void Main(string[] args)
    {
        ICommand postCommand = new PostCommand();
        ICommand readCommand = new ReadCommand();
        ICommand followCommand = new FollowCommand();
        ICommand wallCommand = new WallCommand();

        Store dataStore = new Store();

        while (true)
        {
            var command = Console.ReadLine();
            Console.WriteLine(command);
            if (command != null)
            {
                var parts = command.Split(' ');
                switch (parts.Length)
                {
                    case 1:
                        readCommand.Execute(
                            new CommandData()
                            {
                                Project = parts[0]
                            },
                            dataStore
                        );
                        break;
                    case 2:
                        wallCommand.Execute(
                            new CommandData()
                            {
                                Author = parts[0],
                                WallRequest = true
                            },
                            dataStore
                        );
                        break;
                    case 3:
                        followCommand.Execute(
                            new CommandData()
                            {
                                Author = parts[0],
                                Project = parts[2],
                                FollowRequest = true
                            },
                            dataStore
                        );
                        break;
                    default:
                        postCommand.Execute(
                            new CommandData()
                            {
                                Author = parts[0],
                                Project = parts[2],
                                Message = parts[3]
                            },
                            dataStore
                        );
                        break;
                }
            }
        }
    }
}
