namespace Main.Data;

using System.Collections.Generic;

public class Project
{
    private List<Message> messages;
    public string? Name { get; set; }

    public Project()
    {
        this.messages = new List<Message>();
    }

    public void AddMessage(string userName, string message)
    {
        this.messages.Add(
            new Message()
            {
                Author = userName,
                Text = message,
                TimeStamp = DateTime.Now
            }
        );
    }
}