//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CNPM_DOAN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Data.Entity;
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.UI.WebControls;

    public partial class NGUOIDUNG
    {
        private CNPM_DOANEntities db = new CNPM_DOANEntities();
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]

        public NGUOIDUNG()
        {
            this.BAIGIAIs = new HashSet<BAIGIAI>();
            this.BAITAPs = new HashSet<BAITAP>();
            this.BAITAPs1 = new HashSet<BAITAP>();
            this.MUCTIEUx = new HashSet<MUCTIEU>();
            this.NGUOIDUNG1 = new HashSet<NGUOIDUNG>();
            this.THOIKHOABIEUx = new HashSet<THOIKHOABIEU>();
            this.TIETHOCs = new HashSet<TIETHOC>();
            this.TODOes = new HashSet<TODO>();
        }

        public string IDNguoiDung { get; set; }
        public string TenNguoiDung { get; set; }
        public string GioiTinh { get; set; }
        public System.DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        public byte[] Avatar { get; set; }
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string IDVaiTro { get; set; }
        public string IDQuanLy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAIGIAI> BAIGIAIs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAITAP> BAITAPs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAITAP> BAITAPs1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MUCTIEU> MUCTIEUx { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGUOIDUNG> NGUOIDUNG1 { get; set; }
        public virtual NGUOIDUNG NGUOIDUNG2 { get; set; }
        public virtual VAITRO VAITRO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THOIKHOABIEU> THOIKHOABIEUx { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TIETHOC> TIETHOCs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TODO> TODOes { get; set; }
        public NGUOIDUNG checkAccount(string username, string password)
        {
            NGUOIDUNG nGUOIDUNG = new NGUOIDUNG();
            var data = db.NGUOIDUNGs.Where(s => s.TenTaiKhoan.Equals(username) && s.MatKhau.Equals(password)).ToList();
            if (data.Count > 0)
            {
                nGUOIDUNG.IDNguoiDung = data.FirstOrDefault().IDNguoiDung;
                nGUOIDUNG.TenTaiKhoan = data.FirstOrDefault().TenTaiKhoan;
                nGUOIDUNG.MatKhau = data.FirstOrDefault().MatKhau;
                nGUOIDUNG.Avatar = data.FirstOrDefault().Avatar;
                nGUOIDUNG.NgaySinh = data.FirstOrDefault().NgaySinh;
                nGUOIDUNG.Email = data.FirstOrDefault().Email;
                nGUOIDUNG.GioiTinh = data.FirstOrDefault().GioiTinh;
                nGUOIDUNG.TenNguoiDung = data.FirstOrDefault()?.TenNguoiDung;
                return nGUOIDUNG;
            }
            else return null ;
        }
        public bool checkRegister(string username)
        {
            var data = db.NGUOIDUNGs.Where(s => s.TenTaiKhoan.Equals(username)).ToList();
            if (data.Count > 0) { return false; }
            return true;
        }
        public void ChinhSuaThongTinCaNhan(string iduser, [Bind(Include = "TenNguoiDung,Email,NgaySinh,GioiTinh")] NGUOIDUNG nguoidung)
        {
            NGUOIDUNG data = db.NGUOIDUNGs.Find(iduser);
            data.TenNguoiDung = nguoidung.TenNguoiDung;
            data.Email = nguoidung.Email;
            data.GioiTinh = nguoidung.GioiTinh;
            data.NgaySinh = nguoidung.NgaySinh;
            db.Entry(data).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void ChinhSuaMatKhau(string iduser, string mkmoi)
        {
            NGUOIDUNG data = db.NGUOIDUNGs.Find(iduser);
            data.MatKhau = mkmoi;
            db.Entry(data).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
