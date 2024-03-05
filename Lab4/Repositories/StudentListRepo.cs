using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab4.Repositories
{
    public class StudentListRepo
    {
        // Make the field public to access it from outside
        private List<Student> _studentList;

        public StudentListRepo()
        {
            _studentList = new List<Student>() { new Student() { Age = 18, Name = "Nam", Id = 1, Gender = "male", ChemistryScore = 8, MathScore = 7, PhysicsScore = 7 } };
        }

        // Correct the property name and use a proper getter
        public List<Student> GetStudents()
        {
            return _studentList;
        }
    }
}
