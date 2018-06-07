using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace HelloWorldConsole
{
    public class RestService : IHelloWorldRestSvc
    {
        public string getResponseFromAPI(string Url)
       
        {
            string result = String.Empty;
            RestClient rc = new RestClient(String.Format(Url));
            RestRequest rq = new RestRequest();
            var response = rc.Execute(rq);
            if (response != null)
            {
            }
            else
            {
                throw new Exception("response was null");
            }

            return response.Content;
        }
    }
}
