
using System;

namespace proxy_tasarım_deseni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proxy Tasarım Deseni\n");

            ISubject subject = new proxy();
            Console.WriteLine(subject.Istek());
            subject = new ProtectionProxy();
            Console.WriteLine(subject.Istek());
            Console.WriteLine((subject as ProtectionProxy).Onay("Onaylandı"));
        }
    }


}
