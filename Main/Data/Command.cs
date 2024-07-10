namespace Main.Data;

using System;

public struct CommandData
{
    public string Author { get; set; }
    public string Project { get; set; }
    public string Message { get; set; }
    public DateTime TimeStamp { get; set; }
    public bool FollowRequest { get; set; }
    public bool WallRequest { get; set; }
}