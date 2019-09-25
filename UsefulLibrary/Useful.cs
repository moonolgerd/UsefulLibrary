using System;

namespace UsefulLibrary
{
    public static class Useful
    {
        public static string Greet(string name)
        {
            if (name is null)
                throw new ArgumentNullException(nameof(name));
            
            return $"Hello, {name}!";
        }
    }
}
