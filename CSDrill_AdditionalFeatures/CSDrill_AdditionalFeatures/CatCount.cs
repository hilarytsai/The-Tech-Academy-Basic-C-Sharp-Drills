using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSDrill_AdditionalFeatures
{
    public class CatCount
    {
        public CatCount(int OwnedCats) : this(OwnedCats, 2)
        {
        }
        public CatCount(int OwnedCats, int DesiredCats)
        {
            this.OwnedCats = 3;
            this.DesiredCats = 7;
        }
        public int OwnedCats { get; set; }
        public int DesiredCats { get; set; }
        public bool Hoarder(int OwnedCats, int DesiredCats)
        {
            if (OwnedCats + DesiredCats > 10)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}