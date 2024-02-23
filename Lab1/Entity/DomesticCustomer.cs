using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Xây dựng chương trình quản lý danh sách hoá đơn tiền điện của khách hàng. Thông tin bao gồm các loại khách hàng :

//Khách hàng Việt Nam: mã khách hàng, họ tên, ngày ra hoá đơn (ngày, tháng, năm), đối tượng khách hàng (sinh hoạt, kinh doanh, sản xuất): số lượng(số KW tiêu thụ), đơn giá . Thành tiền được tính như sau:
//Nếu số lượng <= định mức thì: thành tiền = số lượng * đơn giá.
//Ngược lại thì: thành tiền = đơn giá * định mức + số lượng KW vượt định mức * Đơn giá mới
//Khách hàng nước ngoài: mã khách hàng, họ tên, ngày ra hoá đơn (ngày, tháng, năm), quốc tịch, số lượng, đơn giá. Thành tiền được tính = số lượng * đơn giá.
//định mức - đơn giá như sau <50: giá 1000 50-100: giá 1200 100-200: giá 1500

//200: giá 2000 Gía người nước ngoài: 2000
namespace Lab1.Entity
{
    internal class DomesticCustomer : Customer
    {
        public CustomerType CusType { set; get; }
        public DomesticCustomer(string cusId, string cusName, DateTime registerDate, int qty, CustomerType cusType) 
            : base( cusId,  cusName, registerDate,  qty) 
        {
            CusType = cusType;
            if (qty < 50)
            {
                UnitPrice = 1000;
            }
            else if (qty < 100)
            {
                UnitPrice = 1200;
            }
            else if (qty < 200)
            {
                UnitPrice = 1500;
            }
            else if (qty >= 200)
            {
                UnitPrice = 2000;
            }
        }
        public override void PrintBill()
        {
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", CusId, CusName, DateTime.Now.ToString(), UnitPrice, Qty, Bill,CusType, "VietNamese");
        }
    }
}
