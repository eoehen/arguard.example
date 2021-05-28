using System;

namespace oehen.arguard.example.net4._7._2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            testrun("");
        }

        private static void testrun(string v)
        {
            v.ThrowIfIsNullOrEmpty(nameof(v));
        }
    }
}
