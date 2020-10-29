using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Sach
    {
        [Key]
        [StringLength(5)]
        private string _MaSach;
        [Required]
        [StringLength(5)]
        private string _MaDS;
        private string _TinhTrangSach;
        private string _Vitri;
        private DauSach _DauSach;
        public string MaSach { get => _MaSach; set => _MaSach = value; }
        public string MaDS { get => _MaDS; set => _MaDS = value; }
        public string TinhTrangSach { get => _TinhTrangSach; set => _TinhTrangSach = value; }
        public string Vitri { get => _Vitri; set => _Vitri = value; }
        public DauSach DauSach { get => _DauSach; set => _DauSach = value; }
    }
}