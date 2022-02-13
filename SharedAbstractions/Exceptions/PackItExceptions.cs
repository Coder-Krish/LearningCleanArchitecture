
using System;

public abstract class PackItExceptions: Exception
{
    protected PackItExceptions(string message): base(message)
    {
        
    }
}