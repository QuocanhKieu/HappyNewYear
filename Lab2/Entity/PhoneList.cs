namespace Lab2.Entity;

using System;
using System.Diagnostics.Contracts;
using System.Linq;

public class PhoneList : Phone
{
    private List<Contact> _contacts;
    public List<Contact> Contacts
    {
        get { return _contacts; }
        //set { _contacts = value; }
    }
    public PhoneList()
    {
        _contacts = new List<Contact>();
    }

    public override void InsertPhone(string name, string phone)
    {
        var contact = Contacts.Find(contact => contact.Name.Equals( name, StringComparison.OrdinalIgnoreCase));
        if (contact != null )// có contact
        {
            contact.AddNumber(phone);
        }
        else
        {
            Console.WriteLine("here add new contact ");
            _contacts.Add(new Contact(name, new List<string> { phone }));
            Console.WriteLine("here add new contact ");
        }
    }

    public override void RemovePhone(string name)
    {
        var contact = Contacts.Find(contact => contact.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (contact != null)// có contact
        {
            _contacts.Remove(contact);
        }    
            
    }

    public override void UpdatePhone(string name, string newphone)
    {
        var contact = Contacts.Find(contact => contact.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (contact != null)// có contact
        {
            contact.NumberList = new List<string> { newphone };// ko nên
        }    
    }

    public override void SearchPhone(string name)
    {
        var contact = Contacts.Find(contact => contact.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (contact != null)// có contact
        {
            
            Console.WriteLine(contact.ToString());
        }
    }

    public override void Sort()
    {
        _contacts.Sort(new MyCustomComparer());// sử dụng MyCustomComparer Object
        _contacts.Sort((x, y) => x.Name.CompareTo(y.Name));// sử dụng Comparision Object hay chính là 1 Object của Deligate chính là 1 function hay lambda


    }
    public void PrintList()
    {
       foreach(var contact in _contacts)
        {
            Console.WriteLine(contact.ToString());
        }

    }
}
internal class MyCustomComparer : IComparer<Contact>
{
    public int Compare(Contact x, Contact y)
    {
        // Custom comparison logic
        return x.Name.CompareTo(y.Name);
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