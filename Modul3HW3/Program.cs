using System;

namespace Modul3HW3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Subject subject = new Subject();
            Observer firstOserver = new Observer(1, subject);
            Observer secondObserver = new Observer(2, subject);
            Observer thirdObserver = new Observer(3, subject);

            firstOserver.Attach();
            secondObserver.Attach();
            thirdObserver.Attach();

            subject.Notify();

            firstOserver.Detach();
            secondObserver.Detach();
            thirdObserver.Detach();
            Console.ReadKey();
        }
    }
}
