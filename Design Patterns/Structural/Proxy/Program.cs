using System;

namespace Proxy
{
    class Program
    {
        static void Access(Subject subject)
        {
            subject.Read();
            subject.Create();
            subject.Update();
            subject.Delete();
        }

        static void Main()
        {
            Subject subject = new RealSubject();
            Subject proxy;

            Console.WriteLine("Role: Guest");
            proxy = new ProxySubject(subject, Role.guest);
            Access(proxy);

            Console.WriteLine("\nRole: User");
            proxy = new ProxySubject(subject, Role.user);
            Access(proxy);

            Console.WriteLine("\nRole: Administrator");
            proxy = new ProxySubject(subject, Role.administrator);
            Access(proxy);

            Console.ReadKey();
        }
    }
}
