using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XongAgile
{
    internal class serviceSV
    {
        // lấy các account từ file ra, phương thức này trả về 1 lsst account
        public static List<accountSV> GetallAcounts()
        {
            List<accountSV> accounts = new List<accountSV>(); // khởi tạo list để chứa
            // lấy data từ file account.txt đã được tạo ra 1 mảng string, mỗi dòng là 1 account
            string[] datas = File.ReadAllLines("danhchosv.txt");
            foreach (string data in datas) // xử lý mỗi dòng lấy được thành một account
            {
                if (!string.IsNullOrEmpty(data)) // nếu chuỗi không rỗng
                {
                    //cắt chuỗi ra thành từng thuộc tính riêng biệt
                    string[] thuoctinhs = data.Split('|'); // cắt theo gạch |
                    // tạo đối tượng từ thuộc tính và thu được
                    string name = thuoctinhs[0];
                    string email = thuoctinhs[1];
                    string phone = thuoctinhs[2];
                    string taikhoan = thuoctinhs[3];
                    string matkau = thuoctinhs[4];
                    string xacmkk = thuoctinhs[5];
                    accountSV account = new accountSV(name, email, phone, taikhoan, matkau, xacmkk);
                    accounts.Add(account); // thêm account vừa lấy được vào list để trả về
                }
            }
            return accounts; // trả về danh sách
        }
        // kiểm tra account nhập vào từ form đăng nhập có nằm trong danh sách account ko
        public static accountSV CheckLogin(string username, string password)
        {
            var allAccounts = GetallAcounts(); // lấy danh sách từ file txt 
            var check = allAccounts.FirstOrDefault(p => p.Tentaikhoan == username && p.Matkau == password); //linq vs lamba expression
            var check2 = from accountSV in allAccounts
                         where accountSV.Tentaikhoan == username && accountSV.Matkau == password
                         select accountSV; // thuần linq
            return check; //trả về check, nếu check không được tìm thấy thì nó vẫn là null
        }
        public static accountSV CheckMatKhau(string password)
        {
            var allAccounts = GetallAcounts();
            var check = allAccounts.FirstOrDefault(p => p.Matkau == password);
            return check;
        }
        public static accountSV CheckMail(string mail)
        {
            var allAccounts = GetallAcounts();
            var check = allAccounts.FirstOrDefault(p => p.Email == mail);
            return check;
        }
    }
}
