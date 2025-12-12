using System;
using System.Collections; // Cần dòng này để dùng ArrayList [Slide 123]
using System.Windows.Forms;

namespace Full_EX
{
    public partial class EX18 : Form
    {
        public EX18()
        {
            InitializeComponent();
        }

        // [Slide 123] Hàm tạo danh sách bài hát (Data Mockup)
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            Song s = new Song();
            s.Id = 53418;
            s.Name = "Giấc mơ cha pi";
            s.Author = "Trần Tiến";
            lst.Add(s);

            s = new Song();
            s.Id = 52616;
            s.Name = "Đôi mắt pleiku";
            s.Author = "Nguyễn Cường";
            lst.Add(s);

            s = new Song();
            s.Id = 51172;
            s.Name = "Em muốn sống bên anh trọn đời";
            s.Author = "Nguyễn Cường";
            lst.Add(s);

            return lst; //
        }

        // [Slide 124] Load Form: Đổ dữ liệu vào ListBox trái
        private void EX18_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();

            // Gán nguồn dữ liệu
            lbSong.DataSource = lst;          //
            // Chỉ định cột nào sẽ hiện chữ lên màn hình (Cột Tên bài hát)
            lbSong.DisplayMember = "Name";    //
        }

        // [Slide 124] Nút Chọn (>): Lấy Object từ trái, chuyển thành String sang phải
        private void btSelect_Click(object sender, EventArgs e)
        {
            // Ép kiểu item đang chọn về đúng class Song
            Song song = (Song)lbSong.SelectedItem; //

            if (song != null)
            {
                string id = song.Id.ToString();
                string name = song.Name;
                string author = song.Author;

                // Tạo chuỗi kết quả và thêm vào danh sách yêu thích
                // Ví dụ: "53418 - Giấc mơ cha pi - Trần Tiến"
                lbFavorite.Items.Add(id + " - " + name + " - " + author); //
            }
        }
    }
}