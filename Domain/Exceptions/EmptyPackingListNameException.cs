namespace Domain.Exceptions
{
    public class EmptyPackingListNameException:PackItExceptions
    {
        public EmptyPackingListNameException() : base(message: "packing list name cannot be empty")
        {

        }
    }
}