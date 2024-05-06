using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class ContactList
    {
        Contact? head;
        Contact? tail;

        public ContactList()
        {
            head = null;
            tail = null;
        }

        public void Add(Contact contact)
        {
            if (IsEmpty())
            {
                head = contact;
                tail = contact;
            }
            else
            {
                int compare = string.Compare(contact.GetName(), head.GetName(), comparisonType: StringComparison.OrdinalIgnoreCase);

                if (compare <= 0)
                {
                    Contact aux = head;
                    head = contact;
                    head.SetNext(aux);
                }
                else
                {
                    Contact aux = head;
                    Contact prev = head;

                    do
                    {
                        compare = string.Compare(contact.GetName(), aux.GetName());
                        if (compare > 0)
                        {
                            prev = aux;
                            aux = aux.GetNext();
                        }

                    } while (aux != null && compare > 0);

                    prev.SetNext(contact);
                    contact.SetNext(aux);

                    if(aux == null)
                    {
                        tail = contact;
                    }
                }
            }
        }

        bool IsEmpty()
        {
            return head == null && tail == null;
        }

    }
}
