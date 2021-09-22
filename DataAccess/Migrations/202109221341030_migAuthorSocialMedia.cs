namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migAuthorSocialMedia : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "AuthorInstagram", c => c.String(maxLength: 300));
            AddColumn("dbo.Authors", "AuthorTwitter", c => c.String(maxLength: 300));
            AddColumn("dbo.Authors", "AuthorGmail", c => c.String(maxLength: 300));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Authors", "AuthorGmail");
            DropColumn("dbo.Authors", "AuthorTwitter");
            DropColumn("dbo.Authors", "AuthorInstagram");
        }
    }
}
