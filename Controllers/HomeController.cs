using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Brandix.DCAP.WebUI.Models;
using Brandix.DCAP.WebUI.Services;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;

using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;
using System.Text;
using System.IO;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;

namespace Brandix.DCAP.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUIConfiguration appSettings;
        private IHttpContextAccessor client;
        private IHostingEnvironment _hostingEnvironment;
        public HomeController(IUIConfiguration appSettings, IHttpContextAccessor client, IHostingEnvironment hostingEnvironment)
        {
            this.appSettings = appSettings;
            this.client = client;
            this._hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Login()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }

        public IActionResult Barcode()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error()
        {
            var feature = this.HttpContext.Features.Get<IExceptionHandlerFeature>();
            return View();
        }
    }
}
