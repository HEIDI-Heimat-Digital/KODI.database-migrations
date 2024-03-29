using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230525142352)]
    public class AddForumComments: Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS forumcomments;
                CREATE TABLE forumcomments (
                    id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    forumId int, 
                    FOREIGN KEY(forumId) REFERENCES forums(id),  
                    postId int, 
                    FOREIGN KEY(postId) REFERENCES forumposts(id),  
                    userId int, 
                    FOREIGN KEY(userId) REFERENCES users(id),
                    comments varchar(1000),
                    createdAt DATETIME
                );";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS forumcomments;";

            Execute.Sql(sql);
        }
    }
}