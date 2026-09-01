using System;


namespace ConsoleApp1{
    
    public class Week291_1{
        public static void space_counter(){
            Console.WriteLine("Input string to count spaces: ");

            string target_str=Console.ReadLine();

            char[] target_chars=target_str != null?target_str.ToCharArray():new char[0];

            Console.WriteLine("Number of Spaces = {0}",target_chars.Count(c => c == ' '));
        }
    }
}