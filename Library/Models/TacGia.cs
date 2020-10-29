using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class TacGia
    {
        // thuộc tính của bảng tác giả
        [Key]
        [StringLength(5)]
        private string _MaTG;
        [StringLength(50)]
        private string _TenTG;
        //một tác giả có nhiều đàu sách
        private IList<DauSach> _DSDauSach = new List<DauSach>();

        public string MaTG { get => _MaTG; set => _MaTG = value; }
        public string TenTG { get => _TenTG; set => _TenTG = value; }
        public IList<DauSach> DauSach { get => _DSDauSach; set => _DSDauSach = value; }
    }
}