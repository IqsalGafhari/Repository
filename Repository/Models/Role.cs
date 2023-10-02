using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingManagementApp.Models
{//nama tabel role
    [Table("tb_m_roles")]
    public class Role : BaseEntity
    {//nama kolom dan tipe data
        [Required, Column("name", TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        public ICollection<AccountRole>? AccountRoles { get; set;}
    }
}
