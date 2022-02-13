namespace Domain.Exceptions;

public class PackingItemNotFoundException:PackItExceptions
{
    public string ItemName { get; }

    public PackingItemNotFoundException(string itemName) : base(message:$"Packing item '{itemName}' was not found.")
    {
        ItemName = itemName;
    }
}