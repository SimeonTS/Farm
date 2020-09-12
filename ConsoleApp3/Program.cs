using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)

        {
            Context context = new Context(new StateA());
            context.Request();
            context.Request();
            context.Request();

        }
    }
}
