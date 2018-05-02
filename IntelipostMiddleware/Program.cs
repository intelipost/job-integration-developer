using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace IntelipostMiddleware
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebHostListener.GetInstance(args).Host.Run();
        }        
    }
}
