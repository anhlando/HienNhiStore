//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2015/05/30 - 12:36:23
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
    public partial class ChiTietHDBHDTO
    {
        [DataMember()]
        public String MaCTHDBH { get; set; }

        [DataMember()]
        public String MaHDBH { get; set; }

        [DataMember()]
        public String MaSP { get; set; }

        [DataMember()]
        public Int16 SoLuong { get; set; }

        [DataMember()]
        public Int32 GiaBan { get; set; }

        public ChiTietHDBHDTO()
        {
        }

        public ChiTietHDBHDTO(String maCTHDBH, String maHDBH, String maSP, Int16 soLuong, Int32 giaBan)
        {
			this.MaCTHDBH = maCTHDBH;
			this.MaHDBH = maHDBH;
			this.MaSP = maSP;
			this.SoLuong = soLuong;
			this.GiaBan = giaBan;
        }
    }
}
