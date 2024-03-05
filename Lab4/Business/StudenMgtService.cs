//using Lab4.Entity;
//using Lab4.Repositories;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lab4.Services
//{
//    public class StudenMgtService
//    {
//        private StudentListRepo _myStudentListRepo = new StudentListRepo();

//        public StudentListRepo MyStudentListRepo
//        {
//            //set { _myStudentListRepo = value; }
//            get { return _myStudentListRepo; }
//        }
//        public StudenMgtService()
//        {
//            //_myStudentListRepo = new StudentListRepo();
//        }

//        private void AddStudent()
//        {
//            Student student = new Student();

//            Console.Write("Nhập ID: ");
//            student.Id = int.Parse(Console.ReadLine());

//            Console.Write("Nhập Tên: ");
//            student.Name = Console.ReadLine();

//            Console.Write("Nhập Giới tính: ");
//            student.Gender = Console.ReadLine();

//            Console.Write("Nhập Tuổi: ");
//            student.Age = int.Parse(Console.ReadLine());

//            Console.Write("Nhập Điểm Toán: ");
//            student.MathScore = double.Parse(Console.ReadLine());

//            Console.Write("Nhập Điểm Lý: ");
//            student.PhysicsScore = double.Parse(Console.ReadLine());

//            Console.Write("Nhập Điểm Hóa: ");
//            student.ChemistryScore = double.Parse(Console.ReadLine());

//            _myStudentListRepo.GetStudents().Add(student);
//            Console.WriteLine("Thêm sinh viên thành công.");
//        }

//        private void UpdateStudent()
//        {
//            Console.Write("Nhập ID của sinh viên cần cập nhật: ");
//            int id = int.Parse(Console.ReadLine());

//            Student student = _myStudentListRepo.GetStudents().Find(s => s.Id == id);

//            if (student != null)
//            {
//                Console.Write("Nhập Tên mới: ");
//                student.Name = Console.ReadLine();

//                Console.Write("Nhập Giới tính mới: ");
//                student.Gender = Console.ReadLine();

//                Console.Write("Nhập Tuổi mới: ");
//                student.Age = int.Parse(Console.ReadLine());

//                Console.Write("Nhập Điểm Toán mới: ");
//                student.MathScore = double.Parse(Console.ReadLine());

//                Console.Write("Nhập Điểm Lý mới: ");
//                student.PhysicsScore = double.Parse(Console.ReadLine());

//                Console.Write("Nhập Điểm Hóa mới: ");
//                student.ChemistryScore = double.Parse(Console.ReadLine());

//                Console.WriteLine("Cập nhật thông tin sinh viên thành công.");
//            }
//            else
//            {
//                Console.WriteLine("Không tìm thấy sinh viên có ID là {0}.", id);
//            }
//        }

//        private  void DeleteStudent()
//        {
//            Console.Write("Nhập ID của sinh viên cần xóa: ");
//            int id = int.Parse(Console.ReadLine());

//            Student student = students.Find(s => s.Id == id);

//            if (student != null)
//            {
//                students.Remove(student);
//        }
//}
//    }
