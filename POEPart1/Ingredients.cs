using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPart1
{
    public class Ingredients //Class that holds the ingredients attributes
    {
        private String inName { get; set; }
        private double inQuantity { get; set; }
        private String inUnit { get; set; } 
        public double calories { get; set; }
        public string foodGroup { get; set; } //declared private variables of the name of the ingredient, its quantity, unit of measurement, calories and food group.

        public Ingredients(String iN, double iQ, String iU, double c, String fG) //Parameterised constructor
        {
            inName = iN;
            inQuantity = iQ;
            inUnit = iU;
            calories = c;
            foodGroup = fG;
        }

        public String getinName() //Getter for inName
        {
            return inName;
        }
        public void setinName(String s) //Setter for inName
        {
            inName = s;
        }

        public double getinQuantity() //Getter for inQuantity
        {
            return inQuantity;
        }
        public void setinQuantity(double q) //Setter for inQuantity that serves to scale it
        {
            inQuantity = q;
        }

        public String getinUnit() //Getter for inUnit
        {
            return inUnit;
        }
        public void setinUnit(String u) //Setter for the inUnit variable
        {
            inUnit = u;
        }

        public double getCalories() //Getter for inUnit
        {
            return calories;
        }
        public void setCalories(double c) //Setter for the calories variable
        {
            calories = c;
        }

        public String getFoodGroup() //Getter for the foodGroup variable
        {
            return foodGroup;
        }

        public void setFoodGroup(String f) //Setter for the foodGroup variable
        {
            foodGroup = f;
        }

        public void undoScale(double amount)  //Method that divides the quantity by an amount
        {
            inQuantity /= amount;
        }

        public String toString() //Basic toString method that prints out all the Attributes of the class
        {
           return getinName() + "\t" +  getinQuantity() + getinUnit() + "\n" + getFoodGroup() + "\t" + getCalories();
        }

    }
}
