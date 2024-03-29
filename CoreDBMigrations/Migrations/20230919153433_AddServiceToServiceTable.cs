using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230919153433)]
    public class AddServiceToServiceTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"INSERT INTO services (id, name, isRunning, safeStop, createdAt) VALUES (1, ""Delete Expired Listings"", 0, 0,  UTC_TIMESTAMP), (2, ""Fetch Insta Posts"", 0, 0,  UTC_TIMESTAMP);";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql = @"DELETE FROM services WHERE id = 1 OR id = 2;";
            Execute.Sql(sql);
        }
    }
}