using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230620115239)]
    public class AddParentIdForumComments : Migration
    {
        public override void Up()
        {
            string sql =
               @"
                ALTER TABLE forumcomments ADD COLUMN parentId int NOT NULL;
                ALTER TABLE forumcomments ADD CONSTRAINT fk_forumcomments_id_parent_id  FOREIGN KEY (parentId) REFERENCES forumcomments(id);";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
                @"
                ALTER TABLE heidi_city_1.forumcomments DROP FOREIGN KEY fk_forumcomments_id_parent_id;
                ALTER TABLE ForumRequests DROP COLUMN parentId;";

            Execute.Sql(sql);
        }
    }
}