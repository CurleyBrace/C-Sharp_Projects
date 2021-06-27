using System;

namespace mathAndOperatorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating Variables that to keep track of the highest paid employee, both the amount and the position in the array
            double highestSalary = 0.0;
            int highestPaidEmployee = 0;

            Console.WriteLine("Anonymous Income Comparison Program"); 

            Console.WriteLine("How many employees would you like to compare: "); //Taking an input to determine the size of the array for employees
            int numEmployee = Convert.ToInt32(Console.ReadLine());

            double[] payRate = new double[numEmployee];         //Creating an array dependant on the number of employees to determine pay rates
            double[] hoursWorked = new double[numEmployee];     //Creating an array dependant on the number of employees to determine hours worked
            double[] annualSal = new double[numEmployee];       //Creating an array dependant on the number of employees to determine annual salary

            Boolean samePay = false;                            //The Boolean Variable to determine whether the employees pay was greater or not
                                                                //Using a variable here because there may be multiple employees with the same pay and this allows us to keep track if there they are the same
            for (int i = 0; i < numEmployee; i++)               //For loop to cycle through each employee
            {
                Console.WriteLine("------Person " + (i + 1) + "------"); //Requesting input for hourly pay for each employee
                Console.WriteLine("Hourly Rate: ");
                payRate[i] = Convert.ToDouble(Console.ReadLine());       //Assigning input as a double for pay rate
                Console.WriteLine("Hours Worked Per Week: ");            //Requesting input for hours worked for each employee
                hoursWorked[i] = Convert.ToDouble(Console.ReadLine());   //Assigning input as a double for pay rate
                annualSal[i] = (hoursWorked[i]*52)*payRate[i];           //Assigning annual salary dependant on hours worked

                if(annualSal[i] > highestSalary)                        //Tracking each salary input to check if it is larger than the previous largest saved salary
                {
                    highestSalary = annualSal[i];                       //If it is larger, replace oldest largest salary
                    highestPaidEmployee = i;                            //If it is larger, keep track of the position in the array where the largest salary is
                    samePay = false;                                    //Set whether or not the pay is the same to false, this determines the output
                } else if (highestSalary == annualSal[i]) {             
                    samePay = true;                                     //If it is the same as previous, to prevent it from being lost between employees, set samepay to true
                }
            }

            for (int i = 0; i < numEmployee; i++)                       //For every employee print out each of their salaries
            {
                Console.WriteLine("Annual Salary of Person " + (i + 1) + " : " + annualSal[i] + ".");
            }

            if (samePay == false)                                       //If there is a highest salary, print out the numbered employee of which it belongs to
            {
                Console.WriteLine("The Highest Paid Employee is Person " + (highestPaidEmployee + 1));
            } else
            {
                Console.WriteLine("Multiple employees were paid the same.");    //If there is no highest and multiple employees were the same, print that
            }
            
            samePay = !samePay;
            Console.WriteLine("Does Person 1 make more money than Person 2? " + samePay); //This is the last part that was requested by the assignment.
                                                                                          //This was included to make sure each requirement for the assignment was included.
        }
    }
}
