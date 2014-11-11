namespace EasyPTC.Web.Areas.Administration.Controllers
{
    using System.Web.Mvc;

    using AutoMapper;

    using EasyPTC.Data;
    using EasyPTC.Web.Areas.Administration.Controllers.Base;

    using Kendo.Mvc.UI;
    using Kendo.Mvc.Extensions;
    using EasyPTC.Models;
    using System.Collections;

    using Model = EasyPTC.Models.Advertisement;
    using ViewModel = EasyPTC.Web.Areas.Administration.ViewModels.Advertisements.AdvertisementViewModel;

    public class AdvertisementController : KendoGridAdministrationController
    {
        public AdvertisementController(IEasyPtcData data)
            : base(data)
        {
        }

        public ActionResult Index()
        {
            return View();
        }

        protected override IEnumerable GetData()
        {
            return this.Data.Advertisements.All();
        }

        protected override T GetById<T>(object id)
        {
            return this.Data.Advertisements.GetById(id) as T;
        }

        [HttpPost]
        public ActionResult Create([DataSourceRequest]DataSourceRequest request, ViewModel model)
        {
            var dbModel = base.Create<Model>(model);
            if (dbModel != null) model.Id = dbModel.Id;
            return this.GridOperation(model, request);
        }

        [HttpPost]
        public ActionResult Update([DataSourceRequest]DataSourceRequest request, ViewModel model)
        {
            base.Update<Model, ViewModel>(model, model.Id);
            return this.GridOperation(model, request);
        }

        [HttpPost]
        public ActionResult Destroy([DataSourceRequest]DataSourceRequest request, ViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                this.Data.Advertisements.Delete(model.Id.Value);
                this.Data.SaveChanges();
            }

            return this.GridOperation(model, request);
        }
    }
}