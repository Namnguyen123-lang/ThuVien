using System;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class DocGIa
    {
        [Key]
        [StringLength(5)]
        private string _MaDG;
        [Required]
        private string _HoDG;
        [Required]
        private string _TenDG;
        private DateTime _NgaySinhDG;
        private string _EmailDG;
        private DateTime _NgayDangKi;
        private DateTime _NgayHetHanDK;
    }
}