using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.ReadLine();
            /* block comment7
             */
            /*
                character types: string(""), char('')
                whole number : integere and many others
                floating numbers: decimal(28 - 29), double(15 - 16)
                logical type : boolean
            */
            //always decalre variables within main
            //general grammer (syntax) for  declaring a variable is:
            // access_type data_type variable_name [= asssign a value]  [] means optional
            // special case: within a static class the accesstype is not required
            // by default numerical variable are set to 0

            decimal myWeight;
            decimal myHeight;
            decimal BMI = 0.0m;

            const decimal Imperial_BMI_Value = 703; // you CANNOT change the value of a constant 

            //numerical numbers need to match the variable data type
            // integers hae no decimal places
            // doubles are the default but may be explicitly ne type using a d
            // decimals require to be explicitly typed using a m
            myWeight = 110m;

            myHeight = 1.75m;

            // math calculate the following acceptable rules of arithmetic
            // - assignment
            // () excecute within
            // * / %
            // + -
            BMI = myWeight / (myHeight * myHeight);
            Console.WriteLine("for the weight of {0} and height of {1:0.00}: BMI is {2:0.0}", myWeight, myHeight, BMI);      //{0} is called a place holder
                                                                                                                             //0.0 format the result as only one decimal place
                                                                                                                             // imperial calculation
             myWeight = 242.5m;
             myHeight = 69.0m;
            decimal Imperial_BMI = Imperial_BMI_Value * myWeight / (myHeight * myHeight);
            Console.WriteLine($"For the weight of {myWeight} Lb and height{myHeight} inches , the imperial BMI is {Imperial_BMI:0.0}");

        }

    }
}
