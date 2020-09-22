using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAplication20200918_2
{
    class UCase
    {
        public int coountCapital(string source)
        {
            int cnt = 0;
            foreach (char c in source)
            {
                if(c>='A'&&c<='Z')
                {
                    cnt++;
                }
            }
            return cnt;
        }
    }
}
