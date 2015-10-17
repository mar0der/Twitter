namespace Twitter.App.Controllers
{
    #region

    using System.Web.Mvc;

    using Twitter.Data.Interfaces;

    #endregion

    public class UsersController : BaseController
    {
        public UsersController(ITwitterData data)
            : base(data)
        {
        }

        public ActionResult Index()
        {
            return this.View();
        }
    }
}