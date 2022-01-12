namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migAdminRoleRefactor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "AdminRole", c => c.String(maxLength: 1));
            DropColumn("dbo.Admins", "AdmınRole");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Admins", "AdmınRole", c => c.String(maxLength: 1));
            DropColumn("dbo.Admins", "AdminRole");
        }
    }
}
