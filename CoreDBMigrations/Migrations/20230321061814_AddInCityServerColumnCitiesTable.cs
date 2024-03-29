﻿using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230321061814)]
    public class AddInCityServerColumnCitiesTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE cities ADD COLUMN inCityServer bool;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE cities DROP COLUMN inCityServer;";

            Execute.Sql(sql);
        }
    }
}
