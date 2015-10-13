namespace Twitter.App.Controllers
{
    #region

    using System.Web.Mvc;

    #endregion

    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return this.View();
        }
    }
}