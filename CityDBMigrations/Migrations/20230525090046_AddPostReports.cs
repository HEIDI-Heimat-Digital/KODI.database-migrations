using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230525090046)]
    public class AddPostReports: Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS postreports;
                CREATE TABLE postreports (
                    id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    forumId int, 
                    FOREIGN KEY(forumId) REFERENCES forums(id),  
                    postId int, 
                    FOREIGN KEY(postId) REFERENCES forumposts(id),  
                    userId int, 
                    FOREIGN KEY(userId) REFERENCES users(id),
                    createdAt DATETIME
                );";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS postreports;";

            Execute.Sql(sql);
        }
    }
}