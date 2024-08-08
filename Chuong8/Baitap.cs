using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong8
{
    //bt
    // loi sai la get set khong co ngoac tron va truy cap truc tiep vao truong co private phai thong qua getter setter
    class EmployeeDetails
    {
        private string _empName;
        private int _empId;
        public string EmpName
        {
            get
            {
                return _empName;
            }
            set
            {
                _empName = value;
            }
        }

        public int EmpId
        {
            get
            {
                return _empId; // Trả về giá trị của _empId
            }
            private set
            {
                _empId = value; // Gán giá trị cho _empId, chỉ có thể gán bên trong lớp này
            }
        }
        public void SetId(int val)
        {
            _empId = val;
        }

        


      
    }

    //bt2
    //getter khong tra e value phai tra ve balanceAmount

    class Balance
    {
        private double _balanceAmount;

        public double BalanceAmount
        {
            get
            {
                return _balanceAmount; // Sửa lỗi: trả về '_balanceAmount' thay vì 'value'
            }
            set
            {
                _balanceAmount = value; // Đúng
            }
        }

    }
}

