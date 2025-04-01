using System;
using System.Linq;

// simple way of identifying if the int is Armstrong nunber or not 

namespace ArmstrongNumber2 {
    class UsingFunction {
        static void Main(string[] args) {

            Console.WriteLine("Enter a number: ");  
            
            //  convert str to int, for checking input 
            int num = Convert.ToInt32(Console.ReadLine()); 

            // convert int to array 
            int[] num_array = [.. num.ToString().Select(c => c - '0')];

            // list to store arrays power
            List<int> num_power = []; 

            // raise to the power of num_array.Length 
            double result;
            int final_result;

            foreach (int number in num_array) {
                result = Math.Pow(number, num_array.Length); 
                final_result = (int)result; // convert double result to int
            
                num_power.Add(final_result);    // add final_result to list 
            }
            
            int sum_of_num = num_power.Sum();
            
            if (sum_of_num == num) {
                Console.WriteLine("Armstrong Number");
            } else {
                Console.WriteLine("Not Armstrong Number");
            }
            
            // Console.WriteLine("Number sum: " + sum_of_num);            
        }
    }
}


// add input validation 
/*

create function for userinput 
create function for printing 
create function for identifying armstrong number 

if input is  int 
    execute 
else 
    prompt user for input again


static void Main(string[] args) {
    Console.WriteLine("Enter a number: ");  
}

method declaration 
    syntax:
        modifier returntype methodName() {
        }


static void raiseNumber() {
}



// call functions in main method
a. calling methods
    methodName();

b. Variable scoping 
    * global variables
        - var declared w/in a class
        - can be accessed w/in the whole class 
        - static => all GV need static word sa unahan 
        - discourage to use, use LV always for security 

    * local variables
        - var declared inside method, condition, loops, and any other block of code 
        - can only be accessed w/in that block of code 

    
    note:
        * LV is priority, then check if GV an exist 


c. Parameters / Arguments
    * value needs to be passed sa methods 
    * acts as a LV inside method/function 

    methods w/ parameters
        syntax:
            modifiers returntype methodName(parameters) {
            }
        
        example:
            static void say(string word) {
                Console.WriteLine(word);
            }

d. RETURN Keyword
    * return value from the method, babalik kung san sya tinawag 

e. RETURN type 
    * type ng value na irereturn 
    * retrun types are the same as datatypes 
    ex.:
        void returns Nothing 
        int => integer

    methiods w/ return
    syntax:
        modifiers returntype methodName(arguments) {
            // do anything here
            return value; 
        }


*/


