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
    public partial class ChiTietSBHDTO
    {
        [DataMember()]
        public String MaCTSBH { get; set; }

        [DataMember()]
        public String MaSBH { get; set; }

        [DataMember()]
        public DateTime NgayTra { get; set; }

        [DataMember()]
        public Int32 ThanhTien { get; set; }

        public ChiTietSBHDTO()
        {
        }

        public ChiTietSBHDTO(String maCTSBH, String maSBH, DateTime ngayTra, Int32 thanhTien)
        {
			this.MaCTSBH = maCTSBH;
			this.MaSBH = maSBH;
			this.NgayTra = ngayTra;
			this.ThanhTien = thanhTien;
        }
    }
}
