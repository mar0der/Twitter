namespace Twitter.App.Controllers
{
    #region

    using System.Web.Mvc;

    using Twitter.Data;
    using Twitter.Data.Interfaces;
    using Twitter.Data.Repositories;

    #endregion

    public class HomeController : BaseController
    {
        public HomeController(ITwitterData data)
            : base(data)
        {
        }

        public ActionResult Index()
        {
           // var users = this.Data.Users.Find(this.CurrentUserId);
            return this.View();
        }

        public ActionResult About()
        {
            this.ViewBag.Message = "Your application description page.";

            return this.View();
        }

        public ActionResult Contact()
        {
            this.ViewBag.Message = "Your contact page.";

            return this.View();
        }
    }
}