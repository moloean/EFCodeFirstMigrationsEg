﻿using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Migration.Mappings;
using Persistence;

namespace Migration
{
    public class MigrationContext : BaseContext<MigrationContext>
    {
        public MigrationContext()
            : base(new MigrateDatabaseToLatestVersion<MigrationContext, Configuration>())
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // configure the mapping for the personEnity to table
            modelBuilder.Configurations.Add(new PersonMappings());

            // Make alle Datetime to be datetime2
            modelBuilder.Conventions.Add(new DateTime2Convention());
            
            base.OnModelCreating(modelBuilder);
        }
    }


    public class DateTime2Convention : Convention
    {
        public DateTime2Convention()
        {
            Properties<DateTime>()
                .Configure(c => c.HasColumnType("datetime2"));
        }
    }
}