using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingManagementApp.Models
{//nama tabel universitas
    [Table("tb_m_university")]
    public class University : BaseEntity
    {//nama kolom dan tipe data
        [Required, Column("code", TypeName = "nvarchar(50)")]
        public string Code { get; set; }
        [Required, Column("name", TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        public ICollection<Education>? Educations { get; set; }
    }
}
