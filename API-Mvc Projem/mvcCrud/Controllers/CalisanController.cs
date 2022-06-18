using mvcCrud.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Mvc;

namespace mvcCrud.Controllers
{
    public class CalisanController : Controller
    {
        // GET: Calisan
        public ActionResult Index()
        {

            IEnumerable<mvcCalisanModel> calList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Calisanlars").Result;

            calList = response.Content.ReadAsAsync<IEnumerable<mvcCalisanModel>>().Result;

            return View(calList);
        }


        public ActionResult EKLE(int id = 0)
        {
            if (id == 0)
            {
                return View(new mvcCalisanModel());
            }

            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Calisanlars/" + id.ToString()).Result;


                return View(response.Content.ReadAsAsync<mvcCalisanModel>().Result);
            }


        }


        [HttpPost]
        public ActionResult EKLE(mvcCalisanModel calisan)
        {
            if (calisan.CalisanID == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Calisanlars", calisan).Result;

                TempData["SuccessMessage"] = "Başarılı şekilde kaydedildi.";
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Calisanlars/" + calisan.CalisanID, calisan).Result;
                TempData["SuccessMessage"] = "Güncelleme işlemi başarılı.";
            }

            return RedirectToAction("Index");

        }




    }
}