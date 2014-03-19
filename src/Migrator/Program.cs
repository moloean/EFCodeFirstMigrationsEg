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
            if (args == null || args.Length == 0)
            {
                MigrateToTarget(string.Empty);
                return;
            }

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
            //var configuration = new Migration.Migrations.Configuration();
            //var migrator = new DbMigrator(configuration);

            //if (targetMigration != null)
            //    targetMigration = targetMigration.Trim();

            //migrator.Update(targetMigration);
        }

        private static void ParseArgs(IEnumerable<string> args)
        {
            new OptionSet
            {
                {"d|dropdb", v => DropDb(v != null)},
                {"t|target=", MigrateToTarget}
            }.Parse(args);
            
        }
    }
}
