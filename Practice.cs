
using System;
using System.Linq;

// simple way of identifying if the int is Armstrong nunber or not 

namespace ArmstrongNumber2 {
    class UsingMethods {
        static void Main(string[] args) {
            Console.Write("Enter a number: ");  
            int num_input = Convert.ToInt32(Console.ReadLine()); 
            int sum_of_power = Powerof(num_input);  
            CompareToInput(num_input, sum_of_power);               
        }

        static int Powerof(int num_input) {
                    
            // convert int to array 
            int[] num_array = [.. num_input.ToString().Select(c => c - '0')];

            // list to store arrays power
            List<int> num_power = []; 

            // raise to the power of num_array.Length 
            double result;
            int final_result;

            foreach (int number in num_array) {
                result = Math.Pow(number, num_array.Length); 
                final_result = (int)result; 
                num_power.Add(final_result);    // add final_result to list 
            }
            
            int sum_of_num = num_power.Sum();
            return sum_of_num;      
        }

        static void CompareToInput(int num_input, int sum_of_power) {

            if (sum_of_power == num_input) {
                Console.WriteLine("Armstrong Number");
            } else {
                Console.WriteLine("Not Armstrong Number");
            }
        }
    }
}
