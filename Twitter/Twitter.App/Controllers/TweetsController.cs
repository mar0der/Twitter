namespace Twitter.App.Controllers
{
    #region

    using System.Web.Mvc;

    using Twitter.Data.Interfaces;

    #endregion

    public class TweetsController : BaseController
    {
        public TweetsController(ITwitterData data)
            : base(data)
        {
        }

        public ActionResult Index()
        {
            return this.View();
        }
    }
}