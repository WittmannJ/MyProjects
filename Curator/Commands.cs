using System.Threading.Tasks;
using McMaster.Extensions.CommandLineUtils;
using Microsoft.EntityFrameworkCore;

[Subcommand(typeof(AddCommand), typeof(ListCommand), typeof(RemoveCommand))]
public class CuratorCommand
{
    public CuratorContext CuratorContext { get; }

    public CuratorCommand()
    {
        CuratorContext = new CuratorContext();
        CuratorContext.Database.EnsureCreated();
    }

    public Task<int> OnExecuteAsync(CommandLineApplication application)
    {
        application.ShowHelp();
        return Task.FromResult(0);
    }
}

[Command("add")]
public class AddCommand
{
    public CuratorCommand Parent { get; set; }

    [Argument(0, name: "Item name")]
    public string Name { get; set; }

    public async Task<int> OnExecuteAsync()
    {
        Parent.CuratorContext.Add(new Item { Name = Name });
        await Parent.CuratorContext.SaveChangesAsync();
        return 0;
    }
}

[Command("list")]
public class ListCommand
{
    public CuratorCommand Parent { get; set; }

    public async Task<int> OnExecuteAsync()
    {
        var items = await Parent.CuratorContext.Items.ToListAsync();
        items.ForEach(System.Console.WriteLine);
        return 0;
    }
}

[Command("remove")]
public class RemoveCommand
{
    [Argument(0, name: "Item Id")]
    public int Id { get; set; }

    public CuratorCommand Parent { get; set; }

    public async Task<int> OnExecuteAsync()
    {
        Parent.CuratorContext.Remove(new Item { Id = Id });
        await Parent.CuratorContext.SaveChangesAsync();
        return 0;
    }
}