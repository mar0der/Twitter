namespace Twitter.Data
{
    #region

    using System.Data.Entity;

    using Microsoft.AspNet.Identity.EntityFramework;

    using Twitter.Data.Interfaces;
    using Twitter.Data.Migrations;
    using Twitter.Models.Models;

    #endregion

    public class TwitterDbContext : IdentityDbContext<User>, ITwitterDbContext
    {
        public TwitterDbContext()
            : base("TwitterDbContext")
        {
        }

        public static TwitterDbContext Create()
        {
            return new TwitterDbContext();
        }

    }
}