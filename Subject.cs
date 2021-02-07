using System;
using System.Collections.Generic;
using System.Text;

namespace proxy_tasarım_deseni
{
    public interface ISubject
    {
        string Istek();
    }
    class Subject
    {
        public string Istek()
        {
            return "Kek yeni sunu tarafından alındı\n";
        }
    }
}
