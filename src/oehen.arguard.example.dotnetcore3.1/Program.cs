using System;

namespace oehen.arguard.example
{
    internal static class Program
    {
        private static void Main()
        {
            testrun("");
        }

        private static void testrun(string v)
        {
            v.ThrowIfIsNullOrEmpty(nameof(v));
        }
    }
}