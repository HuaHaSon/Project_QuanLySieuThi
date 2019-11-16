namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CTDonGiaBans",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        MaDonGiaBan = c.String(maxLength: 128),
                        MaSP = c.String(maxLength: 128),
                        GiaBan = c.Int(nullable: false),
                        createdDate = c.DateTime(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.DonGiaBans", t => t.MaDonGiaBan)
                .ForeignKey("dbo.SanPhams", t => t.MaSP)
                .Index(t => t.MaDonGiaBan)
                .Index(t => t.MaSP);
            
            CreateTable(
                "dbo.DonGiaBans",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        NgayApDung = c.DateTime(nullable: false),
                        createdDate = c.DateTime(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.SanPhams",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        TenSP = c.String(),
                        MoTa = c.String(),
                        UrlImage = c.String(),
                        createdDate = c.DateTime(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.CTDonGiaNhaps",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        MaPhieuGiaNhap = c.String(maxLength: 128),
                        MaSP = c.String(maxLength: 128),
                        GiaNhap = c.Int(nullable: false),
                        createdDate = c.DateTime(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.DonGiaNhaps", t => t.MaPhieuGiaNhap)
                .ForeignKey("dbo.SanPhams", t => t.MaSP)
                .Index(t => t.MaPhieuGiaNhap)
                .Index(t => t.MaSP);
            
            CreateTable(
                "dbo.DonGiaNhaps",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        MaNCC = c.String(maxLength: 128),
                        NgayApDung = c.DateTime(nullable: false),
                        createdDate = c.DateTime(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.NhaCungCaps", t => t.MaNCC)
                .Index(t => t.MaNCC);
            
            CreateTable(
                "dbo.NhaCungCaps",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        TenNCC = c.String(),
                        DiaChi = c.String(),
                        createdDate = c.DateTime(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.CTHoaDons",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        MaHD = c.String(maxLength: 128),
                        MaSP = c.String(maxLength: 128),
                        MaNCC = c.String(maxLength: 128),
                        SLBan = c.Int(nullable: false),
                        createdDate = c.DateTime(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.HoaDons", t => t.MaHD)
                .ForeignKey("dbo.NhaCungCaps", t => t.MaNCC)
                .ForeignKey("dbo.SanPhams", t => t.MaSP)
                .Index(t => t.MaHD)
                .Index(t => t.MaSP)
                .Index(t => t.MaNCC);
            
            CreateTable(
                "dbo.HoaDons",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        NgayHD = c.DateTime(nullable: false),
                        TongTien = c.Int(nullable: false),
                        createdDate = c.DateTime(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.PhieuNhaps",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        NgayPN = c.DateTime(nullable: false),
                        TongTien = c.Int(nullable: false),
                        MaNCC = c.String(maxLength: 128),
                        createdDate = c.DateTime(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.NhaCungCaps", t => t.MaNCC)
                .Index(t => t.MaNCC);
            
            CreateTable(
                "dbo.CTPhieuNhaps",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        MaPN = c.String(maxLength: 128),
                        MaSP = c.String(maxLength: 128),
                        SLNhap = c.Int(nullable: false),
                        createdDate = c.DateTime(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.PhieuNhaps", t => t.MaPN)
                .ForeignKey("dbo.SanPhams", t => t.MaSP)
                .Index(t => t.MaPN)
                .Index(t => t.MaSP);
            
            CreateTable(
                "dbo.SanPham_NCC",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        MaSP = c.String(maxLength: 128),
                        MaNCC = c.String(maxLength: 128),
                        createdDate = c.DateTime(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.NhaCungCaps", t => t.MaNCC)
                .ForeignKey("dbo.SanPhams", t => t.MaSP)
                .Index(t => t.MaSP)
                .Index(t => t.MaNCC);
            
            CreateTable(
                "dbo.SLTons",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        SoLuong = c.Int(nullable: false),
                        MaSP = c.String(maxLength: 128),
                        MaNCC = c.String(maxLength: 128),
                        createdDate = c.DateTime(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.NhaCungCaps", t => t.MaNCC)
                .ForeignKey("dbo.SanPhams", t => t.MaSP)
                .Index(t => t.MaSP)
                .Index(t => t.MaNCC);
            
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        TenNV = c.String(),
                        MaTK = c.String(maxLength: 128),
                        createdDate = c.DateTime(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TaiKhoans", t => t.MaTK)
                .Index(t => t.MaTK);
            
            CreateTable(
                "dbo.TaiKhoans",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        TenTK = c.String(),
                        MatKhau = c.String(),
                        MaQuyen = c.String(maxLength: 128),
                        createdDate = c.DateTime(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Quyens", t => t.MaQuyen)
                .Index(t => t.MaQuyen);
            
            CreateTable(
                "dbo.Quyens",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        TenQuyen = c.String(),
                        createdDate = c.DateTime(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TaiKhoans", "MaQuyen", "dbo.Quyens");
            DropForeignKey("dbo.NhanViens", "MaTK", "dbo.TaiKhoans");
            DropForeignKey("dbo.CTDonGiaNhaps", "MaSP", "dbo.SanPhams");
            DropForeignKey("dbo.SLTons", "MaSP", "dbo.SanPhams");
            DropForeignKey("dbo.SLTons", "MaNCC", "dbo.NhaCungCaps");
            DropForeignKey("dbo.SanPham_NCC", "MaSP", "dbo.SanPhams");
            DropForeignKey("dbo.SanPham_NCC", "MaNCC", "dbo.NhaCungCaps");
            DropForeignKey("dbo.PhieuNhaps", "MaNCC", "dbo.NhaCungCaps");
            DropForeignKey("dbo.CTPhieuNhaps", "MaSP", "dbo.SanPhams");
            DropForeignKey("dbo.CTPhieuNhaps", "MaPN", "dbo.PhieuNhaps");
            DropForeignKey("dbo.DonGiaNhaps", "MaNCC", "dbo.NhaCungCaps");
            DropForeignKey("dbo.CTHoaDons", "MaSP", "dbo.SanPhams");
            DropForeignKey("dbo.CTHoaDons", "MaNCC", "dbo.NhaCungCaps");
            DropForeignKey("dbo.CTHoaDons", "MaHD", "dbo.HoaDons");
            DropForeignKey("dbo.CTDonGiaNhaps", "MaPhieuGiaNhap", "dbo.DonGiaNhaps");
            DropForeignKey("dbo.CTDonGiaBans", "MaSP", "dbo.SanPhams");
            DropForeignKey("dbo.CTDonGiaBans", "MaDonGiaBan", "dbo.DonGiaBans");
            DropIndex("dbo.TaiKhoans", new[] { "MaQuyen" });
            DropIndex("dbo.NhanViens", new[] { "MaTK" });
            DropIndex("dbo.SLTons", new[] { "MaNCC" });
            DropIndex("dbo.SLTons", new[] { "MaSP" });
            DropIndex("dbo.SanPham_NCC", new[] { "MaNCC" });
            DropIndex("dbo.SanPham_NCC", new[] { "MaSP" });
            DropIndex("dbo.CTPhieuNhaps", new[] { "MaSP" });
            DropIndex("dbo.CTPhieuNhaps", new[] { "MaPN" });
            DropIndex("dbo.PhieuNhaps", new[] { "MaNCC" });
            DropIndex("dbo.CTHoaDons", new[] { "MaNCC" });
            DropIndex("dbo.CTHoaDons", new[] { "MaSP" });
            DropIndex("dbo.CTHoaDons", new[] { "MaHD" });
            DropIndex("dbo.DonGiaNhaps", new[] { "MaNCC" });
            DropIndex("dbo.CTDonGiaNhaps", new[] { "MaSP" });
            DropIndex("dbo.CTDonGiaNhaps", new[] { "MaPhieuGiaNhap" });
            DropIndex("dbo.CTDonGiaBans", new[] { "MaSP" });
            DropIndex("dbo.CTDonGiaBans", new[] { "MaDonGiaBan" });
            DropTable("dbo.Quyens");
            DropTable("dbo.TaiKhoans");
            DropTable("dbo.NhanViens");
            DropTable("dbo.SLTons");
            DropTable("dbo.SanPham_NCC");
            DropTable("dbo.CTPhieuNhaps");
            DropTable("dbo.PhieuNhaps");
            DropTable("dbo.HoaDons");
            DropTable("dbo.CTHoaDons");
            DropTable("dbo.NhaCungCaps");
            DropTable("dbo.DonGiaNhaps");
            DropTable("dbo.CTDonGiaNhaps");
            DropTable("dbo.SanPhams");
            DropTable("dbo.DonGiaBans");
            DropTable("dbo.CTDonGiaBans");
        }
    }
}
