//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2015/05/30 - 12:36:24
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace HienNhiDTOs
{
    [DataContract()]
    public partial class HoaDonBanHangDTO
    {
        [DataMember()]
        public String MaHDBH { get; set; }

        [DataMember()]
        public String MaKH { get; set; }

        [DataMember()]
        public DateTime NgayLap { get; set; }

        [DataMember()]
        public Nullable<Int16> CKPhanTram { get; set; }

        [DataMember()]
        public Nullable<Int32> CKTienMat { get; set; }

        [DataMember()]
        public Int32 ThanhTien { get; set; }

        public HoaDonBanHangDTO()
        {
        }

        public HoaDonBanHangDTO(String maHDBH, String maKH, DateTime ngayLap, Nullable<Int16> cKPhanTram, Nullable<Int32> cKTienMat, Int32 thanhTien)
        {
			this.MaHDBH = maHDBH;
			this.MaKH = maKH;
			this.NgayLap = ngayLap;
			this.CKPhanTram = cKPhanTram;
			this.CKTienMat = cKTienMat;
			this.ThanhTien = thanhTien;
        }
    }
}
