using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.EF
{
    public class NhaCungCap
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int MaNCC { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(200)]
        public string TenNCC { get; set; }
        public string DiaChi { get; set; }
        public bool IsDelete { get; set; }
    }
}
