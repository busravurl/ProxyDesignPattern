using System;
using System.Collections.Generic;
using System.Text;

namespace proxy_tasarım_deseni
{
    public class proxy : ISubject
    {
        Subject subject;

        public string Istek()
        {
            if(subject == null)
            {
                Console.WriteLine("Ne sipariş vermek istersiniz");
                subject = new Subject();
            }
            Console.WriteLine("Kek");
            return subject.Istek();
        }
    }
}
