using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20231211101858)]
    public class AddGuestsTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS guests;
               CREATE TABLE guests (
                id INT PRIMARY KEY NOT NULL,
                firstName VARCHAR(255),
                lastName VARCHAR(255),
                emailId VARCHAR(255),
                phoneNumber VARCHAR(100),
                description TEXT,
                verificationToken VARCHAR(255)
            );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS guests;";

            Execute.Sql(sql);
        }
    }
}
