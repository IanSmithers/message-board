namespace Main.Data;

using System;

struct Message
{
    public string Author { get; set; }
    public string Project { get; set; }
    public string Text { get; set; }
    public DateTime TimeStamp { get; set; }
}