using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

                    if (aux == null)
                    {
                        tail = contact;
                    }
                }
            }
        }

        public bool RemoveByName(string name)
        {
            // check if the list is empty
            if (IsEmpty())
            {
                return false;
            }

            // check if the correspondent name is in head
            if (head.GetName().Equals(name))
            {
                head = head.GetNext();

                if (head == null)
                    tail = null;

                return true;
            }

            Contact aux = head;
            Contact prev = head;

            bool equals;
            do
            {
                equals = aux.GetName().Equals(name);

                if (!equals)
                {
                    prev = aux;
                    aux = aux.GetNext();
                }

            } while (aux != null && !equals);

            if (equals)
            {
                prev.SetNext(aux.GetNext());

                if (prev.GetNext() == null)
                    tail = prev;

                return true;
            }

            return false;
        }

        public void Print()
        {
            Console.WriteLine("List:");

            if (!IsEmpty())
            {
                Contact aux = head;

                do
                {
                    Console.WriteLine($"-->{aux}");
                    aux = aux.GetNext();
                } while (aux != null);
            }
            else
            {
                Console.WriteLine("List is empty!");
            }
        }


        bool IsEmpty()
        {
            return head == null && tail == null;
        }

    }
}
