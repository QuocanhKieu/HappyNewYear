namespace Lab2.Entity;

public class PhoneList : Phone
{
    private List<Contact> _contacts;
    public PhoneList()
    {
        _contacts = new List<Contact>();
    }

    public override void InsertPhone(string name, string phone)
    {
        int isExist = 0;
        foreach (Contact contact in _contacts)
        {
            if (contact.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                isExist = 1;
                if (!contact.Phone.Equals(phone))
                {
                    _contacts.Add(new Contact(name,phone));
                }
            }
        }
        if (isExist == 0)
        {
            _contacts.Add(new Contact(name,phone));
        }
        
    }

    public override void RemovePhone(string name)
    {
        foreach (Contact contact in _contacts)
        {
            if (contact.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                _contacts.Remove(contact);
            }
        }
        _contacts.Where()
    }

    public override void UpdatePhone(string name, string newphone)
    {
        throw new NotImplementedException();
    }

    public override void SearchPhone(string name)
    {
        throw new NotImplementedException();
    }

    public override void Sort()
    {
        throw new NotImplementedException();
    }
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