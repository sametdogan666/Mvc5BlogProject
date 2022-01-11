﻿namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migAdminRole : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "AdmınRole", c => c.String(maxLength: 1));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Admins", "AdmınRole");
        }
    }
}