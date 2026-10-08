using System.Data.Common;

namespace DepInjTest{

    delegate Student GenStudent(int id, string name, string major);
    class StudentRepositoryService:IStudentRepository{
        List<Student> Students=[];

        private GenStudent genStudent;

        public StudentRepositoryService(){
            genStudent=(int id,string name,string major)=>{
                Student student=new Student();
                student.Id=id;
                student.Name=name;
                student.Major=major;
                return student;
            };

            Students.Add(genStudent(1,"Alice","Computer Science"));
            Students.Add(genStudent(2,"Bob","Computer Science"));
        }

        public List<Student> GetAllStudents(){
            return Students;
        }

        public void AddStudent(Student student){
            Students.Add(student);
        }

        public Student GetStudentById(int id){
            foreach(Student student in Students){
                if(student.Id == id){
                    return student;
                }else{
                    continue;
                }
            }

            return null;
        }
    }
}