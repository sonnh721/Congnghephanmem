namespace QuanLyDiemSinhVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BangDiem")]
    public partial class BangDiem
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BangDiemID { get; set; }
        public int SinhVienID { get; set; }
        public int LopTinChiID { get; set; }
        [DisplayName("Điểm TP")]
        [DisplayFormat(DataFormatString = "{0:N2", ApplyFormatInEditMode = true)]
        public double? DiemThanhPhan { get; set; }
        [DisplayName("Điểm Thi")]
        [DisplayFormat(DataFormatString = "{0:N2", ApplyFormatInEditMode = true)]
        public double? DiemThi { get; set; }
        [DisplayName("Điểm TB")]
        [DisplayFormat(DataFormatString = "{0:N2", ApplyFormatInEditMode = true)]
        public double? DiemTrungBinh { get; set; }

        [StringLength(10)]
        [DisplayName("Điểm Chữ")]
        public string DiemChu { get; set; }

        public virtual LopTinChi LopTinChi { get; set; }
    }
}
