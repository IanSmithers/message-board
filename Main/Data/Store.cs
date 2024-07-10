namespace Main.Data;

using System.Collections.Generic;

public class Store
{
    private List<Message> projectMessages = new List<Message>();

    public void AddMessage(string author, string project, string message)
    {
        projectMessages.Add(
            new Message()
            {
                Author = author,
                Project = project,
                Text = message,
                TimeStamp = DateTime.Now
            }
        );

        foreach (var userMessage in projectMessages)
        {
            Console.WriteLine(userMessage.Text);
        }
    }
}