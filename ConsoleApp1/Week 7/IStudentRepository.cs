using System.Collections.Generic;

namespace DepInjTest{
    public interface IStudentRepository{
        void AddStudent(Student student);
        List<Student> GetAllStudents();
        Student GetStudentById(int id);
    }
}