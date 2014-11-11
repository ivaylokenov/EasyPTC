namespace EasyPTC.Web.Controllers
{
    using System.Web.Mvc;

    using EasyPTC.Web.ViewModels;
    using System.Data.Entity;
    using EasyPTC.Models;
    using EasyPTC.Data;

    public abstract class BaseController : Controller
    {
        public BaseController(IEasyPtcData data)
        {
            this.Data = data;
        }

        protected IEasyPtcData Data { get; set; }

        protected User CurrentUser { get; set; }
    }
}