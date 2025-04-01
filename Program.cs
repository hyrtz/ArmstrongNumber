using System;
using System.Linq;

// simple way of identifying if the int is Armstrong nunber or not 

namespace ArmstrongNumber2 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter a number: ");  

            //  convert str to int, for checking input 
            int num = Convert.ToInt32(Console.ReadLine()); 

            // convert int to array 
            int[] num_array = [.. num.ToString().Select(c => c - '0')];

            // list to store arrays power
            List<int> num_power = []; 

            // raise to the power of num_array.Length 
            foreach (int number in num_array) {
                double result = Math.Pow(number, num_array.Length); 
                int final_result = (int)result; // convert double result to int
            
                num_power.Add(final_result);    // add final_result to list 
            }
            
            int sum_of_num = num_power.Sum();
            

            // comparing sum of power and input itself
            if (sum_of_num == num) {
                Console.WriteLine("Armstrong Number");
            } else {
                Console.WriteLine("Not Armstrong Number");
            }       
        }
    }
}
