namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialDb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SLTons", "MaNCC", c => c.String(maxLength: 128));
            CreateIndex("dbo.SLTons", "MaNCC");
            AddForeignKey("dbo.SLTons", "MaNCC", "dbo.NhaCungCaps", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SLTons", "MaNCC", "dbo.NhaCungCaps");
            DropIndex("dbo.SLTons", new[] { "MaNCC" });
            DropColumn("dbo.SLTons", "MaNCC");
        }
    }
}
