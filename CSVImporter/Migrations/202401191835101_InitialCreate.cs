namespace CSVImporter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserContacts",
                c => new
                    {
                        ContactId = c.Int(nullable: false, identity: true),
                        m_name = c.String(maxLength: 20),
                        m_surname = c.String(maxLength: 20),
                        m_privateIdNumber = c.String(maxLength: 10),
                        m_address = c.String(maxLength: 50),
                        m_phoneNumber1 = c.String(maxLength: 9),
                        m_phoneNumber2 = c.String(maxLength: 9),
                    })
                .PrimaryKey(t => t.ContactId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserContacts");
        }
    }
}
