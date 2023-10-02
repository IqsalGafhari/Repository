using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingManagementApp.Models
{//nama tabel room
    [Table("tb_m_rooms")]
    public class Room : BaseEntity
    {//nama kolom dan tipe data
        [Required, Column("name", TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        [Required, Column("floor")]
        public int Floor { get; set; }
        [Required, Column("capacity")]
        public int Capacity { get; set; }
        public ICollection<Booking>? Bookings { get; set; }
    }
}
