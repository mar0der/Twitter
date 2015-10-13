#region

using Microsoft.Owin;

using Twitter.App;

#endregion

[assembly: OwinStartup(typeof(Startup))]

namespace Twitter.App
{
    #region

    using Owin;

    #endregion

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}