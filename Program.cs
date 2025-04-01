using System;
using System.Linq;

namespace ArmstrongNumber2 {
    class Program {
        static void Main(string[] args) {
            // string 
            Console.WriteLine("Enter a number: ");  

            //  convert str to int, for checking input 
            int num = Convert.ToInt32(Console.ReadLine()); 

            // int to array 
            int[] num_array = [.. num.ToString().Select(c => c - '0')];
            // int[] num_array = num.ToString().Select(c => c - '0').ToArray();


            // // size of num 
            // int num_length = num.ToString().Length; 

            // size of array
            // int[] num_arr = new int[num_array.Length];
            
            /* initialist list to store arrays product s*/ 
            List<int> num_power = []; 

            // double result = 0;
            // int final_result = 0;

            foreach (int number in num_array) {
                double result = Math.Pow(number, num_array.Length); 
                int final_result = (int)result;
                // final_result = (int)result;
            
                num_power.Add(final_result); 
            }

            // final_result = (int)result;
            // num_power.Add(final_result); 
            
            int sum_of_num = num_power.Sum();
            
            if (sum_of_num == num) {
                Console.WriteLine("Armstrong Number");
            } else {
                Console.WriteLine("Not Armstrong Number");
            }
            
            Console.WriteLine("Number sum: " + sum_of_num);
            // Console.WriteLine(num_length);
            
            
        }
    }
}


// add input validation 
/*

if input is  int 
    execute 
else 
    prompt user for input again
*/