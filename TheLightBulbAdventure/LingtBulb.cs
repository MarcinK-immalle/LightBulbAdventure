using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLightBulbAdventure
{
    class LingtBulb
    {
        private bool brandend = false;

        public void Toggle()
        {
            if (brandend)
            {
                brandend = false;
            }else if (!brandend)
            {
                brandend = true;
            }
        }

        public bool Brandend
        {
            get
            {
                return brandend;
            }
        }
    }


}
