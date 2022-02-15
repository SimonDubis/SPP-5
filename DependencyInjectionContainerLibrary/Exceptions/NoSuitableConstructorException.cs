using System;

namespace DependencyInjectionContainerLibrary.Exceptions
{
    public class NoSuitableConstructorException : Exception
    {
        public NoSuitableConstructorException(string? message) : base(message)
        {
        }
    }
}