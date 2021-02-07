using System;
using System.Collections.Generic;
using System.Text;

namespace proxy_tasarım_deseni
{
    class ProtectionProxy : ISubject
    {
        Subject subject;

        public string Onay(string supplied)
        {
            Console.WriteLine("Ödemeyi nasıl yapmak istersiniz?");
            Console.WriteLine("Nakit");
            Console.WriteLine("Proxy: yeni ödeme işlemini proxy yerine getiremiyor.");

            subject = new Subject();
            return "Eski sunucu: ödeme işlemi nakit olarak gerçekleşti";
        }

        public string Istek()
        {
            if (subject == null)
                return "Siparişiniz Hazır";
            else
                return subject.Istek();
        }
    }
}
