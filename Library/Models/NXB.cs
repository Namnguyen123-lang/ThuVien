using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class NXB
    {
        // thuộc tính của bảng nxb
        [Key]
        [StringLength(5)]
        private string _MaNXB;
        [Required]
        [StringLength(50)]
        private string _TenNXB;
        // Một nhà xuất bản có nhiều đầu sách
        private IList<DauSach> _DSDauSach = new List<DauSach>();

        public string MaNXB { get => _MaNXB; set => _MaNXB = value; }
        public string TenNXB { get => _TenNXB; set => _TenNXB = value; }
        public IList<DauSach> DSDauSach { get => _DSDauSach; set => _DSDauSach = value; }
    }
}