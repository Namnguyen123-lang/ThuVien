using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class TheLoai
    {
        // thuộc tính của bảng thể loại
        [Key]
        //StringLength là độ dài của biến trong database
        [StringLength(5)]
        private string _MaTL;
        // Required không cho Tên TL trong database = null
        [Required]
        [StringLength(50)]
        private string _TenTL;
        // quan hệ giữa đầu sách và thể loại
        private DauSach _DauSach;

        public string MaTL { get => _MaTL; set => _MaTL = value; }
        public string TenTL { get => _TenTL; set => _TenTL = value; }
        public DauSach DauSach { get => _DauSach; set => _DauSach = value; }
    }
}