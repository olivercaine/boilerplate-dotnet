using System.Data.Entity.Migrations;

namespace BaseProject.Web.Migrations
{
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Phone",
                c => new
                {
                    Id = c.Int(false, true),
                    Title = c.String(),
                    Html = c.String()
                })
                .PrimaryKey(t => t.Id);

            Sql("INSERT INTO Phone VALUES ('Google Nexus P', '<i>An awesome new smartphone</i>')");
        }

        public override void Down()
        {
            DropTable("dbo.Phone");
        }
    }
}