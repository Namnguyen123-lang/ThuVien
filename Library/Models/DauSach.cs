using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class DauSach
    {
        // thuộc tính của bảng đầu sách
        [Key]
        private string _MaDS;
        private string _MaTL;
        private string _MaTG;
        private string _MaNXB;
        private int _Soluong;
        [Required]
        private string _TenDS;
        // thuộc tính là khóa ngoại của bảng đầu sách
        private TheLoai _TheLoai;

        private IList<TacGia> _DSTacGia = new List<TacGia>();
        private NXB _nxb;
        // thể hiển mối quan hệ giứa sách và đầu sách
        private Sach _Sach;
        // các phương thức set get của class DauSach.cs
        public string MaDS { get => _MaDS; set => _MaDS = value; }
        public string MaTL { get => _MaTL; set => _MaTL = value; }
        public string MaTG { get => _MaTG; set => _MaTG = value; }
        public string MaNXB { get => _MaNXB; set => _MaNXB = value; }
        public string TenDS { get => _TenDS; set => _TenDS = value; }
        public TheLoai TheLoai { get => _TheLoai; set => _TheLoai = value; }
        public IList<TacGia> DSTacGia { get => _DSTacGia; set => _DSTacGia = value; }
        public NXB Nxb { get => _nxb; set => _nxb = value; }
        public Sach Sach { get => _Sach; set => _Sach = value; }
        public int Soluong { get => _Soluong; set => _Soluong = value; }
    }
}