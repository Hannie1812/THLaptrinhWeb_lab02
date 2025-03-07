using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _2280600869_NgoBichHang_Lab02.Models
{
    public class Product
    {
        [DisplayName("Mã sản phẩm")]
        public int Id { get; set; }
        [Required(ErrorMessage ="Vui lòng nhập tên sản phẩm!"), StringLength(100), DisplayName("Tên sản phẩm")]
        public string Name { get; set; }
        [Range(0.01, 10000.00), DisplayName("Giá")]
        public decimal Price { get; set; }

        [DisplayName("Mô tả")]
        public string Description { get; set; }

        [DisplayName("Mã loại")]
        public int CategoryId { get; set; }
        [DisplayName("Hình ảnh sản phẩm")]
        public string? ImageUrl { get; set; }

        [DisplayName("Danh sách hình ảnh sản phẩm")]
        public List<string>? ImageUrls { get; set; }
    }
}
