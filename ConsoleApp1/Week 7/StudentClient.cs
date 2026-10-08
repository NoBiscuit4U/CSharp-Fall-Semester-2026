using System;
using System.Runtime.InteropServices;
using Microsoft.Extensions.DependencyInjection;

namespace DepInjTest{
    class StudentClient{
        private readonly IStudentRepository _IStudentRepository;

        public StudentClient(IStudentRepository StudentRepositoryService){
            _IStudentRepository=StudentRepositoryService;
        }

        public void Test(){
            Console.WriteLine("All Students:");

            foreach(Student student in _IStudentRepository.GetAllStudents()){
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Major: {student.Major}");
            }

            Console.WriteLine("Search For Student with ID = 1");
            Console.WriteLine($"Found: {_IStudentRepository.GetStudentById(1).Name}");

        }
    }
}