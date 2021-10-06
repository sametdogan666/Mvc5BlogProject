namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migAuthorEdit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "AuthorTitle", c => c.String(maxLength: 50));
            AddColumn("dbo.Authors", "AboutShort", c => c.String(maxLength: 100));
            AddColumn("dbo.Authors", "Password", c => c.String(maxLength: 50));
            AddColumn("dbo.Authors", "PhoneNumber", c => c.String(maxLength: 20));
            AlterColumn("dbo.Authors", "AuthorInstagram", c => c.String(maxLength: 100));
            AlterColumn("dbo.Authors", "AuthorTwitter", c => c.String(maxLength: 100));
            AlterColumn("dbo.Authors", "AuthorGmail", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Authors", "AuthorGmail", c => c.String(maxLength: 300));
            AlterColumn("dbo.Authors", "AuthorTwitter", c => c.String(maxLength: 300));
            AlterColumn("dbo.Authors", "AuthorInstagram", c => c.String(maxLength: 300));
            DropColumn("dbo.Authors", "PhoneNumber");
            DropColumn("dbo.Authors", "Password");
            DropColumn("dbo.Authors", "AboutShort");
            DropColumn("dbo.Authors", "AuthorTitle");
        }
    }
}
