using System.Collections.Generic;
using System.Data.Entity.Migrations;
using Migration;
using NDesk.Options;

namespace Migrator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            ParseArgs(args);
        }

        private static void DropDb(bool dropdb)
        {
            if (!dropdb) return;

            var dbContext = new MigrationContext();
            dbContext.Database.Delete();
        }

        private static void MigrateToTarget(string targetMigration)
        {
            var configuration = new Configuration();
            var migrator = new DbMigrator(configuration);

            if (targetMigration != null)
                targetMigration = targetMigration.Trim();

            migrator.Update(targetMigration);
        }

        private static void ParseArgs(IEnumerable<string> args)
        {
            new OptionSet
            {
                {"d|dropdb", v => DropDb(v != null)},
                {"t|target", MigrateToTarget}
            }.Parse(args);
            
        }
    }
}
