using System;

namespace oehen.arguard.example.dotnetcore5._0
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
