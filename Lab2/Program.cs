using Lab2.Entity;
using System;

class Program
{
    static void Main()
    {
        PhoneList myPhoneList = new PhoneList();
     
        myPhoneList.InsertPhone("Kieu Quoc Nam", "123456");
        myPhoneList.InsertPhone("Kim Q", "56878");
        myPhoneList.InsertPhone("Kieu Quoc Anh", "0961056732");
        myPhoneList.InsertPhone("Kieu Quoc anh", "0838112062");
        myPhoneList.InsertPhone("Tran Van Linh", "491");
        //myPhoneList.RemovePhone("Kieu Quoc nam");
        myPhoneList.UpdatePhone("kieu quoc anh", "123");
        //myPhoneList.SearchPhone("Kim q");
        myPhoneList.Sort();

        myPhoneList.PrintList();
    }
}