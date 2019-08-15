using System;

public class Item {
    public int Id {get; set; }

    public string Name {get; set;}

    public DateTime CreatedAt {get; set;}

    public Item()
    {
        CreatedAt = DateTime.Now;
    }

    public override string ToString()
    {
        return $"{Id}: {Name}, {CreatedAt}.";
    }
}