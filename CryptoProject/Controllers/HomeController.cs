using CryptoProject.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http;

namespace CryptoProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<HomeController> _logger;

        public HomeController(HttpClient httpclient, ILogger<HomeController> logger)
        {
            _httpClient = httpclient;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var cryptos = await _httpClient.GetAsync("https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=20&page=1&sparkline=false");
            var cryptosJSON = await cryptos.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<CryptoModel>>(cryptosJSON);
            //var result = data.data.Cast<CryptoModel>().ToList();
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}