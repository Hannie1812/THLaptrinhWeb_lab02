using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _2280600869_NgoBichHang_Lab02.Models
{
    public class Category
    {
        [DisplayName("Mã thể loại")]
        public int Id { get; set; }
        [Required, StringLength(50), DisplayName("Thể loại")]
        public string Name { get; set; }
    }
}
