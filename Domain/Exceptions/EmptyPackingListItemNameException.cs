namespace Domain.Exceptions;

public class EmptyPackingListItemNameException:PackItExceptions
{
    public EmptyPackingListItemNameException() : base(message:"Packing Item name cannot be empty")
    {
    }
}