using System;

namespace GitHubActionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            static string X() => "\"Hello World! Dotnet Test!!!\"";
            Console.WriteLine(X());
        }
    }
}
