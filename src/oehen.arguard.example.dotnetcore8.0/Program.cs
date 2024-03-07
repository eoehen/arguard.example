using System;

namespace oehen.arguard.example.dotnetcore8
{
    class Program
    {
        static void Main(string[] args)
        {
            testrun("");
        }

        private static void testrun(string v)
        {
            v.ThrowIfIsNullOrEmpty(nameof(v));
        }
    }
}
