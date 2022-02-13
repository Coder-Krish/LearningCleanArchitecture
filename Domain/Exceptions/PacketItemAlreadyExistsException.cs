namespace Domain.Exceptions;

public class PacketItemAlreadyExistsException:PackItExceptions
{
    public string ListName { get; }
    public string ItemName { get; }

    public PacketItemAlreadyExistsException(string listName, string itemName)
        : base(message: $"Packing List: '{listName}' already defined item '{itemName}'")

    {
        ListName = listName;
        ItemName = itemName;
    }
}