﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLightBulbAdventure
{
    class Lamp
    {
        private bool brandend = false;

        public void Toggle()
        {
            brandend = !brandend;
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
