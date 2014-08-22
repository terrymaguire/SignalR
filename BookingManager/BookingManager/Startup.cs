using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookingManager.Startup))]
namespace BookingManager
{
    public partial class Startup
    {
        //public void Configuration(IAppBuilder app)
        //{
        //    ConfigureAuth(app);
        //}

        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}
