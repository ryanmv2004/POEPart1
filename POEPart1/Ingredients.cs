using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPart1
{
    internal class Ingredients
    {
        private String inName { get; set; }
        private int inQuantity { get; set; }
        private String inUnit { get; set; }

        public Ingredients(String iN, int iQ, String iU) 
        {
            iN = inName;
            iQ = inQuantity;
            iU = inUnit;
        }

        public String getinName()
        {
            return inName;
        }
        public void setinName(String s) 
        {
            inName = s;
        }

        public int getinQuantity()
        {
            return inQuantity;
        }
        public void setinQuantity(int q)
        {
            inQuantity = q;
        }

        public String getinUnit()
        {
            return inUnit;
        }
        public void setinUnit(String u)
        {
            inUnit = u;
        }

        public String toString() 
        {
            return getinName() + "\n" + getinQuantity() + " " + getinUnit();
        }
        

    }
}
