using System.Web.Http;

namespace serfid.Rest.Controllers
{
    public class ReadingsController : ApiController
    {
        public struct saludo
        {
            public string txt;
        }

        public saludo GetAllReadings()
        {
            var s = new saludo { txt = "hola mundo " };
            return s;
        }
    }
}
