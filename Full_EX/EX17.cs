using System;
using System.Windows.Forms;

namespace Full_EX
{
    public partial class EX17 : Form
    {
        public EX17()
        {
            InitializeComponent();
        }

        // [Slide 118] Chuyển 1 bài (>)
        private void btSelect_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có bài nào đang được chọn không
            if (lbSong.SelectedItem != null)
            {
                string song = lbSong.SelectedItem.ToString(); // Lấy tên bài hát
                lbFavorite.Items.Add(song);                   // Thêm vào bên phải
                lbSong.Items.RemoveAt(lbSong.SelectedIndex);  // Xóa khỏi bên trái
            }
        }

        // [Slide 119] Chuyển TẤT CẢ bài (>>)
        private void btSelectAll_Click(object sender, EventArgs e)
        {
            // Duyệt từ dưới lên trên để xóa không bị lỗi Index
            for (int i = 0; i < lbSong.Items.Count; i++) //
            {
                string song = lbSong.Items[i].ToString();
                lbFavorite.Items.Add(song);
            }
            // Sau khi copy hết thì xóa sạch bên trái
            lbSong.Items.Clear();
        }

        // Chuyển 1 bài ngược lại (<) - Logic tương tự btSelect
        private void btDeselect_Click(object sender, EventArgs e)
        {
            if (lbFavorite.SelectedItem != null)
            {
                string song = lbFavorite.SelectedItem.ToString();
                lbSong.Items.Add(song);
                lbFavorite.Items.RemoveAt(lbFavorite.SelectedIndex);
            }
        }

        // Chuyển TẤT CẢ bài ngược lại (<<) - Logic tương tự btSelectAll
        private void btDeselectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbFavorite.Items.Count; i++)
            {
                string song = lbFavorite.Items[i].ToString();
                lbSong.Items.Add(song);
            }
            lbFavorite.Items.Clear();
        }

        // [Slide 118, 119] Xử lý Double Click bên Trái
        private void lbSong_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbSong.IndexFromPoint(e.Location); // Lấy vị trí chuột
            if (index != System.Windows.Forms.ListBox.NoMatches) // Nếu chuột đúng vào 1 bài hát
            {
                string song = lbSong.Items[index].ToString();
                lbFavorite.Items.Add(song);                   //
                lbSong.Items.RemoveAt(index);                 //
            }
        }

        // Xử lý Double Click bên Phải (Tự thêm cho hoàn thiện)
        private void lbFavorite_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbFavorite.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string song = lbFavorite.Items[index].ToString();
                lbSong.Items.Add(song);
                lbFavorite.Items.RemoveAt(index);
            }
        }
    }
}