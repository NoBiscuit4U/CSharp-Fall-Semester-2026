using System.Linq;
using System.Collections.Generic;
using System.Dynamic;

public class Employee{
    private int empId;
    private string empName;
    private int empAge;
    private double empSalary;
    private string empQualification;
    private string empDesignation;

    public Employee(int empId,string empName,int empAge,double empSalary, string empQualification,
                    string empDesignation){
        this.empId=empId;
        this.empName=empName;
        this.empAge=empAge;
        this.empSalary=empSalary;
        this.empQualification=empQualification;
        this.empDesignation=empDesignation;
    }

    public void SetID(int id){
        empId=id;
    }

    public int GetID(){
        return empId;
    }

    public void SetName(string name){
        empName=name;
    }

    public string GetName(){
        return empName;
    }

    public void SetAge(int age){
        empAge=age;
    }

    public int GetAge(){
        return empAge;
    }

    public void SetSalary(double salary){
        empSalary=salary;
    }

    public double GetSalary(){
        return empSalary;
    }

    public void SetQualification(string qual){
        empQualification=qual;
    }

    public string GetQualification(){
        return empQualification;
    }

    public void SetDesignation(string desig){
        empDesignation=desig;
    }

    public string GetDesignation(){
        return empDesignation;
    }
}