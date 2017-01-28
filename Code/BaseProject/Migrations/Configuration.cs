using System.Data.Entity.Migrations;
using BaseProject.Web.DAL;

namespace BaseProject.Web.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DatabaseContext>
    {
        public Configuration()
        {
            ContextKey = "BaseProject.Web.DAL.DatabaseContext";
        }

        protected override void Seed(DatabaseContext context)
        {
            //context.Phones.Add(new Phone
            //{
            //    Title = "A blog title",
            //    Html = "Some <b>bold text</b> in a sentence"
            //});
        }
    }
}