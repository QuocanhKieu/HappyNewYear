using Lab1.Entity;
internal class Program
{
    private static void Main()
    {
        List<Customer> list = new List<Customer>() {
                new DomesticCustomer("cus0", "Kieu Quoc Anh", DateTime.Now, 37, CustomerType.SinhHoat),
                new DomesticCustomer("cus1", "Minh Trong", DateTime.Now, 75, CustomerType.KinhDoanh),
                new ForeignCustomer("cus2", "Luis Tran", DateTime.Now, 75, "England"),
                new ForeignCustomer("cus3", "Leandro Otavio", DateTime.Now, 205, "Italy"),
                new DomesticCustomer("cus4", "Kieu Anh", DateTime.Now, 125, CustomerType.KinhDoanh),
                new DomesticCustomer("cus5", "Kieu Quoc", DateTime.Now, 205, CustomerType.SanXuat),
            };
        foreach (Customer item in list)
        {
            item.PrintBill();
        }

    }
}