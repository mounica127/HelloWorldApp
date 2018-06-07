using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsole
{
    public class Program
    {
        public static IHelloWorldRestSvc svc { set; get; }
        public static void Main(string[] args)
        {
            svc = new RestService();
            Console.WriteLine(svc.getResponseFromAPI("http://localhost:43943/api/HelloWorld"));

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
