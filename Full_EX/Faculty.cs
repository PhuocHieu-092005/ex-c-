using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Full_EX
{
    // [Slide 99] Tạo lớp đối tượng Khoa
    public class Faculty
    {
        public string Id { get; set; }       // Mã khoa
        public string Name { get; set; }     // Tên khoa
        public int Quantity { get; set; }    // Số lượng sinh viên
    }
}