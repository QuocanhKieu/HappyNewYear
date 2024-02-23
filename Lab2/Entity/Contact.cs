namespace Lab2.Entity;

public class Contact
{
    public string Name { get; set; }
    public string Phone { get; set; }

    public List<string> NumberList
    {
        get
        {
            return null;
        }
        set
        {
            
        }
    }
    public Contact(string name, string phone)
    {
        Name = name;
        Phone = phone;
    }
}