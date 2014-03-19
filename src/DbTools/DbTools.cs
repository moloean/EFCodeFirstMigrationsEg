using Migrator;
using NUnit.Framework;

namespace DbTools
{
    [TestFixture]
    public class DbTools
    {
        [Test, Explicit]
        public void DropAndRecreateAndUpGradeToLatesVersion()
        {
            // this is using conection string from config
            Program.Main(new[] { @"-d" });
        }

        [Test, Explicit]
        public void UpGradeToLatesVersion()
        {
            // this is using conection string from config
            Program.Main(new string[0]);
        }


        [Test, Explicit]
        public void MigrateToTargetOnSelectedDatabaset()
        {
            Program.Main(new[] { "-t=V14" });
        }
    }
}
