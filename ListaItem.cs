using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExListaSimples
{
    internal class ListaItem
    {
        public Item Begin { get; set; }
        public Item End { get; set; }

        public ListaItem()
        {
            Begin = null;
            End = null;
        }

        public void InsertFirst(Item i)
        {
            i.Next = Begin;
            Begin = i;
        }

        public void InsertLast(Item i)
        {
            End.Next = i;
            End = i;
        }

        public void InsertMiddle(Item i)
        {
            Item aux = Begin;

            if(aux.Value <= i.Value && aux.Next.Value >= i.Value) 
            {
                i.Next = aux.Next;
                aux.Next = i;
                return;
            }

            aux = aux.Next;
        }

        public void Insert(Item item)
        {
            if (IsEmpty())
            {
                Begin = item;
                End = item;
            }
            else if (item.Value <= Begin.Value)
            {
                InsertFirst(item);
            }
            else if (item.Value >= Begin.Value)
            {
                InsertLast(item);
            }
            else
            {
                InsertMiddle(item);
            }
        }

        public Item Find(Item f)
        {
            Item aux = Begin;
            while(aux.Next != null)
            {
                if(aux.Value == f.Value)
                {
                    return aux;
                }
                aux = aux.Next;
            }
            aux = null;
            return aux;
        }

        public bool IsEmpty()
        {
            if(Begin == null) 
            {
                return true;
            }
            else {
                return false;
            }
        }

        public void Print()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Lista vazia!");
            }
            else 
            {
                Item aux = Begin;
                while(aux != null) 
                {
                    Console.WriteLine(aux.Value);
                    aux = aux.Next;
                }
            }
        }
    }
}
