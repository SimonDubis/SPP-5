using System;

namespace DependencyInjectionContainerLibrary.Exceptions
{
    public class UnsupportedTypeException : Exception
    {
        public UnsupportedTypeException(string? message) : base(message)
        {
        }
    }
}