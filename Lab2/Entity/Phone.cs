namespace Lab2.Entity;

public abstract class Phone
{ 
    
    public abstract void InsertPhone(String name, String phone);
    public abstract void RemovePhone(String name);
    public abstract void UpdatePhone(String name, String newphone);
    public abstract void SearchPhone(String name);
    public abstract void Sort();
    
}


// Tạo một lớp có tên Phone chứa những phương thức trừu tượng sau đây:
// abstract void insertPhone(String name, String phone)
//
// abstract void RemovePhone(String name)
//
// abstract void UpdatePhone(String name, String newphone)
//
// abstract void SearchPhone(String name)
//
// abstract void Sort()
//
// Tạo lớp có tên PhoneBook thừa kế lớp Phone:
// Tạo một List tên PhoneList để lưu dữ liệu.
//
//     Phương thức InsertPhone(String name, String phone):
//
// Nếu tên người dùng (name) chưa có sẵn trong PhoneList thì thêm người dùng cùng số điện thoại (phone) tương ứng vào
//
//     Nếu tên người dùng đã có sẵn thì kiểm tra xem số điện thoại (phone) có khác so với số đã có không, nếu chưa thì thêm vào
//
// Phương thức RemovePhone(String name):
// Xóa người dùng cùng các số điện thoại của chủ sở hữu có tên (name) tương ứng khỏi PhoneList.
//
//     Phương thức UpdatePhone(String name, String newphone):
// Thay số điện thoại cũ bằng số điện thoại (newphone) mới.
//
//     Phương thức SearchPhone(String name):
// Tìm kiếm số điện thoại theo tên người dùng.
//
//     Phương thức Sort():
// Sắp xếp các phần tử trong PhoneList theo tên người dùng.