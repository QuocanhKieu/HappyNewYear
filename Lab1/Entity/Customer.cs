using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//Xây dựng chương trình quản lý danh sách hoá đơn tiền điện của khách hàng. Thông tin bao gồm các loại khách hàng :

//Khách hàng Việt Nam: mã khách hàng, họ tên, ngày ra hoá đơn (ngày, tháng, năm), đối tượng khách hàng (sinh hoạt, kinh doanh, sản xuất): số lượng(số KW tiêu thụ), đơn giá . Thành tiền được tính như sau:
//Nếu số lượng <= định mức thì: thành tiền = số lượng * đơn giá.
//Ngược lại thì: thành tiền = đơn giá * định mức + số lượng KW vượt định mức * Đơn giá mới
//Khách hàng nước ngoài: mã khách hàng, họ tên, ngày ra hoá đơn (ngày, tháng, năm), quốc tịch, số lượng, đơn giá. Thành tiền được tính = số lượng * đơn giá.
//định mức - đơn giá như sau <50: giá 1000 50-100: giá 1200 100-200: giá 1500

//200: giá 2000 Gía người nước ngoài: 2000
namespace Lab1.Entity
{
    internal class Customer
    {
        //using Property
        
        public string CusId { get; set; }
        public string CusName { get; set; }
        public DateTime RegisterDate { get; set; }
        //public string Cus_type { get; set; } // Vnmese
        //public string Nationality { get; set; }// Foreigner
        private int _qty;
        private float _unitPrice = 0;
        public float _bill = 0;
        public int Qty { 
            get
            {
                return _qty;
            }
            set { 
                if(value > 0) { _qty = value; }
                else { _qty = 0; }
            }
        }
       
        public float UnitPrice { 
            get { 
                return _unitPrice;
            } 
            set {
                _unitPrice = value;
            } 
        }


        public float Bill
        {
            get
            {
                return _unitPrice*Qty;
            }
            set
            {
                _unitPrice = value;
            }
        }


        protected Customer (string cusId, string cusName, DateTime registerDate, int qty)
        {
            CusId = cusId;
            CusName = cusName;
            RegisterDate = registerDate;
            if(qty > 0) { Qty = qty; }
            else { Qty = 0; }
        }
        public virtual void PrintBill()
        {
            Console.WriteLine("{0} {1} {2} {3} {4} {5}", CusId, CusName, DateTime.Now.ToString(), UnitPrice, Qty, Bill);
        }

      
    }
}
