using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1{

    public class Week398_1{
        private static Dictionary<int,string> students=new Dictionary<int, string>();

        private enum Marks{
            Hepsiba=100,
            Joe=60,
            John=90,
            Jim=75
        }

        private static string get_grade_letter(int marks){
            string returnVal="";
            if(marks>=98){
                returnVal="A+";
            }else if(marks>=93){
                returnVal="A";
            }else if(marks>=90){
                returnVal="A-";
            }else if (marks>=88){
                returnVal="B+";
            }else if(marks>=83){
                returnVal="B";
            }else if(marks>=80){
                returnVal="B-";
            }else if (marks>=78){
                returnVal="C+";
            }else if(marks>=73){
                returnVal="C";
            }else if (marks>=70){
                returnVal="C+";
            }else if (marks>=68){
                returnVal="D+";
            }else if(marks>=63){
                returnVal="D";
            }else if (marks>=60){
                returnVal="D-";
            }else{
                returnVal="F";
            }
              
            return returnVal;
        }

        public static void marks_to_grade(){
            students.Add(1,"Hepsiba");
            students.Add(2,"Joe");
            students.Add(3,"John");
            students.Add(4,"Jim");


            foreach(int id in students.Keys){
                switch (id){
                    case 1:
                        Console.WriteLine("ID: {0}, Name: {1}, Grade Letter: {2}",id,Marks.Hepsiba.ToString(),get_grade_letter((int) Marks.Hepsiba));
                    break;
                    case 2:
                        Console.WriteLine("ID: {0}, Name: {1}, Grade Letter: {2}",id,Marks.Joe.ToString(),get_grade_letter((int) Marks.Joe));
                    break;
                    case 3:
                        Console.WriteLine("ID: {0}, Name: {1}, Grade Letter: {2}",id,Marks.John.ToString(),get_grade_letter((int) Marks.John));
                    break;
                    case 4:
                        Console.WriteLine("ID: {0}, Name: {1}, Grade Letter: {2}",id,Marks.Jim.ToString(),get_grade_letter((int) Marks.Jim));
                    break;
                }
            }
        }

    }
    
}