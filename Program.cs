using System;

namespace GitHubActionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            static string X()
            {
                return "\"Hello World! Dotnet Test!!!\"";
            }
            Console.WriteLine(X());
        }
    }
}
