using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LvhBaiDanhGiaGiuaKy.Models
{
    public class LvhProduct
    {
        [Key]
        public int LvhId { get; set; }
        [DisplayName("LVH:Họ và Tên")]
        [Required(ErrorMessage = "LVH: Chưa nhập dữ liệu")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "LVH:Họ tên chứa tối thiểu 5 kí tự hoặc tối đa 100")]
        [RegularExpression(@"^[A-Za-z ]{5,100}$", ErrorMessage = "Họ tên chỉ chứa ký tự viết hoa và khoảng trắng")]
        public string LvhFullName { get; set; }
        [DisplayName("LVH:Ảnh")]
        [Required(ErrorMessage = "LVH: Chưa nhập dữ liệu")]
        [DataType(DataType.ImageUrl, ErrorMessage = "Đth:Đây không phải là URL hình ảnh hợp lệ")]
        public string LvhImage { get; set; }
        [DisplayName("LVH:Số lượng")]
        [Required(ErrorMessage = "LVH: Chưa nhập dữ liệu")]
        [Range(1, 100, ErrorMessage = "LVH:Số lượng phải là số trong khoảng 1-100.")]
        public int LvhQuantity { get; set; }
        [DisplayName("LVH:Giá")]
        [Range(0.01, double.MaxValue, ErrorMessage = "LVH:Giá phải là số lớn hơn 0.")]
        [Required(ErrorMessage = "LVH: Chưa nhập dữ liệu")]

        public decimal LvhPrice { get; set; }
        [DisplayName("LVH:Trạng thái")]
        
        
        public bool LvhIsActive { get; set; } = true;
    }
}