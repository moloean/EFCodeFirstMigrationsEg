using System.Data.Entity.Migrations;

namespace Migration
{
    public class Configuration : DbMigrationsConfiguration<MigrationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;

        }

        //Do not use seed !!!!!!!!!! it will brake
        //protected override void Seed(MigrationContext context)
        //{
        //    base.Seed(context);
        //}
    }
}