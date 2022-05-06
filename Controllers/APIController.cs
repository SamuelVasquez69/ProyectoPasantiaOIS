using Newtonsoft.Json;
using ProyectoPasantiaOIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ProyectoPasantiaOIS.Controllers
{
    public class APIController : Controller
    {
        HttpClientHandler _Clienthandler = new HttpClientHandler();
       
        ApiMOdel api = new ApiMOdel();
        List<ApiMOdel> apis = new List<ApiMOdel>();

        public APIController()
        {
            _Clienthandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };   
        }

        // GET: API
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<List<ApiMOdel>> GetAllLibros()
        {
            apis = new List<ApiMOdel>();

            using(var httpClient = new HttpClient(_Clienthandler))
            {
                using (var response = await httpClient.GetAsync("https://fakestoreapi.com/products"))
                {
                    String apiResponse = await response.Content.ReadAsStringAsync();
                    apis = JsonConvert.DeserializeObject<List<ApiMOdel>>(apiResponse);
                }
            }

            return apis;
        }
    }
}