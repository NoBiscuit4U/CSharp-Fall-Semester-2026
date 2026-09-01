using System;
using System.Linq;
using System.Collections.Generic;


namespace ConsoleApp1{
    
    public class Week291_2{
        public static void sum_indivdual_digits(){
            Console.WriteLine("Enter Number: ");

            char[] num_chars=Console.ReadLine().ToCharArray();

            int final_output=(num_chars!=null)?Enumerable.Range(0,num_chars.Length).Where(i => char.IsDigit(num_chars[i])).Sum(i => int.Parse(num_chars[i].ToString())):0;
        }
    }
}