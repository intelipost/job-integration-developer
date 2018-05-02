using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace IntelipostMiddleware
{
    public class WebHostListener
    {
        private static WebHostListener _singletonInstance;
        private IWebHost host;

        private WebHostListener(string[] args)
        {
            this.host = WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()            
                .UseUrls("http://0.0.0.0:5000/")
                .Build();
        }

        public static WebHostListener GetInstance(string[] args)
        {
            if(_singletonInstance is null)
            {
                _singletonInstance = new WebHostListener(args);
            }

            return _singletonInstance;
        }

        public IWebHost Host {
            get{
                return this.host;
            }
            private set { this.host = value; }
        }

    }
}
