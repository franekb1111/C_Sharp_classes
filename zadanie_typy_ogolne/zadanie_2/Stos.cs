using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
     class Stos<T>
        {
            private List<T> elementy = new List<T>();

            public void Push(T element)
            {
                elementy.Add(element);
            }

            public T? Pop()
            {
                if (elementy.Count == 0)
                {
                    Console.WriteLine("Stos jest pusty.");
                    return default;
                }
                T element = elementy[elementy.Count - 1];
                elementy.RemoveAt(elementy.Count - 1);
                return element;
            }

            public void Show()
            {
                if (elementy.Count == 0)
                {
                    Console.WriteLine("Stos jest pusty.");
                    return;
                }
                foreach (T element in elementy)
                {
                    Console.WriteLine(element);
                }
            }

        }
}
