using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
    public double MathScore { get; set; }
    public double PhysicsScore { get; set; }
    public double ChemistryScore { get; set; }

    public double AverageScore => (MathScore + PhysicsScore + ChemistryScore) / 3;

    public string AcademicPerformance
    {
        get
        {
            if (AverageScore >= 8)
                return "Giỏi";
            else if (AverageScore >= 6.5)
                return "Khá";
            else if (AverageScore >= 5)
                return "Trung Bình";
            else
                return "Yếu";
        }
    }
}

class Program
{
    private static List<Student> students = new List<Student>();

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("===== Menu =====");
            Console.WriteLine("1. Them sinh vien");
            Console.WriteLine("2. Cap nhat thong tin sinh vien boi ID");
            Console.WriteLine("3. Xoa sinh vien boi ID");
            Console.WriteLine("4. Tim kiem sinh vien theo ten");
            Console.WriteLine("5. Sap xep sinh vien theo diem trung binh (GPA)");
            Console.WriteLine("6. Sap xep sinh vien theo ten");
            Console.WriteLine("7. Sap xep sinh vien theo ID");
            Console.WriteLine("8. Hien thi danh sach sinh vien");
            Console.WriteLine("0. Thoat");
            Console.Write("Chon: ");


            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        UpdateStudent();
                        break;
                    case 3:
                        DeleteStudent();
                        break;
                    case 4:
                        SearchStudentByName();
                        break;
                    case 5:
                        SortByGPA();
                        break;
                    case 6:
                        SortByName();
                        break;
                    case 7:
                        SortById();
                        break;
                    case 8:
                        DisplayStudents();
                        break;
                    case 0:
                        Console.WriteLine("Kết thúc chương trình.");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập một số.");
            }

        } while (choice != 0);
    }

    private static void AddStudent()
    {
        Student student = new Student();

        Console.Write("Nhập ID: ");
        student.Id = int.Parse(Console.ReadLine());

        Console.Write("Nhập Tên: ");
        student.Name = Console.ReadLine();

        Console.Write("Nhập Giới tính: ");
        student.Gender = Console.ReadLine();

        Console.Write("Nhập Tuổi: ");
        student.Age = int.Parse(Console.ReadLine());

        Console.Write("Nhập Điểm Toán: ");
        student.MathScore = double.Parse(Console.ReadLine());

        Console.Write("Nhập Điểm Lý: ");
        student.PhysicsScore = double.Parse(Console.ReadLine());

        Console.Write("Nhập Điểm Hóa: ");
        student.ChemistryScore = double.Parse(Console.ReadLine());

        students.Add(student);
        Console.WriteLine("Thêm sinh viên thành công.");
    }

    private static void UpdateStudent()
    {
        Console.Write("Nhập ID của sinh viên cần cập nhật: ");
        int id = int.Parse(Console.ReadLine());

        Student student = students.Find(s => s.Id == id);

        if (student != null)
        {
            Console.Write("Nhập Tên mới: ");
            student.Name = Console.ReadLine();

            Console.Write("Nhập Giới tính mới: ");
            student.Gender = Console.ReadLine();

            Console.Write("Nhập Tuổi mới: ");
            student.Age = int.Parse(Console.ReadLine());

            Console.Write("Nhập Điểm Toán mới: ");
            student.MathScore = double.Parse(Console.ReadLine());

            Console.Write("Nhập Điểm Lý mới: ");
            student.PhysicsScore = double.Parse(Console.ReadLine());

            Console.Write("Nhập Điểm Hóa mới: ");
            student.ChemistryScore = double.Parse(Console.ReadLine());

            Console.WriteLine("Cập nhật thông tin sinh viên thành công.");
        }
        else
        {
            Console.WriteLine("Không tìm thấy sinh viên có ID là {0}.", id);
        }
    }

    private static void DeleteStudent()
    {
        Console.Write("Nhập ID của sinh viên cần xóa: ");
        int id = int.Parse(Console.ReadLine());

        Student student = students.Find(s => s.Id == id);

        if (student != null)
        {
            students.Remove(student);
        }
    }
    private static void SearchStudentByName()
    {
        Console.Write("Nhập Tên sinh viên cần tìm: ");
        string name = Console.ReadLine();

        List<Student> searchResults = students.Where(s => s.Name.Contains(name)).ToList();

        if (searchResults.Count > 0)
        {
            Console.WriteLine("Kết quả tìm kiếm:");
            DisplayStudentList(searchResults);
        }
        else
        {
            Console.WriteLine("Không tìm thấy sinh viên có tên chứa '{0}'.", name);
        }
    }

    private static void SortByGPA()
    {
        List<Student> sortedStudents = students.OrderByDescending(s => s.AverageScore).ToList();
        DisplayStudentList(sortedStudents, "Danh sách sinh viên được sắp xếp theo điểm trung bình (GPA):");
    }

    private static void SortByName()
    {
        List<Student> sortedStudents = students.OrderBy(s => s.Name).ToList();
        DisplayStudentList(sortedStudents, "Danh sách sinh viên được sắp xếp theo tên:");
    }

    private static void SortById()
    {
        List<Student> sortedStudents = students.OrderBy(s => s.Id).ToList();
        DisplayStudentList(sortedStudents, "Danh sách sinh viên được sắp xếp theo ID:");
    }

    private static void DisplayStudents()
    {
        DisplayStudentList(students, "Danh sách sinh viên:");
    }

    private static void DisplayStudentList(List<Student> studentList, string message = "")
    {
        if (!string.IsNullOrEmpty(message))
        {
            Console.WriteLine(message);
        }

        foreach (var student in studentList)
        {
            Console.WriteLine($"ID: {student.Id}, Tên: {student.Name}, Tuổi: {student.Age}, Điểm TB: {student.AverageScore}, Học lực: {student.AcademicPerformance}");
        }
    }

    // Add the rest of your methods and logic as needed


}

