using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Contact
    {
        string name;
        string phone;
        Contact? next;

        public Contact(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
            next = null;
        }

        public string GetName()
        {
            return name;
        }

        public void SetNext(Contact next)
        {
            this.next = next;
        }

        public Contact? GetNext()
        {
            return next;
        }

        public override string? ToString()
        {
            return $"Name: {name} | Phone: {phone}";
        }
    }
}
