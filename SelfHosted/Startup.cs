﻿using Owin;
using Microsoft.Owin.Cors;

namespace SelfHosted
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR();
        }
    }
}
