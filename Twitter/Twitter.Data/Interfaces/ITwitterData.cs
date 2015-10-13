namespace Twitter.Data.Interfaces
{
    using Twitter.Models.Models;

    public interface ITwitterData
    {
         IRepository<User> Users { get; }

        int SaveChanges();
    }
}