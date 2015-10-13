namespace Twitter.App.Controllers
{
    #region

    using System.Threading;
    using System.Web.Mvc;

    using Microsoft.AspNet.Identity;

    using Twitter.Data.Interfaces;
    using Twitter.Models.Models;

    #endregion

    public class BaseController : Controller
    {
        public BaseController(ITwitterData data)
        {
            this.Data = data;
        }

        public ITwitterData Data { get; set; }

        public User CurrentUser
        {
            get
            {
                return this.Data.Users.Find(Thread.CurrentPrincipal.Identity.GetUserId());
            }
        }

        public string CurrentUserUsername
        {
            get
            {
                return Thread.CurrentPrincipal.Identity.GetUserName();
            }
        }

        public string CurrentUserId
        {
            get
            {
                return Thread.CurrentPrincipal.Identity.GetUserId();
            }
        }
    }
}