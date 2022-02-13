namespace Domain.Exceptions;

public class EmptyPackingListIdException:PackItExceptions
{
    public EmptyPackingListIdException() : base(message:"Packing List Id cannot be empty")
    {
    }
}