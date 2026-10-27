using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Specialized;

public class LambdaClasswork3{
    // static void Main(string[] args){
    //     Employee emp1=new Employee(002,"John",23,10000,"Bachelors","Programmer");
    //     Employee emp2=new Employee(001,"Bob",33,5000,"Bachelors","AI Designer");
    //     Employee emp3=new Employee(003,"Larry",25,30000,"Bachelors","Artist");
    //     Employee emp4=new Employee(008,"Amanda",26,60000,"Bachelors","Programmer");
    //     Employee emp5=new Employee(005,"Mary",45,80000,"Bachelors","Programmer");
    //     Employee emp6=new Employee(004,"Josiah",18,80000,"Bachelors","Programmer");
    //     Employee emp7=new Employee(007,"Matthew",55,40000,"Masters","Programmer");
    //     Employee emp8=new Employee(006,"Mark",27,30000,"Bachelors","Programmer");
    //     Employee emp9=new Employee(010,"Luke",56,20000,"Bachelors","Programmer");
    //     Employee emp10=new Employee(009,"Paul",78,100000,"Masters","Theology");

    //     List<Employee> employees=new List<Employee>{
    //         emp1,emp2,emp3,emp4,emp5,emp6,emp7,emp8,emp9,emp10
    //     };

    //     Console.WriteLine("Sorted By ID:");
    //     employees.Sort((x,y)=>x.GetID()-y.GetID());
    //     foreach(Employee emp in employees){
    //         Console.WriteLine($"    Employee: {emp.GetName()}, ID: {emp.GetID()}");
    //     }

    //     Console.WriteLine("Employees with Masters:");
    //     foreach(Employee emp in employees.Where(x => x.GetQualification() == "Masters")){
    //         Console.WriteLine($"    Employee: {emp.GetName()}, Degree: {emp.GetQualification()}");
    //     }

    //     double sum=0;
    //     employees.Sum(x=>sum+=x.GetSalary());
    //     Console.WriteLine($"Salary Sum: {sum}");

    //     Console.WriteLine($"Number of Employees Approaching Retirement: {employees.Count(x=>x.GetAge()>=55&&x.GetAge()<58)}");
    // }

}