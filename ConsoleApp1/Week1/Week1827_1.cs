using System;

namespace ConsoleApp1{
    class Week1827_1{
        public void test(){
            Console.WriteLine("Enter the number of students");

            int size=int.Parse(Console.ReadLine());

            double[] studentMarks= new double[size];

            for(int i=0;i<size;i++){
                Console.WriteLine("Enter the marks of student {0}",i+1);
                studentMarks[i]=double.Parse(Console.ReadLine());
            }

            Console.WriteLine("The Total number of students are: {0}",size);
            Console.WriteLine("The Total Marks are: {0}", studentMarks.Sum());
            Console.WriteLine("The Highest Marks are: {0}", studentMarks.Max());
            Console.WriteLine("The Lowest Marks are: {0}", studentMarks.Min());
            Console.WriteLine("The Average Marks are: {0}", studentMarks.Average());

            for(int i=0;i<size;i++){Console.WriteLine("The Marks of student {0} are: {1}",i+1,studentMarks[i]);}
        }
    }
}
