using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeukCore
{
    class LocalFunctions
    {
        int M()
        {
            int y;
            LocalFunction();
            return y;

            /*static*/ void LocalFunction() => y = 0;
        }

        int MStaticLocal()
        {
            int y = 5;
            int x = 7;
            return Add(x, y);

            static int Add(int left, int right) => left + right;
        }
    }
}
