using Practico07.MVC.Models;
using System;
using System.Web.Mvc;

using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Practico07.MVC.Controllers
{
    public class NasaApiController : Controller
    {
        readonly string Baseurl = "https://random-d.uk/";
        public async Task<ActionResult> Index()
        {
            NasaPicView pic = new NasaPicView();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("/api/random");

                if (Res.IsSuccessStatusCode)
                {
                    var PicResponse = Res.Content.ReadAsStringAsync().Result;
                    pic = JsonConvert.DeserializeObject<NasaPicView>(PicResponse);
                }
                return View(pic);
            }
        }
    }
}