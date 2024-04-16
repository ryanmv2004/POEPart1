using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPart1
{
    internal class Steps //class that holds the attrubutes for each step
    {
        private String steps { get; set; } //private variable

        public Steps(String s) //paramterised contructor
        {
            steps = s;
        }

        public String getSteps() //getter that returns the steps variable
        {
            return steps;
        }

        public void setSteps(String s) //setter that sets the steps variable
        {
            steps = s;
        }

        public String toString() //toString that displays the steps variable
        {
            return getSteps();
        }
    }
}
