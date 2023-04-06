using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrashJikken
{
    internal class ZeroJozan
    {
        public ZeroJozan() { }

        /// p4を0にしたら0除算発生する
        public int DoJozan(int p1, int p2, int p3, int p4)
        {
            return SubFunc(p1 + p2 + p3, p4);
        }

        private int SubFunc(int bunshi, int bunbo)
        {
            bunshi = bunshi + 2;
            bunshi = bunshi * 4;
            int ret = bunshi / bunbo;
            return ret;


        }

    }
}
