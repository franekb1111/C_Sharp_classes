using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1
{
    class Para<T1, T2>
    {
        private T1 pierwszy;
        private T2 drugi;

        public Para(T1 pierwszy, T2 drugi)
        {
            this.pierwszy = pierwszy;
            this.drugi = drugi;
        }

        public override string ToString()
        {
            return pierwszy.ToString() + "\t" + drugi.ToString();
        }
    }
}


