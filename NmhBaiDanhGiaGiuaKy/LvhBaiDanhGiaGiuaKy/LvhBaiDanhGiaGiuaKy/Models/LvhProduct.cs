using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LvhBaiDanhGiaGiuaKy.Models
{
    public class NmhProduct
    {
        [Key]
        public int NmhId { get; set; }
        [DisplayName("NMH:Họ và Tên")]
        [Required(ErrorMessage = "NMH: Chưa nhập dữ liệu")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "NMH:Họ tên chứa tối thiểu 5 kí tự hoặc tối đa 100")]
        [RegularExpression(@"^[A-Za-z ]{5,100}$", ErrorMessage = "Họ tên chỉ chứa ký tự viết hoa và khoảng trắng")]
        public string NmhFullName { get; set; }
        [DisplayName("NMH:Ảnh")]
        [Required(ErrorMessage = "NMH: Chưa nhập dữ liệu")]
        [DataType(DataType.ImageUrl, ErrorMessage = "Đth:Đây không phải là URL hình ảnh hợp lệ")]
        public string NmhImage { get; set; }
        [DisplayName("NMH:Số lượng")]
        [Required(ErrorMessage = "NMH: Chưa nhập dữ liệu")]
        [Range(1, 100, ErrorMessage = "NMH:Số lượng phải là số trong khoảng 1-100.")]
        public int NmhQuantity { get; set; }
        [DisplayName("NMH:Giá")]
        [Range(0.01, double.MaxValue, ErrorMessage = "NMH:Giá phải là số lớn hơn 0.")]
        [Required(ErrorMessage = "NMH: Chưa nhập dữ liệu")]

        public decimal NmhPrice { get; set; }
        [DisplayName("NMH:Trạng thái")]
        public bool NmhIsActive { get; set; } = true;
    }
}
