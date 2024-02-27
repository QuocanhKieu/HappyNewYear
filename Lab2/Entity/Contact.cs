using System.Xml.Linq;
using System;
using System.Linq; // Include this line for LINQ
namespace Lab2.Entity;

public class Contact
{
    public string Name { get; set; }

    private List<string> _numberList;

    public List<string> NumberList
    {
        get
        {
            return _numberList;
        }
        set
        {
            _numberList = value;
        }
    }
    public Contact(string name, List<string>phones)
    {
        Name = name;
        _numberList = new List<string>();
        _numberList = phones;

    }
    public void AddNumber(string phone)
    {
        if(!NumberList.Contains(phone))
        {
            _numberList.Add(phone);
        }
        else Console.WriteLine("Duplicate Number");
    }
    public override string ToString()
    {

        string content =   Name + $" has {NumberList.Count} numbers Which is:\n";

        foreach(string item in NumberList) {
            content += item ;
            content += "\n" ;
        }
        return content ;
    }
}