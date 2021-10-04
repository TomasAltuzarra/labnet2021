using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practico07.MVC.Models;

using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Practico07.MVC.Controllers
{
    public class CNFactsController : Controller
    {
        readonly string Baseurl = "https://api.chucknorris.io";
        public async Task<ActionResult> Index()
        {
            CNFactView fact = new CNFactView();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("/jokes/random");
                if (Res.IsSuccessStatusCode)
                {
                    var FactResponse = Res.Content.ReadAsStringAsync().Result;
                    fact = JsonConvert.DeserializeObject<CNFactView>(FactResponse);
                }
                return View(fact);
            }
        }
    }
}