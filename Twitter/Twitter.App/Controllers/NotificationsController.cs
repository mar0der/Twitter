namespace Twitter.App.Controllers
{
    #region

    using System.Web.Mvc;

    using Twitter.Data.Interfaces;

    #endregion

    public class NotificationsController : BaseController
    {
        public NotificationsController(ITwitterData data)
            : base(data)
        {
        }

        public ActionResult Index()
        {
            return this.View();
        }
    }
}