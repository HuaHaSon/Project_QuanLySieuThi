using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.EF
{
    public class SanPham
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int MaSP { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(150)]
        public string TenSP { get; set; }
        public string MoTa { get; set; }
        public bool IsDelete { get; set; }
    }
}
