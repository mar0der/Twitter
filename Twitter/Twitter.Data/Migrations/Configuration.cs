namespace Twitter.Data.Migrations
{
    #region

    using System.Data.Entity.Migrations;

    using Twitter.Data.Repositories;

    #endregion

    public sealed class Configuration : DbMigrationsConfiguration<TwitterDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TwitterDbContext context)
        {
        }
    }
}