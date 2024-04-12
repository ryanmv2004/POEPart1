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
        private double inQuantity { get; set; }
        private String inUnit { get; set; }

        public Ingredients(String iN, double iQ, String iU) 
        {
            inName = iN;
            inQuantity = iQ;
            inUnit = iU;
        }

        public String getinName()
        {
            return inName;
        }
        public void setinName(String s) 
        {
            inName = s;
        }

        public double getinQuantity()
        {
            return inQuantity;
        }
        public void setinQuantity(double q)
        {
            inQuantity *= q;
        }

        public String getinUnit()
        {
            return inUnit;
        }
        public void setinUnit(String u)
        {
            inUnit = u;
        }

        public void undoScale(double amount) 
        {
            inQuantity /= amount;
        }

        public String toString() 
        {
           return getinName() + getinQuantity() + getinUnit();
        }
        

    }
}
